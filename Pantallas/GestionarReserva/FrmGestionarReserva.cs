using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI_3K2_PPAI.Pantallas.GestionarReserva
{
    public partial class FrmGestionarReserva : Form
    {
        public FrmGestionarReserva()
        {
            InitializeComponent();
        }

        private void btm_Agregar_Click(object sender, EventArgs e)
        {
            AgregarExposicion reserva = new AgregarExposicion();
            reserva.ShowDialog();
        }

        private void btm_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
