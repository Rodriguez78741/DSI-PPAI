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

        public bool dispEnFechaHoraReserva(DateTime horaInicio, DateTime Horafin)
        {
            int dia = horaInicio.Day;
            int mes = horaInicio.Month;
            int año = horaInicio.Year;

            int shiem = this.horaInicio.Seconds;
            int mhiem = this.horaInicio.Minutes;
            int hhiem = this.horaInicio.Hours;
            int shfem = this.horaFin.Seconds;
            int mhfem = this.horaFin.Minutes;
            int hhfem = this.horaFin.Hours;

            DateTime horaInicioEmpleado = new DateTime(año, mes, dia, hhiem, mhiem, shiem);
            DateTime horafinEmpleado = new DateTime(año, mes, dia, hhfem, mhfem, shfem);

            if (horaInicioEmpleado < horaInicio && horafinEmpleado > Horafin)
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
