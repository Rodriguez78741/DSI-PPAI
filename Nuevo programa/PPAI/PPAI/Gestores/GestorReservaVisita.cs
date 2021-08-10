using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.AccesoADatos;
using PPAI.Objetos;
using System.Windows.Forms;

namespace PPAI.Gestores
{
    public class GestorReservaVisita
    {

        //Tomar Registro Reserva Visita
        public static DataTable tomarRegReservaVisita()
        {
            List<Escuela> Escuelas = BuscarEscuelas();

            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("Id", typeof (int)));
            tabla.Columns.Add(new DataColumn("Nombre", typeof(string)));
            foreach(var e in Escuelas)
            {
                string nombre = e.mostrarNombre();
                tabla.Rows.Add(e.id, nombre);
            }
            return tabla;
        }

        //Buscar Escuelas
        private static List<Escuela> BuscarEscuelas() 
        {
            //Busca las escuelas en la BD
            DataTable tabla = Datos.BuscarEscuelasBD();

            //Toma los datos de la tabla y los transforma en la lista de entidades escuela
            List<Escuela> Escuelas = new List<Escuela>();
            for (var f = 0; f < int.Parse(tabla.Rows.Count.ToString()); f++)

             {
                Escuelas.Add(new Escuela(int.Parse(tabla.Rows[f][0].ToString()), tabla.Rows[f][1].ToString(), tabla.Rows[f][2].ToString(), tabla.Rows[f][3].ToString(), int .Parse(tabla.Rows[f][4].ToString()), int.Parse(tabla.Rows[f][5].ToString()), tabla.Rows[f][6].ToString(), tabla.Rows[f][7].ToString()));
             }

            return Escuelas;
        }

        //Tomar Escuelas
        public static void tomarEscuela (int id)
        {
            int idEscuela = id;
        }

        //Tomar Cantidad de Visitantes
        public static DataTable tomarCantidadVisitantes(int cant_visitantes)
        {
            List<Sede> sedes = BuscarSedes(cant_visitantes);

            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("Id", typeof(int)));
            tabla.Columns.Add(new DataColumn("Nombre", typeof(string)));
            foreach (var e in sedes)
            {
                string nombre = e.mostrarNombre();
                tabla.Rows.Add(e.idsede, nombre);
            }
            return tabla;
        }

        //Buscar Sedes
        private static List<Sede> BuscarSedes(int cant_visitantes)
        {          
            //Busca las Sedes en la BD
            DataTable tabla = Datos.BuscarSedesBD(cant_visitantes);

            //Toma los datos de la tabla y los transforma en la lista de entidades Sede
            List<Sede> sedes = new List<Sede>();
            
            for (var f = 0; f < int.Parse(tabla.Rows.Count.ToString()); f++)

            {
                sedes.Add(new Sede(int.Parse(tabla.Rows[f][0].ToString()), tabla.Rows[f][1].ToString(), int.Parse(tabla.Rows[f][2].ToString()), int.Parse(tabla.Rows[f][3].ToString()), TimeSpan.Parse(tabla.Rows[f][4].ToString()), TimeSpan.Parse(tabla.Rows[f][5].ToString())));
            }
            return sedes;
        }
        //Tomar Sede
        
        public static DataTable TomarSede()
        {
            List<TipoVisita> visitas = BuscarTipoVisita();

            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("Id", typeof(int)));
            tabla.Columns.Add(new DataColumn("Nombre", typeof(string)));
            foreach (var e in visitas)
            {
                string nombre = e.mostrarNombre();
                tabla.Rows.Add(e.idTipoVisita, nombre);
            }
            return tabla;
        }

        //Buscar Tipo Visita
        
        private static List<TipoVisita> BuscarTipoVisita()
        {
               
            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("Id", typeof(int)));
            tabla.Columns.Add(new DataColumn("Nombre", typeof(string)));
            tabla.Rows.Add(0, "General");
            tabla.Rows.Add(1, "Particular");

            List<TipoVisita> tipoVisitas = new List<TipoVisita>();

            for (var f = 0; f < int.Parse(tabla.Rows.Count.ToString()); f++)
            {
                tipoVisitas.Add(new TipoVisita(int.Parse(tabla.Rows[f][0].ToString()), tabla.Rows[f][1].ToString()));
            }

             return tipoVisitas;
                  
        }

        //Tomar fecha y hora actuales
        private static DateTime tomarFechayHoraAct()
        {
            DateTime fechaActual = DateTime.Parse(DateTime.Now.ToString());
            return fechaActual;
        }

        //Tomar tipo Visita
        public static DataTable tomarTipoVisita(int idSede)
        {
            List<Exposicion> Exposiciones = BuscarExpoTempVig(idSede);
            DataTable tabla = Sede.buscarExposiciones(Exposiciones);         
            return tabla;
        }

        //Buscar Exposicion de temporada Vigente
        private static List<Exposicion> BuscarExpoTempVig(int idSede)
        {

            DataTable tabla = Datos.BuscarExpoVigentesBD(idSede);

            List<Exposicion> Exposiciones = new List<Exposicion>();

            for (var f = 0; f < int.Parse(tabla.Rows.Count.ToString()); f++)
            {
                Exposiciones.Add(new Exposicion(int.Parse(tabla.Rows[f][0].ToString()), tabla.Rows[f][1].ToString(), tabla.Rows[f][2].ToString(), DateTime.Parse(tabla.Rows[f][3].ToString()), DateTime.Parse(tabla.Rows[f][4].ToString()), int.Parse(tabla.Rows[f][5].ToString()), int.Parse(tabla.Rows[f][6].ToString()), int.Parse(tabla.Rows[f][7].ToString()), int.Parse(tabla.Rows[f][8].ToString()), bool.Parse(tabla.Rows[f][9].ToString())));
            }

            return Exposiciones;

        }

        //Tomar fecha y hora Reserva
        public static (int, int, DataTable) tomarFechaHoraRes(DateTime fecha_reserva, TimeSpan horainicio, TimeSpan horafin, List<int> idExpos, int idSede, int cantVisitas)
        {
            int posible = 0;
            int cantidadDeGuiasNecesarios = 1;
            DataTable guias = new DataTable();

            TimeSpan duracion = calcularDuracionEst(horainicio, horafin);
            TimeSpan duracionObras = new TimeSpan();
            for (int i = 0; i < cantVisitas; i++)
            {
                duracionObras += Sede.buscarDuracionExp(idExpos);
            }
            
            bool cumpleCapacidadTiempo = calcularSobrepasoCapMax(duracion, duracionObras);
            bool cumpleCapacidadVisita = Sede.buscarReservasParaFechaHora(idSede, fecha_reserva, horainicio, horafin, cantVisitas);
            cantidadDeGuiasNecesarios = calcularCantGuiasNecesarios(cantVisitas, idSede);
            guias = buscarGuiasDispFechaReserva(idSede, fecha_reserva, horainicio, horafin);
            if (cumpleCapacidadTiempo == true && cumpleCapacidadVisita == true && guias.Rows.Count != 0)
            {
                return (posible, cantidadDeGuiasNecesarios, guias);
            }
            else
            {
                if (cumpleCapacidadTiempo == false)
                {
                    posible += 1;
                }
                if (cumpleCapacidadVisita == false)
                {
                    posible += 2;
                }
                if (guias.Rows.Count == 0)
                {
                    posible += 4;
                }
                return (posible, cantidadDeGuiasNecesarios, guias);
            }
        }

        //calcular duracion
        private static TimeSpan calcularDuracionEst(TimeSpan inicio, TimeSpan fin)
        {
            TimeSpan duracion = (fin - inicio);
            return duracion;
        }





        /*
        //Buscar Duracion Exposicion
        private static TimeSpan buscarDuracionExposicion(List<int> idExposiciones)
        {
            List<int> idObras = new List<int>();
            foreach (var i in idExposiciones) 
            {
                DataTable tabla = Datos.BuscarDetalleExpoidBD(i);
                idObras.Add(int.Parse(tabla.Rows[0][0].ToString()));
            }

            TimeSpan duracion = new TimeSpan();
            duracion.Equals(TimeSpan.Zero);
            foreach (var i in idObras)
            {
                DataTable tabla = Datos.BuscarObrasIdBD(i);
                duracion += TimeSpan.Parse(tabla.Rows[0][10].ToString());

            }

            return duracion;
        }
        */



        //Calcular sobrepaso capacidad maxima
        private static bool calcularSobrepasoCapMax(TimeSpan timespan1, TimeSpan timespan2)
        {
            bool resultado = true;
            if(timespan2 > timespan1)
            {
                resultado = false;
            }
            return resultado;
        }

        /*
        //Buscar reservas para fecha y hora
        private static bool buscarReservasParaFechaHora(int idSede, DateTime horaainicio, DateTime horafin)
        {
            bool res = true;
            DataTable tabla = Datos.BuuscarReservasXSede(idSede);
            for(var r = 0; r<tabla.Rows.Count; r++)
            {
               
                DateTime fecha = (DateTime)tabla.Rows[r][4];
                TimeSpan hie = (TimeSpan)tabla.Rows[r][5];
                TimeSpan hfe = (TimeSpan)tabla.Rows[r][6];




                int horaini = hie.Hours;
                int minutosini = hie.Minutes;
                int segundosini = hie.Seconds;

                int horasfin = hfe.Hours;
                int minutosfin = hfe.Minutes;
                int segundosfin = hfe.Seconds;

                int diaExpo = fecha.Day;
                int mesExpo = fecha.Month;
                int añoExpo = fecha.Year;

                DateTime horaInicioExpo = new DateTime(añoExpo, mesExpo, diaExpo, horaini, minutosini, segundosini);
                DateTime horaFinExpo = new DateTime(añoExpo, mesExpo, diaExpo, horasfin, minutosfin, segundosfin);

                int primero = DateTime.Compare(horaainicio, horaFinExpo);
                int segundo = DateTime.Compare(horafin, horaInicioExpo);

                
                if ((primero > 0 || primero < 0 && segundo < 0) == false)
                {
                    res = false;
                }
            }
            return res;
        }

        */
        /*
        //Cantidad maxima de visitantes en la sede
        private static int getCantMaxVisitantes(int idSede)
        {
            DataTable tabla = Datos.BuuscarSedeId(idSede);
            Sede sede = new Sede((int)tabla.Rows[0][0], tabla.Rows[0][1].ToString(), (int)tabla.Rows[0][2], (int)tabla.Rows[0][3], (TimeSpan)tabla.Rows[0][4], (TimeSpan)tabla.Rows[0][5]);
            int visitas = sede.getCantMaximaVisitantes();
            return visitas;
        }*/

        //Calcular guías
        private static int calcularCantGuiasNecesarios(int visitas, int sede)
        {
            DataTable tabla = Datos.BuuscarSedeId(sede);
            Sede sedeEsp = new Sede((int)tabla.Rows[0][0], tabla.Rows[0][1].ToString(), (int)tabla.Rows[0][2], (int)tabla.Rows[0][3], (TimeSpan)tabla.Rows[0][4], (TimeSpan)tabla.Rows[0][5]);

            int maxVisitas = sedeEsp.getCantMaximaVisitantes();
            int guiasXVisitas = sedeEsp.getCantMaximaGuias();
            int maxGuias = (maxVisitas / guiasXVisitas);
            int minGuias = (visitas / guiasXVisitas);
            return minGuias;
        }

        /*
        //Cantidad maxima de guias por sede
        private static int getCantMaxPorGuia(int idSede)
        {
            DataTable tabla = Datos.BuuscarSedeId(idSede);
            Sede sede = new Sede((int)tabla.Rows[0][0], tabla.Rows[0][1].ToString(), (int)tabla.Rows[0][2], (int)tabla.Rows[0][3], (TimeSpan)tabla.Rows[0][4], (TimeSpan)tabla.Rows[0][5]);
            int guias = sede.getCantMaximaGuias();
            return guias;
        }
        */

        //Buscar guias disponibles en la fecha(Que sea guia, que este disponible y devolver su id junto con su nombre y asignacion
        private static DataTable buscarGuiasDispFechaReserva(int idSede, DateTime fecha_reserva, TimeSpan horaInicio, TimeSpan Horafin)
        {
            DataTable tablaEmpleados = Datos.BuscarEmpleadoGuia(idSede);
            List<Empleado> empleados = tablaAEmpleado(tablaEmpleados);

            List<Empleado> guias = new List<Empleado>();

            foreach(var e in empleados)
            {
                if (e.getGuiaDispEnHorario(fecha_reserva, horaInicio, Horafin))
                {
                    guias.Add(e);
 
                }
            }

            DataTable tablaGuias = listaATabla(guias);
            return tablaGuias;



            /*
                        DataTable tablaAsignaciones = Datos.BuscarAsignacionEmpleado();
                        DataTable tablaHoraEmpleados = Datos.BuscarHorarioEmpleado();


                        List<HorarioEmpleado> horarios = tablaAHorario(tablaHoraEmpleados);
                        List<AsignacionVisita> visitas = tablaAAsignacion(tablaAsignaciones);

                        List<Empleado> guias = new List<Empleado>();

                        foreach (var e in empleados)
                        {
                            if (e.idCargo == 1)
                            {
                                foreach(var h in horarios)
                                {


                                    int dia = horaInicio.Day;
                                    int mes = horaInicio.Month;
                                    int año = horaInicio.Year;

                                    int shiem = h.horaInicio.Seconds;
                                    int mhiem = h.horaInicio.Minutes;
                                    int hhiem = h.horaInicio.Hours;
                                    int shfem = h.horaFin.Seconds;
                                    int mhfem = h.horaFin.Minutes;
                                    int hhfem = h.horaFin.Hours;

                                    DateTime horaInicioEmpleado = new DateTime(año, mes, dia, hhiem, mhiem, shiem);
                                    DateTime horafinEmpleado = new DateTime(año, mes, dia, hhfem, mhfem, shfem);

                                    if (e.id == h.idEmpleado && horaInicioEmpleado < horaInicio && horafinEmpleado > Horafin)
                                    {
                                        if(visitas.Count == 0)
                                        {
                                            guias.Add(e);
                                        }
                                        else
                                        {
                                            foreach (var a in visitas)
                                            {

                                                int shia = a.horainicio.Seconds;
                                                int mhia = a.horainicio.Minutes;
                                                int hhia = a.horainicio.Hours;
                                                int shfa = a.horafin.Seconds;
                                                int mhfa = a.horafin.Minutes;
                                                int hhfa = a.horafin.Hours;

                                                DateTime horaInicioAsignacion = new DateTime(año, mes, dia, hhia, mhia, shia);
                                                DateTime horafinAsignacion = new DateTime(año, mes, dia, hhfa, mhfa, shfa);

                                                if ((e.id == a.idEmpleado && (horaInicioAsignacion < Horafin | horafinAsignacion > horaInicio)) == false)
                                                {
                                                    guias.Add(e);
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        DataTable tablaGuias = listaATabla(guias);
                        return tablaGuias;
            */

        }

        //tomar-guias
        public static bool tomarGuias(List<int> idExpo, int idEscuela, int cantVisit, int idSede, int tipoVisita, DateTime fechaReserva, string horainicioReserva, string horafinReserva, List<int> idGuias)
        {
            DateTime fechaActual = tomarFechayHoraAct();
            int idReserva = (buscarUltimoNroReserva() + 1);
            TimeSpan dur = Sede.buscarDuracionExp(idExpo);
            bool res = RegistrarReserva(idReserva, idExpo, idEscuela, cantVisit, idSede, tipoVisita, fechaReserva, horainicioReserva, horafinReserva, fechaActual, idGuias, dur);
            return res;

        }

        public static DataTable gest_expoXobra(int idExpo)
        {
            return DetalleExposicion.expoXobra(idExpo);
            //N-Help: esperando a expo
        }

        public static int gest_cant_obrasXexpo(int idExpo)
        {
            return DetalleExposicion.cant_obrasXexpo(idExpo);
            //N-Help: esperando a expo
        }

        //Buscar ultimo id reserva
        private static int buscarUltimoNroReserva()
        {
            int id = Datos.buscarUltimoIdReserva();
            return id;
        }

        //Registrar Reserva
        private static bool RegistrarReserva(int idReserva, List<int> idExpo, int idEscuela, int cantVisit, int idSede, int tipoVisita, DateTime fechaReserva, string horainicioReserva, string horafinReserva, DateTime fechaActual, List<int> idGuias, TimeSpan dur)
        {
            
            bool res = Datos.AltaReserva(idReserva, tipoVisita + 1, idEscuela, fechaActual, fechaReserva, horainicioReserva, horafinReserva, cantVisit, idSede, idExpo, idGuias, dur);
            return res;
        }



//Funciones Auxiliares
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
                asignacion.Add(new AsignacionVisita((int)tabla.Rows[r][0], (int)tabla.Rows[r][1], (TimeSpan)tabla.Rows[r][2], (TimeSpan)tabla.Rows[r][3], (DateTime)tabla.Rows[r][4]));
            }
            return asignacion;
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
