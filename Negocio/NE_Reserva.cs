using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_3K2_PPAI.Clases;
using System.Windows.Forms;



namespace DSI_3K2_PPAI.Negocio
{
    class NE_Reserva
    {
        //DateTime FechaHoy = new DateTime();

        //DateTime FechaHoy = DateTime.Now;
        //string FechaHoyFormatted = FechaHoy.ToString("yyyy/MM/dd");
        static DateTime FechaHoy = DateTime.Now;
        string FechaHoyFormateada = FechaHoy.ToString("yyyy/MM/dd");

        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public string Pp_id_tipo_visita { get; set; }
        public string Pp_id_escuela { get; set; }
        public string Pp_id_guia { get; set; }
        public string Pp_fecha_creacion { get; set; }
        public string Pp_fecha_reserva { get; set; }
        public string Pp_hora_inicio { get; set; }
        public string Pp_hora_fin { get; set; }
        public string Pp_hora_incio_real { get; set; }
        public string Pp_hora_fin_real { get; set; }
        public string Pp_cant_alumnos_confirm { get; set; }

        public void Insertar_Reserva(Control.ControlCollection controles)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            _BD.Insertar(tratamientos.CostructorInsert("Reserva", controles));

        }

        public void Insertar_Reserva()
        {
            string InsertarReserva = "INSERT INTO Reserva (id_tipo_visita, id_escuela, id_guia, fecha_creacion,fecha_reserva, hora_inicio, hora_fin" +
            ", hora_incio_real, hora_fin_real, cant_alumnos_confirm ) "
            + "VALUES ("
            + Pp_id_tipo_visita
            + ", " + Pp_id_escuela
            + ", " + Pp_id_guia 
            + ", '" + "'"
            + ", '" + Pp_fecha_reserva + "'"
            + ", '" + Pp_hora_inicio + "'"
            + ", '" + Pp_hora_fin + "'"
            + ", '" + Pp_hora_incio_real + "'"
            + ", '" + Pp_hora_fin_real + "'"
            + ", " + Pp_cant_alumnos_confirm + ");";

            MessageBox.Show(InsertarReserva);
            _BD.Insertar_Reserva(InsertarReserva);
            MessageBox.Show("La carga a finalizado correctamente");

        }
    }
}
