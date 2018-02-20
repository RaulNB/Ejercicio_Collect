using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalDint
{
    public partial class FormEditarElemento : Form
    {
        MySqlConnection connection;
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] ImgBytes;

        public FormEditarElemento(MySqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void buttonImagen_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Cargar Imagen";
            openFile.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                labelImg.Text = openFile.FileName;
                FileStream fs = new FileStream(openFile.FileName, FileMode.Open);
                BinaryReader reader = new BinaryReader(fs);
                ImgBytes = reader.ReadBytes((int)fs.Length);
                reader.Close();
            }
        }

        private void buttonAceptar_Click(object sender, System.EventArgs e)
        {
            string update = "Update elementos set descripcion = @descripcion where nombre = @nombre";
            MySqlCommand command = new MySqlCommand(update, connection);
            command.Parameters.AddWithValue("@nombre", Nombre);
            command.Parameters.AddWithValue("@descripcion", richTextBoxDescripcion.Text);

            connection.Open();

            command.ExecuteNonQuery();

            if (labelImg.Text != "Cambiar imagen...")
            {
                update = "Update elementos set imagen = @imagen where nombre = @nombre";
                command = new MySqlCommand(update, connection);
                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@imagen", ImgBytes);
            }

            command.ExecuteNonQuery();

            connection.Close();

            DialogResult = DialogResult.OK;
        }

        private void FormEditarElemento_Load(object sender, System.EventArgs e)
        {
            labelNombre.Text = Nombre;

            richTextBoxDescripcion.Text = Descripcion;
        }
    }
}
