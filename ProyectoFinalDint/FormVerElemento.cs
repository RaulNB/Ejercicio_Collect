using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalDint
{
    /// <summary>
    /// Ventana que muestra en detalle un elemento
    /// </summary>
    public partial class FormVerElemento : Form
    {
        private MySqlConnection connection;

        /// <summary>
        /// Imagen del elemento en bytes
        /// </summary>
        public byte[] ImgBytes { get; set; }

        /// <summary>
        /// Descripción del elemento
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Inicializa los componentes y recoge la conexión
        /// </summary>
        public FormVerElemento(MySqlConnection connection)
        {
            this.connection = connection;

            InitializeComponent();
        }

        /// <summary>
        /// Muestra los datos del elemento seleccionado
        /// </summary>
        private void FormVerElemento_Load(object sender, EventArgs e)
        {
            labelNombre.Text = Text;
            richTextBoxDescripcion.Text = Descripcion;
            if (ImgBytes != null)
            {
                MemoryStream ms = new MemoryStream(ImgBytes);
                pictureBoxCaratula.Image = Image.FromStream(ms);
            }
        }

        /// <summary>
        /// Permite modificar el elemento mostrado
        /// </summary>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            FormEditarElemento form = new FormEditarElemento(connection);
            form.Nombre = Text;
            form.Descripcion = richTextBoxDescripcion.Text;
            form.ImgBytes = ImgBytes;

            form.ShowDialog();

            if(form.DialogResult == DialogResult.OK)
            {
                richTextBoxDescripcion.Text = form.Descripcion;
                if (form.ImgBytes != null)
                {
                    MemoryStream ms = new MemoryStream(form.ImgBytes);
                    pictureBoxCaratula.Image = Image.FromStream(ms);
                }
            }
        }

        /// <summary>
        /// Permite borrar el elemento mostrado
        /// </summary>
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
