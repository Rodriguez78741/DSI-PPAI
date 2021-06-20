
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
            this.gbx_reserva = new System.Windows.Forms.GroupBox();
            this.btm_eliminar = new System.Windows.Forms.Button();
            this.btm_modificar = new System.Windows.Forms.Button();
            this.btm_Agregar = new System.Windows.Forms.Button();
            this.dataGrid_Reserva = new System.Windows.Forms.DataGridView();
            this.Id_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Visita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Escuela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_inicio_real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_fin_real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_alumnos_confirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btm_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Escuela = new DSI_3K2_PPAI.Clases.TextBox001();
            this.Txt_ID = new DSI_3K2_PPAI.Clases.TextBox001();
            this.gbx_reserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Reserva)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_reserva
            // 
            this.gbx_reserva.BackgroundImage = global::DSI_3K2_PPAI.Properties.Resources.WhatsApp_Image_2021_06_20_at_17_05_20;
            this.gbx_reserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbx_reserva.Controls.Add(this.btm_eliminar);
            this.gbx_reserva.Controls.Add(this.btm_modificar);
            this.gbx_reserva.Controls.Add(this.btm_Agregar);
            this.gbx_reserva.Controls.Add(this.dataGrid_Reserva);
            this.gbx_reserva.Controls.Add(this.btm_buscar);
            this.gbx_reserva.Controls.Add(this.Txt_Escuela);
            this.gbx_reserva.Controls.Add(this.Txt_ID);
            this.gbx_reserva.Controls.Add(this.label2);
            this.gbx_reserva.Controls.Add(this.label1);
            this.gbx_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbx_reserva.Location = new System.Drawing.Point(1, 0);
            this.gbx_reserva.Name = "gbx_reserva";
            this.gbx_reserva.Size = new System.Drawing.Size(798, 448);
            this.gbx_reserva.TabIndex = 0;
            this.gbx_reserva.TabStop = false;
            this.gbx_reserva.Text = "Filtros";
            // 
            // btm_eliminar
            // 
            this.btm_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btm_eliminar.BackgroundImage = global::DSI_3K2_PPAI.Properties.Resources._18;
            this.btm_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_eliminar.Location = new System.Drawing.Point(162, 401);
            this.btm_eliminar.Name = "btm_eliminar";
            this.btm_eliminar.Size = new System.Drawing.Size(55, 38);
            this.btm_eliminar.TabIndex = 8;
            this.btm_eliminar.UseVisualStyleBackColor = false;
            // 
            // btm_modificar
            // 
            this.btm_modificar.BackColor = System.Drawing.Color.Transparent;
            this.btm_modificar.BackgroundImage = global::DSI_3K2_PPAI.Properties.Resources.editar_imagenes_clipart_2;
            this.btm_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_modificar.Location = new System.Drawing.Point(101, 401);
            this.btm_modificar.Name = "btm_modificar";
            this.btm_modificar.Size = new System.Drawing.Size(55, 38);
            this.btm_modificar.TabIndex = 7;
            this.btm_modificar.UseVisualStyleBackColor = false;
            // 
            // btm_Agregar
            // 
            this.btm_Agregar.BackColor = System.Drawing.Color.Transparent;
            this.btm_Agregar.BackgroundImage = global::DSI_3K2_PPAI.Properties.Resources.png_transparent_computer_icons_document_add_button_number_add_button_add;
            this.btm_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_Agregar.Location = new System.Drawing.Point(40, 401);
            this.btm_Agregar.Name = "btm_Agregar";
            this.btm_Agregar.Size = new System.Drawing.Size(55, 38);
            this.btm_Agregar.TabIndex = 6;
            this.btm_Agregar.UseVisualStyleBackColor = false;
            // 
            // dataGrid_Reserva
            // 
            this.dataGrid_Reserva.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGrid_Reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Reserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Reserva,
            this.Tipo_Visita,
            this.Escuela,
            this.Fecha_creacion,
            this.fecha_reserva,
            this.hora_inicio,
            this.hora_fin,
            this.hora_inicio_real,
            this.hora_fin_real,
            this.cant_alumnos_confirm});
            this.dataGrid_Reserva.Location = new System.Drawing.Point(40, 140);
            this.dataGrid_Reserva.Name = "dataGrid_Reserva";
            this.dataGrid_Reserva.Size = new System.Drawing.Size(691, 255);
            this.dataGrid_Reserva.TabIndex = 5;
            // 
            // Id_Reserva
            // 
            this.Id_Reserva.HeaderText = "ID";
            this.Id_Reserva.Name = "Id_Reserva";
            // 
            // Tipo_Visita
            // 
            this.Tipo_Visita.HeaderText = "Tipo Visita";
            this.Tipo_Visita.Name = "Tipo_Visita";
            // 
            // Escuela
            // 
            this.Escuela.HeaderText = "Escuela";
            this.Escuela.Name = "Escuela";
            // 
            // Fecha_creacion
            // 
            this.Fecha_creacion.HeaderText = "Fecha Creacion";
            this.Fecha_creacion.Name = "Fecha_creacion";
            // 
            // fecha_reserva
            // 
            this.fecha_reserva.HeaderText = "Fecha Reserva";
            this.fecha_reserva.Name = "fecha_reserva";
            // 
            // hora_inicio
            // 
            this.hora_inicio.HeaderText = "Hora Inicio";
            this.hora_inicio.Name = "hora_inicio";
            // 
            // hora_fin
            // 
            this.hora_fin.HeaderText = "Hora Fin";
            this.hora_fin.Name = "hora_fin";
            // 
            // hora_inicio_real
            // 
            this.hora_inicio_real.HeaderText = "Hora Inicio Real";
            this.hora_inicio_real.Name = "hora_inicio_real";
            // 
            // hora_fin_real
            // 
            this.hora_fin_real.HeaderText = "Hora Fin Real";
            this.hora_fin_real.Name = "hora_fin_real";
            // 
            // cant_alumnos_confirm
            // 
            this.cant_alumnos_confirm.HeaderText = "Cant. Alumnos";
            this.cant_alumnos_confirm.Name = "cant_alumnos_confirm";
            // 
            // btm_buscar
            // 
            this.btm_buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btm_buscar.Location = new System.Drawing.Point(656, 98);
            this.btm_buscar.Name = "btm_buscar";
            this.btm_buscar.Size = new System.Drawing.Size(75, 28);
            this.btm_buscar.TabIndex = 4;
            this.btm_buscar.Text = "Buscar";
            this.btm_buscar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Escuela";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Reserva";
            // 
            // Txt_Escuela
            // 
            this.Txt_Escuela.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Txt_Escuela.Location = new System.Drawing.Point(167, 78);
            this.Txt_Escuela.Name = "Txt_Escuela";
            this.Txt_Escuela.Pp_MensajeError = null;
            this.Txt_Escuela.Pp_NombreCampo = null;
            this.Txt_Escuela.Pp_NombreTabla = null;
            this.Txt_Escuela.Pp_Validable = false;
            this.Txt_Escuela.Size = new System.Drawing.Size(100, 23);
            this.Txt_Escuela.TabIndex = 3;
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Txt_ID.Location = new System.Drawing.Point(167, 42);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Pp_MensajeError = null;
            this.Txt_ID.Pp_NombreCampo = null;
            this.Txt_ID.Pp_NombreTabla = null;
            this.Txt_ID.Pp_Validable = false;
            this.Txt_ID.Size = new System.Drawing.Size(100, 23);
            this.Txt_ID.TabIndex = 2;
            // 
            // FrmGestionarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_reserva);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionarReserva";
            this.Text = "FrmGestionarReserva";
            this.gbx_reserva.ResumeLayout(false);
            this.gbx_reserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Reserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_reserva;
        private System.Windows.Forms.DataGridView dataGrid_Reserva;
        private System.Windows.Forms.Button btm_buscar;
        private Clases.TextBox001 Txt_Escuela;
        private Clases.TextBox001 Txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btm_eliminar;
        private System.Windows.Forms.Button btm_modificar;
        private System.Windows.Forms.Button btm_Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Visita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Escuela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_inicio_real;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_fin_real;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_alumnos_confirm;
    }
}