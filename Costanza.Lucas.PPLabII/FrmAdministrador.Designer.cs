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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelMenuVuelos = new System.Windows.Forms.Panel();
            this.btnAdministrarAviones = new System.Windows.Forms.Button();
            this.btnAdministrarVuelos = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbAdministrarVuelos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearVuelo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblTituloAdministarVuelos = new System.Windows.Forms.Label();
            this.dgvDatosVuelos = new System.Windows.Forms.DataGridView();
            this.lblInformacionVuelo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelMenuVuelos.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbAdministrarVuelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1709, 1045);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.panelMenuVuelos);
            this.panelMenu.Controls.Add(this.btnAdministrar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 1045);
            this.panelMenu.TabIndex = 2;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 988);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 57);
            this.btnCerrarSesion.TabIndex = 21;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // panelMenuVuelos
            // 
            this.panelMenuVuelos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenuVuelos.Controls.Add(this.btnAdministrarAviones);
            this.panelMenuVuelos.Controls.Add(this.btnAdministrarVuelos);
            this.panelMenuVuelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuVuelos.Location = new System.Drawing.Point(0, 224);
            this.panelMenuVuelos.Name = "panelMenuVuelos";
            this.panelMenuVuelos.Size = new System.Drawing.Size(200, 116);
            this.panelMenuVuelos.TabIndex = 18;
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
            this.btnAdministrarAviones.Size = new System.Drawing.Size(200, 57);
            this.btnAdministrarAviones.TabIndex = 18;
            this.btnAdministrarAviones.Text = "Aviones";
            this.btnAdministrarAviones.UseVisualStyleBackColor = true;
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
            this.btnAdministrarVuelos.Size = new System.Drawing.Size(200, 57);
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
            this.btnAdministrar.Location = new System.Drawing.Point(0, 167);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(200, 57);
            this.btnAdministrar.TabIndex = 16;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
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
            // gbAdministrarVuelos
            // 
            this.gbAdministrarVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.gbAdministrarVuelos.Controls.Add(this.lblInformacionVuelo);
            this.gbAdministrarVuelos.Controls.Add(this.label1);
            this.gbAdministrarVuelos.Controls.Add(this.btnCrearVuelo);
            this.gbAdministrarVuelos.Controls.Add(this.btnEliminar);
            this.gbAdministrarVuelos.Controls.Add(this.btnEditar);
            this.gbAdministrarVuelos.Controls.Add(this.lblTituloAdministarVuelos);
            this.gbAdministrarVuelos.Controls.Add(this.dgvDatosVuelos);
            this.gbAdministrarVuelos.Location = new System.Drawing.Point(200, 167);
            this.gbAdministrarVuelos.Name = "gbAdministrarVuelos";
            this.gbAdministrarVuelos.Size = new System.Drawing.Size(1709, 874);
            this.gbAdministrarVuelos.TabIndex = 22;
            this.gbAdministrarVuelos.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1060, 114);
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
            this.btnCrearVuelo.Location = new System.Drawing.Point(1465, 297);
            this.btnCrearVuelo.Name = "btnCrearVuelo";
            this.btnCrearVuelo.Size = new System.Drawing.Size(218, 59);
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
            this.btnEliminar.Location = new System.Drawing.Point(1465, 190);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(218, 38);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Bisque;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(1465, 114);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(218, 70);
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
            this.dgvDatosVuelos.Location = new System.Drawing.Point(23, 114);
            this.dgvDatosVuelos.Name = "dgvDatosVuelos";
            this.dgvDatosVuelos.ReadOnly = true;
            this.dgvDatosVuelos.RowTemplate.Height = 25;
            this.dgvDatosVuelos.Size = new System.Drawing.Size(973, 705);
            this.dgvDatosVuelos.TabIndex = 26;
            this.dgvDatosVuelos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVuelos_CellDoubleClick);
            // 
            // lblInformacionVuelo
            // 
            this.lblInformacionVuelo.AutoSize = true;
            this.lblInformacionVuelo.Location = new System.Drawing.Point(1060, 143);
            this.lblInformacionVuelo.Name = "lblInformacionVuelo";
            this.lblInformacionVuelo.Size = new System.Drawing.Size(38, 15);
            this.lblInformacionVuelo.TabIndex = 33;
            this.lblInformacionVuelo.Text = "label2";
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1907, 1045);
            this.Controls.Add(this.gbAdministrarVuelos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenuVuelos.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbAdministrarVuelos.ResumeLayout(false);
            this.gbAdministrarVuelos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        protected Panel panelMenu;
        private Button btnCerrarSesion;
        private Panel panelMenuVuelos;
        protected Button btnAdministrarAviones;
        private Button btnAdministrarVuelos;
        private Panel panelLogo;
        private PictureBox pbLogo;
        private Button btnAdministrar;
        private GroupBox gbAdministrarVuelos;
        protected DataGridView dgvDatosVuelos;
        private Label label1;
        private Button btnCrearVuelo;
        private Button btnEliminar;
        private Button btnEditar;
        private Label lblTituloAdministarVuelos;
        private Label lblInformacionVuelo;
    }
}