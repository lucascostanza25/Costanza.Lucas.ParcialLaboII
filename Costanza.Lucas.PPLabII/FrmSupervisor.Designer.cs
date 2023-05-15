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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor));
            this.btnAgregarPasajero = new System.Windows.Forms.Button();
            this.gbVerVuelos.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVerVuelos
            // 
            this.gbVerVuelos.Controls.Add(this.btnAgregarPasajero);
            this.gbVerVuelos.Controls.SetChildIndex(this.btnAgregarPasajero, 0);
            // 
            // btnVenderVueloLateral
            // 
            this.btnVenderVueloLateral.FlatAppearance.BorderSize = 0;
            // 
            // btnVuelos
            // 
            this.btnVuelos.FlatAppearance.BorderSize = 0;
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
            // Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1903, 1041);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Supervisor";
            this.Text = "FrmSupervisor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Supervisor_FormClosing);
            this.gbVerVuelos.ResumeLayout(false);
            this.gbVerVuelos.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAgregarPasajero;
    }
}