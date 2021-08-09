using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class PublicoDestino
    {
        private int id;
        private string descripcion;

        public PublicoDestino(int id, string descr)
        {

            this.id = id;
            this.descripcion = descr;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public String Descrip
        {
            get => descripcion;
            set => descripcion = value;
        }

        public static string getPublicoDestino(int id)
        {

            DataTable tabla = AccesoADatos.Datos.BuscarPublico(id);
            return tabla.Rows[0][1].ToString();
            
            
        }
    }
}
