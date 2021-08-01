using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_3K2_PPAI.Clases;
using System.Data;

namespace DSI_3K2_PPAI.Negocio
{
    class NE_Usuarios
    {
        public enum Respuesta { validacion_correcta, validacion_incorrecta };
        BE_AccesoDatos _BD = new BE_AccesoDatos();
        public Respuesta Validar_user(string user, string pass)
        {
            string sql = "";
            sql = "SELECT * FROM Usuario WHERE nombre_usuario = '" + user + "' AND contraseña = '" + pass + "'";
            DataTable datatable = new DataTable();
            datatable = _BD.Consulta(sql);
            if (datatable.Rows.Count == 0)
            {
                //no existe
                return Respuesta.validacion_incorrecta;
            }
            else
            {
                //existe
                return Respuesta.validacion_correcta;
            }
        }
    }
}
