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
        private void buttonElementVerColeccion_Click(Object sender, EventArgs e)
        {
            ButtonElement.ButtonElement buttonClicked = sender as ButtonElement.ButtonElement;
            ColeccionActiva = buttonClicked.Name;

            limpiarElementos();

            connection.Open();

            command = new MySqlCommand("Select nombre from elementos where nombre_col = @nombre_col order by nombre", connection);
            command.Parameters.AddWithValue("@nombre_col", ColeccionActiva);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ButtonElement.ButtonElement button = new ButtonElement.ButtonElement();
                button.Name = reader["nombre"].ToString();
                button.Text = reader["nombre"].ToString();
                button.Click += new EventHandler(buttonElementVerElemento_Click);

                flowLayoutPanelElementos.Controls.Add(button);
            }

            connection.Close();

            flowLayoutPanelElementos.Visible = true;
        }

        /// <summary>
        /// Muestra los datos del elemento seleccionado
        /// </summary>
        private void buttonElementVerElemento_Click(Object sender, EventArgs e)
        {
            ButtonElement.ButtonElement buttonClicked = sender as ButtonElement.ButtonElement;
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
        private void buttonElementAnadirColeccion_Click(object sender, EventArgs e)
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
            buttonElementAnadirColeccion_Click(sender, e);
        }

        /// <summary>
        /// Añade un elemento a una colección desde un form externo y muestra los elementos de esa colección
        /// </summary>
        private void buttonElementAnadirElemento_Click(object sender, EventArgs e)
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

                ButtonElement.ButtonElement button = new ButtonElement.ButtonElement();
                button.Name = reader["nombre"].ToString();
                button.Text = reader["nombre"].ToString();
                button.Click += new EventHandler(buttonElementVerElemento_Click);

                flowLayoutPanelElementos.Controls.Add(button);

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
            int indexButtonElement = flowLayoutPanelElementos.Controls.OfType<ButtonElement.ButtonElement>().Count() - 1;
            for (int i = indexButtonElement; i >= 0; i--)
            {
                ButtonElement.ButtonElement button = flowLayoutPanelElementos.Controls.OfType<ButtonElement.ButtonElement>().ElementAt(i);
                if (button.Name != "buttonElementAnadirElemento")
                {
                    flowLayoutPanelElementos.Controls.Remove(button);
                }
            }
        }

        /// <summary>
        /// Vacía la pantalla de colecciones
        /// </summary>
        private void limpiarColecciones()
        {
            int indexButtonElement = flowLayoutPanelColecciones.Controls.OfType<ButtonElement.ButtonElement>().Count() - 1;
            for (int i = indexButtonElement; i >= 0; i--)
            {
                ButtonElement.ButtonElement button = flowLayoutPanelColecciones.Controls.OfType<ButtonElement.ButtonElement>().ElementAt(i);
                if (button.Name != "buttonElementAnadirColeccion")
                {
                    flowLayoutPanelColecciones.Controls.Remove(button);
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
                ControlElemento.Elemento button = new ControlElemento.Elemento();
                button.Name = reader["nombre"].ToString();
                button.Text = reader["nombre"].ToString();
                button.Click += new EventHandler(buttonElementVerColeccion_Click);

                flowLayoutPanelColecciones.Controls.Add(button);
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
