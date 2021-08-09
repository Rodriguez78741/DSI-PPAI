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

        public bool buscarAsignacion(DateTime inicio, DateTime fin)
        {

            int diaa = this.dia.Day;
            int mesa = this.dia.Month;
            int añoa = this.dia.Year;

            int shia = this.horainicio.Seconds;
            int mhia = this.horainicio.Minutes;
            int hhia = this.horainicio.Hours;
            int shfa = this.horafin.Seconds;
            int mhfa = this.horafin.Minutes;
            int hhfa = this.horafin.Hours;

            DateTime horaInicioAsignacion = new DateTime(añoa, mesa, diaa, hhia, mhia, shia);
            DateTime horafinAsignacion = new DateTime(añoa, mesa, diaa, hhfa, mhfa, shfa);


            if ((horaInicioAsignacion < fin | horafinAsignacion > inicio) == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
