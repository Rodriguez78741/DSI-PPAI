﻿using PPAI.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PPAI.AccesoADatos
{
    public class Datos
    {



        public static DataTable BuscarEscuelasBD()
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Escuela";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }


        public static DataTable BuscarSedesBD(int cant_visitantes)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Sede WHERE cant_max_visit >= " + cant_visitantes.ToString();

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }


        public static DataTable BuscarTipoVisitasBD()
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Tipo_visita";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }

        public static DataTable BuscarExpoVigentesBD(int idSesion)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Exposicion WHERE id_Sede = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idSesion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }


        public static DataTable BuscarDetalleExpoidBD(int id)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM DetalleExposicion WHERE id_expo = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }

        public static DataTable BuscarObrasIdBD(int id)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT DISTINCT * FROM Obra WHERE id_obra = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }

        public static DataTable BuuscarReservasXSede(int id, DateTime fecha_reserva)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT DISTINCT * FROM Reserva WHERE id_sede = @id and fecha_reserva = @fecha";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@fecha", fecha_reserva);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }

        public static DataTable BuuscarSedeId(int id)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT DISTINCT * FROM Sede WHERE id_sede = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }


        public static DataTable BuscarEmpleadoGuia(int id)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT DISTINCT * FROM Empleado WHERE id_sede = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }


        public static DataTable BuscarHorarioEmpleado(int id)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Hora_Empleado WHERE id_empleado = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }

        public static DataTable BuscarAsignacionEmpleado()
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Asignaciones";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }

        public static bool AltaReserva(int id, int idTipoVisita, int idEscuela, DateTime fechaCreacion, DateTime fechaReserva, string horaInicio, string horaFin, int cantVisitas, int idSede, List<int> idExpo, List<int> idGuias, TimeSpan dur)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlTransaction objetoTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                ReservaVisita reserva = new ReservaVisita(id, idTipoVisita, idEscuela, fechaCreacion, fechaReserva, TimeSpan.Parse(horaInicio), TimeSpan.Parse(horaFin), TimeSpan.Parse(horaInicio), TimeSpan.Parse(horaFin), cantVisitas, idSede);

                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Reserva (id_reserva,id_tipo_visita, id_escuela, fecha_creacion, fecha_reserva,hora_inicio,hora_fin,hora_incio_real,hora_fin_real,cant_alumnos_confirm,id_sede, detalleConfirmacion, horaEstimada)" +
                                  "VALUES(@idRes,@tipoVisita, @Escuela, @fechaCreacion, @fechaReserva, @horainicio,@horafin,@horainicioreal,@horafinreal,@cantvisitas,@idsede,@pend,@dur)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idRes", reserva.idReserva);
                cmd.Parameters.AddWithValue("@tipoVisita", reserva.idTipoVisita);
                cmd.Parameters.AddWithValue("@Escuela", reserva.idEscuela);
                cmd.Parameters.AddWithValue("@fechaCreacion", reserva.fechaCreación);
                cmd.Parameters.AddWithValue("@fechaReserva", reserva.fechaReserva);
                cmd.Parameters.AddWithValue("@horainicio", reserva.horaInicio);
                cmd.Parameters.AddWithValue("@horafin", reserva.horaFin);
                cmd.Parameters.AddWithValue("@horainicioreal", reserva.horaInicioReal); 
                cmd.Parameters.AddWithValue("@horafinreal", reserva.horaFinReal);
                cmd.Parameters.AddWithValue("@cantvisitas", reserva.cantAlumnos);
                cmd.Parameters.AddWithValue("@idsede", reserva.idsede);
                cmd.Parameters.AddWithValue("@dur", dur);
                cmd.Parameters.AddWithValue("@pend", '0');
                


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                objetoTransaccion = cn.BeginTransaction("AltaDeReserva");

                cmd.Transaction = objetoTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();


                foreach (var idExpos in idExpo)
                {

                    string consultaExpo = "INSERT INTO Expo_X_Reserva(id_reserva, id_exposicion) values(@idreserva,@idexpo)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idexpo", idExpos);
                    cmd.Parameters.AddWithValue("@idreserva", id);
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = consultaExpo;
                    cmd.ExecuteNonQuery();
                }


                foreach (var idGuia in idGuias)
                {

                    string consultaGuia = "INSERT INTO Guia_X_Reserva (idGuia, idReserva) VALUES (@idguia,@idReserva)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idguia", idGuia);
                    cmd.Parameters.AddWithValue("@idReserva", id);
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = consultaGuia;
                    cmd.ExecuteNonQuery();
                }


                foreach (var idGuia in idGuias)
                {

                    string consultaGuia =  @"INSERT INTO Asignaciones (id_empleado, horaInicio, horaFin, fecha) " +
                                            "VALUES (@idguia,@Inicio,@Fin,@Fecha)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idguia", idGuia);
                    cmd.Parameters.AddWithValue("@Inicio", horaInicio);
                    cmd.Parameters.AddWithValue("@Fin", horaFin);
                    cmd.Parameters.AddWithValue("@Fecha", fechaReserva);
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = consultaGuia;
                    cmd.ExecuteNonQuery();
                }
                objetoTransaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("rooll");
                objetoTransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }


        }

        public static int buscarUltimoIdReserva()
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT MAX(id_reserva) FROM Reserva";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();
                cn.Close();
                return resultado;

            }
            catch (Exception)
            {

                return 0;
            }
            finally
            {
                cn.Close();
            }
        }


        public static DataTable BuscarPublico(int id)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT DISTINCT * FROM Publico_Destino WHERE id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }

        public static DataTable BuscarExpoXobras(int idExpo)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT e.nombre AS expo, o.nombre AS obra, o.artista, o.descripcion, o.fecha_creacion, o.valuacion " +
                                    "FROM DetalleExposicion d, Exposicion e, Obra o " +
                                    "WHERE d.id_expo = e.id_expo " +
                                      "and o.id_obra = d.id_obra " +
                                      "and d.id_expo = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idExpo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }

        public static int BuscarCantExpoXobras(int idExpo)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = @"SELECT COUNT(*) " +
                                    "FROM DetalleExposicion d " +
                                      "WHERE d.id_expo = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idExpo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return int.Parse(tabla.Rows[0][0].ToString());
            }
            catch
            {
                throw;
            }
        }


        public static DataTable BuscarExpoid(int id)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Exposicion WHERE id_expo = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }



        public static DataTable BuscarCargo(int id)
        {
            string cadenaconexion = "Data Source=LAPTOP-17DLPH1G\\SQLEXPRESS;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Cargo WHERE id_cargo = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                cn.Close();
                return tabla;
            }
            catch
            {
                throw;
            }
        }
    }
}
