using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_3K2_PPAI.Pantallas.GestionarReserva;

namespace DSI_3K2_PPAI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void gestionarObraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionarReserva GestionReservas = new FrmGestionarReserva();
            GestionReservas.ShowDialog();
        }
    }
}
