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
            this.btnVuelos = new System.Windows.Forms.Button();
            this.panelMenuVuelos = new System.Windows.Forms.Panel();
            this.btnVenderVuelo = new System.Windows.Forms.Button();
            this.btnVerVuelos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscarVuelo = new System.Windows.Forms.Label();
            this.txtCodigoVuelo = new System.Windows.Forms.TextBox();
            this.dgvDatosVuelos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInformacionVendedeor = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAvion)).BeginInit();
            this.panelMenuVuelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(0, 795);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelMenuVuelos);
            this.panelMenu.Controls.Add(this.btnVuelos);
            this.panelMenu.Size = new System.Drawing.Size(207, 852);
            this.panelMenu.Controls.SetChildIndex(this.panelLogo, 0);
            this.panelMenu.Controls.SetChildIndex(this.btnIniciarSesion, 0);
            this.panelMenu.Controls.SetChildIndex(this.btnSalir, 0);
            this.panelMenu.Controls.SetChildIndex(this.btnVuelos, 0);
            this.panelMenu.Controls.SetChildIndex(this.panelMenuVuelos, 0);
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
            this.lblMail.Location = new System.Drawing.Point(496, 433);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(485, 455);
            this.txtMail.Size = new System.Drawing.Size(178, 23);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(485, 528);
            this.txtContrasenia.Size = new System.Drawing.Size(178, 23);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.Location = new System.Drawing.Point(463, 506);
            // 
            // btnLogearse
            // 
            this.btnLogearse.Location = new System.Drawing.Point(542, 588);
            this.btnLogearse.Size = new System.Drawing.Size(10, 23);
            // 
            // pbFotoAvion
            // 
            this.pbFotoAvion.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoAvion.Image")));
            this.pbFotoAvion.Size = new System.Drawing.Size(995, 852);
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
            this.btnVuelos.TabIndex = 3;
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
            this.panelMenuVuelos.TabIndex = 4;
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
            this.btnVenderVuelo.TabIndex = 5;
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
            this.btnVerVuelos.Size = new System.Drawing.Size(207, 57);
            this.btnVerVuelos.TabIndex = 4;
            this.btnVerVuelos.Text = "Ver vuelos";
            this.btnVerVuelos.UseVisualStyleBackColor = true;
            this.btnVerVuelos.Click += new System.EventHandler(this.btnVerVuelos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(937, 522);
            this.dataGridView1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 23);
            this.textBox1.TabIndex = 13;
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
            this.lblBuscarVuelo.Location = new System.Drawing.Point(219, 247);
            this.lblBuscarVuelo.Name = "lblBuscarVuelo";
            this.lblBuscarVuelo.Size = new System.Drawing.Size(209, 19);
            this.lblBuscarVuelo.TabIndex = 14;
            this.lblBuscarVuelo.Text = "Introduce el código del vuelo";
            // 
            // txtCodigoVuelo
            // 
            this.txtCodigoVuelo.Location = new System.Drawing.Point(434, 243);
            this.txtCodigoVuelo.Name = "txtCodigoVuelo";
            this.txtCodigoVuelo.Size = new System.Drawing.Size(182, 23);
            this.txtCodigoVuelo.TabIndex = 15;
            // 
            // dgvDatosVuelos
            // 
            this.dgvDatosVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVuelos.Location = new System.Drawing.Point(221, 333);
            this.dgvDatosVuelos.Name = "dgvDatosVuelos";
            this.dgvDatosVuelos.RowTemplate.Height = 25;
            this.dgvDatosVuelos.Size = new System.Drawing.Size(965, 338);
            this.dgvDatosVuelos.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Gadugi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(220, 185);
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
            this.lblInformacionVendedeor.Location = new System.Drawing.Point(1135, 185);
            this.lblInformacionVendedeor.Name = "lblInformacionVendedeor";
            this.lblInformacionVendedeor.Size = new System.Drawing.Size(51, 19);
            this.lblInformacionVendedeor.TabIndex = 18;
            this.lblInformacionVendedeor.Text = "label2";
            this.lblInformacionVendedeor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 852);
            this.Controls.Add(this.lblInformacionVendedeor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvDatosVuelos);
            this.Controls.Add(this.txtCodigoVuelo);
            this.Controls.Add(this.lblBuscarVuelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmVendedor";
            this.Text = "FrmVendedor";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panelMenu, 0);
            this.Controls.SetChildIndex(this.btnLogearse, 0);
            this.Controls.SetChildIndex(this.lblMail, 0);
            this.Controls.SetChildIndex(this.txtMail, 0);
            this.Controls.SetChildIndex(this.lblContrasenia, 0);
            this.Controls.SetChildIndex(this.txtContrasenia, 0);
            this.Controls.SetChildIndex(this.pbFotoAvion, 0);
            this.Controls.SetChildIndex(this.lblBuscarVuelo, 0);
            this.Controls.SetChildIndex(this.txtCodigoVuelo, 0);
            this.Controls.SetChildIndex(this.dgvDatosVuelos, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblInformacionVendedeor, 0);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAvion)).EndInit();
            this.panelMenuVuelos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenuVuelos;
        private Button btnVuelos;
        private Button btnVenderVuelo;
        private Button btnVerVuelos;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label lblBuscarVuelo;
        private TextBox txtCodigoVuelo;
        private DataGridView dgvDatosVuelos;
        private Label lblTitulo;
        private Label lblInformacionVendedeor;
    }
}