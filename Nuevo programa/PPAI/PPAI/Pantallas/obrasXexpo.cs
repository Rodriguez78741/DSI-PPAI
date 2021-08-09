using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Gestores;

namespace PPAI.Pantallas
{
    public partial class win_detalle_obras_expo : Form
    {
        public List<int> expos {get; set; }
        public win_detalle_obras_expo()
        {
            InitializeComponent();
        }

        private void obrasXexpo_Load(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < expos.Count(); i++)
            {
                int idExpo = expos[i];
                int cant_obrasXexpo = GestorReservaVisita.gest_cant_obrasXexpo(idExpo);
                for (int j = 0; j < cant_obrasXexpo; j++)
                {
                    string expo = GestorReservaVisita.gest_expoXobra(idExpo).Rows[cnt][0].ToString();
                    string obra = GestorReservaVisita.gest_expoXobra(idExpo).Rows[cnt][1].ToString();
                    string artista = GestorReservaVisita.gest_expoXobra(idExpo).Rows[cnt][2].ToString();
                    string descrip = GestorReservaVisita.gest_expoXobra(idExpo).Rows[cnt][3].ToString();
                    string creacion = GestorReservaVisita.gest_expoXobra(idExpo).Rows[cnt][4].ToString();
                    string valuacion = GestorReservaVisita.gest_expoXobra(idExpo).Rows[cnt][5].ToString();
                    dt_grid_expoXobras.Rows.Add(expo, obra, artista, descrip, creacion, valuacion);
                    cnt += 1;
                }
            }
        }

        private void btn_close_obrasXexpo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
