using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PPAI.AccesoADatos;

namespace PPAI.Objetos
{
    class DetalleExposicion
    {
        private int id_obra;
        private int id_exposicion;

        public DetalleExposicion(int idobr, int idexpo)
        {
            this.id_exposicion = idexpo;
            this.id_obra = idobr;
        }

        public int IdReserva
        {
            get => id_obra;
            set => id_obra = value;
        }

        public int IdExposicion
        {
            get => id_exposicion;
            set => id_exposicion = value;
        }

        public static DataTable expoXobra(int idExpo)
        {
            return Datos.BuscarExpoXobras(idExpo);
        }

        public static int cant_obrasXexpo(int idExpo)
        {
            return Datos.BuscarCantExpoXobras(idExpo);
        }

        public TimeSpan buscarDuracExObra()
        {
            
            DataTable tabla = Datos.BuscarObrasIdBD(this.id_obra);

            Obra obr = new Obra((int)tabla.Rows[0][0], tabla.Rows[0][1].ToString(), (decimal)tabla.Rows[0][2], (decimal)tabla.Rows[0][3], (decimal)tabla.Rows[0][4], (DateTime)tabla.Rows[0][5], (DateTime)tabla.Rows[0][6], (decimal)tabla.Rows[0][7], tabla.Rows[0][8].ToString(), (int)tabla.Rows[0][9], (TimeSpan)tabla.Rows[0][10], tabla.Rows[0][11].ToString());
            TimeSpan dur = obr.getDuracionExtendida();
            return dur;
        }
    }
}
