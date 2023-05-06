namespace Costanza.Lucas.PPLabII
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelMenuEstadisticas = new System.Windows.Forms.Panel();
            this.btnVerEstadisticas = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.panelMenuVuelos = new System.Windows.Forms.Panel();
            this.btnVenderVuelo = new System.Windows.Forms.Button();
            this.btnVerVuelos = new System.Windows.Forms.Button();
            this.btnVuelos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbVerVuelos = new System.Windows.Forms.GroupBox();
            this.gbVenderVuelos = new System.Windows.Forms.GroupBox();
            this.cbSoloIda = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaVuelta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIda = new System.Windows.Forms.DateTimePicker();
            this.pbFotoCliente = new System.Windows.Forms.PictureBox();
            this.btnBuscarVuelos = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.rbInternacional = new System.Windows.Forms.RadioButton();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInformacionCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVenderVuelosDisponibles = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInformacionVuelo = new System.Windows.Forms.Label();
            this.lblDetallesVuelo = new System.Windows.Forms.Label();
            this.dgvPasajeros = new System.Windows.Forms.DataGridView();
            this.txtDniPasajero = new System.Windows.Forms.TextBox();
            this.lblBuscarPasajero = new System.Windows.Forms.Label();
            this.lblPasajerosVuelo = new System.Windows.Forms.Label();
            this.dgvDatosVuelos = new System.Windows.Forms.DataGridView();
            this.txtCodigoVuelo = new System.Windows.Forms.TextBox();
            this.lblBuscarVuelo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInformacionPasajero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInformacionTrabajador = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelMenuEstadisticas.SuspendLayout();
            this.panelMenuVuelos.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbVerVuelos.SuspendLayout();
            this.gbVenderVuelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenderVuelosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.panelMenuEstadisticas);
            this.panelMenu.Controls.Add(this.btnEstadisticas);
            this.panelMenu.Controls.Add(this.panelMenuVuelos);
            this.panelMenu.Controls.Add(this.btnVuelos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 1041);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 984);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 57);
            this.btnCerrarSesion.TabIndex = 21;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelMenuEstadisticas
            // 
            this.panelMenuEstadisticas.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenuEstadisticas.Controls.Add(this.btnVerEstadisticas);
            this.panelMenuEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuEstadisticas.Location = new System.Drawing.Point(0, 397);
            this.panelMenuEstadisticas.Name = "panelMenuEstadisticas";
            this.panelMenuEstadisticas.Size = new System.Drawing.Size(200, 57);
            this.panelMenuEstadisticas.TabIndex = 20;
            // 
            // btnVerEstadisticas
            // 
            this.btnVerEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnVerEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEstadisticas.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerEstadisticas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVerEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.btnVerEstadisticas.Name = "btnVerEstadisticas";
            this.btnVerEstadisticas.Size = new System.Drawing.Size(200, 57);
            this.btnVerEstadisticas.TabIndex = 6;
            this.btnVerEstadisticas.Text = "Ver";
            this.btnVerEstadisticas.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 340);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(200, 57);
            this.btnEstadisticas.TabIndex = 19;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // panelMenuVuelos
            // 
            this.panelMenuVuelos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenuVuelos.Controls.Add(this.btnVenderVuelo);
            this.panelMenuVuelos.Controls.Add(this.btnVerVuelos);
            this.panelMenuVuelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuVuelos.Location = new System.Drawing.Point(0, 224);
            this.panelMenuVuelos.Name = "panelMenuVuelos";
            this.panelMenuVuelos.Size = new System.Drawing.Size(200, 116);
            this.panelMenuVuelos.TabIndex = 18;
            // 
            // btnVenderVuelo
            // 
            this.btnVenderVuelo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenderVuelo.FlatAppearance.BorderSize = 0;
            this.btnVenderVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderVuelo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenderVuelo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVenderVuelo.Location = new System.Drawing.Point(0, 57);
            this.btnVenderVuelo.Name = "btnVenderVuelo";
            this.btnVenderVuelo.Size = new System.Drawing.Size(200, 57);
            this.btnVenderVuelo.TabIndex = 18;
            this.btnVenderVuelo.Text = "Vender";
            this.btnVenderVuelo.UseVisualStyleBackColor = true;
            this.btnVenderVuelo.Click += new System.EventHandler(this.btnVenderVuelo_Click);
            // 
            // btnVerVuelos
            // 
            this.btnVerVuelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerVuelos.FlatAppearance.BorderSize = 0;
            this.btnVerVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVuelos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerVuelos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVerVuelos.Location = new System.Drawing.Point(0, 0);
            this.btnVerVuelos.Name = "btnVerVuelos";
            this.btnVerVuelos.Size = new System.Drawing.Size(200, 57);
            this.btnVerVuelos.TabIndex = 8;
            this.btnVerVuelos.Text = "Ver vuelos";
            this.btnVerVuelos.UseVisualStyleBackColor = true;
            this.btnVerVuelos.Click += new System.EventHandler(this.btnVerVuelos_Click);
            // 
            // btnVuelos
            // 
            this.btnVuelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVuelos.FlatAppearance.BorderSize = 0;
            this.btnVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVuelos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVuelos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVuelos.Location = new System.Drawing.Point(0, 167);
            this.btnVuelos.Name = "btnVuelos";
            this.btnVuelos.Size = new System.Drawing.Size(200, 57);
            this.btnVuelos.TabIndex = 16;
            this.btnVuelos.Text = "Vuelos";
            this.btnVuelos.UseVisualStyleBackColor = true;
            this.btnVuelos.Click += new System.EventHandler(this.btnVuelos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 167);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 167);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // gbVerVuelos
            // 
            this.gbVerVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gbVerVuelos.Controls.Add(this.gbVenderVuelos);
            this.gbVerVuelos.Controls.Add(this.lblInformacionVuelo);
            this.gbVerVuelos.Controls.Add(this.lblDetallesVuelo);
            this.gbVerVuelos.Controls.Add(this.dgvPasajeros);
            this.gbVerVuelos.Controls.Add(this.txtDniPasajero);
            this.gbVerVuelos.Controls.Add(this.lblBuscarPasajero);
            this.gbVerVuelos.Controls.Add(this.lblPasajerosVuelo);
            this.gbVerVuelos.Controls.Add(this.dgvDatosVuelos);
            this.gbVerVuelos.Controls.Add(this.txtCodigoVuelo);
            this.gbVerVuelos.Controls.Add(this.lblBuscarVuelo);
            this.gbVerVuelos.Controls.Add(this.lblTitulo);
            this.gbVerVuelos.Controls.Add(this.lblInformacionPasajero);
            this.gbVerVuelos.Controls.Add(this.label4);
            this.gbVerVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbVerVuelos.Location = new System.Drawing.Point(200, 167);
            this.gbVerVuelos.Name = "gbVerVuelos";
            this.gbVerVuelos.Size = new System.Drawing.Size(1709, 882);
            this.gbVerVuelos.TabIndex = 2;
            this.gbVerVuelos.TabStop = false;
            this.gbVerVuelos.Visible = false;
            // 
            // gbVenderVuelos
            // 
            this.gbVenderVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gbVenderVuelos.Controls.Add(this.cbSoloIda);
            this.gbVenderVuelos.Controls.Add(this.label9);
            this.gbVenderVuelos.Controls.Add(this.label8);
            this.gbVenderVuelos.Controls.Add(this.label7);
            this.gbVenderVuelos.Controls.Add(this.dtpFechaVuelta);
            this.gbVenderVuelos.Controls.Add(this.dtpFechaIda);
            this.gbVenderVuelos.Controls.Add(this.pbFotoCliente);
            this.gbVenderVuelos.Controls.Add(this.btnBuscarVuelos);
            this.gbVenderVuelos.Controls.Add(this.cmbDestino);
            this.gbVenderVuelos.Controls.Add(this.label3);
            this.gbVenderVuelos.Controls.Add(this.cmbOrigen);
            this.gbVenderVuelos.Controls.Add(this.rbInternacional);
            this.gbVenderVuelos.Controls.Add(this.rbNacional);
            this.gbVenderVuelos.Controls.Add(this.label1);
            this.gbVenderVuelos.Controls.Add(this.lblInformacionCliente);
            this.gbVenderVuelos.Controls.Add(this.label2);
            this.gbVenderVuelos.Controls.Add(this.dgvVenderVuelosDisponibles);
            this.gbVenderVuelos.Controls.Add(this.label5);
            this.gbVenderVuelos.Controls.Add(this.label6);
            this.gbVenderVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbVenderVuelos.Location = new System.Drawing.Point(123, 0);
            this.gbVenderVuelos.Name = "gbVenderVuelos";
            this.gbVenderVuelos.Size = new System.Drawing.Size(1709, 882);
            this.gbVenderVuelos.TabIndex = 33;
            this.gbVenderVuelos.TabStop = false;
            this.gbVenderVuelos.Visible = false;
            // 
            // cbSoloIda
            // 
            this.cbSoloIda.AutoSize = true;
            this.cbSoloIda.Location = new System.Drawing.Point(922, 63);
            this.cbSoloIda.Name = "cbSoloIda";
            this.cbSoloIda.Size = new System.Drawing.Size(68, 19);
            this.cbSoloIda.TabIndex = 47;
            this.cbSoloIda.Text = "Solo ida";
            this.cbSoloIda.UseVisualStyleBackColor = true;
            this.cbSoloIda.CheckedChanged += new System.EventHandler(this.cbSoloIda_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(853, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Vuelta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(853, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "Ida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(751, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 38);
            this.label7.TabIndex = 44;
            this.label7.Text = "Seleccione \r\nlas fechas";
            // 
            // dtpFechaVuelta
            // 
            this.dtpFechaVuelta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVuelta.Location = new System.Drawing.Point(853, 137);
            this.dtpFechaVuelta.MinDate = new System.DateTime(2023, 5, 6, 0, 0, 0, 0);
            this.dtpFechaVuelta.Name = "dtpFechaVuelta";
            this.dtpFechaVuelta.Size = new System.Drawing.Size(137, 23);
            this.dtpFechaVuelta.TabIndex = 42;
            // 
            // dtpFechaIda
            // 
            this.dtpFechaIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIda.Location = new System.Drawing.Point(853, 85);
            this.dtpFechaIda.MinDate = new System.DateTime(2023, 5, 6, 0, 0, 0, 0);
            this.dtpFechaIda.Name = "dtpFechaIda";
            this.dtpFechaIda.Size = new System.Drawing.Size(137, 23);
            this.dtpFechaIda.TabIndex = 41;
            // 
            // pbFotoCliente
            // 
            this.pbFotoCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoCliente.Image")));
            this.pbFotoCliente.Location = new System.Drawing.Point(1040, 68);
            this.pbFotoCliente.Name = "pbFotoCliente";
            this.pbFotoCliente.Size = new System.Drawing.Size(263, 253);
            this.pbFotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoCliente.TabIndex = 40;
            this.pbFotoCliente.TabStop = false;
            // 
            // btnBuscarVuelos
            // 
            this.btnBuscarVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVuelos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarVuelos.Location = new System.Drawing.Point(315, 173);
            this.btnBuscarVuelos.Name = "btnBuscarVuelos";
            this.btnBuscarVuelos.Size = new System.Drawing.Size(373, 31);
            this.btnBuscarVuelos.TabIndex = 39;
            this.btnBuscarVuelos.Text = "Buscar vuelos";
            this.btnBuscarVuelos.UseVisualStyleBackColor = true;
            this.btnBuscarVuelos.Click += new System.EventHandler(this.btnBuscarVuelos_Click);
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDestino.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(506, 103);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(196, 27);
            this.cmbDestino.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(528, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Seleccione el destino";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrigen.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(269, 103);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(196, 27);
            this.cmbOrigen.TabIndex = 36;
            // 
            // rbInternacional
            // 
            this.rbInternacional.AutoSize = true;
            this.rbInternacional.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rbInternacional.Location = new System.Drawing.Point(134, 117);
            this.rbInternacional.Name = "rbInternacional";
            this.rbInternacional.Size = new System.Drawing.Size(117, 23);
            this.rbInternacional.TabIndex = 35;
            this.rbInternacional.TabStop = true;
            this.rbInternacional.Text = "Internacional";
            this.rbInternacional.UseVisualStyleBackColor = true;
            this.rbInternacional.Click += new System.EventHandler(this.rbInternacional_Click);
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rbNacional.Location = new System.Drawing.Point(134, 85);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(88, 23);
            this.rbNacional.TabIndex = 34;
            this.rbNacional.TabStop = true;
            this.rbNacional.Text = "Nacional";
            this.rbNacional.UseVisualStyleBackColor = true;
            this.rbNacional.CheckedChanged += new System.EventHandler(this.rbNacional_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tipo de vuelo";
            // 
            // lblInformacionCliente
            // 
            this.lblInformacionCliente.AutoSize = true;
            this.lblInformacionCliente.Location = new System.Drawing.Point(1309, 66);
            this.lblInformacionCliente.Name = "lblInformacionCliente";
            this.lblInformacionCliente.Size = new System.Drawing.Size(38, 15);
            this.lblInformacionCliente.TabIndex = 32;
            this.lblInformacionCliente.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1040, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 44);
            this.label2.TabIndex = 31;
            this.label2.Text = "INFORMACIÓN DEL CLIENTE";
            // 
            // dgvVenderVuelosDisponibles
            // 
            this.dgvVenderVuelosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenderVuelosDisponibles.Location = new System.Drawing.Point(15, 230);
            this.dgvVenderVuelosDisponibles.Name = "dgvVenderVuelosDisponibles";
            this.dgvVenderVuelosDisponibles.ReadOnly = true;
            this.dgvVenderVuelosDisponibles.RowTemplate.Height = 25;
            this.dgvVenderVuelosDisponibles.Size = new System.Drawing.Size(973, 389);
            this.dgvVenderVuelosDisponibles.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(294, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Seleccione el origen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 44);
            this.label6.TabIndex = 26;
            this.label6.Text = "VUELOS DISPONIBLES";
            // 
            // lblInformacionVuelo
            // 
            this.lblInformacionVuelo.AutoSize = true;
            this.lblInformacionVuelo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformacionVuelo.Location = new System.Drawing.Point(1118, 95);
            this.lblInformacionVuelo.Name = "lblInformacionVuelo";
            this.lblInformacionVuelo.Size = new System.Drawing.Size(206, 19);
            this.lblInformacionVuelo.TabIndex = 32;
            this.lblInformacionVuelo.Text = "Seleccione un vuelo primero";
            // 
            // lblDetallesVuelo
            // 
            this.lblDetallesVuelo.AutoSize = true;
            this.lblDetallesVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesVuelo.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDetallesVuelo.Location = new System.Drawing.Point(1118, 19);
            this.lblDetallesVuelo.Name = "lblDetallesVuelo";
            this.lblDetallesVuelo.Size = new System.Drawing.Size(489, 44);
            this.lblDetallesVuelo.TabIndex = 31;
            this.lblDetallesVuelo.Text = "INFORMACIÓN DEL VUELO";
            // 
            // dgvPasajeros
            // 
            this.dgvPasajeros.AllowUserToResizeColumns = false;
            this.dgvPasajeros.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvPasajeros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajeros.Location = new System.Drawing.Point(27, 395);
            this.dgvPasajeros.Name = "dgvPasajeros";
            this.dgvPasajeros.ReadOnly = true;
            this.dgvPasajeros.RowTemplate.Height = 25;
            this.dgvPasajeros.Size = new System.Drawing.Size(973, 430);
            this.dgvPasajeros.TabIndex = 27;
            // 
            // txtDniPasajero
            // 
            this.txtDniPasajero.Location = new System.Drawing.Point(1337, 486);
            this.txtDniPasajero.Name = "txtDniPasajero";
            this.txtDniPasajero.Size = new System.Drawing.Size(129, 23);
            this.txtDniPasajero.TabIndex = 30;
            this.txtDniPasajero.TextChanged += new System.EventHandler(this.txtDniPasajero_TextChanged);
            // 
            // lblBuscarPasajero
            // 
            this.lblBuscarPasajero.AutoSize = true;
            this.lblBuscarPasajero.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarPasajero.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarPasajero.Location = new System.Drawing.Point(1118, 486);
            this.lblBuscarPasajero.Name = "lblBuscarPasajero";
            this.lblBuscarPasajero.Size = new System.Drawing.Size(213, 19);
            this.lblBuscarPasajero.TabIndex = 29;
            this.lblBuscarPasajero.Text = "Introduce el DNI del pasajero:";
            // 
            // lblPasajerosVuelo
            // 
            this.lblPasajerosVuelo.AutoSize = true;
            this.lblPasajerosVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblPasajerosVuelo.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPasajerosVuelo.Location = new System.Drawing.Point(26, 337);
            this.lblPasajerosVuelo.Name = "lblPasajerosVuelo";
            this.lblPasajerosVuelo.Size = new System.Drawing.Size(429, 44);
            this.lblPasajerosVuelo.TabIndex = 28;
            this.lblPasajerosVuelo.Text = "PASAJEROS DEL VUELO";
            // 
            // dgvDatosVuelos
            // 
            this.dgvDatosVuelos.AllowUserToOrderColumns = true;
            this.dgvDatosVuelos.AllowUserToResizeColumns = false;
            this.dgvDatosVuelos.AllowUserToResizeRows = false;
            this.dgvDatosVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVuelos.Location = new System.Drawing.Point(27, 99);
            this.dgvDatosVuelos.Name = "dgvDatosVuelos";
            this.dgvDatosVuelos.ReadOnly = true;
            this.dgvDatosVuelos.RowTemplate.Height = 25;
            this.dgvDatosVuelos.Size = new System.Drawing.Size(973, 218);
            this.dgvDatosVuelos.TabIndex = 25;
            this.dgvDatosVuelos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVuelos_CellDoubleClick);
            // 
            // txtCodigoVuelo
            // 
            this.txtCodigoVuelo.Location = new System.Drawing.Point(241, 63);
            this.txtCodigoVuelo.Name = "txtCodigoVuelo";
            this.txtCodigoVuelo.Size = new System.Drawing.Size(182, 23);
            this.txtCodigoVuelo.TabIndex = 24;
            this.txtCodigoVuelo.TextChanged += new System.EventHandler(this.txtCodigoVuelo_TextChanged);
            // 
            // lblBuscarVuelo
            // 
            this.lblBuscarVuelo.AutoSize = true;
            this.lblBuscarVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarVuelo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarVuelo.Location = new System.Drawing.Point(26, 63);
            this.lblBuscarVuelo.Name = "lblBuscarVuelo";
            this.lblBuscarVuelo.Size = new System.Drawing.Size(209, 19);
            this.lblBuscarVuelo.TabIndex = 23;
            this.lblBuscarVuelo.Text = "Introduce el código del vuelo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(15, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(405, 44);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "VUELOS DISPONIBLES";
            // 
            // lblInformacionPasajero
            // 
            this.lblInformacionPasajero.AutoSize = true;
            this.lblInformacionPasajero.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacionPasajero.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformacionPasajero.Location = new System.Drawing.Point(1119, 528);
            this.lblInformacionPasajero.Name = "lblInformacionPasajero";
            this.lblInformacionPasajero.Size = new System.Drawing.Size(205, 19);
            this.lblInformacionPasajero.TabIndex = 35;
            this.lblInformacionPasajero.Text = "Busque un pasajero primero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1118, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 88);
            this.label4.TabIndex = 34;
            this.label4.Text = "BUSCAR PASAJERO EN TODOS \r\nLOS VUELOS";
            // 
            // lblInformacionTrabajador
            // 
            this.lblInformacionTrabajador.AutoSize = true;
            this.lblInformacionTrabajador.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformacionTrabajador.Location = new System.Drawing.Point(215, 9);
            this.lblInformacionTrabajador.Name = "lblInformacionTrabajador";
            this.lblInformacionTrabajador.Size = new System.Drawing.Size(51, 19);
            this.lblInformacionTrabajador.TabIndex = 33;
            this.lblInformacionTrabajador.Text = "label2";
            this.lblInformacionTrabajador.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1709, 1041);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1903, 1041);
            this.Controls.Add(this.lblInformacionTrabajador);
            this.Controls.Add(this.gbVerVuelos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuEstadisticas.ResumeLayout(false);
            this.panelMenuVuelos.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbVerVuelos.ResumeLayout(false);
            this.gbVerVuelos.PerformLayout();
            this.gbVenderVuelos.ResumeLayout(false);
            this.gbVenderVuelos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenderVuelosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private PictureBox pbLogo;
        private Button btnVuelos;
        private Panel panelMenuVuelos;
        private Button btnVerVuelos;
        private Button btnVenderVuelo;
        private Button btnEstadisticas;
        private Panel panelMenuEstadisticas;
        private Button btnVerEstadisticas;
        private GroupBox gbVerVuelos;
        private Label lblInformacionTrabajador;
        private Button btnCerrarSesion;
        private PictureBox pictureBox1;
        private Label lblInformacionVuelo;
        private Label lblDetallesVuelo;
        private DataGridView dgvPasajeros;
        private TextBox txtDniPasajero;
        private Label lblBuscarPasajero;
        private Label lblPasajerosVuelo;
        private DataGridView dgvDatosVuelos;
        private TextBox txtCodigoVuelo;
        private Label lblBuscarVuelo;
        private Label lblTitulo;
        private GroupBox gbVenderVuelos;
        private Button btnBuscarVuelos;
        private ComboBox cmbDestino;
        private Label label3;
        private ComboBox cmbOrigen;
        private RadioButton rbInternacional;
        private RadioButton rbNacional;
        private Label label1;
        private Label lblInformacionCliente;
        private Label label2;
        private DataGridView dgvVenderVuelosDisponibles;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label lblInformacionPasajero;
        private PictureBox pbFotoCliente;
        private DateTimePicker dtpFechaIda;
        private DateTimePicker dtpFechaVuelta;
        private Label label9;
        private Label label8;
        private Label label7;
        private CheckBox cbSoloIda;
    }
}