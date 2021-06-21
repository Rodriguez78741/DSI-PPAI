using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_3K2_PPAI.Pantallas;

namespace DSI_3K2_PPAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Principal inicio = new Principal();
            inicio.ShowDialog();
            this.Close();


        }
    }
}
