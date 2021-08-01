using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class Cargo
    {
        private int id_cargo;
        private string descripcion;

        public Cargo(int id, string descripcion)
        {
            this.id_cargo = id;
            this.descripcion = descripcion;
        }

        public int Id
        {
            get => id_cargo;
            set => id_cargo = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}
