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
    }
}
