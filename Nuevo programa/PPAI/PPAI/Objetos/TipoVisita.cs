using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PPAI.AccesoADatos;
using PPAI.Objetos;

namespace PPAI.Objetos
{
    class TipoVisita
    {
        private int id_tipo_visita;
        private string descripcion;

        public TipoVisita(int id, string descripcion)
        {
            this.id_tipo_visita = id;
            this.descripcion = descripcion;
        }

        public int idTipoVisita
        {
            get => id_tipo_visita;
            set => id_tipo_visita = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        //Buscar Tipo Visita
        public static List<TipoVisita> BuscarTipoVisita()
        {

            DataTable tabla = Datos.BuscarTipoVisitasBD();

            List<TipoVisita> tipoVisitas = new List<TipoVisita>();

            for (var f = 0; f < int.Parse(tabla.Rows.Count.ToString()); f++)
            {
                tipoVisitas.Add(new TipoVisita(int.Parse(tabla.Rows[f][0].ToString()), tabla.Rows[f][1].ToString()));
            }

            return tipoVisitas;
        }
    }
}
