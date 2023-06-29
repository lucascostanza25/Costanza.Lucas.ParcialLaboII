namespace Costanza.Lucas.PPLabII
{
    partial class FrmAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTema = new System.Windows.Forms.Panel();
            this.rbTemaRojo = new System.Windows.Forms.RadioButton();
            this.rbTemaClaro = new System.Windows.Forms.RadioButton();
            this.rbTemaVerde = new System.Windows.Forms.RadioButton();
            this.rbTemaOscuro = new System.Windows.Forms.RadioButton();
            this.btnTema = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panelMenuVuelos = new System.Windows.Forms.Panel();
            this.btnBaseDatos = new System.Windows.Forms.Button();
            this.btnAdministrarAviones = new System.Windows.Forms.Button();
            this.btnAdministrarVuelos = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFotoPerfil = new System.Windows.Forms.PictureBox();
            this.lblInformacionTrabajador = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTimerVuelo = new System.Windows.Forms.Label();
            this.gbAdministrarVuelos = new System.Windows.Forms.GroupBox();
            this.btnCopiaSeguridadVuelos = new System.Windows.Forms.Button();
            this.lblInformacionVuelo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearVuelo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblTituloAdministarVuelos = new System.Windows.Forms.Label();
            this.dgvDatosVuelos = new System.Windows.Forms.DataGridView();
            this.gbAdministrarAviones = new System.Windows.Forms.GroupBox();
            this.lblInformacionAvion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrearAvion = new System.Windows.Forms.Button();
            this.btnEliminarAvion = new System.Windows.Forms.Button();
            this.btnEditarAvion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDatosAviones = new System.Windows.Forms.DataGridView();
            this.gbBaseDatos = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFirebase = new System.Windows.Forms.Button();
            this.btnSql = new System.Windows.Forms.Button();
            this.lblTextoDb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timerVueloAdmin = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelTema.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMenuVuelos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPerfil)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbAdministrarVuelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).BeginInit();
            this.gbAdministrarAviones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAviones)).BeginInit();
            this.gbBaseDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.panelTema);
            this.panelMenu.Controls.Add(this.btnTema);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panelMenuVuelos);
            this.panelMenu.Controls.Add(this.btnAdministrar);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(234, 779);
            this.panelMenu.TabIndex = 2;
            // 
            // panelTema
            // 
            this.panelTema.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelTema.Controls.Add(this.rbTemaRojo);
            this.panelTema.Controls.Add(this.rbTemaClaro);
            this.panelTema.Controls.Add(this.rbTemaVerde);
            this.panelTema.Controls.Add(this.rbTemaOscuro);
            this.panelTema.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTema.Location = new System.Drawing.Point(0, 540);
            this.panelTema.Name = "panelTema";
            this.panelTema.Size = new System.Drawing.Size(234, 99);
            this.panelTema.TabIndex = 40;
            // 
            // rbTemaRojo
            // 
            this.rbTemaRojo.AutoSize = true;
            this.rbTemaRojo.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbTemaRojo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbTemaRojo.Location = new System.Drawing.Point(15, 60);
            this.rbTemaRojo.Name = "rbTemaRojo";
            this.rbTemaRojo.Size = new System.Drawing.Size(58, 23);
            this.rbTemaRojo.TabIndex = 0;
            this.rbTemaRojo.TabStop = true;
            this.rbTemaRojo.Text = "Rojo";
            this.rbTemaRojo.UseVisualStyleBackColor = true;
            this.rbTemaRojo.CheckedChanged += new System.EventHandler(this.rbTemaRojo_CheckedChanged);
            // 
            // rbTemaClaro
            // 
            this.rbTemaClaro.AutoSize = true;
            this.rbTemaClaro.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbTemaClaro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbTemaClaro.Location = new System.Drawing.Point(15, 20);
            this.rbTemaClaro.Name = "rbTemaClaro";
            this.rbTemaClaro.Size = new System.Drawing.Size(62, 23);
            this.rbTemaClaro.TabIndex = 0;
            this.rbTemaClaro.TabStop = true;
            this.rbTemaClaro.Text = "Claro";
            this.rbTemaClaro.UseVisualStyleBackColor = true;
            this.rbTemaClaro.CheckedChanged += new System.EventHandler(this.rbTemaClaro_CheckedChanged);
            // 
            // rbTemaVerde
            // 
            this.rbTemaVerde.AutoSize = true;
            this.rbTemaVerde.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbTemaVerde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbTemaVerde.Location = new System.Drawing.Point(115, 60);
            this.rbTemaVerde.Name = "rbTemaVerde";
            this.rbTemaVerde.Size = new System.Drawing.Size(66, 23);
            this.rbTemaVerde.TabIndex = 0;
            this.rbTemaVerde.TabStop = true;
            this.rbTemaVerde.Text = "Verde";
            this.rbTemaVerde.UseVisualStyleBackColor = true;
            this.rbTemaVerde.CheckedChanged += new System.EventHandler(this.rbTemaVerde_CheckedChanged);
            // 
            // rbTemaOscuro
            // 
            this.rbTemaOscuro.AutoSize = true;
            this.rbTemaOscuro.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbTemaOscuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbTemaOscuro.Location = new System.Drawing.Point(115, 20);
            this.rbTemaOscuro.Name = "rbTemaOscuro";
            this.rbTemaOscuro.Size = new System.Drawing.Size(73, 23);
            this.rbTemaOscuro.TabIndex = 0;
            this.rbTemaOscuro.TabStop = true;
            this.rbTemaOscuro.Text = "Oscuro";
            this.rbTemaOscuro.UseVisualStyleBackColor = true;
            this.rbTemaOscuro.CheckedChanged += new System.EventHandler(this.rbTemaOscuro_CheckedChanged);
            // 
            // btnTema
            // 
            this.btnTema.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTema.FlatAppearance.BorderSize = 0;
            this.btnTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTema.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTema.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTema.Location = new System.Drawing.Point(0, 639);
            this.btnTema.Name = "btnTema";
            this.btnTema.Size = new System.Drawing.Size(234, 57);
            this.btnTema.TabIndex = 39;
            this.btnTema.Text = "Seleccionar tema";
            this.btnTema.UseVisualStyleBackColor = true;
            this.btnTema.Click += new System.EventHandler(this.btnTema_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 696);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 26);
            this.panel2.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(32, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 19);
            this.label16.TabIndex = 34;
            this.label16.Text = "____________________________";
            // 
            // panelMenuVuelos
            // 
            this.panelMenuVuelos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenuVuelos.Controls.Add(this.btnBaseDatos);
            this.panelMenuVuelos.Controls.Add(this.btnAdministrarAviones);
            this.panelMenuVuelos.Controls.Add(this.btnAdministrarVuelos);
            this.panelMenuVuelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuVuelos.Location = new System.Drawing.Point(0, 309);
            this.panelMenuVuelos.Name = "panelMenuVuelos";
            this.panelMenuVuelos.Size = new System.Drawing.Size(234, 171);
            this.panelMenuVuelos.TabIndex = 37;
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaseDatos.FlatAppearance.BorderSize = 0;
            this.btnBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaseDatos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBaseDatos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBaseDatos.Location = new System.Drawing.Point(0, 114);
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(234, 57);
            this.btnBaseDatos.TabIndex = 19;
            this.btnBaseDatos.Text = "Bases de datos";
            this.btnBaseDatos.UseVisualStyleBackColor = true;
            this.btnBaseDatos.Click += new System.EventHandler(this.btnBaseDatos_Click);
            // 
            // btnAdministrarAviones
            // 
            this.btnAdministrarAviones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrarAviones.FlatAppearance.BorderSize = 0;
            this.btnAdministrarAviones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarAviones.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdministrarAviones.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdministrarAviones.Location = new System.Drawing.Point(0, 57);
            this.btnAdministrarAviones.Name = "btnAdministrarAviones";
            this.btnAdministrarAviones.Size = new System.Drawing.Size(234, 57);
            this.btnAdministrarAviones.TabIndex = 18;
            this.btnAdministrarAviones.Text = "Aviones";
            this.btnAdministrarAviones.UseVisualStyleBackColor = true;
            this.btnAdministrarAviones.Click += new System.EventHandler(this.btnAdministrarAviones_Click);
            // 
            // btnAdministrarVuelos
            // 
            this.btnAdministrarVuelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrarVuelos.FlatAppearance.BorderSize = 0;
            this.btnAdministrarVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarVuelos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdministrarVuelos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdministrarVuelos.Location = new System.Drawing.Point(0, 0);
            this.btnAdministrarVuelos.Name = "btnAdministrarVuelos";
            this.btnAdministrarVuelos.Size = new System.Drawing.Size(234, 57);
            this.btnAdministrarVuelos.TabIndex = 8;
            this.btnAdministrarVuelos.Text = "Vuelos";
            this.btnAdministrarVuelos.UseVisualStyleBackColor = true;
            this.btnAdministrarVuelos.Click += new System.EventHandler(this.btnAdministrarVuelos_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrar.FlatAppearance.BorderSize = 0;
            this.btnAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdministrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdministrar.Location = new System.Drawing.Point(0, 252);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(234, 57);
            this.btnAdministrar.TabIndex = 36;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbFotoPerfil);
            this.panel1.Controls.Add(this.lblInformacionTrabajador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 85);
            this.panel1.TabIndex = 35;
            // 
            // pbFotoPerfil
            // 
            this.pbFotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoPerfil.Image")));
            this.pbFotoPerfil.Location = new System.Drawing.Point(12, 15);
            this.pbFotoPerfil.Name = "pbFotoPerfil";
            this.pbFotoPerfil.Size = new System.Drawing.Size(57, 58);
            this.pbFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoPerfil.TabIndex = 35;
            this.pbFotoPerfil.TabStop = false;
            // 
            // lblInformacionTrabajador
            // 
            this.lblInformacionTrabajador.AutoSize = true;
            this.lblInformacionTrabajador.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacionTrabajador.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformacionTrabajador.ForeColor = System.Drawing.SystemColors.Window;
            this.lblInformacionTrabajador.Location = new System.Drawing.Point(75, 15);
            this.lblInformacionTrabajador.Name = "lblInformacionTrabajador";
            this.lblInformacionTrabajador.Size = new System.Drawing.Size(42, 16);
            this.lblInformacionTrabajador.TabIndex = 34;
            this.lblInformacionTrabajador.Text = "label2";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 722);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(234, 57);
            this.btnCerrarSesion.TabIndex = 21;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(234, 167);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(234, 167);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblTimerVuelo
            // 
            this.lblTimerVuelo.AutoSize = true;
            this.lblTimerVuelo.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimerVuelo.Location = new System.Drawing.Point(378, 742);
            this.lblTimerVuelo.Name = "lblTimerVuelo";
            this.lblTimerVuelo.Size = new System.Drawing.Size(293, 21);
            this.lblTimerVuelo.TabIndex = 35;
            this.lblTimerVuelo.Text = "Calculando vuelo mas cercano...";
            // 
            // gbAdministrarVuelos
            // 
            this.gbAdministrarVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gbAdministrarVuelos.Controls.Add(this.btnCopiaSeguridadVuelos);
            this.gbAdministrarVuelos.Controls.Add(this.lblInformacionVuelo);
            this.gbAdministrarVuelos.Controls.Add(this.label1);
            this.gbAdministrarVuelos.Controls.Add(this.btnCrearVuelo);
            this.gbAdministrarVuelos.Controls.Add(this.btnEliminar);
            this.gbAdministrarVuelos.Controls.Add(this.btnEditar);
            this.gbAdministrarVuelos.Controls.Add(this.lblTituloAdministarVuelos);
            this.gbAdministrarVuelos.Controls.Add(this.dgvDatosVuelos);
            this.gbAdministrarVuelos.Location = new System.Drawing.Point(233, 0);
            this.gbAdministrarVuelos.Name = "gbAdministrarVuelos";
            this.gbAdministrarVuelos.Size = new System.Drawing.Size(1437, 723);
            this.gbAdministrarVuelos.TabIndex = 22;
            this.gbAdministrarVuelos.TabStop = false;
            this.gbAdministrarVuelos.Visible = false;
            this.gbAdministrarVuelos.Enter += new System.EventHandler(this.gbAdministrarVuelos_Enter);
            // 
            // btnCopiaSeguridadVuelos
            // 
            this.btnCopiaSeguridadVuelos.BackColor = System.Drawing.Color.Bisque;
            this.btnCopiaSeguridadVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiaSeguridadVuelos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopiaSeguridadVuelos.Location = new System.Drawing.Point(901, 483);
            this.btnCopiaSeguridadVuelos.Name = "btnCopiaSeguridadVuelos";
            this.btnCopiaSeguridadVuelos.Size = new System.Drawing.Size(417, 37);
            this.btnCopiaSeguridadVuelos.TabIndex = 34;
            this.btnCopiaSeguridadVuelos.Text = "Crear copia de seguridad";
            this.btnCopiaSeguridadVuelos.UseVisualStyleBackColor = false;
            this.btnCopiaSeguridadVuelos.Click += new System.EventHandler(this.btnCopiaSeguridadVuelos_Click);
            // 
            // lblInformacionVuelo
            // 
            this.lblInformacionVuelo.AutoSize = true;
            this.lblInformacionVuelo.Location = new System.Drawing.Point(890, 126);
            this.lblInformacionVuelo.Name = "lblInformacionVuelo";
            this.lblInformacionVuelo.Size = new System.Drawing.Size(450, 15);
            this.lblInformacionVuelo.TabIndex = 33;
            this.lblInformacionVuelo.Text = "Seleccione un vuelo clickeando en la primera columna con la fecla de la fila dese" +
    "ada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(890, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Datos del vuelo seleccionado";
            // 
            // btnCrearVuelo
            // 
            this.btnCrearVuelo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCrearVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearVuelo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearVuelo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCrearVuelo.Location = new System.Drawing.Point(1183, 423);
            this.btnCrearVuelo.Name = "btnCrearVuelo";
            this.btnCrearVuelo.Size = new System.Drawing.Size(135, 37);
            this.btnCrearVuelo.TabIndex = 31;
            this.btnCrearVuelo.Text = "CREAR";
            this.btnCrearVuelo.UseVisualStyleBackColor = false;
            this.btnCrearVuelo.Click += new System.EventHandler(this.btnCrearVuelo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(1042, 423);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 37);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Bisque;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(901, 423);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 37);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblTituloAdministarVuelos
            // 
            this.lblTituloAdministarVuelos.AutoSize = true;
            this.lblTituloAdministarVuelos.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloAdministarVuelos.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTituloAdministarVuelos.Location = new System.Drawing.Point(23, 33);
            this.lblTituloAdministarVuelos.Name = "lblTituloAdministarVuelos";
            this.lblTituloAdministarVuelos.Size = new System.Drawing.Size(434, 44);
            this.lblTituloAdministarVuelos.TabIndex = 28;
            this.lblTituloAdministarVuelos.Text = "VUELOS EN EL SISTEMA";
            // 
            // dgvDatosVuelos
            // 
            this.dgvDatosVuelos.AllowUserToOrderColumns = true;
            this.dgvDatosVuelos.AllowUserToResizeColumns = false;
            this.dgvDatosVuelos.AllowUserToResizeRows = false;
            this.dgvDatosVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVuelos.Location = new System.Drawing.Point(33, 97);
            this.dgvDatosVuelos.Name = "dgvDatosVuelos";
            this.dgvDatosVuelos.ReadOnly = true;
            this.dgvDatosVuelos.RowTemplate.Height = 25;
            this.dgvDatosVuelos.Size = new System.Drawing.Size(851, 363);
            this.dgvDatosVuelos.TabIndex = 26;
            this.dgvDatosVuelos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVuelos_CellDoubleClick);
            // 
            // gbAdministrarAviones
            // 
            this.gbAdministrarAviones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gbAdministrarAviones.Controls.Add(this.lblInformacionAvion);
            this.gbAdministrarAviones.Controls.Add(this.label3);
            this.gbAdministrarAviones.Controls.Add(this.btnCrearAvion);
            this.gbAdministrarAviones.Controls.Add(this.btnEliminarAvion);
            this.gbAdministrarAviones.Controls.Add(this.btnEditarAvion);
            this.gbAdministrarAviones.Controls.Add(this.label4);
            this.gbAdministrarAviones.Controls.Add(this.dgvDatosAviones);
            this.gbAdministrarAviones.Location = new System.Drawing.Point(233, 0);
            this.gbAdministrarAviones.Name = "gbAdministrarAviones";
            this.gbAdministrarAviones.Size = new System.Drawing.Size(1437, 723);
            this.gbAdministrarAviones.TabIndex = 34;
            this.gbAdministrarAviones.TabStop = false;
            this.gbAdministrarAviones.Visible = false;
            // 
            // lblInformacionAvion
            // 
            this.lblInformacionAvion.AutoSize = true;
            this.lblInformacionAvion.Location = new System.Drawing.Point(889, 143);
            this.lblInformacionAvion.Name = "lblInformacionAvion";
            this.lblInformacionAvion.Size = new System.Drawing.Size(457, 15);
            this.lblInformacionAvion.TabIndex = 33;
            this.lblInformacionAvion.Text = "Seleccione un avion clickeando en la primera columna con la flecha de la fila des" +
    "eada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(889, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Datos del avion seleccionado";
            // 
            // btnCrearAvion
            // 
            this.btnCrearAvion.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCrearAvion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearAvion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearAvion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCrearAvion.Location = new System.Drawing.Point(905, 440);
            this.btnCrearAvion.Name = "btnCrearAvion";
            this.btnCrearAvion.Size = new System.Drawing.Size(135, 37);
            this.btnCrearAvion.TabIndex = 31;
            this.btnCrearAvion.Text = "CREAR";
            this.btnCrearAvion.UseVisualStyleBackColor = false;
            this.btnCrearAvion.Click += new System.EventHandler(this.btnCrearAvion_Click);
            // 
            // btnEliminarAvion
            // 
            this.btnEliminarAvion.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarAvion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAvion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarAvion.Location = new System.Drawing.Point(1187, 440);
            this.btnEliminarAvion.Name = "btnEliminarAvion";
            this.btnEliminarAvion.Size = new System.Drawing.Size(135, 37);
            this.btnEliminarAvion.TabIndex = 30;
            this.btnEliminarAvion.Text = "ELIMINAR";
            this.btnEliminarAvion.UseVisualStyleBackColor = false;
            this.btnEliminarAvion.Click += new System.EventHandler(this.btnEliminarAvion_Click);
            // 
            // btnEditarAvion
            // 
            this.btnEditarAvion.BackColor = System.Drawing.Color.Bisque;
            this.btnEditarAvion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAvion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarAvion.Location = new System.Drawing.Point(1046, 440);
            this.btnEditarAvion.Name = "btnEditarAvion";
            this.btnEditarAvion.Size = new System.Drawing.Size(135, 37);
            this.btnEditarAvion.TabIndex = 29;
            this.btnEditarAvion.Text = "EDITAR";
            this.btnEditarAvion.UseVisualStyleBackColor = false;
            this.btnEditarAvion.Click += new System.EventHandler(this.btnEditarAvion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(455, 44);
            this.label4.TabIndex = 28;
            this.label4.Text = "AVIONES EN EL SISTEMA";
            // 
            // dgvDatosAviones
            // 
            this.dgvDatosAviones.AllowUserToOrderColumns = true;
            this.dgvDatosAviones.AllowUserToResizeColumns = false;
            this.dgvDatosAviones.AllowUserToResizeRows = false;
            this.dgvDatosAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAviones.Location = new System.Drawing.Point(23, 114);
            this.dgvDatosAviones.Name = "dgvDatosAviones";
            this.dgvDatosAviones.ReadOnly = true;
            this.dgvDatosAviones.RowTemplate.Height = 25;
            this.dgvDatosAviones.Size = new System.Drawing.Size(851, 363);
            this.dgvDatosAviones.TabIndex = 26;
            this.dgvDatosAviones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosAviones_CellDoubleClick);
            // 
            // gbBaseDatos
            // 
            this.gbBaseDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gbBaseDatos.Controls.Add(this.pictureBox3);
            this.gbBaseDatos.Controls.Add(this.pictureBox2);
            this.gbBaseDatos.Controls.Add(this.btnFirebase);
            this.gbBaseDatos.Controls.Add(this.btnSql);
            this.gbBaseDatos.Controls.Add(this.lblTextoDb);
            this.gbBaseDatos.Controls.Add(this.label6);
            this.gbBaseDatos.Location = new System.Drawing.Point(233, 0);
            this.gbBaseDatos.Name = "gbBaseDatos";
            this.gbBaseDatos.Size = new System.Drawing.Size(1437, 723);
            this.gbBaseDatos.TabIndex = 35;
            this.gbBaseDatos.TabStop = false;
            this.gbBaseDatos.Visible = false;
            this.gbBaseDatos.Enter += new System.EventHandler(this.gbBaseDatos_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(340, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // btnFirebase
            // 
            this.btnFirebase.Location = new System.Drawing.Point(420, 171);
            this.btnFirebase.Name = "btnFirebase";
            this.btnFirebase.Size = new System.Drawing.Size(207, 74);
            this.btnFirebase.TabIndex = 31;
            this.btnFirebase.Text = "Google Firebase";
            this.btnFirebase.UseVisualStyleBackColor = true;
            this.btnFirebase.Click += new System.EventHandler(this.btnFirebase_Click);
            // 
            // btnSql
            // 
            this.btnSql.Location = new System.Drawing.Point(103, 171);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(207, 74);
            this.btnSql.TabIndex = 30;
            this.btnSql.Text = "SQL Server";
            this.btnSql.UseVisualStyleBackColor = true;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // lblTextoDb
            // 
            this.lblTextoDb.AutoSize = true;
            this.lblTextoDb.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoDb.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTextoDb.Location = new System.Drawing.Point(23, 99);
            this.lblTextoDb.Name = "lblTextoDb";
            this.lblTextoDb.Size = new System.Drawing.Size(510, 44);
            this.lblTextoDb.TabIndex = 29;
            this.lblTextoDb.Text = "Base de datos seleccionada: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 44);
            this.label6.TabIndex = 28;
            this.label6.Text = "BASE DE DATOS";
            // 
            // timerVueloAdmin
            // 
            this.timerVueloAdmin.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 726);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1664, 779);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTimerVuelo);
            this.Controls.Add(this.gbAdministrarVuelos);
            this.Controls.Add(this.gbBaseDatos);
            this.Controls.Add(this.gbAdministrarAviones);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdministrador_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTema.ResumeLayout(false);
            this.panelTema.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMenuVuelos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPerfil)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbAdministrarVuelos.ResumeLayout(false);
            this.gbAdministrarVuelos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).EndInit();
            this.gbAdministrarAviones.ResumeLayout(false);
            this.gbAdministrarAviones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAviones)).EndInit();
            this.gbBaseDatos.ResumeLayout(false);
            this.gbBaseDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected Panel panelMenu;
        private Button btnCerrarSesion;
        private Panel panelLogo;
        private PictureBox pbLogo;
        private GroupBox gbAdministrarVuelos;
        protected DataGridView dgvDatosVuelos;
        private Label label1;
        private Button btnCrearVuelo;
        private Button btnEliminar;
        private Button btnEditar;
        private Label lblTituloAdministarVuelos;
        private Label lblInformacionVuelo;
        private GroupBox gbAdministrarAviones;
        private Label lblInformacionAvion;
        private Label label3;
        private Button btnCrearAvion;
        private Button btnEliminarAvion;
        private Button btnEditarAvion;
        private Label label4;
        protected DataGridView dgvDatosAviones;
        private Label lblInformacionTrabajador;
        private GroupBox gbBaseDatos;
        private Label lblTextoDb;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btnFirebase;
        private Button btnSql;
        private Label lblTimerVuelo;
        private Panel panelMenuVuelos;
        protected Button btnBaseDatos;
        protected Button btnAdministrarAviones;
        private Button btnAdministrarVuelos;
        private Button btnAdministrar;
        private Panel panel1;
        private PictureBox pbFotoPerfil;
        private Panel panel2;
        protected Label label16;
        private Panel panelTema;
        private RadioButton rbTemaRojo;
        private RadioButton rbTemaClaro;
        private RadioButton rbTemaVerde;
        private RadioButton rbTemaOscuro;
        private Button btnTema;
        private PictureBox pictureBox1;
        public System.Windows.Forms.Timer timerVueloAdmin;
        private Button btnCopiaSeguridadVuelos;
    }
}