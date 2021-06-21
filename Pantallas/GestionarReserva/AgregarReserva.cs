﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_3K2_PPAI.Negocio;
using DSI_3K2_PPAI.Clases;

namespace DSI_3K2_PPAI.Pantallas.GestionarReserva
{
    public partial class AgregarReserva : Form
    {
        public AgregarReserva()
        {
            InitializeComponent();
        }

        private void AgregarReserva_Load(object sender, EventArgs e)
        {
            comboBox011.CargarCombo();
            comboBox012.CargarCombo();
            comboBox013.CargarCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamientos = new TratamientosEspeciales();

            if (Tratamientos.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Reserva reserva = new NE_Reserva();
                reserva.Insertar_Reserva(this.Controls);


                this.Close();

            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}