
namespace DSI_3K2_PPAI.Pantallas.GestionarReserva
{
    partial class AgregarReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox0011 = new DSI_3K2_PPAI.Clases.TextBox001();
            this.cmb_visita = new DSI_3K2_PPAI.Clases.ComboBox01();
            this.cmb_escuela = new DSI_3K2_PPAI.Clases.ComboBox01();
            this.cmb_guia = new DSI_3K2_PPAI.Clases.ComboBox01();
            this.labelText011 = new DSI_3K2_PPAI.Clases.LabelText01();
            this.labelText012 = new DSI_3K2_PPAI.Clases.LabelText01();
            this.labelText013 = new DSI_3K2_PPAI.Clases.LabelText01();
            this.labelText014 = new DSI_3K2_PPAI.Clases.LabelText01();
            this.labelText015 = new DSI_3K2_PPAI.Clases.LabelText01();
            this.labelText016 = new DSI_3K2_PPAI.Clases.LabelText01();
            this.labelText017 = new DSI_3K2_PPAI.Clases.LabelText01();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(60, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Visita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(57, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Escuela";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(74, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Guia";
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
            // textBox0011
            // 
            this.textBox0011.Location = new System.Drawing.Point(137, 32);
            this.textBox0011.Name = "textBox0011";
            this.textBox0011.Pp_MensajeError = null;
            this.textBox0011.Pp_NombreCampo = null;
            this.textBox0011.Pp_NombreTabla = null;
            this.textBox0011.Pp_Validable = false;
            this.textBox0011.Size = new System.Drawing.Size(100, 20);
            this.textBox0011.TabIndex = 11;
            // 
            // cmb_visita
            // 
            this.cmb_visita.FormattingEnabled = true;
            this.cmb_visita.Location = new System.Drawing.Point(137, 62);
            this.cmb_visita.Name = "cmb_visita";
            this.cmb_visita.Pp_Coseleccion = false;
            this.cmb_visita.Pp_descripcion = "descripcion";
            this.cmb_visita.Pp_MensajeError = null;
            this.cmb_visita.Pp_NombreCampo = "Tipo_visita";
            this.cmb_visita.Pp_NombreTabla = null;
            this.cmb_visita.Pp_Pk = "id_tipo_visita";
            this.cmb_visita.Pp_tabla = "Tipo_visita";
            this.cmb_visita.Pp_Validable = false;
            this.cmb_visita.Size = new System.Drawing.Size(121, 21);
            this.cmb_visita.TabIndex = 12;
            // 
            // cmb_escuela
            // 
            this.cmb_escuela.FormattingEnabled = true;
            this.cmb_escuela.Location = new System.Drawing.Point(137, 92);
            this.cmb_escuela.Name = "cmb_escuela";
            this.cmb_escuela.Pp_Coseleccion = false;
            this.cmb_escuela.Pp_descripcion = "nombre";
            this.cmb_escuela.Pp_MensajeError = null;
            this.cmb_escuela.Pp_NombreCampo = "Escuela";
            this.cmb_escuela.Pp_NombreTabla = null;
            this.cmb_escuela.Pp_Pk = "id_escuela";
            this.cmb_escuela.Pp_tabla = "Escuela";
            this.cmb_escuela.Pp_Validable = false;
            this.cmb_escuela.Size = new System.Drawing.Size(121, 21);
            this.cmb_escuela.TabIndex = 13;
            // 
            // cmb_guia
            // 
            this.cmb_guia.FormattingEnabled = true;
            this.cmb_guia.Location = new System.Drawing.Point(137, 122);
            this.cmb_guia.Name = "cmb_guia";
            this.cmb_guia.Pp_Coseleccion = false;
            this.cmb_guia.Pp_descripcion = "nombre";
            this.cmb_guia.Pp_MensajeError = null;
            this.cmb_guia.Pp_NombreCampo = "Empleado";
            this.cmb_guia.Pp_NombreTabla = "";
            this.cmb_guia.Pp_Pk = "id_empleado";
            this.cmb_guia.Pp_tabla = "Empleado";
            this.cmb_guia.Pp_Validable = false;
            this.cmb_guia.Size = new System.Drawing.Size(121, 21);
            this.cmb_guia.TabIndex = 14;
            // 
            // labelText011
            // 
            this.labelText011.AutoSize = true;
            this.labelText011.Location = new System.Drawing.Point(1, 149);
            this.labelText011.Name = "labelText011";
            this.labelText011.Pp_ancho = 10;
            this.labelText011.Pp_decimales = 2;
            this.labelText011.Pp_Etiqueta = "Fecha Creacion";
            this.labelText011.Pp_mensajeError = null;
            this.labelText011.Pp_nombre_campo = null;
            this.labelText011.Pp_nombre_tabla = null;
            this.labelText011.Pp_ReadOnly = false;
            this.labelText011.Pp_Text = "  /  /";
            this.labelText011.Pp_tipoDato = DSI_3K2_PPAI.Clases.LabelText01.TipoDato.fecha;
            this.labelText011.Pp_validable = false;
            this.labelText011.Size = new System.Drawing.Size(236, 26);
            this.labelText011.TabIndex = 16;
            // 
            // labelText012
            // 
            this.labelText012.AutoSize = true;
            this.labelText012.Location = new System.Drawing.Point(-1, 181);
            this.labelText012.Name = "labelText012";
            this.labelText012.Pp_ancho = 10;
            this.labelText012.Pp_decimales = 2;
            this.labelText012.Pp_Etiqueta = "Fecha Reserva";
            this.labelText012.Pp_mensajeError = null;
            this.labelText012.Pp_nombre_campo = null;
            this.labelText012.Pp_nombre_tabla = null;
            this.labelText012.Pp_ReadOnly = false;
            this.labelText012.Pp_Text = "  /  /";
            this.labelText012.Pp_tipoDato = DSI_3K2_PPAI.Clases.LabelText01.TipoDato.fecha;
            this.labelText012.Pp_validable = false;
            this.labelText012.Size = new System.Drawing.Size(236, 26);
            this.labelText012.TabIndex = 17;
            // 
            // labelText013
            // 
            this.labelText013.AutoSize = true;
            this.labelText013.Location = new System.Drawing.Point(-1, 210);
            this.labelText013.Name = "labelText013";
            this.labelText013.Pp_ancho = 10;
            this.labelText013.Pp_decimales = 2;
            this.labelText013.Pp_Etiqueta = "Hora Inicio";
            this.labelText013.Pp_mensajeError = null;
            this.labelText013.Pp_nombre_campo = null;
            this.labelText013.Pp_nombre_tabla = null;
            this.labelText013.Pp_ReadOnly = false;
            this.labelText013.Pp_Text = "  :";
            this.labelText013.Pp_tipoDato = DSI_3K2_PPAI.Clases.LabelText01.TipoDato.hora;
            this.labelText013.Pp_validable = false;
            this.labelText013.Size = new System.Drawing.Size(236, 26);
            this.labelText013.TabIndex = 18;
            // 
            // labelText014
            // 
            this.labelText014.AutoSize = true;
            this.labelText014.Location = new System.Drawing.Point(-1, 242);
            this.labelText014.Name = "labelText014";
            this.labelText014.Pp_ancho = 10;
            this.labelText014.Pp_decimales = 2;
            this.labelText014.Pp_Etiqueta = "Hora Fin";
            this.labelText014.Pp_mensajeError = null;
            this.labelText014.Pp_nombre_campo = null;
            this.labelText014.Pp_nombre_tabla = null;
            this.labelText014.Pp_ReadOnly = false;
            this.labelText014.Pp_Text = "  :";
            this.labelText014.Pp_tipoDato = DSI_3K2_PPAI.Clases.LabelText01.TipoDato.hora;
            this.labelText014.Pp_validable = false;
            this.labelText014.Size = new System.Drawing.Size(236, 26);
            this.labelText014.TabIndex = 19;
            // 
            // labelText015
            // 
            this.labelText015.AutoSize = true;
            this.labelText015.Location = new System.Drawing.Point(-1, 274);
            this.labelText015.Name = "labelText015";
            this.labelText015.Pp_ancho = 10;
            this.labelText015.Pp_decimales = 2;
            this.labelText015.Pp_Etiqueta = "Hora Inicio Real";
            this.labelText015.Pp_mensajeError = null;
            this.labelText015.Pp_nombre_campo = null;
            this.labelText015.Pp_nombre_tabla = null;
            this.labelText015.Pp_ReadOnly = false;
            this.labelText015.Pp_Text = "  :";
            this.labelText015.Pp_tipoDato = DSI_3K2_PPAI.Clases.LabelText01.TipoDato.hora;
            this.labelText015.Pp_validable = false;
            this.labelText015.Size = new System.Drawing.Size(236, 26);
            this.labelText015.TabIndex = 20;
            // 
            // labelText016
            // 
            this.labelText016.AutoSize = true;
            this.labelText016.Location = new System.Drawing.Point(-1, 306);
            this.labelText016.Name = "labelText016";
            this.labelText016.Pp_ancho = 10;
            this.labelText016.Pp_decimales = 2;
            this.labelText016.Pp_Etiqueta = "Hora Inicio Fin";
            this.labelText016.Pp_mensajeError = null;
            this.labelText016.Pp_nombre_campo = null;
            this.labelText016.Pp_nombre_tabla = null;
            this.labelText016.Pp_ReadOnly = false;
            this.labelText016.Pp_Text = "  :";
            this.labelText016.Pp_tipoDato = DSI_3K2_PPAI.Clases.LabelText01.TipoDato.hora;
            this.labelText016.Pp_validable = false;
            this.labelText016.Size = new System.Drawing.Size(236, 26);
            this.labelText016.TabIndex = 21;
            // 
            // labelText017
            // 
            this.labelText017.AutoSize = true;
            this.labelText017.Location = new System.Drawing.Point(-1, 338);
            this.labelText017.Name = "labelText017";
            this.labelText017.Pp_ancho = 10;
            this.labelText017.Pp_decimales = 2;
            this.labelText017.Pp_Etiqueta = "Cantidad Alumno";
            this.labelText017.Pp_mensajeError = null;
            this.labelText017.Pp_nombre_campo = null;
            this.labelText017.Pp_nombre_tabla = null;
            this.labelText017.Pp_ReadOnly = false;
            this.labelText017.Pp_Text = "       ,";
            this.labelText017.Pp_tipoDato = DSI_3K2_PPAI.Clases.LabelText01.TipoDato.numero;
            this.labelText017.Pp_validable = false;
            this.labelText017.Size = new System.Drawing.Size(236, 26);
            this.labelText017.TabIndex = 22;
            // 
            // btm_agregar
            // 
            this.btm_agregar.BackgroundImage = global::DSI_3K2_PPAI.Properties.Resources.tilde;
            this.btm_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_agregar.Location = new System.Drawing.Point(335, 127);
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
            this.btn_cancelar.Location = new System.Drawing.Point(335, 181);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(56, 42);
            this.btn_cancelar.TabIndex = 24;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // AgregarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 384);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btm_agregar);
            this.Controls.Add(this.labelText017);
            this.Controls.Add(this.labelText016);
            this.Controls.Add(this.labelText015);
            this.Controls.Add(this.labelText014);
            this.Controls.Add(this.labelText013);
            this.Controls.Add(this.labelText012);
            this.Controls.Add(this.labelText011);
            this.Controls.Add(this.cmb_guia);
            this.Controls.Add(this.cmb_escuela);
            this.Controls.Add(this.cmb_visita);
            this.Controls.Add(this.textBox0011);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarReserva";
            this.Text = "AgregarReserva";
            this.Load += new System.EventHandler(this.AgregarReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private Clases.TextBox001 textBox0011;
        private Clases.ComboBox01 cmb_visita;
        private Clases.ComboBox01 cmb_escuela;
        private Clases.ComboBox01 cmb_guia;
        private Clases.LabelText01 labelText011;
        private Clases.LabelText01 labelText012;
        private Clases.LabelText01 labelText013;
        private Clases.LabelText01 labelText014;
        private Clases.LabelText01 labelText015;
        private Clases.LabelText01 labelText016;
        private Clases.LabelText01 labelText017;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}