using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class AsignacionVisita
    {
        private int id_asignacion;
        private int id_empleado;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;

        public AsignacionVisita(int idasignacion, int idempleado, TimeSpan horainicio, TimeSpan horafin)
        {
            this.id_asignacion = idasignacion;
            this.id_empleado = idempleado;
            this.horaInicio = horainicio;
            this.horaFin = horafin;
        }

        public int idAsignacion
        {
            get => id_asignacion;
            set => id_asignacion = value;
        }

        public int idEmpleado
        {
            get => id_empleado;
            set => id_empleado = value;
        }
        public TimeSpan horainicio
        {
            get => horaInicio;
            set => horaInicio = value;
        }
        public TimeSpan horafin
        {
            get => horaFin;
            set => horaFin = value;
        }
    }
}
