using PPAI.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
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

        public bool getGuiaDispEnHorario(DateTime horaInicio, DateTime Horafin)
        {
            bool res = true;
           
            DataTable tablaAsignaciones = Datos.BuscarAsignacionEmpleado();
            DataTable tablaHoraEmpleados = Datos.BuscarHorarioEmpleado(id);
            DataTable tablaCargos = Datos.BuscarCargo(this.id_cargo);
            
            HorarioEmpleado horarios = new HorarioEmpleado((int)tablaHoraEmpleados.Rows[0][0], tablaHoraEmpleados.Rows[0][1].ToString(), (TimeSpan)tablaHoraEmpleados.Rows[0][2], (TimeSpan)tablaHoraEmpleados.Rows[0][3]);
            List<AsignacionVisita> visitas = tablaAAsignacion(tablaAsignaciones);
            Cargo cargo = new Cargo((int)tablaCargos.Rows[0][0], tablaCargos.Rows[0][1].ToString());

            List<Empleado> guias = new List<Empleado>();


            
            if (cargo.esGuia())
            {
                if (horarios.dispEnFechaHoraReserva(horaInicio,Horafin))
                {
                    foreach (var a in visitas)
                    {
                        if (a.buscarAsignacion(horaInicio, Horafin) == false)
                        {
                            res = false;
                        }                                                                     
                    }
                }
                else
                {
                    res = false;
                }
            }
            else
            {
                res = false;
            }

            return res;
        }







        //Auxiliares
        private static List<Empleado> tablaAEmpleado(DataTable tabla)
        {
            List<Empleado> empleados = new List<Empleado>();
            for (var r = 0; r < tabla.Rows.Count; r++)
            {
                empleados.Add(new Empleado((int)tabla.Rows[r][0], tabla.Rows[r][1].ToString(), tabla.Rows[r][2].ToString(), (int)tabla.Rows[r][3], (decimal)tabla.Rows[r][4], tabla.Rows[r][5].ToString(), (int)tabla.Rows[r][6], (int)tabla.Rows[r][7], (int)tabla.Rows[r][8], (int)tabla.Rows[r][9], tabla.Rows[r][10].ToString(), tabla.Rows[r][11].ToString(), (int)tabla.Rows[r][12], tabla.Rows[r][13].ToString(), (DateTime)tabla.Rows[r][14], (DateTime)tabla.Rows[r][15]));
            }
            return empleados;
        }

        private static List<HorarioEmpleado> tablaAHorario(DataTable tabla)
        {
            List<HorarioEmpleado> horarios = new List<HorarioEmpleado>();
            for (var r = 0; r < tabla.Rows.Count; r++)
            {
                horarios.Add(new HorarioEmpleado((int)tabla.Rows[r][0], tabla.Rows[r][1].ToString(), (TimeSpan)tabla.Rows[r][2], (TimeSpan)tabla.Rows[r][3]));
            }
            return horarios;
        }

        private static List<AsignacionVisita> tablaAAsignacion(DataTable tabla)
        {
            List<AsignacionVisita> asignacion = new List<AsignacionVisita>();
            for (var r = 0; r < tabla.Rows.Count; r++)
            {
                asignacion.Add(new AsignacionVisita((int)tabla.Rows[r][0], (int)tabla.Rows[r][1], (TimeSpan)tabla.Rows[r][2], (TimeSpan)tabla.Rows[r][3]));
            }
            return asignacion;
        }

        private static List<Cargo> tablaACargo(DataTable tabla)
        {
            List<Cargo> cargo = new List<Cargo>();
            for (var r = 0; r < tabla.Rows.Count; r++)
            {
                cargo.Add(new Cargo((int)tabla.Rows[r][0], tabla.Rows[r][1].ToString()));
            }
            return cargo;
        }

        private static DataTable listaATabla(List<Empleado> empleados)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Cuil");
            foreach (var e in empleados)
            {
                tabla.Rows.Add(e.id, e.Nombre, e.Apellido, e.Cuit);
            }

            return tabla;
        }


    }
}
