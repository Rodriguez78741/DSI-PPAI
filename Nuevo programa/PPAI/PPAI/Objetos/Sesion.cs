using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class Sesion
    {
        private int id_usuario;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;

        public Sesion(int id, DateTime fechainicio, DateTime fechaFin)
        {
            this.id_usuario = id;
            this.fecha_inicio = fechainicio;
            this.fecha_fin = fechaFin;
        }

        public int Id
        {
            get => id_usuario;
            set => id_usuario = value;
        }
        public DateTime fechaInicio
        {
            get => fecha_inicio;
            set => fecha_inicio = value;
        }
        public DateTime fechaFin
        {
            get => fecha_fin;
            set => fecha_fin = value;
        }
    }


}
