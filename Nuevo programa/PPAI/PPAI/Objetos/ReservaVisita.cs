using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class ReservaVisita
    {
        private int id_reserva;
        private int id_tipo_visita;
        private int id_escuela;
        private DateTime fecha_creacion;
        private DateTime fecha_reserva;
        private TimeSpan hora_inicio;
        private TimeSpan hora_fin;
        private TimeSpan hora_inicio_real;
        private TimeSpan hora_fin_real;
        private int cant_alumnos_confirm;
        private int id_Sede;   
        

        public ReservaVisita(int id, int idTipoVisita, int idEscuela, DateTime fechaCreacion, DateTime fechaReserva, TimeSpan horaInicio, TimeSpan horaFin, TimeSpan horaInicioReal, TimeSpan horaFinReal, int cantAlumnosConfirm, int idSede)
        {
            this.id_reserva = id;
            this.id_tipo_visita = idTipoVisita;
            this.id_escuela = idEscuela;
            this.fecha_creacion = fechaCreacion;
            this.fecha_reserva = fechaReserva;
            this.hora_inicio = horaInicio;
            this.hora_fin = horaFin;
            this.hora_inicio_real = horaInicioReal;
            this.hora_fin_real = horaFinReal;
            this.cant_alumnos_confirm = cantAlumnosConfirm;
            this.id_Sede = idSede;
    }
        public int idReserva
        {
            get => id_reserva;
            set => id_reserva = value;
        }
        public int idTipoVisita
        {
            get => id_tipo_visita;
            set => id_tipo_visita = value;
        }
        public int idEscuela
        {
            get => id_escuela;
            set => id_escuela = value;
        }
        public DateTime fechaCreación
        {
            get => fecha_creacion;
            set => fecha_creacion = value;
        }
        public DateTime fechaReserva
        {
            get => fecha_reserva;
            set => fecha_reserva = value;
        }
        public TimeSpan horaInicio
        {
            get => hora_inicio;
            set => hora_inicio = value;
        }
        public TimeSpan horaFin
        {
            get => hora_fin;
            set => hora_fin = value;
        }
        public TimeSpan horaInicioReal
        {
            get => hora_inicio_real;
            set => hora_inicio_real = value;
        }
        public TimeSpan horaFinReal
        {
            get => hora_fin_real;
            set => hora_fin_real = value;
        }
        public int cantAlumnos
        {
            get => cant_alumnos_confirm;
            set => cant_alumnos_confirm = value;
        }
        public int idsede
        {
            get => id_Sede;
            set => id_Sede = value;
        }

        public (TimeSpan, TimeSpan) getFechaHoraReserva()
        {
            TimeSpan inicio = this.hora_inicio;
            TimeSpan fin = this.hora_fin;
            return (inicio, fin);
        }
    }
}
