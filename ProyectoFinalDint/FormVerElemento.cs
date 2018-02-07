using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalDint
{
    public partial class FormVerElemento : Form
    {
        public byte[] ImgBytes { get; set; }
        public string Descripcion { get; set; }

        public FormVerElemento()
        {
            InitializeComponent();
        }

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
