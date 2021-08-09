using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class HorarioEmpleado
    {
        private int id_empleado;
        private string dia;
        private TimeSpan hora_inicio;
        private TimeSpan Hora_fin;

        public HorarioEmpleado(int id, string dia, TimeSpan horaInicio, TimeSpan horaFin)
        {
            this.dia = dia;
            this.id_empleado = id;
            this.hora_inicio = horaInicio;
            this.Hora_fin = horaFin;
        }

        public int idEmpleado
        {
            get => id_empleado;
            set => id_empleado = value;
        }
        public String Dia
        {
            get => dia;
            set => dia = value;
        }
        public TimeSpan horaInicio
        {
            get => hora_inicio;
            set => hora_inicio = value;
        }
        public TimeSpan horaFin
        {
            get => Hora_fin;
            set => Hora_fin = value;
        }
 
    }
}
