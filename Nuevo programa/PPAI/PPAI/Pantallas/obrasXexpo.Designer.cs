
namespace PPAI.Pantallas
{
    partial class win_detalle_obras_expo
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
            this.dt_grid_expoXobras = new System.Windows.Forms.DataGridView();
            this.Exposición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close_obrasXexpo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_grid_expoXobras)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_grid_expoXobras
            // 
            this.dt_grid_expoXobras.AllowUserToAddRows = false;
            this.dt_grid_expoXobras.AllowUserToDeleteRows = false;
            this.dt_grid_expoXobras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_grid_expoXobras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exposición,
            this.Obra,
            this.Artista,
            this.Descripción,
            this.Creación,
            this.Valuacion});
            this.dt_grid_expoXobras.Location = new System.Drawing.Point(13, 13);
            this.dt_grid_expoXobras.Name = "dt_grid_expoXobras";
            this.dt_grid_expoXobras.ReadOnly = true;
            this.dt_grid_expoXobras.Size = new System.Drawing.Size(659, 150);
            this.dt_grid_expoXobras.TabIndex = 0;
            // 
            // Exposición
            // 
            this.Exposición.HeaderText = "Exposicion";
            this.Exposición.Name = "Exposición";
            this.Exposición.ReadOnly = true;
            // 
            // Obra
            // 
            this.Obra.HeaderText = "Obra";
            this.Obra.Name = "Obra";
            this.Obra.ReadOnly = true;
            // 
            // Artista
            // 
            this.Artista.HeaderText = "Artista";
            this.Artista.Name = "Artista";
            this.Artista.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripcion";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Creación
            // 
            this.Creación.HeaderText = "Creación";
            this.Creación.Name = "Creación";
            this.Creación.ReadOnly = true;
            // 
            // Valuacion
            // 
            this.Valuacion.HeaderText = "Valuación";
            this.Valuacion.Name = "Valuacion";
            this.Valuacion.ReadOnly = true;
            // 
            // btn_close_obrasXexpo
            // 
            this.btn_close_obrasXexpo.Location = new System.Drawing.Point(596, 173);
            this.btn_close_obrasXexpo.Name = "btn_close_obrasXexpo";
            this.btn_close_obrasXexpo.Size = new System.Drawing.Size(75, 23);
            this.btn_close_obrasXexpo.TabIndex = 1;
            this.btn_close_obrasXexpo.Text = "Cerrar";
            this.btn_close_obrasXexpo.UseVisualStyleBackColor = true;
            this.btn_close_obrasXexpo.Click += new System.EventHandler(this.btn_close_obrasXexpo_Click);
            // 
            // win_detalle_obras_expo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 208);
            this.Controls.Add(this.btn_close_obrasXexpo);
            this.Controls.Add(this.dt_grid_expoXobras);
            this.Name = "win_detalle_obras_expo";
            this.Text = "Detalle Obras de Reserva";
            this.Load += new System.EventHandler(this.obrasXexpo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_grid_expoXobras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_grid_expoXobras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exposición;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valuacion;
        private System.Windows.Forms.Button btn_close_obrasXexpo;
    }
}