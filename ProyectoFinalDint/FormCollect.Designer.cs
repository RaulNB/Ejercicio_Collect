namespace ProyectoFinalDint
{
    partial class FormCollect
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCollect));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coleccionesFavoritasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coleccionesRecientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.crearColecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.linkLabelColecciones = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelColecciones = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonElementAnadirColeccion = new ButtonElement.ButtonElement();
            this.linkLabelMisColecciones = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelElementos = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonElementAnadirElemento = new ButtonElement.ButtonElement();
            this.menuStrip.SuspendLayout();
            this.flowLayoutPanelColecciones.SuspendLayout();
            this.flowLayoutPanelElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.toolStripTextBoxBusqueda});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(923, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coleccionesFavoritasToolStripMenuItem,
            this.coleccionesRecientesToolStripMenuItem,
            this.toolStripSeparator1,
            this.crearColecciónToolStripMenuItem});
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            // 
            // coleccionesFavoritasToolStripMenuItem
            // 
            this.coleccionesFavoritasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("coleccionesFavoritasToolStripMenuItem.Image")));
            this.coleccionesFavoritasToolStripMenuItem.Name = "coleccionesFavoritasToolStripMenuItem";
            this.coleccionesFavoritasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.coleccionesFavoritasToolStripMenuItem.Text = "Colecciones Favoritas";
            this.coleccionesFavoritasToolStripMenuItem.Click += new System.EventHandler(this.coleccionesFavoritasToolStripMenuItem_Click);
            // 
            // coleccionesRecientesToolStripMenuItem
            // 
            this.coleccionesRecientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("coleccionesRecientesToolStripMenuItem.Image")));
            this.coleccionesRecientesToolStripMenuItem.Name = "coleccionesRecientesToolStripMenuItem";
            this.coleccionesRecientesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.coleccionesRecientesToolStripMenuItem.Text = "Colecciones Recientes";
            this.coleccionesRecientesToolStripMenuItem.Click += new System.EventHandler(this.coleccionesRecientesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // crearColecciónToolStripMenuItem
            // 
            this.crearColecciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("crearColecciónToolStripMenuItem.Image")));
            this.crearColecciónToolStripMenuItem.Name = "crearColecciónToolStripMenuItem";
            this.crearColecciónToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.crearColecciónToolStripMenuItem.Text = "Crear Colección";
            this.crearColecciónToolStripMenuItem.Click += new System.EventHandler(this.crearColecciónToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.perfilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("perfilToolStripMenuItem.Image")));
            this.perfilToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buscarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.buscarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarToolStripMenuItem.Image")));
            this.buscarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // toolStripTextBoxBusqueda
            // 
            this.toolStripTextBoxBusqueda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxBusqueda.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.toolStripTextBoxBusqueda.Name = "toolStripTextBoxBusqueda";
            this.toolStripTextBoxBusqueda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripTextBoxBusqueda.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxBusqueda_KeyDown);
            // 
            // linkLabelColecciones
            // 
            this.linkLabelColecciones.AutoSize = true;
            this.flowLayoutPanelColecciones.SetFlowBreak(this.linkLabelColecciones, true);
            this.linkLabelColecciones.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelColecciones.Location = new System.Drawing.Point(3, 0);
            this.linkLabelColecciones.Name = "linkLabelColecciones";
            this.linkLabelColecciones.Size = new System.Drawing.Size(185, 21);
            this.linkLabelColecciones.TabIndex = 7;
            this.linkLabelColecciones.TabStop = true;
            this.linkLabelColecciones.Text = "Ver todas las Colecciones";
            this.linkLabelColecciones.Visible = false;
            this.linkLabelColecciones.Click += new System.EventHandler(this.linkLabelColecciones_Click);
            // 
            // flowLayoutPanelColecciones
            // 
            this.flowLayoutPanelColecciones.AutoScroll = true;
            this.flowLayoutPanelColecciones.AutoSize = true;
            this.flowLayoutPanelColecciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelColecciones.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanelColecciones.Controls.Add(this.linkLabelColecciones);
            this.flowLayoutPanelColecciones.Controls.Add(this.buttonElementAnadirColeccion);
            this.flowLayoutPanelColecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelColecciones.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanelColecciones.Name = "flowLayoutPanelColecciones";
            this.flowLayoutPanelColecciones.Size = new System.Drawing.Size(923, 302);
            this.flowLayoutPanelColecciones.TabIndex = 4;
            // 
            // buttonElementAnadirColeccion
            // 
            this.buttonElementAnadirColeccion.BackColor = System.Drawing.Color.White;
            this.buttonElementAnadirColeccion.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonElementAnadirColeccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonElementAnadirColeccion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonElementAnadirColeccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonElementAnadirColeccion.Image = ((System.Drawing.Image)(resources.GetObject("buttonElementAnadirColeccion.Image")));
            this.buttonElementAnadirColeccion.Location = new System.Drawing.Point(3, 99);
            this.buttonElementAnadirColeccion.MinimumSize = new System.Drawing.Size(250, 90);
            this.buttonElementAnadirColeccion.Name = "buttonElementAnadirColeccion";
            this.buttonElementAnadirColeccion.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttonElementAnadirColeccion.Size = new System.Drawing.Size(250, 90);
            this.buttonElementAnadirColeccion.TabIndex = 3;
            this.buttonElementAnadirColeccion.Text = "Añadir una colección";
            this.buttonElementAnadirColeccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonElementAnadirColeccion.UseVisualStyleBackColor = false;
            this.buttonElementAnadirColeccion.Click += new System.EventHandler(this.buttonElementAnadirColeccion_Click);
            // 
            // linkLabelMisColecciones
            // 
            this.linkLabelMisColecciones.AutoSize = true;
            this.flowLayoutPanelElementos.SetFlowBreak(this.linkLabelMisColecciones, true);
            this.linkLabelMisColecciones.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelMisColecciones.Location = new System.Drawing.Point(3, 0);
            this.linkLabelMisColecciones.Name = "linkLabelMisColecciones";
            this.linkLabelMisColecciones.Size = new System.Drawing.Size(182, 21);
            this.linkLabelMisColecciones.TabIndex = 6;
            this.linkLabelMisColecciones.TabStop = true;
            this.linkLabelMisColecciones.Text = "Volver a Mis Colecciones";
            this.linkLabelMisColecciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMisColecciones_LinkClicked);
            // 
            // flowLayoutPanelElementos
            // 
            this.flowLayoutPanelElementos.AutoSize = true;
            this.flowLayoutPanelElementos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelElementos.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanelElementos.Controls.Add(this.linkLabelMisColecciones);
            this.flowLayoutPanelElementos.Controls.Add(this.buttonElementAnadirElemento);
            this.flowLayoutPanelElementos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelElementos.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanelElementos.Name = "flowLayoutPanelElementos";
            this.flowLayoutPanelElementos.Size = new System.Drawing.Size(923, 302);
            this.flowLayoutPanelElementos.TabIndex = 4;
            this.flowLayoutPanelElementos.Visible = false;
            // 
            // buttonElementAnadirElemento
            // 
            this.buttonElementAnadirElemento.BackColor = System.Drawing.Color.White;
            this.buttonElementAnadirElemento.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonElementAnadirElemento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonElementAnadirElemento.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonElementAnadirElemento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonElementAnadirElemento.Image = ((System.Drawing.Image)(resources.GetObject("buttonElementAnadirElemento.Image")));
            this.buttonElementAnadirElemento.Location = new System.Drawing.Point(3, 99);
            this.buttonElementAnadirElemento.MinimumSize = new System.Drawing.Size(250, 90);
            this.buttonElementAnadirElemento.Name = "buttonElementAnadirElemento";
            this.buttonElementAnadirElemento.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttonElementAnadirElemento.Size = new System.Drawing.Size(250, 90);
            this.buttonElementAnadirElemento.TabIndex = 5;
            this.buttonElementAnadirElemento.Text = "Añadir una elemento";
            this.buttonElementAnadirElemento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonElementAnadirElemento.UseVisualStyleBackColor = false;
            this.buttonElementAnadirElemento.Click += new System.EventHandler(this.buttonElementAnadirElemento_Click);
            // 
            // FormCollect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(923, 329);
            this.Controls.Add(this.flowLayoutPanelElementos);
            this.Controls.Add(this.flowLayoutPanelColecciones);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(558, 166);
            this.Name = "FormCollect";
            this.Text = "Collect";
            this.Load += new System.EventHandler(this.FormCollect_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.flowLayoutPanelColecciones.ResumeLayout(false);
            this.flowLayoutPanelColecciones.PerformLayout();
            this.flowLayoutPanelElementos.ResumeLayout(false);
            this.flowLayoutPanelElementos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coleccionesFavoritasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coleccionesRecientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearColecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBusqueda;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private ButtonElement.ButtonElement buttonElementAnadirColeccion;
        private System.Windows.Forms.LinkLabel linkLabelColecciones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColecciones;
        private ButtonElement.ButtonElement buttonElementAnadirElemento;
        private System.Windows.Forms.LinkLabel linkLabelMisColecciones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelElementos;
    }
}

