namespace Costanza.Lucas.PPLabII
{
    partial class FrmCrearModificarAvion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearModificarAvion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.nudCantidadAsientos = new System.Windows.Forms.NumericUpDown();
            this.cbInternet = new System.Windows.Forms.CheckBox();
            this.cbComida = new System.Windows.Forms.CheckBox();
            this.nudCapacidadBodega = new System.Windows.Forms.NumericUpDown();
            this.txtMarcaModelo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAsientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(23, 153);
            this.txtMatricula.MaxLength = 7;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(180, 23);
            this.txtMatricula.TabIndex = 2;
            // 
            // nudCantidadAsientos
            // 
            this.nudCantidadAsientos.Location = new System.Drawing.Point(217, 154);
            this.nudCantidadAsientos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidadAsientos.Name = "nudCantidadAsientos";
            this.nudCantidadAsientos.Size = new System.Drawing.Size(180, 23);
            this.nudCantidadAsientos.TabIndex = 3;
            // 
            // cbInternet
            // 
            this.cbInternet.AutoSize = true;
            this.cbInternet.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbInternet.Location = new System.Drawing.Point(315, 307);
            this.cbInternet.Name = "cbInternet";
            this.cbInternet.Size = new System.Drawing.Size(82, 23);
            this.cbInternet.TabIndex = 4;
            this.cbInternet.Text = "Internet";
            this.cbInternet.UseVisualStyleBackColor = true;
            this.cbInternet.CheckedChanged += new System.EventHandler(this.cbInternet_CheckedChanged);
            // 
            // cbComida
            // 
            this.cbComida.AutoSize = true;
            this.cbComida.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbComida.Location = new System.Drawing.Point(217, 307);
            this.cbComida.Name = "cbComida";
            this.cbComida.Size = new System.Drawing.Size(82, 23);
            this.cbComida.TabIndex = 5;
            this.cbComida.Text = "Comida";
            this.cbComida.UseVisualStyleBackColor = true;
            this.cbComida.CheckedChanged += new System.EventHandler(this.cbComida_CheckedChanged);
            // 
            // nudCapacidadBodega
            // 
            this.nudCapacidadBodega.Location = new System.Drawing.Point(217, 238);
            this.nudCapacidadBodega.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCapacidadBodega.Name = "nudCapacidadBodega";
            this.nudCapacidadBodega.Size = new System.Drawing.Size(180, 23);
            this.nudCapacidadBodega.TabIndex = 6;
            // 
            // txtMarcaModelo
            // 
            this.txtMarcaModelo.Location = new System.Drawing.Point(23, 238);
            this.txtMarcaModelo.Name = "txtMarcaModelo";
            this.txtMarcaModelo.Size = new System.Drawing.Size(180, 23);
            this.txtMarcaModelo.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Bisque;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(23, 307);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(180, 46);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(23, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 29);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(217, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad asientos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marca y modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(217, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Capacidad bodega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(218, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Servicios";
            // 
            // FrmCrearModificarAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 429);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtMarcaModelo);
            this.Controls.Add(this.nudCapacidadBodega);
            this.Controls.Add(this.cbComida);
            this.Controls.Add(this.cbInternet);
            this.Controls.Add(this.nudCantidadAsientos);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCrearModificarAvion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearModificarAvion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAsientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidadBodega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtMatricula;
        private NumericUpDown nudCantidadAsientos;
        private CheckBox cbInternet;
        private CheckBox cbComida;
        private NumericUpDown nudCapacidadBodega;
        private TextBox txtMarcaModelo;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}