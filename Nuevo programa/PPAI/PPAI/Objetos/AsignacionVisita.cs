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
        private DateTime fecha;

        public AsignacionVisita(int idasignacion, int idempleado, TimeSpan horainicio, TimeSpan horafin, DateTime dia)
        {
            this.id_asignacion = idasignacion;
            this.id_empleado = idempleado;
            this.horaInicio = horainicio;
            this.horaFin = horafin;
            this.fecha = dia;
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

        public DateTime dia
        {
            get => fecha;
            set => fecha = value;
        }

        public bool buscarAsignacion(DateTime fecha_reserva, TimeSpan inicio, TimeSpan fin)
        {

            int shia = this.horainicio.Seconds;
            int mhia = this.horainicio.Minutes;
            int hhia = this.horainicio.Hours;
            int shfa = this.horafin.Seconds;
            int mhfa = this.horafin.Minutes;
            int hhfa = this.horafin.Hours;

            TimeSpan horaInicioAsignacion = new TimeSpan(hhia, mhia, shia);
            TimeSpan horafinAsignacion = new TimeSpan(hhfa, mhfa, shfa);

            int primero = TimeSpan.Compare(inicio, horaInicioAsignacion);
            int segundo = TimeSpan.Compare(fin, horafinAsignacion);

            if (( primero >= 0 && segundo <= 0) == true && dia == fecha_reserva)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
