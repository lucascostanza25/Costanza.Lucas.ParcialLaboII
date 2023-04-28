namespace Costanza.Lucas.PPLabII
{
    partial class FrmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedor));
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscarVuelo = new System.Windows.Forms.Label();
            this.txtCodigoVuelo = new System.Windows.Forms.TextBox();
            this.dgvDatosVuelos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInformacionVendedeor = new System.Windows.Forms.Label();
            this.dgvPasajeros = new System.Windows.Forms.DataGridView();
            this.lblPasajerosVuelo = new System.Windows.Forms.Label();
            this.lblBuscarPasajero = new System.Windows.Forms.Label();
            this.txtDniPasajero = new System.Windows.Forms.TextBox();
            this.lblDetallesVuelo = new System.Windows.Forms.Label();
            this.btnVuelos = new System.Windows.Forms.Button();
            this.panelMenuVuelos = new System.Windows.Forms.Panel();
            this.btnVerVuelos = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.panelMenuEstadisticas = new System.Windows.Forms.Panel();
            this.btnVerEstadisticas = new System.Windows.Forms.Button();
            this.lblInformacionVuelo = new System.Windows.Forms.Label();
            this.btnVenderVuelo = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAvion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).BeginInit();
            this.panelMenuVuelos.SuspendLayout();
            this.panelMenuEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(0, 795);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelMenuEstadisticas);
            this.panelMenu.Controls.Add(this.btnEstadisticas);
            this.panelMenu.Controls.Add(this.panelMenuVuelos);
            this.panelMenu.Controls.Add(this.btnVuelos);
            this.panelMenu.Size = new System.Drawing.Size(207, 852);
            this.panelMenu.Controls.SetChildIndex(this.panelLogo, 0);
            this.panelMenu.Controls.SetChildIndex(this.btnIniciarSesion, 0);
            this.panelMenu.Controls.SetChildIndex(this.btnSalir, 0);
            this.panelMenu.Controls.SetChildIndex(this.btnVuelos, 0);
            this.panelMenu.Controls.SetChildIndex(this.panelMenuVuelos, 0);
            this.panelMenu.Controls.SetChildIndex(this.btnEstadisticas, 0);
            this.panelMenu.Controls.SetChildIndex(this.panelMenuEstadisticas, 0);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Dock = System.Windows.Forms.DockStyle.None;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.Location = new System.Drawing.Point(32, 811);
            this.btnIniciarSesion.Size = new System.Drawing.Size(24, 25);
            this.btnIniciarSesion.Visible = false;
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(1322, 670);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(1311, 692);
            this.txtMail.Size = new System.Drawing.Size(178, 23);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(1311, 765);
            this.txtContrasenia.Size = new System.Drawing.Size(178, 23);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.Location = new System.Drawing.Point(1289, 743);
            // 
            // btnLogearse
            // 
            this.btnLogearse.Location = new System.Drawing.Point(1479, 801);
            this.btnLogearse.Size = new System.Drawing.Size(10, 23);
            // 
            // pbFotoAvion
            // 
            this.pbFotoAvion.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoAvion.Image")));
            this.pbFotoAvion.Size = new System.Drawing.Size(1472, 852);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblBuscarVuelo
            // 
            this.lblBuscarVuelo.AutoSize = true;
            this.lblBuscarVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarVuelo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarVuelo.Location = new System.Drawing.Point(234, 267);
            this.lblBuscarVuelo.Name = "lblBuscarVuelo";
            this.lblBuscarVuelo.Size = new System.Drawing.Size(209, 19);
            this.lblBuscarVuelo.TabIndex = 14;
            this.lblBuscarVuelo.Text = "Introduce el código del vuelo";
            // 
            // txtCodigoVuelo
            // 
            this.txtCodigoVuelo.Location = new System.Drawing.Point(447, 267);
            this.txtCodigoVuelo.Name = "txtCodigoVuelo";
            this.txtCodigoVuelo.Size = new System.Drawing.Size(182, 23);
            this.txtCodigoVuelo.TabIndex = 15;
            // 
            // dgvDatosVuelos
            // 
            this.dgvDatosVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVuelos.Location = new System.Drawing.Point(233, 296);
            this.dgvDatosVuelos.Name = "dgvDatosVuelos";
            this.dgvDatosVuelos.ReadOnly = true;
            this.dgvDatosVuelos.RowTemplate.Height = 25;
            this.dgvDatosVuelos.Size = new System.Drawing.Size(973, 218);
            this.dgvDatosVuelos.TabIndex = 16;
            this.dgvDatosVuelos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVuelos_CellDoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(233, 220);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(405, 44);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "VUELOS DISPONIBLES";
            this.lblTitulo.Visible = false;
            // 
            // lblInformacionVendedeor
            // 
            this.lblInformacionVendedeor.AutoSize = true;
            this.lblInformacionVendedeor.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformacionVendedeor.Location = new System.Drawing.Point(233, 186);
            this.lblInformacionVendedeor.Name = "lblInformacionVendedeor";
            this.lblInformacionVendedeor.Size = new System.Drawing.Size(51, 19);
            this.lblInformacionVendedeor.TabIndex = 18;
            this.lblInformacionVendedeor.Text = "label2";
            this.lblInformacionVendedeor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvPasajeros
            // 
            this.dgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajeros.Location = new System.Drawing.Point(233, 622);
            this.dgvPasajeros.Name = "dgvPasajeros";
            this.dgvPasajeros.ReadOnly = true;
            this.dgvPasajeros.RowTemplate.Height = 25;
            this.dgvPasajeros.Size = new System.Drawing.Size(972, 218);
            this.dgvPasajeros.TabIndex = 19;
            this.dgvPasajeros.Visible = false;
            // 
            // lblPasajerosVuelo
            // 
            this.lblPasajerosVuelo.AutoSize = true;
            this.lblPasajerosVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblPasajerosVuelo.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPasajerosVuelo.Location = new System.Drawing.Point(234, 541);
            this.lblPasajerosVuelo.Name = "lblPasajerosVuelo";
            this.lblPasajerosVuelo.Size = new System.Drawing.Size(224, 44);
            this.lblPasajerosVuelo.TabIndex = 20;
            this.lblPasajerosVuelo.Text = "PASAJEROS";
            this.lblPasajerosVuelo.Visible = false;
            // 
            // lblBuscarPasajero
            // 
            this.lblBuscarPasajero.AutoSize = true;
            this.lblBuscarPasajero.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarPasajero.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarPasajero.Location = new System.Drawing.Point(234, 588);
            this.lblBuscarPasajero.Name = "lblBuscarPasajero";
            this.lblBuscarPasajero.Size = new System.Drawing.Size(210, 19);
            this.lblBuscarPasajero.TabIndex = 21;
            this.lblBuscarPasajero.Text = "Introduce el DNI del pasajero";
            this.lblBuscarPasajero.Visible = false;
            this.lblBuscarPasajero.Click += new System.EventHandler(this.lblBuscarPasajero_Click);
            // 
            // txtDniPasajero
            // 
            this.txtDniPasajero.Location = new System.Drawing.Point(447, 588);
            this.txtDniPasajero.Name = "txtDniPasajero";
            this.txtDniPasajero.Size = new System.Drawing.Size(182, 23);
            this.txtDniPasajero.TabIndex = 22;
            this.txtDniPasajero.Visible = false;
            this.txtDniPasajero.TextChanged += new System.EventHandler(this.txtDniPasajero_TextChanged);
            // 
            // lblDetallesVuelo
            // 
            this.lblDetallesVuelo.AutoSize = true;
            this.lblDetallesVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesVuelo.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDetallesVuelo.Location = new System.Drawing.Point(1255, 202);
            this.lblDetallesVuelo.Name = "lblDetallesVuelo";
            this.lblDetallesVuelo.Size = new System.Drawing.Size(294, 88);
            this.lblDetallesVuelo.TabIndex = 23;
            this.lblDetallesVuelo.Text = "INFORMACIÓN \r\nDEL VUELO";
            this.lblDetallesVuelo.Visible = false;
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
            this.btnVuelos.Size = new System.Drawing.Size(207, 57);
            this.btnVuelos.TabIndex = 15;
            this.btnVuelos.Text = "Vuelos";
            this.btnVuelos.UseVisualStyleBackColor = true;
            this.btnVuelos.Click += new System.EventHandler(this.btnVuelos_Click);
            // 
            // panelMenuVuelos
            // 
            this.panelMenuVuelos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenuVuelos.Controls.Add(this.btnVenderVuelo);
            this.panelMenuVuelos.Controls.Add(this.btnVerVuelos);
            this.panelMenuVuelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuVuelos.Location = new System.Drawing.Point(0, 224);
            this.panelMenuVuelos.Name = "panelMenuVuelos";
            this.panelMenuVuelos.Size = new System.Drawing.Size(207, 116);
            this.panelMenuVuelos.TabIndex = 17;
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
            this.btnVerVuelos.Size = new System.Drawing.Size(207, 57);
            this.btnVerVuelos.TabIndex = 8;
            this.btnVerVuelos.Text = "Ver vuelos";
            this.btnVerVuelos.UseVisualStyleBackColor = true;
            this.btnVerVuelos.Click += new System.EventHandler(this.btnVerVuelos_Click);
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
            this.btnEstadisticas.Size = new System.Drawing.Size(207, 57);
            this.btnEstadisticas.TabIndex = 18;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // panelMenuEstadisticas
            // 
            this.panelMenuEstadisticas.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenuEstadisticas.Controls.Add(this.btnVerEstadisticas);
            this.panelMenuEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuEstadisticas.Location = new System.Drawing.Point(0, 397);
            this.panelMenuEstadisticas.Name = "panelMenuEstadisticas";
            this.panelMenuEstadisticas.Size = new System.Drawing.Size(207, 210);
            this.panelMenuEstadisticas.TabIndex = 19;
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
            this.btnVerEstadisticas.Size = new System.Drawing.Size(207, 57);
            this.btnVerEstadisticas.TabIndex = 6;
            this.btnVerEstadisticas.Text = "Ver";
            this.btnVerEstadisticas.UseVisualStyleBackColor = true;
            // 
            // lblInformacionVuelo
            // 
            this.lblInformacionVuelo.AutoSize = true;
            this.lblInformacionVuelo.Location = new System.Drawing.Point(1255, 323);
            this.lblInformacionVuelo.Name = "lblInformacionVuelo";
            this.lblInformacionVuelo.Size = new System.Drawing.Size(38, 15);
            this.lblInformacionVuelo.TabIndex = 24;
            this.lblInformacionVuelo.Text = "label2";
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
            this.btnVenderVuelo.Size = new System.Drawing.Size(207, 57);
            this.btnVenderVuelo.TabIndex = 17;
            this.btnVenderVuelo.Text = "Vender";
            this.btnVenderVuelo.UseVisualStyleBackColor = true;
            this.btnVenderVuelo.Click += new System.EventHandler(this.btnVenderVuelo_Click);
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 852);
            this.Controls.Add(this.lblInformacionVuelo);
            this.Controls.Add(this.lblDetallesVuelo);
            this.Controls.Add(this.dgvPasajeros);
            this.Controls.Add(this.txtDniPasajero);
            this.Controls.Add(this.lblBuscarPasajero);
            this.Controls.Add(this.lblPasajerosVuelo);
            this.Controls.Add(this.dgvDatosVuelos);
            this.Controls.Add(this.txtCodigoVuelo);
            this.Controls.Add(this.lblBuscarVuelo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblInformacionVendedeor);
            this.Controls.Add(this.label1);
            this.Name = "FrmVendedor";
            this.Text = "FrmVendedor";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panelMenu, 0);
            this.Controls.SetChildIndex(this.btnLogearse, 0);
            this.Controls.SetChildIndex(this.lblMail, 0);
            this.Controls.SetChildIndex(this.txtMail, 0);
            this.Controls.SetChildIndex(this.lblContrasenia, 0);
            this.Controls.SetChildIndex(this.txtContrasenia, 0);
            this.Controls.SetChildIndex(this.pbFotoAvion, 0);
            this.Controls.SetChildIndex(this.lblInformacionVendedeor, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblBuscarVuelo, 0);
            this.Controls.SetChildIndex(this.txtCodigoVuelo, 0);
            this.Controls.SetChildIndex(this.dgvDatosVuelos, 0);
            this.Controls.SetChildIndex(this.lblPasajerosVuelo, 0);
            this.Controls.SetChildIndex(this.lblBuscarPasajero, 0);
            this.Controls.SetChildIndex(this.txtDniPasajero, 0);
            this.Controls.SetChildIndex(this.dgvPasajeros, 0);
            this.Controls.SetChildIndex(this.lblDetallesVuelo, 0);
            this.Controls.SetChildIndex(this.lblInformacionVuelo, 0);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAvion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).EndInit();
            this.panelMenuVuelos.ResumeLayout(false);
            this.panelMenuEstadisticas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label lblBuscarVuelo;
        private TextBox txtCodigoVuelo;
        private DataGridView dgvDatosVuelos;
        private Label lblTitulo;
        private Label lblInformacionVendedeor;
        private DataGridView dgvPasajeros;
        private Label lblPasajerosVuelo;
        private Label lblBuscarPasajero;
        private TextBox txtDniPasajero;
        private Label lblDetallesVuelo;
        private Panel panelMenuEstadisticas;
        private Button btnVerEstadisticas;
        private Button btnEstadisticas;
        private Panel panelMenuVuelos;
        private Button btnVerVuelos;
        private Button btnVuelos;
        private Label lblInformacionVuelo;
        private Button btnVenderVuelo;
    }
}