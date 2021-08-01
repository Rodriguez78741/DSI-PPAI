﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    public class Exposicion
    {
        private int id_expo;
        private string nombre;
        private string descripcion;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private int id_tipo_expo;
        private int id_guia;
        private bool temporal;
        private int id_publico;
        private int id_sede;



        public Exposicion(int idExpo, string nombre, string descripcion, DateTime fechainicio, DateTime fechafin, int idTipoExpo, int idGuia, bool temporal, int idpublico, int idsede)
        {
            this.id_expo = idExpo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fecha_inicio = fechainicio;
            this.fecha_fin = fechafin;
            this.id_tipo_expo = idTipoExpo;
            this.id_guia = idGuia;
            this.temporal = temporal;
            this.id_publico = idpublico;
            this.id_sede = idsede;
    }

        public int idExposicion
        {
            get => id_expo;
            set => id_expo = value;
        }

        public string nombreExpo
        {
            get => nombre;
            set => nombre = value;
        }
        public string descripcionExpo
        {
            get => descripcion;
            set => descripcion = value;
        }
        public DateTime fechaInicio
        {
            get => fecha_inicio;
            set => fecha_inicio = value;
        }
        public DateTime FechaFin
        {
            get => fecha_fin;
            set => fecha_fin = value;
        }
        public int idTipoExpo
        {
            get => id_tipo_expo;
            set => id_tipo_expo = value;
        }
        public int idGuia
        {
            get => id_guia;
            set => id_guia = value;
        }

        public bool Temporal
        {
            get => temporal;
            set => temporal = value;
        }
        public int Publico
        {
            get => id_publico;
            set => id_publico = value;
        }
        public int Sede
        {
            get => id_sede;
            set => id_sede = value;
        }

    }
}