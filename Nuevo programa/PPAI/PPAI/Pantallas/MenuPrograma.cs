using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Pantallas
{
    public partial class MenuPrograma : Form
    {
        public MenuPrograma()
        {
            InitializeComponent();
        }

        private void exposicionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaReservaVisita ventana = new PantallaReservaVisita();
            ventana.ShowDialog();
        }

        private void MenuPrograma_Load(object sender, EventArgs e)
        {

        }
    }
}
