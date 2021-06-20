using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_3K2_PPAI.Clases;
using DSI_3K2_PPAI.Negocio;

namespace DSI_3K2_PPAI.Pantallas.GestionarReserva
{
    public partial class AgregarReserva : Form
    {
        public AgregarReserva()
        {
            InitializeComponent();
        }

        private void btm_agregar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamientos = new TratamientosEspeciales();

            if (Tratamientos.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Reserva reserva = new NE_Reserva();
                reserva.Insertar_Reserva(this.Controls);
                this.Close();

            }
            else
            {
                return;
            }

        }

        private void AgregarReserva_Load(object sender, EventArgs e)
        {
            cmb_escuela.CargarCombo();
            cmb_guia.CargarCombo();
            cmb_visita.CargarCombo();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
