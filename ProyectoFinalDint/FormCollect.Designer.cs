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
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.flowLayoutPanelColecciones = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabelColecciones = new System.Windows.Forms.LinkLabel();
            this.labelMisColecciones = new System.Windows.Forms.Label();
            this.buttonAnadirColeccion = new System.Windows.Forms.Button();
            this.linkLabelMisColecciones = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelElementos = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabelElementos = new System.Windows.Forms.LinkLabel();
            this.labelTituloColeccion = new System.Windows.Forms.Label();
            this.buttonAnadirElemento = new System.Windows.Forms.Button();
            this.panelInicioSesion = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxContrasenaUser = new System.Windows.Forms.TextBox();
            this.labelInicioSesion = new System.Windows.Forms.Label();
            this.labelNombreUsusario = new System.Windows.Forms.Label();
            this.textBoxNombreUser = new System.Windows.Forms.TextBox();
            this.buttonInicioSesion = new System.Windows.Forms.Button();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.linkLabelRegistro = new System.Windows.Forms.LinkLabel();
            this.cuteButton1 = new ctlCuteButton.cuteButton();
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
            this.homeToolStripMenuItem,
            this.toolStripTextBoxBusqueda});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(542, 27);
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
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesiónToolStripMenuItem.Image")));
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // toolStripTextBoxBusqueda
            // 
            this.toolStripTextBoxBusqueda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxBusqueda.Margin = new System.Windows.Forms.Padding(1, 0, 60, 0);
            this.toolStripTextBoxBusqueda.MaxLength = 25;
            this.toolStripTextBoxBusqueda.Name = "toolStripTextBoxBusqueda";
            this.toolStripTextBoxBusqueda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripTextBoxBusqueda.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxBusqueda_KeyUp);
            // 
            // flowLayoutPanelColecciones
            // 
            this.flowLayoutPanelColecciones.AutoScroll = true;
            this.flowLayoutPanelColecciones.AutoSize = true;
            this.flowLayoutPanelColecciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelColecciones.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelColecciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanelColecciones.BackgroundImage")));
            this.flowLayoutPanelColecciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanelColecciones.Controls.Add(this.linkLabelColecciones);
            this.flowLayoutPanelColecciones.Controls.Add(this.labelMisColecciones);
            this.flowLayoutPanelColecciones.Controls.Add(this.buttonAnadirColeccion);
            this.flowLayoutPanelColecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelColecciones.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanelColecciones.Name = "flowLayoutPanelColecciones";
            this.flowLayoutPanelColecciones.Size = new System.Drawing.Size(542, 323);
            this.flowLayoutPanelColecciones.TabIndex = 4;
            this.flowLayoutPanelColecciones.Visible = false;
            // 
            // linkLabelColecciones
            // 
            this.linkLabelColecciones.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelColecciones.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelColecciones.Location = new System.Drawing.Point(3, 0);
            this.linkLabelColecciones.Name = "linkLabelColecciones";
            this.linkLabelColecciones.Size = new System.Drawing.Size(187, 62);
            this.linkLabelColecciones.TabIndex = 7;
            this.linkLabelColecciones.TabStop = true;
            this.linkLabelColecciones.Text = "Ver todas las Colecciones";
            this.linkLabelColecciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelColecciones.Visible = false;
            this.linkLabelColecciones.Click += new System.EventHandler(this.linkLabelColecciones_Click);
            // 
            // labelMisColecciones
            // 
            this.labelMisColecciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMisColecciones.AutoSize = true;
            this.labelMisColecciones.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelColecciones.SetFlowBreak(this.labelMisColecciones, true);
            this.labelMisColecciones.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMisColecciones.Location = new System.Drawing.Point(196, 14);
            this.labelMisColecciones.Name = "labelMisColecciones";
            this.labelMisColecciones.Size = new System.Drawing.Size(202, 34);
            this.labelMisColecciones.TabIndex = 8;
            this.labelMisColecciones.Text = "Mis Colecciones";
            this.labelMisColecciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAnadirColeccion
            // 
            this.buttonAnadirColeccion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAnadirColeccion.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnadirColeccion.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnadirColeccion.Image")));
            this.buttonAnadirColeccion.Location = new System.Drawing.Point(70, 72);
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
            this.linkLabelMisColecciones.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelMisColecciones.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelMisColecciones.Location = new System.Drawing.Point(3, 0);
            this.linkLabelMisColecciones.Name = "linkLabelMisColecciones";
            this.linkLabelMisColecciones.Size = new System.Drawing.Size(182, 62);
            this.linkLabelMisColecciones.TabIndex = 6;
            this.linkLabelMisColecciones.TabStop = true;
            this.linkLabelMisColecciones.Text = "Volver a Mis Colecciones";
            this.linkLabelMisColecciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelMisColecciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMisColecciones_LinkClicked);
            // 
            // flowLayoutPanelElementos
            // 
            this.flowLayoutPanelElementos.AutoScroll = true;
            this.flowLayoutPanelElementos.AutoSize = true;
            this.flowLayoutPanelElementos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelElementos.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelElementos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanelElementos.BackgroundImage")));
            this.flowLayoutPanelElementos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanelElementos.Controls.Add(this.linkLabelMisColecciones);
            this.flowLayoutPanelElementos.Controls.Add(this.linkLabelElementos);
            this.flowLayoutPanelElementos.Controls.Add(this.labelTituloColeccion);
            this.flowLayoutPanelElementos.Controls.Add(this.buttonAnadirElemento);
            this.flowLayoutPanelElementos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelElementos.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanelElementos.Name = "flowLayoutPanelElementos";
            this.flowLayoutPanelElementos.Size = new System.Drawing.Size(542, 323);
            this.flowLayoutPanelElementos.TabIndex = 4;
            this.flowLayoutPanelElementos.Visible = false;
            // 
            // linkLabelElementos
            // 
            this.linkLabelElementos.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelElementos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelElementos.Location = new System.Drawing.Point(191, 0);
            this.linkLabelElementos.Name = "linkLabelElementos";
            this.linkLabelElementos.Size = new System.Drawing.Size(182, 62);
            this.linkLabelElementos.TabIndex = 8;
            this.linkLabelElementos.TabStop = true;
            this.linkLabelElementos.Text = "Ver todos los elementos";
            this.linkLabelElementos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelElementos.Visible = false;
            this.linkLabelElementos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelElementos_LinkClicked);
            // 
            // labelTituloColeccion
            // 
            this.labelTituloColeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTituloColeccion.AutoSize = true;
            this.labelTituloColeccion.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelElementos.SetFlowBreak(this.labelTituloColeccion, true);
            this.labelTituloColeccion.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloColeccion.Location = new System.Drawing.Point(379, 14);
            this.labelTituloColeccion.Name = "labelTituloColeccion";
            this.labelTituloColeccion.Size = new System.Drawing.Size(76, 34);
            this.labelTituloColeccion.TabIndex = 7;
            this.labelTituloColeccion.Text = "titulo";
            this.labelTituloColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAnadirElemento
            // 
            this.buttonAnadirElemento.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAnadirElemento.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnadirElemento.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnadirElemento.Image")));
            this.buttonAnadirElemento.Location = new System.Drawing.Point(70, 72);
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
            this.panelInicioSesion.BackColor = System.Drawing.Color.White;
            this.panelInicioSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInicioSesion.BackgroundImage")));
            this.panelInicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInicioSesion.Controls.Add(this.tableLayoutPanel1);
            this.panelInicioSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicioSesion.Location = new System.Drawing.Point(0, 0);
            this.panelInicioSesion.Name = "panelInicioSesion";
            this.panelInicioSesion.Size = new System.Drawing.Size(542, 350);
            this.panelInicioSesion.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxContrasenaUser, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelInicioSesion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNombreUsusario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNombreUser, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonInicioSesion, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelContrasena, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelRegistro, 0, 6);
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
            this.textBoxContrasenaUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUser_KeyDown);
            // 
            // labelInicioSesion
            // 
            this.labelInicioSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInicioSesion.AutoSize = true;
            this.labelInicioSesion.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelNombreUsusario.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.textBoxNombreUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUser_KeyDown);
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
            this.labelContrasena.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasena.Location = new System.Drawing.Point(3, 120);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(274, 24);
            this.labelContrasena.TabIndex = 3;
            this.labelContrasena.Text = "Contraseña";
            this.labelContrasena.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelRegistro
            // 
            this.labelRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.Location = new System.Drawing.Point(3, 224);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(274, 36);
            this.labelRegistro.TabIndex = 6;
            this.labelRegistro.Text = "¿No tienes cuenta aún?";
            this.labelRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // cuteButton1
            // 
            this.cuteButton1.cuteColor1 = System.Drawing.Color.LightGreen;
            this.cuteButton1.cuteColor2 = System.Drawing.Color.DarkBlue;
            this.cuteButton1.cuteTransparent1 = 64;
            this.cuteButton1.cuteTransparent2 = 64;
            this.cuteButton1.Location = new System.Drawing.Point(0, 0);
            this.cuteButton1.Name = "cuteButton1";
            this.cuteButton1.Size = new System.Drawing.Size(75, 23);
            this.cuteButton1.TabIndex = 0;
            this.cuteButton1.Text = "cuteButton1";
            this.cuteButton1.UseVisualStyleBackColor = true;
            // 
            // FormCollect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(542, 350);
            this.Controls.Add(this.flowLayoutPanelElementos);
            this.Controls.Add(this.flowLayoutPanelColecciones);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelInicioSesion);
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
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.LinkLabel linkLabelRegistro;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Label labelTituloColeccion;
        private System.Windows.Forms.Label labelMisColecciones;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private ctlCuteButton.cuteButton cuteButton1;
        private System.Windows.Forms.LinkLabel linkLabelColecciones;
        private System.Windows.Forms.LinkLabel linkLabelElementos;
    }
}

