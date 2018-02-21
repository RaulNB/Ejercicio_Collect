using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalDint
{
    public partial class FormNuevoElemento : Form
    {
        private MySqlConnection connection;

        /// <summary>
        /// Nombre del elemento
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción del elemento
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Imagen del elemento en bytes
        /// </summary>
        public byte[] ImgBytes { get; set; }

        /// <summary>
        /// Nombre de la colección a la que pertenece
        /// </summary>
        public string NombreCol { get; set; }

        /// <summary>
        /// Nombre del usuario que crea el elemento
        /// </summary>
        public string NombreUser { get; set; }

        /// <summary>
        /// Recoge la conexión y inicializa los componentes
        /// </summary>
        /// <param name="connection">Conexión a la base de datos</param>
        public FormNuevoElemento(MySqlConnection connection)
        {
            this.connection = connection;

            InitializeComponent();
        }

        /// <summary>
        /// Permite añadir una imagen al elemento
        /// </summary>
        private void buttonImg_Click(object sender, EventArgs e)
        {
            if (buttonImg.Text == "Eliminar")
            {
                textBoxImg.Text = "";
                buttonImg.Text = "Buscar...";
            }
            else
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Cargar Imagen";
                openFile.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    textBoxImg.Text = openFile.FileName;
                    buttonImg.Text = "Eliminar";
                }
            }
        }

        /// <summary>
        /// Permite añadir un elemento
        /// </summary>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Nombre = textBoxNombre.Text;
            Descripcion = richTextBoxDescripcion.Text;

            if (textBoxImg.Text != "")
            {
                FileStream fs = new FileStream(textBoxImg.Text, FileMode.Open);
                BinaryReader reader = new BinaryReader(fs);
                ImgBytes = reader.ReadBytes((int)fs.Length);
                reader.Close();
            }

            bool InsercionCorrecta = true;

            if (Nombre.Trim().Equals(""))
            {
                InsercionCorrecta = false;
                MessageBox.Show("Introduce un nombre", "Error");
            }
            else
            {
                connection.Open();

                string insert = "Insert into elementos values(@nombre, @imagen, @descripcion, @nombre_col, @nombre_user)";
                MySqlCommand command = new MySqlCommand(insert, connection);
                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@imagen", ImgBytes);
                command.Parameters.AddWithValue("@descripcion", Descripcion);
                command.Parameters.AddWithValue("@nombre_col", NombreCol);
                command.Parameters.AddWithValue("@nombre_user", NombreUser);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException)
                {
                    InsercionCorrecta = false;
                    MessageBox.Show("Ya existe un elemento con ese nombre", "Error");
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
