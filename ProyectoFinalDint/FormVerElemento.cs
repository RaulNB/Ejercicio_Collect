using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalDint
{
    public partial class FormVerElemento : Form
    {
        /// <summary>
        /// Imagen del elemento en bytes
        /// </summary>
        public byte[] ImgBytes { get; set; }

        /// <summary>
        /// Descripción del elemento
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Inicializa los componentes
        /// </summary>
        public FormVerElemento()
        {
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
    }
}
