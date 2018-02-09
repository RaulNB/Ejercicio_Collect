using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace ProyectoFinalDint
{
    public partial class FormCollect : Form
    {
        public string ColeccionActiva { get; set; }

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
        /// Muestra las colecciones disponibles
        /// </summary>
        private void FormCollect_Load(object sender, EventArgs e)
        {
            linkLabelColecciones.Visible = false;
            command = new MySqlCommand("Select nombre from coleccion order by nombre", connection);

            mostrarColecciones();
        }

        /// <summary>
        /// Muestra los elementos de la colección seleccionada
        /// </summary>
        private void elementVerColeccion_Click(Object sender, EventArgs e)
        {
            ControlElemento.Elemento buttonClicked = sender as ControlElemento.Elemento;
            ColeccionActiva = buttonClicked.Name;

            limpiarElementos();

            connection.Open();

            command = new MySqlCommand("Select nombre from elementos where nombre_col = @nombre_col order by nombre", connection);
            command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ControlElemento.Elemento elemento = new ControlElemento.Elemento();
                elemento.Name = reader["nombre"].ToString();
                elemento.setNombre(reader["nombre"].ToString());
                elemento.Margin = new Padding(70, 10, 0, 60);
                elemento.Click += new EventHandler(elementVerElemento_Click);

                flowLayoutPanelElementos.Controls.Add(elemento);
            }

            connection.Close();

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

            command = new MySqlCommand("Select nombre, descripcion, imagen from elementos where nombre=@nombre and nombre_col = @nombre_col", connection);
            command.Parameters.AddWithValue("@nombre", buttonClicked.Name);
            command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);
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
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                FormCollect_Load(sender, e);
            }
        }

        /// <summary>
        /// Añade una coleccion desde un form externo y muestra las coleccion llamando al evento buttonElementAnadirColeccion_Click
        /// </summary>
        private void crearColecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAnadirColeccion_Click(sender, e);
        }

        /// <summary>
        /// Añade un elemento a una colección desde un form externo y muestra los elementos de esa colección MODIFICAR
        /// </summary>
        private void buttonAnadirElemento_Click(object sender, EventArgs e)
        {
            FormNuevoElemento form = new FormNuevoElemento(connection, ColeccionActiva);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                connection.Open();

                command = new MySqlCommand("Select nombre from elementos where nombre=@nombre and nombre_col = @nombre_col order", connection);
                command.Parameters.AddWithValue("@nombre", form.Nombre);
                command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);
                reader = command.ExecuteReader();
                reader.Read();

                ControlElemento.Elemento elemento = new ControlElemento.Elemento();
                elemento.Name = reader["nombre"].ToString();
                elemento.setNombre(reader["nombre"].ToString());
                elemento.Margin = new Padding(70, 10, 0, 60);
                elemento.Click += new EventHandler(elementVerElemento_Click);

                flowLayoutPanelElementos.Controls.Add(elemento);

                connection.Close();
            }
        }

        /// <summary>
        /// Oculta los elementos y muestra las colecciones
        /// </summary>
        private void linkLabelMisColecciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flowLayoutPanelElementos.Visible = false;
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
                linkLabelColecciones.Visible = true;

                command = new MySqlCommand("Select nombre from coleccion where nombre LIKE @nombre order by nombre", connection);
                command.Parameters.AddWithValue("@nombre", "%" + textoBusqueda + "%");

                mostrarColecciones();

                toolStripTextBoxBusqueda.Text = "";
            }
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

                flowLayoutPanelColecciones.Controls.Add(coleccion);
            }

            connection.Close();
        }

        /// <summary>
        /// Muestra las colecciones disponibles llamando al evento FormCollect_Load
        /// </summary>
        private void linkLabelColecciones_Click(object sender, EventArgs e)
        {
            FormCollect_Load(sender, e);
        }

        /// <summary>
        /// Muestra las colecciones marcadas como favoritas
        /// </summary>
        private void coleccionesFavoritasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linkLabelColecciones.Visible = true;

            command = new MySqlCommand("Select nombre from coleccion where favorito = 1 order by nombre", connection);

            mostrarColecciones();
        }

        /// <summary>
        /// Muestra las colecciones creadas en el último mes
        /// </summary>
        private void coleccionesRecientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linkLabelColecciones.Visible = true;

            command = new MySqlCommand("Select nombre from coleccion where fecha > @fecha order by fecha desc", connection);
            command.Parameters.AddWithValue("@fecha", DateTime.Now.AddMonths(-1));
            
            mostrarColecciones();
        }
    }
}
