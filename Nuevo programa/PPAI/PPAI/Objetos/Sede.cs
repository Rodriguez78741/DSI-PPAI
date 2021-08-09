using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class Sede
    {
        private int id_sede;
        private string nombre_sede;
        private int cant_max_visit;
        private int cant_max_guias;
        private TimeSpan horario_desde;
        private TimeSpan horario_hasta;
        
        public Sede(int idSede, string nombreSede, int cant_max_visit, int cant_max_guias, TimeSpan horarioDesde, TimeSpan horarioHasta)
        {
            this.id_sede = idSede;
            this.nombre_sede = nombreSede;
            this.cant_max_guias = cant_max_guias;
            this.cant_max_visit = cant_max_visit;
            this.horarioDesde = horarioDesde;
            this.HorarioHasta = horarioHasta;
        }

        public int idsede
        {
            get => id_sede;
            set => id_sede = value;
        }

        public string nombresede
        {
            get => nombre_sede;
            set => nombre_sede = value;
        }
        public int maxVisitas
        {
            get => cant_max_visit;
            set => cant_max_visit = value;
        }
        public int maxGuias
        {
            get => cant_max_guias;
            set => cant_max_guias = value;
        }
        public TimeSpan horarioDesde
        {
            get => horario_desde;
            set => horario_desde = value;
        }
        public TimeSpan HorarioHasta
        {
            get => horario_hasta;
            set => horario_hasta = value;
        }

        public string mostrarNombre()
        {
            string nombr = this.nombresede;
            return nombr;
        }

        public static DataTable buscarExposiciones(List<Exposicion> Expo)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("Id", typeof(int)));
            tabla.Columns.Add(new DataColumn("Tipo", typeof(string)));
            tabla.Columns.Add(new DataColumn("Publico", typeof(string)));
            tabla.Columns.Add(new DataColumn("Detalle", typeof(string)));

            foreach (var e in Expo)
            {
                (int, string, string, string) tupla = e.getTempVigentes();
                tabla.Rows.Add(tupla.Item1, tupla.Item2, tupla.Item3, tupla.Item4);
            }
                       
           return tabla;
        }
    }
}
