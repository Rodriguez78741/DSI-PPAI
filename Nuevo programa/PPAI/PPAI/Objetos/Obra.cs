﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Objetos
{
    class Obra
    {
        private int id_obra;
        private string nombre;
        private int alto;
        private int ancho;
        private int peso;
        private DateTime fecha_creacion;
        private DateTime fecha_ingreso;
        private int valuacion;
        private string descripcion;
        private int id_empleado;
        private TimeSpan duracion_expo_obra;

        public Obra(int id, string nombre, int alto, int ancho, int peso, DateTime fechaCreacion, DateTime fechaIngreso, int valuacion, string descripcion, int idEmpleado, TimeSpan dracionexob)
        {
            this.id_obra = id;
            this.nombre = nombre;
            this.alto = alto;
            this.ancho = ancho;
            this.peso = peso;
            this.fecha_creacion = fechaCreacion;
            this.fecha_ingreso = fechaIngreso;
            this.valuacion = valuacion;
            this.descripcion = descripcion;
            this.id_empleado = idEmpleado;
            this.duracion_expo_obra = dracionexob;

    }

    public int idObra
        {
            get => id_obra;
            set => id_obra = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public int Alto
        {
            get => alto;
            set => alto = value;
        }
        public int Ancho
        {
            get => ancho;
            set => ancho = value;
        }
        public int Peso
        {
            get => peso;
            set => peso = value;
        }
        public DateTime fechaCreacion
        {
            get => fecha_creacion;
            set => fecha_creacion = value;
        }
        public DateTime fechaIngreso
        {
            get => fecha_ingreso;
            set => fecha_ingreso = value;
        }
        public int Valuacion
        {
            get => valuacion;
            set => valuacion = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public int idEmpleado
        {
            get => id_empleado;
            set => id_empleado = value;
        }

        public TimeSpan duracionExpoObra
        {
            get => duracion_expo_obra;
            set => duracion_expo_obra = value;
        }
    }
}
