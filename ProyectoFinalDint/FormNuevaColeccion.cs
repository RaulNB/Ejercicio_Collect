using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProyectoFinalDint
{
    /// <summary>
    /// Ventana que permite crear colecciones
    /// </summary>
    public partial class FormNuevaColeccion : Form
    {
        private MySqlConnection connection;

        /// <summary>
        /// Nombre de la colección
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Nombre del usuario que crea la colección
        /// </summary>
        public string NombreUser { get; set; }

        /// <summary>
        /// Recoge la conexión y inicializa los componentes
        /// </summary>
        /// <param name="connection">Conexión a la base de datos</param>
        public FormNuevaColeccion(MySqlConnection connection)
        {
            this.connection = connection;

            InitializeComponent();
        }

        /// <summary>
        /// Permite la inserción de un elemento
        /// </summary>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Nombre = textBoxNombre.Text;
            bool InsercionCorrecta = true;

            if (Nombre.Trim().Equals(""))
            {
                InsercionCorrecta = false;
                MessageBox.Show("Introduce un nombre", "Error");
            }
            else
            {
                connection.Open();

                string insert = "Insert into coleccion (nombre, nombre_user) values(@nombre, @nombre_user)";
                MySqlCommand command = new MySqlCommand(insert, connection);
                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@nombre_user", NombreUser);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException)
                {
                    InsercionCorrecta = false;
                    MessageBox.Show("Ya existe una colección con ese nombre", "Error");
                }

                connection.Close();
            }

            if (InsercionCorrecta == true)
            {
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Permite la inserción de un elemento al pulsar enter
        /// </summary>
        private void textBoxNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonAceptar_Click(sender, null);
            }
        }
    }
}
