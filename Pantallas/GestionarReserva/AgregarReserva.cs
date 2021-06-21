using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_3K2_PPAI.Negocio;
using DSI_3K2_PPAI.Clases;

namespace DSI_3K2_PPAI.Pantallas.GestionarReserva
{
    public partial class AgregarReserva : Form
    {


        public AgregarReserva()
        {
            InitializeComponent();
        }

        private void AgregarReserva_Load(object sender, EventArgs e)
        {
            comboBox011.CargarCombo();
            comboBox012.CargarCombo();
            comboBox013.CargarCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamientos = new TratamientosEspeciales();

            if (Tratamientos.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Reserva reserva = new NE_Reserva();
                //reserva.Insertar_Reserva(this.Controls);

                reserva.Pp_id_tipo_visita = comboBox011.SelectedValue.ToString();
                reserva.Pp_id_escuela = comboBox012.SelectedValue.ToString();
                reserva.Pp_id_guia = comboBox013.SelectedValue.ToString();
                reserva.Pp_fecha_reserva = textBox0011.Text;
                reserva.Pp_hora_inicio = textBox0012.Text;
                reserva.Pp_hora_fin= textBox0013.Text;
                reserva.Pp_hora_incio_real = textBox0014.Text;
                reserva.Pp_hora_fin_real = textBox0015.Text;
                reserva.Pp_cant_alumnos_confirm = textBox0016.Text;

                reserva.Insertar_Reserva();

                this.Close();

            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
