using PPAI.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class Sede
    {
        private int id_sede;
        private string nombre_sede;
        private int cant_max_visit;
        private int cant_max_guias;
        private TimeSpan horario_desde;
        private TimeSpan horario_hasta;
        
        public Sede(int idSede, string nombreSede, int cant_max_visit, int cant_max_guias, TimeSpan horarioDesde, TimeSpan horarioHasta)
        {
            this.id_sede = idSede;
            this.nombre_sede = nombreSede;
            this.cant_max_guias = cant_max_guias;
            this.cant_max_visit = cant_max_visit;
            this.horarioDesde = horarioDesde;
            this.HorarioHasta = horarioHasta;
        }

        public int idsede
        {
            get => id_sede;
            set => id_sede = value;
        }

        public string nombresede
        {
            get => nombre_sede;
            set => nombre_sede = value;
        }
        public int maxVisitas
        {
            get => cant_max_visit;
            set => cant_max_visit = value;
        }
        public int maxGuias
        {
            get => cant_max_guias;
            set => cant_max_guias = value;
        }
        public TimeSpan horarioDesde
        {
            get => horario_desde;
            set => horario_desde = value;
        }
        public TimeSpan HorarioHasta
        {
            get => horario_hasta;
            set => horario_hasta = value;
        }

        public string mostrarNombre()
        {
            string nombr = this.nombresede;
            return nombr;
        }

        public static DataTable buscarExposiciones(List<Exposicion> Expo)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add(new DataColumn("Id", typeof(int)));
            tabla.Columns.Add(new DataColumn("Tipo", typeof(string)));
            tabla.Columns.Add(new DataColumn("Publico", typeof(string)));
            tabla.Columns.Add(new DataColumn("Detalle", typeof(string)));

            foreach (var e in Expo)
            {
                (int, string, string, string) tupla = e.getTempVigentes();
                tabla.Rows.Add(tupla.Item1, tupla.Item2, tupla.Item3, tupla.Item4);
            }
                       
           return tabla;
        }

        public static TimeSpan buscarDuracionExp(List<int> Expo)
        {
            TimeSpan duracion = new TimeSpan();
            duracion.Equals(TimeSpan.Zero);
            foreach(var i in Expo)
            {
                DataTable tabla = Datos.BuscarExpoid(i);
                Exposicion expos = new Exposicion((int)tabla.Rows[0][0], tabla.Rows[0][1].ToString(), tabla.Rows[0][2].ToString(), (DateTime)tabla.Rows[0][3], (DateTime)tabla.Rows[0][4], (int)tabla.Rows[0][5], (int)tabla.Rows[0][6], (int)tabla.Rows[0][7], (int)tabla.Rows[0][8], (bool)tabla.Rows[0][9]);
                TimeSpan durac = expos.buscarDurExtendidaObras();
                duracion += durac;
            }
           
            return duracion;
            
        }

        public static bool buscarReservasParaFechaHora(int idSede, DateTime horaainicio, DateTime horafin, int cantAl)
        {
            DataTable tabla = Datos.BuuscarReservasXSede(idSede);
            List<ReservaVisita> reservas = new List<ReservaVisita>();
            DataTable sede = Datos.BuuscarSedeId(idSede);

            for (var r = 0; r < tabla.Rows.Count; r++)
            {
                ReservaVisita reserva = new ReservaVisita((int)tabla.Rows[r][0], (int)tabla.Rows[r][1], (int)tabla.Rows[r][2], (DateTime)tabla.Rows[r][3], (DateTime)tabla.Rows[r][4], (TimeSpan)tabla.Rows[r][5], (TimeSpan)tabla.Rows[r][6], (TimeSpan)tabla.Rows[r][7], (TimeSpan)tabla.Rows[r][8], (int)tabla.Rows[r][9], (int)tabla.Rows[r][10]);
                reservas.Add(reserva);
            }

            bool res = true;

            foreach (var r in reservas)
            {
                (DateTime, TimeSpan, TimeSpan) tupla = r.getFechaHoraReserva();
                            
                    DateTime fecha = tupla.Item1;
                    TimeSpan hie = tupla.Item2;
                    TimeSpan hfe = tupla.Item3;

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
                    //cantidad de personas en la sede al mismo tiempo
                    int max = (int)sede.Rows[0][2];
                    if(max < (r.cantAlumnos + cantAl))

                        res = false;
                    }                                
            }

            return res;

        }



        public int getCantMaximaVisitantes()
        {
            int cant = this.cant_max_visit;
            return cant;
        }

        public int getCantMaximaGuias()
        {
            int cant = this.cant_max_guias;
            return cant;
        }
    }
}
