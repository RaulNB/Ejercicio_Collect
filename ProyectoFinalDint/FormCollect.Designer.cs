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
            this.buttonAnadirColeccion = new System.Windows.Forms.Button();
            this.linkLabelMisColecciones = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelElementos = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAnadirElemento = new System.Windows.Forms.Button();
            this.panelInicioSesion = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxContrasenaUser = new System.Windows.Forms.TextBox();
            this.labelInicioSesion = new System.Windows.Forms.Label();
            this.labelNombreUsusario = new System.Windows.Forms.Label();
            this.textBoxNombreUser = new System.Windows.Forms.TextBox();
            this.buttonInicioSesion = new System.Windows.Forms.Button();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelRegistro = new System.Windows.Forms.LinkLabel();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.flowLayoutPanelColecciones.SuspendLayout();
            this.flowLayoutPanelElementos.SuspendLayout();
            this.panelInicioSesion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(821, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.Visible = false;
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
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
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
            this.flowLayoutPanelColecciones.Controls.Add(this.buttonAnadirColeccion);
            this.flowLayoutPanelColecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelColecciones.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelColecciones.Name = "flowLayoutPanelColecciones";
            this.flowLayoutPanelColecciones.Size = new System.Drawing.Size(821, 350);
            this.flowLayoutPanelColecciones.TabIndex = 4;
            this.flowLayoutPanelColecciones.Visible = false;
            // 
            // buttonAnadirColeccion
            // 
            this.buttonAnadirColeccion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAnadirColeccion.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnadirColeccion.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnadirColeccion.Image")));
            this.buttonAnadirColeccion.Location = new System.Drawing.Point(70, 193);
            this.buttonAnadirColeccion.Margin = new System.Windows.Forms.Padding(70, 10, 0, 60);
            this.buttonAnadirColeccion.Name = "buttonAnadirColeccion";
            this.buttonAnadirColeccion.Size = new System.Drawing.Size(292, 113);
            this.buttonAnadirColeccion.TabIndex = 8;
            this.buttonAnadirColeccion.Text = "Nueva Colección";
            this.buttonAnadirColeccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAnadirColeccion.UseVisualStyleBackColor = false;
            this.buttonAnadirColeccion.Click += new System.EventHandler(this.buttonAnadirColeccion_Click);
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
            this.flowLayoutPanelElementos.Controls.Add(this.buttonAnadirElemento);
            this.flowLayoutPanelElementos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelElementos.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelElementos.Name = "flowLayoutPanelElementos";
            this.flowLayoutPanelElementos.Size = new System.Drawing.Size(821, 350);
            this.flowLayoutPanelElementos.TabIndex = 4;
            this.flowLayoutPanelElementos.Visible = false;
            // 
            // buttonAnadirElemento
            // 
            this.buttonAnadirElemento.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAnadirElemento.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnadirElemento.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnadirElemento.Image")));
            this.buttonAnadirElemento.Location = new System.Drawing.Point(70, 193);
            this.buttonAnadirElemento.Margin = new System.Windows.Forms.Padding(70, 10, 0, 60);
            this.buttonAnadirElemento.Name = "buttonAnadirElemento";
            this.buttonAnadirElemento.Size = new System.Drawing.Size(292, 113);
            this.buttonAnadirElemento.TabIndex = 7;
            this.buttonAnadirElemento.Text = "Nuevo Elemento";
            this.buttonAnadirElemento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAnadirElemento.UseVisualStyleBackColor = false;
            this.buttonAnadirElemento.Click += new System.EventHandler(this.buttonAnadirElemento_Click);
            // 
            // panelInicioSesion
            // 
            this.panelInicioSesion.AutoSize = true;
            this.panelInicioSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelInicioSesion.Controls.Add(this.tableLayoutPanel1);
            this.panelInicioSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicioSesion.Location = new System.Drawing.Point(0, 0);
            this.panelInicioSesion.Name = "panelInicioSesion";
            this.panelInicioSesion.Size = new System.Drawing.Size(821, 350);
            this.panelInicioSesion.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxContrasenaUser, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelInicioSesion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNombreUsusario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNombreUser, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonInicioSesion, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelContrasena, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelRegistro, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 325);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxContrasenaUser
            // 
            this.textBoxContrasenaUser.Location = new System.Drawing.Point(3, 147);
            this.textBoxContrasenaUser.MaxLength = 20;
            this.textBoxContrasenaUser.Name = "textBoxContrasenaUser";
            this.textBoxContrasenaUser.Size = new System.Drawing.Size(274, 20);
            this.textBoxContrasenaUser.TabIndex = 4;
            this.textBoxContrasenaUser.UseSystemPasswordChar = true;
            // 
            // labelInicioSesion
            // 
            this.labelInicioSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInicioSesion.AutoSize = true;
            this.labelInicioSesion.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicioSesion.Location = new System.Drawing.Point(3, 0);
            this.labelInicioSesion.Name = "labelInicioSesion";
            this.labelInicioSesion.Size = new System.Drawing.Size(274, 61);
            this.labelInicioSesion.TabIndex = 0;
            this.labelInicioSesion.Text = "Inicio de Sesión";
            this.labelInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombreUsusario
            // 
            this.labelNombreUsusario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombreUsusario.AutoSize = true;
            this.labelNombreUsusario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsusario.Location = new System.Drawing.Point(3, 61);
            this.labelNombreUsusario.Name = "labelNombreUsusario";
            this.labelNombreUsusario.Size = new System.Drawing.Size(274, 30);
            this.labelNombreUsusario.TabIndex = 1;
            this.labelNombreUsusario.Text = "Nombre de Usuario";
            this.labelNombreUsusario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxNombreUser
            // 
            this.textBoxNombreUser.Location = new System.Drawing.Point(3, 94);
            this.textBoxNombreUser.MaxLength = 20;
            this.textBoxNombreUser.Name = "textBoxNombreUser";
            this.textBoxNombreUser.Size = new System.Drawing.Size(274, 20);
            this.textBoxNombreUser.TabIndex = 2;
            // 
            // buttonInicioSesion
            // 
            this.buttonInicioSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonInicioSesion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonInicioSesion.Location = new System.Drawing.Point(101, 185);
            this.buttonInicioSesion.Name = "buttonInicioSesion";
            this.buttonInicioSesion.Size = new System.Drawing.Size(77, 36);
            this.buttonInicioSesion.TabIndex = 5;
            this.buttonInicioSesion.Text = "Iniciar Sesión";
            this.buttonInicioSesion.UseVisualStyleBackColor = false;
            this.buttonInicioSesion.Click += new System.EventHandler(this.buttonInicioSesion_Click);
            // 
            // labelContrasena
            // 
            this.labelContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasena.Location = new System.Drawing.Point(3, 120);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(274, 24);
            this.labelContrasena.TabIndex = 3;
            this.labelContrasena.Text = "Contraseña";
            this.labelContrasena.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿No tienes cuenta aún?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // linkLabelRegistro
            // 
            this.linkLabelRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelRegistro.AutoSize = true;
            this.linkLabelRegistro.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegistro.Location = new System.Drawing.Point(3, 260);
            this.linkLabelRegistro.Name = "linkLabelRegistro";
            this.linkLabelRegistro.Size = new System.Drawing.Size(274, 28);
            this.linkLabelRegistro.TabIndex = 7;
            this.linkLabelRegistro.TabStop = true;
            this.linkLabelRegistro.Text = "Regístrate Aquí";
            this.linkLabelRegistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabelRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistro_LinkClicked);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // FormCollect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(821, 350);
            this.Controls.Add(this.flowLayoutPanelElementos);
            this.Controls.Add(this.flowLayoutPanelColecciones);
            this.Controls.Add(this.panelInicioSesion);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(558, 388);
            this.Name = "FormCollect";
            this.Text = "Collect";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.flowLayoutPanelColecciones.ResumeLayout(false);
            this.flowLayoutPanelColecciones.PerformLayout();
            this.flowLayoutPanelElementos.ResumeLayout(false);
            this.flowLayoutPanelElementos.PerformLayout();
            this.panelInicioSesion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.LinkLabel linkLabelColecciones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColecciones;
        private System.Windows.Forms.LinkLabel linkLabelMisColecciones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelElementos;
        private System.Windows.Forms.Button buttonAnadirElemento;
        private System.Windows.Forms.Button buttonAnadirColeccion;
        private System.Windows.Forms.Panel panelInicioSesion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxContrasenaUser;
        private System.Windows.Forms.Label labelInicioSesion;
        private System.Windows.Forms.Label labelNombreUsusario;
        private System.Windows.Forms.TextBox textBoxNombreUser;
        private System.Windows.Forms.Button buttonInicioSesion;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelRegistro;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}

