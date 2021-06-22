using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_3K2_PPAI.Clases;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

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

        public void Insertar_Reserva(List<int> exposiciones, List<int> empleados)
        {
            string InsertarReserva = "INSERT INTO Reserva (id_tipo_visita, id_escuela, fecha_creacion,fecha_reserva, hora_inicio, hora_fin" +
            ", hora_incio_real, hora_fin_real, cant_alumnos_confirm ) "
            + "VALUES ("
            + Pp_id_tipo_visita
            + ", " + Pp_id_escuela 
            + ", '" + "'"
            + ", '" + Pp_fecha_reserva + "'"
            + ", '" + Pp_hora_inicio + "'"
            + ", '" + Pp_hora_fin + "'"
            + ", '" + Pp_hora_incio_real + "'"
            + ", '" + Pp_hora_fin_real + "'"
            + ", " + Pp_cant_alumnos_confirm + ");";

            MessageBox.Show(InsertarReserva);
            _BD.Insertar_Reserva(InsertarReserva);

            MessageBox.Show("inicio Transaccion");
            BE_AccesoDatos.TransaccionReserva(exposiciones,empleados);
            MessageBox.Show("fin Transaccion");
            MessageBox.Show("La carga a finalizado correctamente");



        }


        public static DataTable ObtenerGuia()
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Empleado";


                cmd.Parameters.Clear();
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        public static DataTable ObtenerExpo()
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Exposicion";


                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }





        public static DataTable ObtenerGuiaEspecifica(int id)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Empleado WHERE id_empleado=@Id ";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id",id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }


        public static DataTable ObtenerExpoEspecifica(int id)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Exposicion WHERE id_expo=@id";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id",id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }



    }



}
