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
            this.lblInformacionOperador = new System.Windows.Forms.Label();
            this.grpBoxVendedor = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblInformacionOperador
            // 
            this.lblInformacionOperador.AutoSize = true;
            this.lblInformacionOperador.Location = new System.Drawing.Point(12, 9);
            this.lblInformacionOperador.Name = "lblInformacionOperador";
            this.lblInformacionOperador.Size = new System.Drawing.Size(38, 15);
            this.lblInformacionOperador.TabIndex = 1;
            this.lblInformacionOperador.Text = "label1";
            // 
            // grpBoxVendedor
            // 
            this.grpBoxVendedor.Location = new System.Drawing.Point(12, 46);
            this.grpBoxVendedor.Name = "grpBoxVendedor";
            this.grpBoxVendedor.Size = new System.Drawing.Size(713, 421);
            this.grpBoxVendedor.TabIndex = 2;
            this.grpBoxVendedor.TabStop = false;
            this.grpBoxVendedor.Text = "groupBox1";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 479);
            this.Controls.Add(this.grpBoxVendedor);
            this.Controls.Add(this.lblInformacionOperador);
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblInformacionOperador;
        private GroupBox grpBoxVendedor;
    }
}