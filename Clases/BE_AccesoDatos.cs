using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DSI_3K2_PPAI.Clases
{
    class BE_AccesoDatos
    {
        public enum EstadoTransaccion { error, correcto }
        public enum TipoConexion { simple, transaccion }

        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlTransaction Transaccion;

        public void InicioTransaccion()
        {
            ControlTransaccion = EstadoTransaccion.correcto;
            ControlConexion = TipoConexion.transaccion;
        }

        public EstadoTransaccion FinalTransaccion()
        {
            if (ControlConexion == TipoConexion.transaccion)
            {
                if (ControlTransaccion == EstadoTransaccion.correcto)
                {
                    Transaccion.Commit();
                }
                else
                {
                    Transaccion.Rollback();
                }
            }
            ControlConexion = TipoConexion.simple;
            Desconectar();
            return ControlTransaccion;
        }

        private void Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = "Data Source=DESKTOP-CCTL5C4\\SQLEXPRESS01;Initial Catalog=DSI_PPAI;Integrated Security=True";
                Conexion.Open();
                Cmd.Connection = Conexion;
                Cmd.CommandType = CommandType.Text;

                if (ControlConexion == TipoConexion.transaccion)
                {
                    Transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    Cmd.Transaction = Transaccion;
                }
            }
        }

        EstadoTransaccion ControlTransaccion = EstadoTransaccion.correcto;
        TipoConexion ControlConexion = TipoConexion.simple;

       

        

        
        private void Desconectar()
        {
            if (ControlConexion == TipoConexion.simple)
                Conexion.Close();
        }
        public DataTable EjecutarSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error en la consulta: \n "
                                 + sql + "\n"
                                 + "El mensaje de error es: \n"
                                 + e.Message);
            }
            Desconectar();
            return tabla;
        }
        public EstadoTransaccion Insertar(string SqlInsertar)
        {
            MessageBox.Show("diego");
            return InsModBorr(SqlInsertar);
        }

        public void Insertar_Reserva(string sqlInsertar)
        {

            Conectar();
            Cmd.CommandText = sqlInsertar;
            Cmd.ExecuteNonQuery();
            Desconectar();
        }



        public static bool TransaccionReserva(List<int> exposiciones, List<int> empleados)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objetoTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {



                int idReserva = ObtenerUltimoIdReserva();


                SqlCommand cmd = new SqlCommand();


                


                cn.Open();

                objetoTransaccion = cn.BeginTransaction("RegistroDeReserva");
                cmd.Transaction = objetoTransaccion;
                cmd.Connection = cn;

                



                foreach (var idEmpleado in empleados)
                {

                    string consultaAlumno = "INSERT INTO Guia_X_Reserva values(@idPersona,@idCurso)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idPersona", idEmpleado);
                    cmd.Parameters.AddWithValue("@idCurso", idReserva);
                    

                    cmd.CommandText = consultaAlumno;
                    cmd.ExecuteNonQuery();
                }



                foreach (var idExpo in exposiciones)
                {

                    string consultaAlumno = "INSERT INTO Expo_X_Reserva values(@idCurso,@idPersona)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idPersona", idExpo);
                    cmd.Parameters.AddWithValue("@idCurso", idReserva);
                    

                    cmd.CommandText = consultaAlumno;
                    cmd.ExecuteNonQuery();
                }

                objetoTransaccion.Commit();
                return true;
            }
            catch (Exception)
            {

                objetoTransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }


        }


        public static int ObtenerUltimoIdReserva()
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
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































        public EstadoTransaccion Modificar(string SqlModificar)
        {
            return InsModBorr(SqlModificar);
        }
        public EstadoTransaccion Borrar(string SqlBorrar)
        {
            return InsModBorr(SqlBorrar);
        }
        private EstadoTransaccion InsModBorr(string sql)
        {
            MessageBox.Show("Diego 2");
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error en comando sql: \n "
                                 + sql + "\n"
                                 + "El mensaje de error es: \n"
                                 + e.Message);

            }
            Desconectar();
            return ControlTransaccion;
        }

        private EstadoTransaccion Mostrar(string sqlbuscar)
        {
            return InsModBorr(sqlbuscar);
        }
        public DataTable Consulta(String sql)

        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                + "En el comando:" + "\n"
                                + sql + "\n"
                                + "El mensaje es:" + "\n"
                                + e.Message);
            }

            Desconectar();
            return tabla;
        }

}
}