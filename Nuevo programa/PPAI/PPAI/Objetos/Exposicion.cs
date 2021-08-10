using PPAI.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Objetos
{
    public class Exposicion
    {
        private int id_expo;
        private string nombre;
        private string descripcion;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private int id_tipo_expo;
        private int id_guia;
        private int id_publico;
        private int id_sede;
        private bool Temporal;



        public Exposicion(int idExpo, string nombre, string descripcion, DateTime fechainicio, DateTime fechafin, int idTipoExpo, int idGuia, int idpublico, int idsede, bool Temp)
        {
            this.id_expo = idExpo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fecha_inicio = fechainicio;
            this.fecha_fin = fechafin;
            this.id_tipo_expo = idTipoExpo;
            this.id_guia = idGuia;
            this.id_publico = idpublico;
            this.id_sede = idsede;
            this.Temporal = Temp;
    }

        public int idExposicion
        {
            get => id_expo;
            set => id_expo = value;
        }

        public string nombreExpo
        {
            get => nombre;
            set => nombre = value;
        }
        public string descripcionExpo
        {
            get => descripcion;
            set => descripcion = value;
        }
        public DateTime fechaInicio
        {
            get => fecha_inicio;
            set => fecha_inicio = value;
        }
        public DateTime FechaFin
        {
            get => fecha_fin;
            set => fecha_fin = value;
        }
        public int idTipoExpo
        {
            get => id_tipo_expo;
            set => id_tipo_expo = value;
        }
        public int idGuia
        {
            get => id_guia;
            set => id_guia = value;
        }

        public int Publico
        {
            get => id_publico;
            set => id_publico = value;
        }
        public int Sede
        {
            get => id_sede;
            set => id_sede = value;
        }

        public bool TEmporal
        {
            get => Temporal;
            set => Temporal = value;
        }

        public (int, string, string, string) getTempVigentes()
        {
            int ID = this.idExposicion;
            string TIPO = TipoExposicion.esTemporal(this.Temporal);
            string detalle = this.nombre;
            string publico = PublicoDestino.getPublicoDestino(this.id_publico);
            return (ID, TIPO, publico, detalle);
        }

        public TimeSpan buscarDurExtendidaObras()
        {
            DataTable tabla = Datos.BuscarDetalleExpoidBD(this.id_expo);
            List<DetalleExposicion> DE = new List<DetalleExposicion>();
            TimeSpan durac = new TimeSpan();
            durac.Equals(TimeSpan.Zero);
            for(var r = 0; r<tabla.Rows.Count; r++)
            {
                DE.Add(new DetalleExposicion((int)tabla.Rows[r][0], (int)tabla.Rows[r][1]));
            }
            
            foreach(var d in DE)
            {
                TimeSpan dur = d.buscarDuracExObra();
                durac += dur;
            }

            return durac;
            
        }
    }
}
