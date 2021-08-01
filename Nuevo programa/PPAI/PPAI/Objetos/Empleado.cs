using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class Empleado
    {
        private int id_empleado;
        private string nombre;
        private string apellido;
        private int id_tipo_doc;
        private decimal nro_doc;
        private string nombre_calle;
        private int nro_calle;
        private int id_sede;
        private int id_cargo;
        private int id_genero;
        private string email;
        private string cuit;
        private int id_barrio;
        private string telefono;
        private DateTime fecha_nac;
        private DateTime fecha_ingreso;

        public Empleado(int idEmpleado, string nombre, string apellido, int idTipoDoc, decimal nroDoc, string nombreCalle, int nroCalle, int idSede, int idCargo, int idGenero, string mail, string Cuit, int idBarrio, string Telefono, DateTime fechaNac, DateTime fechaIngreso)
        {
            this.id_empleado = idEmpleado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.id_tipo_doc = idTipoDoc;
            this.nro_doc = nroDoc;
            this.nombre_calle = nombreCalle;
            this.nro_calle = nroCalle;
            this.id_sede = idSede;
            this.id_cargo = idCargo;
            this.id_genero = idGenero;
            this.email = mail;
            this.cuit = Cuit;
            this.id_barrio = idBarrio;
            this.telefono = Telefono;
            this.fecha_nac = fechaNac;
            this.fecha_ingreso = fechaIngreso;
    }

        public int id
        {
            get => id_empleado;
            set => id_empleado = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public int idTipoDoc
        {
            get => id_tipo_doc;
            set => id_tipo_doc = value;
        }
        public decimal nroDoc
        {
            get => nro_doc;
            set => nro_doc = value;
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
        public int idSede
        {
            get => id_sede;
            set => id_sede = value;
        }
        public int idCargo
        {
            get => id_cargo;
            set => id_cargo = value;
        }
        public int idGenero
        {
            get => id_genero;
            set => id_genero = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Cuit
        {
            get => cuit;
            set => cuit = value;
        }
        public int idBarrio
        {
            get => id_barrio;
            set => id_barrio = value;
        }
        public string Telefono
        {
            get => telefono;
            set => telefono = value;
        }
        public DateTime fechaNacimiento
        {
            get => fecha_nac;
            set => fecha_nac = value;
        }
        public DateTime fechaIngreso
        {
            get => fecha_ingreso;
            set => fecha_ingreso = value;
        }
    }
}
