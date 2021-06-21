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
    public partial class AgregarExposicion : Form
    {
        public AgregarExposicion()
        {
            InitializeComponent();
        }

        private void btm_agregar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamientos = new TratamientosEspeciales();

            if (Tratamientos.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Exposicion exposicion = new NE_Exposicion();
                exposicion.Insertar_Reserva(this.Controls);

                //string sqlExpoxReserva= "INSERT INTO Expo_X_Reserva (id_reserva, id_exposicion)" +
                //    "VALUES ("
                //    +



                this.Close();

            }
            else
            {
                return;
            }

        }

        private void AgregarReserva_Load(object sender, EventArgs e)
        {
            cbm_guia.CargarCombo();
            cbm_tipo.CargarCombo();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
