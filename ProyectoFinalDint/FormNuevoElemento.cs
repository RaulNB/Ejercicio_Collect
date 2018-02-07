using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalDint
{
    public partial class FormNuevoElemento : Form
    {
        private MySqlConnection connection;
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] ImgBytes { get; set; }
        public string NombreCol { get; set; }

        public FormNuevoElemento(MySqlConnection connection, string NombreCol)
        {
            this.connection = connection;
            this.NombreCol = NombreCol;

            InitializeComponent();
        }

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

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Nombre = textBoxNombre.Text;
            Descripcion = richTextBoxDescripcion.Text;

            if (textBoxImg.Text != "")
            {
                FileStream fs = new FileStream(textBoxImg.Text, FileMode.Open);
                BinaryReader reader = new BinaryReader(fs);
                ImgBytes = reader.ReadBytes((int)fs.Length);
                fs.Close();
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

                string insert = "Insert into elementos values(@nombre, @imagen, @descripcion, @nombre_col)";
                MySqlCommand command = new MySqlCommand(insert, connection);
                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@imagen", ImgBytes);
                command.Parameters.AddWithValue("@descripcion", Descripcion);
                command.Parameters.AddWithValue("@nombre_col", NombreCol);

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
