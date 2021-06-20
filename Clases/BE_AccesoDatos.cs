using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DSI_3K2_PPAI.Clases
{
    class BE_AccesoDatos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        private void conectar()
        {   
            conexion.ConnectionString = "";
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }
        private void desconectar()
        {
            conexion.Close();
        }
        public DataTable Ejecutar_Select(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void Insertar(string SqlInsertar)
        {
            InsModBorr(SqlInsertar);
        }
        public void Modificar(string SqlModificar)
        {
            InsModBorr(SqlModificar);
        }
        public void Borrar(string SqlBorrar)
        {
            InsModBorr(SqlBorrar);
        }
        private void InsModBorr(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            desconectar();
        }
    }
}
