using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace ProyectoFinalDint
{
    public partial class FormCollect : Form
    {
        /// <summary>
        /// Guarda la última colección seleccionada
        /// </summary>
        public string ColeccionActiva { get; set; }

        /// <summary>
        /// Guarda el último usuario que ha iniciado sesión
        /// </summary>
        public string UsuarioActivo { get; set; }

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection connection = null;
        MySqlCommand command = null;
        MySqlDataReader reader = null;

        /// <summary>
        /// Conectar a la base de datos y mostrar los componentes
        /// </summary>
        public FormCollect()
        {
            conectarBBDD();

            InitializeComponent();
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
        /// Inicia sesión con el usuario y contraseña escritos
        /// </summary>
        private void buttonInicioSesion_Click(object sender, EventArgs e)
        {
            iniciarSesion(textBoxNombreUser.Text, textBoxContrasenaUser.Text);
        }

        /// <summary>
        /// Permite el inicio de sesión al pulsar enter
        /// </summary>
        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciarSesion(textBoxNombreUser.Text, textBoxContrasenaUser.Text);
            }
        }

        /// <summary>
        /// Permite el inicio de sesión
        /// </summary>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="contrasena">Contraseña del usuario</param>
        private void iniciarSesion(string nombre, string contrasena)
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
                textBoxNombreUser.Text = "";

                flowLayoutPanelColecciones.Visible = true;
                linkLabelColecciones.Visible = false;
                flowLayoutPanelElementos.Visible = true;
                MainMenuStrip.Visible = true;

                mostrarColecciones();
            }
            else
            {
                connection.Close();
                MessageBox.Show("Nombre o contraseña incorrecto", "Error");
            }
        }

        /// <summary>
        /// Registra a un usuario mediante un form externo y inicia su sesión
        /// </summary>
        private void linkLabelRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistro form = new FormRegistro(connection);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                iniciarSesion(form.Nombre, form.Contrasena);
            }
        }

        /// <summary>
        /// Cierra la session
        /// </summary>
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenuStrip.Visible = false;
            flowLayoutPanelElementos.Visible = false;
            flowLayoutPanelColecciones.Visible = false;
        }

        /// <summary>
        /// Añade una colección al panel
        /// </summary>
        /// <param name="nombre">Nombre de la colección</param>
        /// <param name="fav">0 si no es favorito o 1 si sí que lo es</param>
        private void anadirColeccion(string nombre, string fav)
        {
            ControlElemento.Elemento coleccion = new ControlElemento.Elemento();
            coleccion.Name = nombre;
            coleccion.setNombre(nombre);
            coleccion.Margin = new Padding(70, 10, 0, 60);
            coleccion.setOnClick(elementVerColeccion_Click);

            if (fav == "0")
            {
                coleccion.setFavorito(false);
            }
            else
            {
                coleccion.setFavorito(true);
            }

            coleccion.setButtonBorrarClick(buttonBorrarColeccion_Click);
            coleccion.setButtonFavoritosClick(buttonFavoritos_Click);

            flowLayoutPanelColecciones.Controls.Add(coleccion);
        }

        /// <summary>
        /// Añade una coleccion desde un form externo y entra en ella
        /// </summary>
        private void buttonAnadirColeccion_Click(object sender, EventArgs e)
        {
            if (linkLabelColecciones.Visible == true)
            {
                linkLabelColecciones.Visible = false;
                mostrarColecciones();
            }

            FormNuevaColeccion form = new FormNuevaColeccion(connection);
            form.NombreUser = UsuarioActivo;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                anadirColeccion(form.Nombre, "0");
            }
        }

        /// <summary>
        /// Añade una coleccion desde un form externo y entra en ella
        /// </summary>
        private void crearColecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(flowLayoutPanelColecciones.Visible == false)
            {
                flowLayoutPanelColecciones.Visible = true;
            }

            buttonAnadirColeccion_Click(sender, e);
        }

        /// <summary>
        /// Muestra todas las colecciones del usuario activo
        /// </summary>
        private void mostrarColecciones()
        {
            limpiarColecciones();

            if(linkLabelColecciones.Visible == true)
            {
                linkLabelColecciones.Visible = false;
            }

            command = new MySqlCommand("select nombre, favorito from coleccion where nombre_user = @nombre_user order by fecha asc", connection);
            command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);

            connection.Open();

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                anadirColeccion(reader["nombre"].ToString(), reader["favorito"].ToString());
            }

            connection.Close();
        }

        /// <summary>
        /// Borra la colección
        /// </summary>
        private void buttonBorrarColeccion_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;

            DialogResult result = MessageBox.Show("¿Quieres eliminar la colección \"" + buttonClicked.Name + "\"?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                MySqlCommand delete = new MySqlCommand("Delete from coleccion where nombre_user = @nombre_user and nombre = @nombre", connection);
                delete.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
                delete.Parameters.AddWithValue("@nombre", buttonClicked.Name);

                connection.Open();
                delete.ExecuteNonQuery();
                connection.Close();

                flowLayoutPanelColecciones.Controls.Remove(flowLayoutPanelColecciones.Controls.Find(buttonClicked.Name, false).First());
            } 
        }

        /// <summary>
        /// Añade una colección a favoritos
        /// </summary>
        private void buttonFavoritos_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            MySqlCommand favorito = new MySqlCommand("Select favorito from coleccion where nombre_user = @nombre_user and nombre = @nombre", connection);
            favorito.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
            favorito.Parameters.AddWithValue("@nombre", buttonClicked.Name);

            ControlElemento.Elemento elemento = flowLayoutPanelColecciones.Controls.Find(buttonClicked.Name, false).Cast<ControlElemento.Elemento>().First();

            connection.Open();

            MySqlDataReader readerFav = favorito.ExecuteReader();
            readerFav.Read();

            if (readerFav["favorito"].ToString() == "0")
            {
                favorito = new MySqlCommand("Update coleccion set favorito = 1 where nombre_user = @nombre_user and nombre = @nombre", connection);
                elemento.setFavorito(true);
            }
            else
            {
                favorito = new MySqlCommand("Update coleccion set favorito = 0 where nombre_user = @nombre_user and nombre = @nombre", connection);
                elemento.setFavorito(false);
            }

            readerFav.Close();

            favorito.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
            favorito.Parameters.AddWithValue("@nombre", buttonClicked.Name);

            favorito.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Muestra las colecciones disponibles
        /// </summary>
        private void linkLabelColecciones_Click(object sender, EventArgs e)
        {
            linkLabelColecciones.Visible = false;

            mostrarColecciones();
        }

        /// <summary>
        /// Muestra las colecciones marcadas como favoritas
        /// </summary>
        private void coleccionesFavoritasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelColecciones.Visible == false)
            {
                flowLayoutPanelColecciones.Visible = true;
            }

            linkLabelColecciones.Visible = true;

            command = new MySqlCommand("Select nombre, favorito from coleccion where favorito = 1 and nombre_user = @nombre_user order by nombre", connection);
            command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);

            limpiarColecciones();

            connection.Open();

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                anadirColeccion(reader["nombre"].ToString(), reader["favorito"].ToString());
            }

            connection.Close();
        }

        /// <summary>
        /// Muestra las colecciones creadas en el último mes
        /// </summary>
        private void coleccionesRecientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelColecciones.Visible == false)
            {
                flowLayoutPanelColecciones.Visible = true;
            }

            flowLayoutPanelColecciones.Visible = true;

            linkLabelColecciones.Visible = true;

            command = new MySqlCommand("Select nombre, favorito from coleccion where fecha > @fecha and nombre_user = @nombre_user order by fecha desc", connection);
            command.Parameters.AddWithValue("@fecha", DateTime.Now.AddMonths(-1));
            command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);

            limpiarColecciones();

            connection.Open();

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                anadirColeccion(reader["nombre"].ToString(), reader["favorito"].ToString());
            }

            connection.Close();
        }

        /// <summary>
        /// Muestra todas las colecciones del usuario activo
        /// </summary>
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelColecciones.Visible == false)
            {
                flowLayoutPanelColecciones.Visible = true;

                mostrarColecciones();
            }
            else if (linkLabelColecciones.Visible == true)
            {
                linkLabelColecciones.Visible = false;

                mostrarColecciones();
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
                flowLayoutPanelColecciones.Controls.Remove(coleccion);
            }
        }

        /// <summary>
        /// Añade un elemento al panel
        /// </summary>
        /// <param name="nombre">Nombre del elemento</param>
        /// <param name="ImgBytes">Imagen del elemento</param>
        private void anadirElemento(string nombre, byte[] ImgBytes)
        {
            ControlElemento.Elemento elemento = new ControlElemento.Elemento();
            elemento.Name = nombre;
            elemento.setNombre(nombre);
            elemento.Margin = new Padding(70, 10, 0, 60);

            elemento.setOnClick(elementVerElemento_Click);
            elemento.ocultarFavoritos();
            elemento.setButtonBorrarClick(buttonBorrarElemento_Click);
            elemento.setButtonEditarClick(buttonEditar_Click);

            if (ImgBytes != null)
            {
                MemoryStream ms = new MemoryStream(ImgBytes);
                Image fondo = Image.FromStream(ms);

                elemento.BackgroundImage = fondo;
                elemento.BackgroundImageLayout = ImageLayout.Zoom;
            }

            flowLayoutPanelElementos.Controls.Add(elemento);
        }

        /// <summary>
        /// Muestra los elementos de una colección
        /// </summary>
        private void mostrarElementos()
        {
            byte[] ImgBytes = null;

            limpiarElementos();

            labelTituloColeccion.Text = ColeccionActiva;

            linkLabelMisColecciones.Visible = true;
            linkLabelElementos.Visible = false;

            command = new MySqlCommand("Select nombre, imagen from elementos where nombre_col = @nombre_col and nombre_user=@nombre_user order by fecha asc", connection);
            command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);
            command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);

            connection.Open();

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader["imagen"] != null)
                {
                    ImgBytes = (byte[])reader["imagen"];
                }
                anadirElemento(reader["nombre"].ToString(), ImgBytes);
            }

            connection.Close();
        }

        /// <summary>
        /// Muestra los elementos de la colección seleccionada
        /// </summary>
        private void elementVerColeccion_Click(Object sender, EventArgs e)
        {
            flowLayoutPanelColecciones.Visible = false;

            try
            {
                ControlElemento.Elemento buttonClicked = sender as ControlElemento.Elemento;
                ColeccionActiva = buttonClicked.Name;
            }
            catch (NullReferenceException)
            {
                Label buttonClicked = sender as Label;
                ColeccionActiva = buttonClicked.Text;
            }

            mostrarElementos();
        }

        /// <summary>
        /// Muestra los datos del elemento seleccionado
        /// </summary>
        private void elementVerElemento_Click(Object sender, EventArgs e)
        {
            string buttonClicked;
            try
            {
                ControlElemento.Elemento elemento = sender as ControlElemento.Elemento;
                buttonClicked = elemento.Name;
            }
            catch (NullReferenceException)
            {
                Label label = sender as Label;
                buttonClicked = label.Text;
            }
            FormVerElemento form = new FormVerElemento(connection);

            connection.Open();

            command = new MySqlCommand("Select nombre, descripcion, imagen from elementos where nombre=@nombre and nombre_col = @nombre_col and nombre_user = @nombre_user", connection);
            command.Parameters.AddWithValue("@nombre", buttonClicked);
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

            if (form.DialogResult == DialogResult.No)
            {
                Button elementoBorrar = new Button();
                elementoBorrar.Name = buttonClicked;
                buttonBorrarElemento_Click(elementoBorrar, null);
            }
        }

        /// <summary>
        /// Añade un elemento a una colección desde un form externo y muestra los elementos de esa colección
        /// </summary>
        private void buttonAnadirElemento_Click(object sender, EventArgs e)
        {
            if (linkLabelMisColecciones.Visible == false)
            {
                mostrarElementos();
            }

            FormNuevoElemento form = new FormNuevoElemento(connection);
            form.NombreCol = ColeccionActiva;
            form.NombreUser = UsuarioActivo;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                anadirElemento(form.Nombre, form.ImgBytes);
            }
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
                flowLayoutPanelElementos.Controls.Remove(elemento);
            }
        }

        /// <summary>
        /// Muestra todos los elementos de la colección y cambia el link del panel de elementos
        /// </summary>
        private void linkLabelElementos_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpiarElementos();
            mostrarElementos();
        }

        /// <summary>
        /// Borra el elemento
        /// </summary>
        private void buttonBorrarElemento_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;

            DialogResult result = MessageBox.Show("¿Quieres eliminar el elemento \"" + buttonClicked.Name + "\"?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                MySqlCommand delete = new MySqlCommand("Delete from elementos where nombre_user = @nombre_user and nombre = @nombre and nombre_col = @nombre_col", connection);
                delete.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
                delete.Parameters.AddWithValue("@nombre", buttonClicked.Name);
                delete.Parameters.AddWithValue("@nombre_col", ColeccionActiva);

                connection.Open();
                delete.ExecuteNonQuery();
                connection.Close();

                flowLayoutPanelElementos.Controls.Remove(flowLayoutPanelElementos.Controls.Find(buttonClicked.Name, false).First());
            }
        }

        /// <summary>
        /// Permite editar los datos de un elemento**********MOSTRAR IMAGEN EN DISEÑO***********
        /// </summary>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            FormEditarElemento form = new FormEditarElemento(connection);

            command = new MySqlCommand("Select nombre, descripcion, imagen from elementos where nombre=@nombre and nombre_col = @nombre_col and nombre_user = @nombre_user", connection);
            command.Parameters.AddWithValue("@nombre", buttonClicked.Name);
            command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);
            command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);

            connection.Open();

            reader = command.ExecuteReader();
            reader.Read();

            form.Nombre = buttonClicked.Name;
            form.Descripcion = reader["descripcion"].ToString();

            if(reader["imagen"] != null)
            {
                form.ImgBytes = (byte[])reader["imagen"];
            }
            else
            {
                form.ImgBytes = null;
            }
            

            ControlElemento.Elemento elemento = (ControlElemento.Elemento) flowLayoutPanelElementos.Controls.Find(buttonClicked.Name, false).First();

            connection.Close();

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK && form.ImgBytes != null)
            {
                MemoryStream ms = new MemoryStream(form.ImgBytes);
                Image fondo = Image.FromStream(ms);

                elemento.BackgroundImage = fondo;
                elemento.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        /// <summary>
        /// Muestra todas las colecciones del usuario
        /// </summary>
        private void linkLabelMisColecciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flowLayoutPanelColecciones.Visible = true;

            mostrarColecciones();
        }

        /// <summary>
        /// Muestra las colecciones o elementos cuyo nombre incluya la cadena escrita en la barra de búsqueda al escribir una letra
        /// </summary>
        private void toolStripTextBoxBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            string textoBusqueda = toolStripTextBoxBusqueda.Text.Trim();
            byte[] ImgBytes = null;

            if (textoBusqueda != "")
            {
                if (flowLayoutPanelColecciones.Visible == false)
                {
                    linkLabelElementos.Visible = true;
                    linkLabelMisColecciones.Visible = false;

                    command = new MySqlCommand("Select nombre, imagen from elementos where nombre LIKE @nombre and nombre_user = @nombre_user and nombre_col = @nombre_col order by nombre", connection);
                    command.Parameters.AddWithValue("@nombre", "%" + textoBusqueda + "%");
                    command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);
                    command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);

                    limpiarElementos();

                    connection.Open();

                    reader = command.ExecuteReader();

                    if (reader["imagen"] != null)
                    {
                        ImgBytes = (byte[])reader["imagen"];
                    }

                    while (reader.Read())
                    {
                        anadirElemento(reader["nombre"].ToString(), ImgBytes);
                    }

                    connection.Close();
                }
                else
                {
                    linkLabelColecciones.Visible = true;

                    command = new MySqlCommand("Select nombre, favorito from coleccion where nombre LIKE @nombre and nombre_user = @nombre_user order by nombre", connection);
                    command.Parameters.AddWithValue("@nombre", "%" + textoBusqueda + "%");
                    command.Parameters.AddWithValue("@nombre_user", UsuarioActivo);

                    limpiarColecciones();

                    connection.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        anadirColeccion(reader["nombre"].ToString(), reader["favorito"].ToString());
                    }

                    connection.Close();
                }
            }
            else
            {
                if (flowLayoutPanelColecciones.Visible == false)
                {
                    limpiarElementos();
                    mostrarElementos();
                }
                else
                {
                    limpiarColecciones();
                    mostrarColecciones();
                }
            }
        }
    }
}
