using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProyectoFinalDint
{
    public partial class FormNuevaColeccion : Form
    {
        private MySqlConnection connection;
        public string Nombre { get; set; }
        public string NombreUser { get; set; }

        public FormNuevaColeccion(MySqlConnection connection)
        {
            this.connection = connection;

            InitializeComponent();
        }

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
    }
}
