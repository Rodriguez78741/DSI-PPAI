using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class Escuela
    {
        private int id_escuela;
        private string nombre;
        private string email;
        private string nombre_calle;
        private int nro_calle;
        private int id_barrio;
        private string tel_celular;
        private string tel_fijo;

        public Escuela(int id, string nombre, string email, string nombre_calle, int nro_calle, int id_barrio, string tel_celular, string tel_fijo)
        {
            this.id_escuela = id;
            this.nombre = nombre;
            this.email = email;
            this.nombre_calle = nombre_calle;
            this.nro_calle = nro_calle;
            this.id_barrio = id_barrio;
            this.tel_celular = tel_celular;
            this.tel_fijo = tel_fijo;
    }

        public int id
        {
            get => id_escuela;
            set => id_escuela = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string nombreCalle
        {
            get => nombre_calle;
            set => nombre_calle = value;
        }
        public int nroCalle
        {
            get => nro_calle;
            set => nro_calle = value;
        }
        public int idBarrio
        {
            get => id_barrio;
            set => id_barrio = value;
        }
        public string telCelular
        {
            get => tel_celular;
            set => tel_celular = value;
        }
        public string telFijo
        {
            get => tel_fijo;
            set => tel_fijo = value;
        }

        public string mostrarNombre()
        {
            string nombr = this.nombre;
            return nombr;
        }


    }
}
