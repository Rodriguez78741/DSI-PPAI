
namespace DSI_3K2_PPAI.Pantallas.GestionarReserva
{
    partial class FrmGestionarReserva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_ID = new DSI_3K2_PPAI.Clases.TextBox001();
            this.Txt_Escuela = new DSI_3K2_PPAI.Clases.TextBox001();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGrid_Reserva = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Reserva)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGrid_Reserva);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Txt_Escuela);
            this.groupBox1.Controls.Add(this.Txt_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Escuela";
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(167, 42);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Pp_MensajeError = null;
            this.Txt_ID.Pp_NombreCampo = null;
            this.Txt_ID.Pp_NombreTabla = null;
            this.Txt_ID.Pp_Validable = false;
            this.Txt_ID.Size = new System.Drawing.Size(100, 23);
            this.Txt_ID.TabIndex = 2;
            // 
            // Txt_Escuela
            // 
            this.Txt_Escuela.Location = new System.Drawing.Point(167, 78);
            this.Txt_Escuela.Name = "Txt_Escuela";
            this.Txt_Escuela.Pp_MensajeError = null;
            this.Txt_Escuela.Pp_NombreCampo = null;
            this.Txt_Escuela.Pp_NombreTabla = null;
            this.Txt_Escuela.Pp_Validable = false;
            this.Txt_Escuela.Size = new System.Drawing.Size(100, 23);
            this.Txt_Escuela.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGrid_Reserva
            // 
            this.dataGrid_Reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Reserva.Location = new System.Drawing.Point(40, 155);
            this.dataGrid_Reserva.Name = "dataGrid_Reserva";
            this.dataGrid_Reserva.Size = new System.Drawing.Size(691, 197);
            this.dataGrid_Reserva.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::DSI_3K2_PPAI.Properties.Resources._18;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(162, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 38);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::DSI_3K2_PPAI.Properties.Resources.editar_imagenes_clipart_2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(101, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 38);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::DSI_3K2_PPAI.Properties.Resources.png_transparent_computer_icons_document_add_button_number_add_button_add;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(40, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 38);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmGestionarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGestionarReserva";
            this.Text = "FrmGestionarReserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Reserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGrid_Reserva;
        private System.Windows.Forms.Button button1;
        private Clases.TextBox001 Txt_Escuela;
        private Clases.TextBox001 Txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}