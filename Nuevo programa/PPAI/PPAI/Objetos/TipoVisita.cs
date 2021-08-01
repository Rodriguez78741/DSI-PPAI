using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class TipoVisita
    {
        private int id_tipo_visita;
        private string descripcion;

        public TipoVisita(int id, string descripcion)
        {
            this.id_tipo_visita = id;
            this.descripcion = descripcion;
        }

        public int idTipoVisita
        {
            get => id_tipo_visita;
            set => id_tipo_visita = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}
