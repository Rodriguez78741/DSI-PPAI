
namespace DSI_3K2_PPAI.Pantallas.GestionarReserva
{
    partial class AgregarExposicion
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
            this.label9 = new System.Windows.Forms.Label();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_expo = new DSI_3K2_PPAI.Clases.TextBox001();
            this.txt_nombre = new DSI_3K2_PPAI.Clases.TextBox001();
            this.txt_descripcion = new DSI_3K2_PPAI.Clases.TextBox001();
            this.txt_fecha_inicio = new DSI_3K2_PPAI.Clases.TextBox001();
            this.txt_fecha_fin = new DSI_3K2_PPAI.Clases.TextBox001();
            this.cbm_tipo = new DSI_3K2_PPAI.Clases.ComboBox01();
            this.cbm_guia = new DSI_3K2_PPAI.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(9, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 8;
            // 
            // btm_agregar
            // 
            this.btm_agregar.BackgroundImage = global::DSI_3K2_PPAI.Properties.Resources.tilde;
            this.btm_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_agregar.Location = new System.Drawing.Point(335, 82);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(56, 48);
            this.btm_agregar.TabIndex = 23;
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.btm_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::DSI_3K2_PPAI.Properties.Resources.kisspng_multiplication_sign_computer_icons_button_x_icon_5b15131f4ee6f5_9780013515281078073232;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Location = new System.Drawing.Point(335, 136);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(56, 42);
            this.btn_cancelar.TabIndex = 24;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID Exposicion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fecha Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fecha Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "ID Tipo Exp.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "ID Guia";
            // 
            // txt_expo
            // 
            this.txt_expo.Location = new System.Drawing.Point(118, 39);
            this.txt_expo.Name = "txt_expo";
            this.txt_expo.Pp_MensajeError = null;
            this.txt_expo.Pp_NombreCampo = null;
            this.txt_expo.Pp_NombreTabla = null;
            this.txt_expo.Pp_Validable = false;
            this.txt_expo.Size = new System.Drawing.Size(121, 20);
            this.txt_expo.TabIndex = 32;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(118, 65);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_MensajeError = null;
            this.txt_nombre.Pp_NombreCampo = null;
            this.txt_nombre.Pp_NombreTabla = null;
            this.txt_nombre.Pp_Validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 33;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(118, 89);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_MensajeError = null;
            this.txt_descripcion.Pp_NombreCampo = null;
            this.txt_descripcion.Pp_NombreTabla = null;
            this.txt_descripcion.Pp_Validable = false;
            this.txt_descripcion.Size = new System.Drawing.Size(121, 20);
            this.txt_descripcion.TabIndex = 34;
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio.Location = new System.Drawing.Point(118, 114);
            this.txt_fecha_inicio.Name = "txt_fecha_inicio";
            this.txt_fecha_inicio.Pp_MensajeError = null;
            this.txt_fecha_inicio.Pp_NombreCampo = null;
            this.txt_fecha_inicio.Pp_NombreTabla = null;
            this.txt_fecha_inicio.Pp_Validable = false;
            this.txt_fecha_inicio.Size = new System.Drawing.Size(121, 20);
            this.txt_fecha_inicio.TabIndex = 35;
            // 
            // txt_fecha_fin
            // 
            this.txt_fecha_fin.Location = new System.Drawing.Point(118, 138);
            this.txt_fecha_fin.Name = "txt_fecha_fin";
            this.txt_fecha_fin.Pp_MensajeError = null;
            this.txt_fecha_fin.Pp_NombreCampo = null;
            this.txt_fecha_fin.Pp_NombreTabla = null;
            this.txt_fecha_fin.Pp_Validable = false;
            this.txt_fecha_fin.Size = new System.Drawing.Size(121, 20);
            this.txt_fecha_fin.TabIndex = 36;
            // 
            // cbm_tipo
            // 
            this.cbm_tipo.FormattingEnabled = true;
            this.cbm_tipo.Location = new System.Drawing.Point(118, 164);
            this.cbm_tipo.Name = "cbm_tipo";
            this.cbm_tipo.Pp_Coseleccion = false;
            this.cbm_tipo.Pp_descripcion = "nombre_tipo_expo";
            this.cbm_tipo.Pp_MensajeError = null;
            this.cbm_tipo.Pp_NombreCampo = null;
            this.cbm_tipo.Pp_NombreTabla = "Tipo_exposicion";
            this.cbm_tipo.Pp_Pk = "id_tipo_expo";
            this.cbm_tipo.Pp_tabla = "Tipo_exposicion";
            this.cbm_tipo.Pp_Validable = false;
            this.cbm_tipo.Size = new System.Drawing.Size(121, 21);
            this.cbm_tipo.TabIndex = 37;
            // 
            // cbm_guia
            // 
            this.cbm_guia.FormattingEnabled = true;
            this.cbm_guia.Location = new System.Drawing.Point(118, 191);
            this.cbm_guia.Name = "cbm_guia";
            this.cbm_guia.Pp_Coseleccion = false;
            this.cbm_guia.Pp_descripcion = "nombre";
            this.cbm_guia.Pp_MensajeError = null;
            this.cbm_guia.Pp_NombreCampo = null;
            this.cbm_guia.Pp_NombreTabla = "Empleado";
            this.cbm_guia.Pp_Pk = "id_empleado";
            this.cbm_guia.Pp_tabla = "Empleado";
            this.cbm_guia.Pp_Validable = false;
            this.cbm_guia.Size = new System.Drawing.Size(121, 21);
            this.cbm_guia.TabIndex = 38;
            // 
            // AgregarExposicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 248);
            this.Controls.Add(this.cbm_guia);
            this.Controls.Add(this.cbm_tipo);
            this.Controls.Add(this.txt_fecha_fin);
            this.Controls.Add(this.txt_fecha_inicio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_expo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btm_agregar);
            this.Controls.Add(this.label9);
            this.Name = "AgregarExposicion";
            this.Text = "AgregarReserva";
            this.Load += new System.EventHandler(this.AgregarReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox001 txt_expo;
        private Clases.TextBox001 txt_nombre;
        private Clases.TextBox001 txt_descripcion;
        private Clases.TextBox001 txt_fecha_inicio;
        private Clases.TextBox001 txt_fecha_fin;
        private Clases.ComboBox01 cbm_tipo;
        private Clases.ComboBox01 cbm_guia;
    }
}