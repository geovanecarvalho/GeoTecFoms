namespace GeoTec
{
    partial class frmGeoTec
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.likConfiguração = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // likConfiguração
            // 
            this.likConfiguração.AutoSize = true;
            this.likConfiguração.Location = new System.Drawing.Point(347, 9);
            this.likConfiguração.Name = "likConfiguração";
            this.likConfiguração.Size = new System.Drawing.Size(70, 13);
            this.likConfiguração.TabIndex = 0;
            this.likConfiguração.TabStop = true;
            this.likConfiguração.Text = "Configuração";
            this.likConfiguração.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likConfiguração_LinkClicked);
            // 
            // frmGeoTec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 278);
            this.Controls.Add(this.likConfiguração);
            this.Name = "frmGeoTec";
            this.Text = "GeoTec";
            this.Load += new System.EventHandler(this.frmGeoTec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel likConfiguração;
    }
}

