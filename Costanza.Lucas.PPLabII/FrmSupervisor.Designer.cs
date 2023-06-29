namespace Costanza.Lucas.PPLabII
{
    partial class Supervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor));
            this.btnAgregarPasajero = new System.Windows.Forms.Button();
            this.pbGuardarPdf = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.timerVueloSup = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.gbVerVuelos.SuspendLayout();
            this.gbEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVuelos
            // 
            this.btnVuelos.FlatAppearance.BorderSize = 0;
            // 
            // gbVerVuelos
            // 
            this.gbVerVuelos.Controls.Add(this.btnAgregarPasajero);
            this.gbVerVuelos.Controls.SetChildIndex(this.btnAgregarPasajero, 0);
            // 
            // gbEstadisticas
            // 
            this.gbEstadisticas.Controls.Add(this.label14);
            this.gbEstadisticas.Controls.Add(this.pbGuardarPdf);
            this.gbEstadisticas.Controls.SetChildIndex(this.pbGuardarPdf, 0);
            this.gbEstadisticas.Controls.SetChildIndex(this.label14, 0);
            // 
            // btnVenderVueloLateral
            // 
            this.btnVenderVueloLateral.FlatAppearance.BorderSize = 0;
            // 
            // btnAgregarPasajero
            // 
            this.btnAgregarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPasajero.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPasajero.Location = new System.Drawing.Point(1509, 554);
            this.btnAgregarPasajero.Name = "btnAgregarPasajero";
            this.btnAgregarPasajero.Size = new System.Drawing.Size(163, 31);
            this.btnAgregarPasajero.TabIndex = 69;
            this.btnAgregarPasajero.Text = "Agregar pasajero";
            this.btnAgregarPasajero.UseVisualStyleBackColor = true;
            this.btnAgregarPasajero.Click += new System.EventHandler(this.btnAgregarPasajero_Click);
            // 
            // pbGuardarPdf
            // 
            this.pbGuardarPdf.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardarPdf.Image")));
            this.pbGuardarPdf.Location = new System.Drawing.Point(1293, 588);
            this.pbGuardarPdf.Name = "pbGuardarPdf";
            this.pbGuardarPdf.Size = new System.Drawing.Size(103, 108);
            this.pbGuardarPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardarPdf.TabIndex = 37;
            this.pbGuardarPdf.TabStop = false;
            this.pbGuardarPdf.Click += new System.EventHandler(this.pbGuardarPdf_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(1311, 560);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 38;
            this.label14.Text = "Guardar";
            // 
            // Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 779);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Supervisor";
            this.Text = "Supervisor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Supervisor_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.gbVerVuelos.ResumeLayout(false);
            this.gbVerVuelos.PerformLayout();
            this.gbEstadisticas.ResumeLayout(false);
            this.gbEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarPdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregarPasajero;
        private Label label14;
        private PictureBox pbGuardarPdf;
        private System.Windows.Forms.Timer timerVueloSup;
    }
}