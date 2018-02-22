using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalDint
{
    public partial class FormEditarElemento : Form
    {
        MySqlConnection connection;
        
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
        public byte[] ImgBytes;

        /// <summary>
        /// Recoge la conexión y inicializa los componentes
        /// </summary>
        /// <param name="connection">Conexión a la base de datos</param>
        public FormEditarElemento(MySqlConnection connection)
        {
            this.connection = connection;

            InitializeComponent();
        }

        /// <summary>
        /// Permite cambiar la imagen de un elemento
        /// </summary>
        private void buttonImagen_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Cargar Imagen";
            openFile.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFile.FileName, FileMode.Open);
                BinaryReader reader = new BinaryReader(fs);
                ImgBytes = reader.ReadBytes((int)fs.Length);
                panelImagen.BackgroundImage = Image.FromStream(fs);
                reader.Close();
            }
        }

        /// <summary>
        /// Permite la edición de la descripción y la imagen
        /// </summary>
        private void buttonAceptar_Click(object sender, System.EventArgs e)
        {
            string update = "Update elementos set descripcion = @descripcion where nombre = @nombre";
            MySqlCommand command = new MySqlCommand(update, connection);
            command.Parameters.AddWithValue("@nombre", Nombre);
            command.Parameters.AddWithValue("@descripcion", richTextBoxDescripcion.Text);

            Descripcion = richTextBoxDescripcion.Text;

            connection.Open();

            command.ExecuteNonQuery();

            if (ImgBytes != null)
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

        /// <summary>
        /// Muestra el nombre y la descripción del elemento
        /// </summary>
        private void FormEditarElemento_Load(object sender, System.EventArgs e)
        {
            if (ImgBytes != null)
            {
                MemoryStream stream = new MemoryStream(ImgBytes);
                panelImagen.BackgroundImage = Image.FromStream(stream);
                ImgBytes = null;
            }
            labelNombre.Text = Nombre;
            

            richTextBoxDescripcion.Text = Descripcion;
        }
    }
}
