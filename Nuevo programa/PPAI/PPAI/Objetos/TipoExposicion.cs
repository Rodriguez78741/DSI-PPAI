using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PPAI.Objetos
{
    class TipoExposicion
    {
        private int id_tipo_expo;
        private string nombre_tipo_expo;
        private string descripcion;

        public TipoExposicion(int id, string nombre, string descrip)
        {
            this.id_tipo_expo = id;
            this.nombre_tipo_expo = nombre;
            this.descripcion = descrip;
        }

        public static string esTemporal(bool id_tipo_expo)
        {
            string tipo = "Temporal";

            if (id_tipo_expo == true)
            {
                tipo = "Permanente";
            }
            return tipo;
        }        

        public int Id
        {
            get => id_tipo_expo;
            set => id_tipo_expo = value;
        }

        public string Nombre
        {
            get => nombre_tipo_expo;
            set => nombre_tipo_expo = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}
