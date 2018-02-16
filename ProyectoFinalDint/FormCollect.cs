﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace ProyectoFinalDint
{
    public partial class FormCollect : Form
    {
        public string ColeccionActiva { get; set; }
        public string UsuarioActivo { get; set; }

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection connection = null;
        MySqlCommand command = null;
        MySqlDataReader reader = null;

        public FormCollect()
        {
            conectarBBDD();

            InitializeComponent();
        }

        /// <summary>
        /// Muestra los elementos de la colección seleccionada
        /// </summary>
        private void elementVerColeccion_Click(Object sender, EventArgs e)
        {
            ControlElemento.Elemento buttonClicked = sender as ControlElemento.Elemento;
            ColeccionActiva = buttonClicked.Name;
            
            limpiarElementos();

            labelTituloColeccion.Text = ColeccionActiva;

            linkLabelMisColecciones.Text = "Volver a mis colecciones";
            linkLabelMisColecciones.LinkClicked += linkLabelMisColecciones_LinkClicked;

            command = new MySqlCommand("Select nombre from elementos where nombre_col = @nombre_col and nombre_user=@nombre_user order by nombre", connection);
            command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);
            command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);

            mostrarElementos();

            flowLayoutPanelColecciones.Visible = false;
            flowLayoutPanelElementos.Visible = true;
        }

        /// <summary>
        /// Muestra los datos del elemento seleccionado
        /// </summary>
        private void elementVerElemento_Click(Object sender, EventArgs e)
        {
            ControlElemento.Elemento buttonClicked = sender as ControlElemento.Elemento;
            FormVerElemento form = new FormVerElemento();

            connection.Open();

            command = new MySqlCommand("Select nombre, descripcion, imagen from elementos where nombre=@nombre and nombre_col = @nombre_col and nombre_user = @nombre_user", connection);
            command.Parameters.AddWithValue("@nombre", buttonClicked.Name);
            command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);
            command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
            reader = command.ExecuteReader();

            reader.Read();

            form.Text = reader["nombre"].ToString();
            form.Descripcion = reader["descripcion"].ToString();
            try
            { 
                form.ImgBytes = (byte[])reader["imagen"];
            }
            catch (InvalidCastException)
            {
                form.ImgBytes = null;
            }

            connection.Close();

            form.ShowDialog();
        }

        /// <summary>
        /// Añade una coleccion desde un form externo y muestra las colecciones
        /// </summary>
        private void buttonAnadirColeccion_Click(object sender, EventArgs e)
        {
            FormNuevaColeccion form = new FormNuevaColeccion(connection);
            form.NombreUser = UsuarioActivo;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                ControlElemento.Elemento buttonClicked = new ControlElemento.Elemento();
                buttonClicked.Name = form.Nombre;

                elementVerColeccion_Click(buttonClicked, e);
            }
        }

        /// <summary>
        /// Añade una coleccion desde un form externo y muestra las coleccion llamando al evento buttonElementAnadirColeccion_Click
        /// </summary>
        private void crearColecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanelColecciones.Visible = true;
            buttonAnadirColeccion_Click(sender, e);
        }

        /// <summary>
        /// Añade un elemento a una colección desde un form externo y muestra los elementos de esa colección MODIFICAR
        /// </summary>
        private void buttonAnadirElemento_Click(object sender, EventArgs e)
        {
            FormNuevoElemento form = new FormNuevoElemento(connection);
            form.NombreCol = ColeccionActiva;
            form.NombreUser = UsuarioActivo;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                linkLabelMisColecciones.Text = "Volver a mis colecciones";
                linkLabelMisColecciones.LinkClicked += linkLabelMisColecciones_LinkClicked;
                linkLabelMisColecciones.LinkClicked -= linkLabelMisColecciones_TodosElementos;

                command = new MySqlCommand("Select nombre from elementos where nombre_user = @nombre_user and nombre_col = @nombre_col order by nombre", connection);
                command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
                command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);

                mostrarElementos();
            }
        }

        /// <summary>
        /// Oculta los elementos y muestra las colecciones
        /// </summary>
        private void linkLabelMisColecciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flowLayoutPanelColecciones.Visible = true;
            flowLayoutPanelElementos.Visible = false;

            homeToolStripMenuItem_Click(sender, null);
        }

        /// <summary>
        /// Realiza la conexión con la base de datos
        /// </summary>
        private void conectarBBDD()
        {
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "1234";
            builder.Database = "collect";

            connection = new MySqlConnection(builder.ToString());
            command = connection.CreateCommand();
        }

        /// <summary>
        /// Vacía la pantalla de elementos
        /// </summary>
        private void limpiarElementos()
        {
            int indexButtonElement = flowLayoutPanelElementos.Controls.OfType<ControlElemento.Elemento>().Count() - 1;
            for (int i = indexButtonElement; i >= 0; i--)
            {
                ControlElemento.Elemento elemento = flowLayoutPanelElementos.Controls.OfType<ControlElemento.Elemento>().ElementAt(i);
                if (elemento.Name != "buttonElementAnadirElemento")
                {
                    flowLayoutPanelElementos.Controls.Remove(elemento);
                }
            }
        }

        /// <summary>
        /// Vacía la pantalla de colecciones
        /// </summary>
        private void limpiarColecciones()
        {
            int indexButtonElement = flowLayoutPanelColecciones.Controls.OfType<ControlElemento.Elemento>().Count() - 1;
            for (int i = indexButtonElement; i >= 0; i--)
            {
                ControlElemento.Elemento coleccion = flowLayoutPanelColecciones.Controls.OfType<ControlElemento.Elemento>().ElementAt(i);
                if (coleccion.Name != "buttonElementAnadirColeccion")
                {
                    flowLayoutPanelColecciones.Controls.Remove(coleccion);
                }
            }
        }

        /// <summary>
        /// Muestra las colecciones cuyo nombre incluya la cadena escrita en el TextBoxBusqueda
        /// </summary>
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textoBusqueda = toolStripTextBoxBusqueda.Text.Trim();

            if (textoBusqueda != "")
            {
                if (flowLayoutPanelColecciones.Visible == false && flowLayoutPanelElementos.Visible == true)
                {
                    linkLabelMisColecciones.Text = "Ver todos los elementos";
                    linkLabelMisColecciones.LinkClicked -= linkLabelMisColecciones_LinkClicked;
                    linkLabelMisColecciones.LinkClicked += linkLabelMisColecciones_TodosElementos;

                    command = new MySqlCommand("Select nombre from elementos where nombre LIKE @nombre and nombre_user = @nombre_user and nombre_col = @nombre_col order by nombre", connection);
                    command.Parameters.AddWithValue("@nombre", "%" + textoBusqueda + "%");
                    command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
                    command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);

                    mostrarElementos();
                }
                else
                {
                    linkLabelColecciones.Visible = true;

                    command = new MySqlCommand("Select nombre, favorito from coleccion where nombre LIKE @nombre and nombre_user = @nombre_user order by nombre", connection);
                    command.Parameters.AddWithValue("@nombre", "%" + textoBusqueda + "%");
                    command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);

                    mostrarColecciones();
                }
            }

            toolStripTextBoxBusqueda.Text = "";
        }

        private void linkLabelMisColecciones_TodosElementos(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelMisColecciones.Text = "Volver a mis colecciones";
            linkLabelMisColecciones.LinkClicked += linkLabelMisColecciones_LinkClicked;
            linkLabelMisColecciones.LinkClicked -= linkLabelMisColecciones_TodosElementos;

            command = new MySqlCommand("Select nombre from elementos where nombre_user = @nombre_user and nombre_col = @nombre_col order by nombre", connection);
            command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
            command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);

            mostrarElementos();
        }

        /// <summary>
        /// Muestra las colecciones cuyo nombre incluya la cadena escrita en el TextBoxBusqueda llamando al evento buscarToolStripMenuItem_Click
        /// </summary>
        private void toolStripTextBoxBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarToolStripMenuItem_Click(sender, e);
            }
        }

        /// <summary>
        /// Muestra las colecciones a partir de una query que se ha de definir necesariamente antes de llamar a esta función
        /// </summary>
        private void mostrarColecciones()
        {
            limpiarColecciones();

            connection.Open();

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ControlElemento.Elemento coleccion = new ControlElemento.Elemento();
                coleccion.Name = reader["nombre"].ToString();
                coleccion.setNombre(reader["nombre"].ToString());
                coleccion.Margin = new Padding(70, 10, 0, 60);
                coleccion.Click += new EventHandler(elementVerColeccion_Click);

                if(reader["favorito"].ToString() == "0")
                {
                    coleccion.setFavorito(false);
                }
                else
                {
                    coleccion.setFavorito(true);
                }

                coleccion.setButtonBorrarClick(buttonBorrar_Click) ;
                coleccion.setButtonEditarClick(buttonEditar_Click);
                coleccion.setButtonFavoritosClick(buttonFavoritos_Click);

                flowLayoutPanelColecciones.Controls.Add(coleccion);
            }

            connection.Close();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;

            MySqlCommand delete = new MySqlCommand("Delete from coleccion where nombre_user = @nombre_user and nombre = @nombre", connection);
            delete.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
            delete.Parameters.AddWithValue("@nombre", buttonClicked.Name);

            connection.Open();
            delete.ExecuteNonQuery();
            connection.Close();

            homeToolStripMenuItem_Click(sender, null);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonFavoritos_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            MySqlCommand favorito = new MySqlCommand("Select favorito from coleccion where nombre_user = @nombre_user and nombre = @nombre", connection);
            favorito.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
            favorito.Parameters.AddWithValue("@nombre", buttonClicked.Name);

            connection.Open();

            MySqlDataReader readerFav = favorito.ExecuteReader();
            readerFav.Read();

            if(readerFav["favorito"].ToString() == "0")
            {
                favorito = new MySqlCommand("Update coleccion set favorito = 1 where nombre_user = @nombre_user and nombre = @nombre", connection);
            }
            else
            {
                favorito = new MySqlCommand("Update coleccion set favorito = 0 where nombre_user = @nombre_user and nombre = @nombre", connection);
            }

            readerFav.Close();
            
            favorito.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
            favorito.Parameters.AddWithValue("@nombre", buttonClicked.Name);

            favorito.ExecuteNonQuery();
            connection.Close();

            homeToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Muestra los elementos de una colección a partir de una query definida antes de llamar a la función
        /// </summary>
        private void mostrarElementos()
        {
            limpiarElementos();

            connection.Open();

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ControlElemento.Elemento elemento = new ControlElemento.Elemento();
                elemento.Name = reader["nombre"].ToString();
                elemento.setNombre(reader["nombre"].ToString());
                elemento.Margin = new Padding(70, 10, 0, 60);
                elemento.Click += new EventHandler(elementVerElemento_Click);
                elemento.ocultarFavoritos();

                flowLayoutPanelElementos.Controls.Add(elemento);
            }

            connection.Close();
        }

        /// <summary>
        /// Muestra las colecciones disponibles llamando al evento FormCollect_Load
        /// </summary>
        private void linkLabelColecciones_Click(object sender, EventArgs e)
        {
            linkLabelColecciones.Visible = false;
            command = new MySqlCommand("Select nombre, favorito from coleccion where nombre_user=@usuario order by nombre", connection);
            command.Parameters.AddWithValue("@usuario", UsuarioActivo);

            mostrarColecciones();
        }

        /// <summary>
        /// Muestra las colecciones marcadas como favoritas
        /// </summary>
        private void coleccionesFavoritasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanelColecciones.Visible = true;

            linkLabelColecciones.Visible = true;

            command = new MySqlCommand("Select nombre, favorito from coleccion where favorito = 1 and nombre_user = @nombre_user order by nombre", connection);
            command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);

            mostrarColecciones();
        }

        /// <summary>
        /// Muestra las colecciones creadas en el último mes
        /// </summary>
        private void coleccionesRecientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanelColecciones.Visible = true;

            linkLabelColecciones.Visible = true;

            command = new MySqlCommand("Select nombre, favorito from coleccion where fecha > @fecha and nombre_user = @nombre_user order by fecha desc", connection);
            command.Parameters.AddWithValue("@fecha", DateTime.Now.AddMonths(-1));
            command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);

            mostrarColecciones();
        }

        private void linkLabelRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistro form = new FormRegistro(connection);
            form.ShowDialog();

            iniciarSesion(form.Nombre, form.Contrasena);
        }

        private void buttonInicioSesion_Click(object sender, EventArgs e)
        {
            iniciarSesion(textBoxNombreUser.Text, textBoxContrasenaUser.Text);
        }

        private void iniciarSesion (string nombre, string contrasena)
        {
            connection.Open();

            command = new MySqlCommand("Select nombre from usuarios where nombre=@nombre and contrasena=@contrasena", connection);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@contrasena", contrasena);

            reader = command.ExecuteReader();

            if (reader.Read())
            {
                connection.Close();

                UsuarioActivo = nombre;

                textBoxContrasenaUser.Text = "";

                homeToolStripMenuItem_Click(null, null);
            }
            else
            {
                connection.Close();
                MessageBox.Show("Nombre o contraseña incorrecto", "Error");
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenuStrip.Visible = false;
            flowLayoutPanelElementos.Visible = false;
            flowLayoutPanelColecciones.Visible = false;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanelColecciones.Visible = true;
            flowLayoutPanelElementos.Visible = true;
            MainMenuStrip.Visible = true;

            textBoxContrasenaUser.Text = "";

            linkLabelColecciones.Visible = false;
            command = new MySqlCommand("Select nombre, favorito from coleccion where nombre_user=@usuario order by nombre", connection);
            command.Parameters.AddWithValue("@usuario", UsuarioActivo);

            mostrarColecciones();
        }

        private void textBoxNombreUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciarSesion(textBoxNombreUser.Text, textBoxContrasenaUser.Text);
            }
        }

        private void textBoxContrasenaUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciarSesion(textBoxNombreUser.Text, textBoxContrasenaUser.Text);
            }
        }
    }
}
