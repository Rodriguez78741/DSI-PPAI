using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class Usuario
    {
        private int id_usuario;
        private int id_empleado;
        private string contraseña;
        private string nombre_usuario;

        public Usuario(int idUsu, int idEmpleado, string contra, string nombreUsuario)
        {
            this.id_usuario = idUsu;
            this.id_empleado = idEmpleado;
            this.contraseña = contra;
            this.nombre_usuario = nombreUsuario;
        }
        public int idUsuario
        {
            get => id_usuario;
            set => id_usuario = value;
        }
        public int idEmpleado
        {
            get => id_empleado;
            set => id_empleado = value;
        }
        public string Contraseña
        {
            get => contraseña;
            set => contraseña = value;
        }
        public string nombreUsuario
        {
            get => nombre_usuario;
            set => nombre_usuario = value;
        }

    }
}
