using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool dispEnFechaHoraReserva(DateTime fecha_reserva, TimeSpan horaInicio, TimeSpan Horafin)
        {
            int shiem = this.horaInicio.Seconds;
            int mhiem = this.horaInicio.Minutes;
            int hhiem = this.horaInicio.Hours;
            int shfem = this.horaFin.Seconds;
            int mhfem = this.horaFin.Minutes;
            int hhfem = this.horaFin.Hours;

            TimeSpan horaInicioEmpleado = new TimeSpan(hhiem, mhiem, shiem);
            TimeSpan horafinEmpleado = new TimeSpan(hhfem, mhfem, shfem);

            int primero = TimeSpan.Compare(horaInicio, horaInicioEmpleado);
            int segundo = TimeSpan.Compare(Horafin, horafinEmpleado);


            if (fecha_reserva.DayOfWeek == DayOfWeek.Monday && this.Dia == "L")
            {
                if (primero >= 0 && segundo <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (fecha_reserva.DayOfWeek == DayOfWeek.Tuesday && this.dia == "M")
            {
                if (primero >= 0 && segundo <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (fecha_reserva.DayOfWeek == DayOfWeek.Wednesday && this.dia == "X")
            {
                if (primero >= 0 && segundo <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (fecha_reserva.DayOfWeek == DayOfWeek.Thursday && this.dia == "J")
            {
                if (primero >= 0 && segundo <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (fecha_reserva.DayOfWeek == DayOfWeek.Friday && this.dia == "V")
            {
                
                if (primero >= 0 && segundo <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (fecha_reserva.DayOfWeek == DayOfWeek.Saturday && this.dia == "S")
            {
                if (primero >= 0 && segundo <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (fecha_reserva.DayOfWeek == DayOfWeek.Sunday && this.dia == "D")
            {
                if (primero >= 0 && segundo <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
