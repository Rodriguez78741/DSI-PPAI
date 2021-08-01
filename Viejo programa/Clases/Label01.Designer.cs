
namespace DSI_3K2_PPAI.Clases
{
    partial class LabelText01
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtDato = new System.Windows.Forms.MaskedTextBox();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDato
            // 
            this.TxtDato.Location = new System.Drawing.Point(133, 3);
            this.TxtDato.Name = "TxtDato";
            this.TxtDato.Size = new System.Drawing.Size(100, 20);
            this.TxtDato.TabIndex = 0;
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.Location = new System.Drawing.Point(7, 3);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(120, 19);
            this.lblEtiqueta.TabIndex = 0;
            this.lblEtiqueta.Text = "label1";
            this.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelText01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.TxtDato);
            this.Name = "LabelText01";
            this.Size = new System.Drawing.Size(242, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TxtDato;
        private System.Windows.Forms.Label lblEtiqueta;
    }
}
