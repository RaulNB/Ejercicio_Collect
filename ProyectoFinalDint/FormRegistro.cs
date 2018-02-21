using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace ProyectoFinalDint
{
    public partial class FormRegistro : Form
    {
        private MySqlConnection connection;

        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Contraseña del usuario
        /// </summary>
        public string Contrasena { get; set; }

        /// <summary>
        /// Recoge la conexión y inicializa los componentes
        /// </summary>
        /// <param name="connection">Conexión a la base de datos</param>
        public FormRegistro(MySqlConnection connection)
        {
            this.connection = connection;

            InitializeComponent();
        }

        /// <summary>
        /// Permite el registro de un usuario
        /// </summary>
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            bool InsercionCorrecta = false;

            if (textBoxNombre.Text.Trim() != "" && textBoxEmail.Text.Trim() != "" && textBoxContrasena.Text.Trim() != "" && textBoxRepetirContrasena.Text.Trim() != "")
            {
                Nombre = textBoxNombre.Text;
                Contrasena = textBoxContrasena.Text;

                if (textBoxContrasena.Text == textBoxRepetirContrasena.Text)
                {
                    connection.Open();

                    string insert = "Insert into usuarios values(@nombre, @email, @contrasena)";
                    MySqlCommand command = new MySqlCommand(insert, connection);
                    command.Parameters.AddWithValue("@nombre", Nombre);
                    command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    command.Parameters.AddWithValue("@contrasena", Contrasena);

                    try
                    {
                        command.ExecuteNonQuery();
                        InsercionCorrecta = true;
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Ya existe un usuario con ese nombre", "Error");
                    }

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error");
                }
            }
            else
            {
                MessageBox.Show("Algún campo no introducido", "Error");
            }

            if (InsercionCorrecta == true)
            {
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Permite el registro de un usuario al pulsar enter
        /// </summary>
        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonRegistrar_Click(sender, null);
            }
        }
    }
}
