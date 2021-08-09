using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Gestores;

namespace PPAI.Pantallas
{
    public partial class PantallaReservaVisita : Form
    {
        public PantallaReservaVisita()
        {
            InitializeComponent();
        }

//Pantalla

        //Tomar Opcion Registrar Reserva Visitas
        private void PantallaReservaVisita_Load(object sender, EventArgs e)
        {
            DataTable tabla = GestorReservaVisita.tomarRegReservaVisita();
            MostrarEscuela(tabla);
        }

        //Boton seleccionar escuela
        private void btnSeleccionarEscuela_Click(object sender, EventArgs e)
        {
            if (cmdEscuelas.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una escuela");
            }
            else
            {
                tomarSeleccionEscuela();
                solicitarCantidadVisitantes();
                cmdEscuelas.Enabled = false;
            }
        }

        //Boton seleccionar cantidad
        private void btnSeleccionarCantidad_Click(object sender, EventArgs e)
        {
            tomarCantidadVisitantes();
        }

        //Boton seleccionar sede
        private void btnSeleccionarSede_Click(object sender, EventArgs e)
        {
            tomarSelecSede();
        }

        //Boton seleccionar tipo visita
        private void btnSeleccionarTipoVisita_Click(object sender, EventArgs e)
        {
            tomarSelecTipoVisita();
        }

        //Boton agregar exposicion
        private void btnAgregarExpo_Click(object sender, EventArgs e)
        {
            if (txtIdExpo.Text == "")
            {
                MessageBox.Show("Falta informacion");
            }
            else
            {
                dataGridViewExpo.Rows.Add(txtIdExpo.Text, txtTipoExpo.Text, txtPublico.Text, txtDetalle.Text);
            }
        }

        //Boton buscar exposicion
        private void btnBuscarExpo_Click(object sender, EventArgs e)
        {
            DataTable tabla = GestorReservaVisita.tomarTipoVisita(int.Parse(cmdSede.SelectedValue.ToString()));
            for (var c = 0; c < tabla.Rows.Count; c++)
            {
                if (tabla.Rows[c][0].ToString() == cmdExposicion.SelectedValue.ToString())
                {
                    txtIdExpo.Text = tabla.Rows[c][0].ToString();
                    txtDetalle.Text = tabla.Rows[c][3].ToString();
                    txtPublico.Text = tabla.Rows[c][2].ToString();
                    txtTipoExpo.Text = tabla.Rows[c][1].ToString();
                }
            }
        }

        //Boton seleccionar Exposicion
        private void btnSeleccionarExposicion_Click(object sender, EventArgs e)
        {
            tomarSelecExposicion();
            solicitarFechaHoraRes();
        }

        //Boton seleccionar horario
        private void btnSeleccionarHorario_Click(object sender, EventArgs e)
        {
            tomarFechaHoraRes();
        }

        //Boton Agregar guia
        private void btnAgregarGuia_Click(object sender, EventArgs e)
        {
            if (txtIdGuia.Text == "")
            {
                MessageBox.Show("Informacion incompleta");
            }
            else
            {
                dataGridViewGuias.Rows.Add(txtIdGuia.Text, txtNombre.Text, txtApellido.Text, txtCuil.Text);
            }
        }

        //Boton buscar guia
        private void btnBuscarGuia_Click(object sender, EventArgs e)
        {
            DataTable tabla = dataSet1.Tables[0];
            for (var c = 0; c < tabla.Rows.Count; c++)
            {
                if (tabla.Rows[c][0].ToString() == cmdGuia.SelectedValue.ToString())
                {
                    txtIdGuia.Text = tabla.Rows[c][0].ToString();
                    txtNombre.Text = tabla.Rows[c][1].ToString();
                    txtApellido.Text = tabla.Rows[c][2].ToString();
                    txtCuil.Text = tabla.Rows[c][3].ToString();
                }
            }

        }

        //Boton agregar reserva
        private void btnAgregarReserva_Click(object sender, EventArgs e)
        {
            tomarSelecionGuias();
        }



//Funciones programa

        //Mostrar Escuela
        private void MostrarEscuela(DataTable tabla)
        {
            cmdEscuelas.DataSource = tabla;
            cmdEscuelas.DisplayMember = "Nombre";
            cmdEscuelas.ValueMember = "Id";
            cmdEscuelas.SelectedIndex = -1;   
        }

        //Tomar Seleccion de escuela              
        private void tomarSeleccionEscuela()
        {
            int id = int.Parse(cmdEscuelas.SelectedValue.ToString());
            GestorReservaVisita.tomarEscuela(id);
        }

        //Solicitar Cantidad de visitantes
        private void solicitarCantidadVisitantes()
        {
            panelCantidadDeVisitantes.Visible = true;
            panelEscuelas.Enabled = false;
        }


        //Tomar Cantidad de Visitantes
        private void tomarCantidadVisitantes()
        {
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese cantidad de visitantes");
            }
            else
            {
                int cantidad = int.Parse(txtCantidad.Text);
                MostrarSedes();               
            }           
        }

        //Mostrar sedes
        private void MostrarSedes()
        {
            DataTable tabla = GestorReservaVisita.tomarCantidadVisitantes();

            cmdSede.DataSource = tabla;
            cmdSede.DisplayMember = "Nombre";
            cmdSede.ValueMember = "Id";
            cmdSede.SelectedIndex = -1;

            panelSedes.Visible = true;
            panelCantidadDeVisitantes.Enabled = false;

        }

        //Tomar Seleccion de Sede
        private int tomarSelecSede()
        {
            if (cmdSede.Text == "")
            {
                MessageBox.Show("Ingrese Sede");
            }
            else
            {
                int sede = int.Parse(cmdSede.SelectedValue.ToString());
                MostrarTiposVisita();
                return sede;        
            }
            return 0;
        }

        //Mostrar Tipo Visita
        private void MostrarTiposVisita()
        {

            cmdTipoVisita.SelectedIndex = -1;

            panelTipoVisitas.Visible = true;
            panelSedes.Enabled = false;
        }

        //Tomar Seleccion tipo visita
        private void tomarSelecTipoVisita()
        {
            //Si no selecciona nada genera un error para que seleccione un tipo de visita
            if (cmdTipoVisita.Text == "")
            {
                MessageBox.Show("Ingrese TipoVisita");
            }

            //En el caso de que si seleccione, se verifica si es general o particular.
            else
            {
                int tipoVisita = cmdTipoVisita.SelectedIndex;
                //Si es general se seleccionaría todas las exposiciones
                if (tipoVisita == 0)
                {
                    //N-Help: Esperando a que exposiciones siga
                }
                //Si es particular, ingresa a la interfaz para que seleccione las exposiciones que quiere ver
                else
                {
                    MostrarDatosExpoTempVig();
                }
            }
        }

        //Mostrar datos Exposicion
         private void MostrarDatosExpoTempVig()
        {
            DataTable tabla = GestorReservaVisita.tomarTipoVisita(int.Parse(cmdSede.SelectedValue.ToString()));
            cmdExposicion.DataSource = tabla;
            cmdExposicion.DisplayMember = "Detalle";
            cmdExposicion.ValueMember = "Id";
            cmdExposicion.SelectedIndex = -1;

            panelTipoVisitas.Enabled = false;
            panelExposicion.Visible = true;           
        }

       
        //Tomar Selecion de Exposicion
        private List<int> tomarSelecExposicion()
        {
            List<int> idExposiciones = new List<int>();

            for (int i = 0; i < dataGridViewExpo.Rows.Count; i++)
            {
                idExposiciones.Add(int.Parse(dataGridViewExpo.Rows[i].Cells[0].Value.ToString()));
            }

            return idExposiciones;
        }
        
        //solicitar Fecha y Hora Respectiva
        private void solicitarFechaHoraRes()
        {
            panelExposicion.Enabled = false;
            panelFechaYHora.Visible = true;
        }

        //Tomar fecha y hora respectiva
        private void tomarFechaHoraRes()
        {
            DateTime hi = DateTime.Parse(txtHorarioInicio.Text);
            DateTime hf = DateTime.Parse(txtHorarioFin.Text);

            int segundoi = hi.Second;
            int minutoi = hi.Minute;
            int horai = hi.Hour;
            int segundof = hf.Second;
            int minutof = hf.Minute;
            int horaf = hf.Hour;
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int año = int.Parse(txtAño.Text);
            

            DateTime horaInicio = new DateTime(año, mes, dia, horai, minutoi, segundoi);
            DateTime horaFin = new DateTime(año, mes, dia, horaf, minutof, segundof);

            List<int> Exposiciones = tomarSelecExposicion();
            int idSede = tomarSelecSede2();
            int cantVisitas = int.Parse(txtCantidad.Text);
            
            (bool, int, DataTable) tupla = GestorReservaVisita.tomarFechaHoraRes(horaInicio, horaFin, Exposiciones, idSede, cantVisitas);
            if (tupla.Item1)
            {
                panelFechaYHora.Enabled = false;
                panelGuias.Enabled = true;
                labelCant.Text = "minimo: " + tupla.Item2.ToString();
                cmdGuia.DataSource = tupla.Item3;
                dataSet1.Tables.Add(tupla.Item3);
                cmdGuia.DisplayMember = "Nombre";
                cmdGuia.ValueMember = "Id";
                cmdGuia.SelectedValue = -1;
                panelGuias.Visible = true;

            }
            else
            {
                MessageBox.Show("Imposible registrar ese horario");
            }
        }

        //Tomar Seleccion guias
        private void tomarSelecionGuias()
        {
            List<int> idGuias = new List<int>();

            for (int i = 0; i < dataGridViewGuias.Rows.Count; i++)
            {
                idGuias.Add(int.Parse(dataGridViewGuias.Rows[i].Cells[0].Value.ToString()));
            }

            List<int> idExpo = tomarSelecExposicion();
            int idEscuela = (int)cmdEscuelas.SelectedValue;
            int cantVisit = int.Parse(txtCantidad.Text);
            int idSede = (int)cmdSede.SelectedValue;
            int tipoVisita = (int)cmdTipoVisita.SelectedIndex;
            DateTime fechaReserva = new DateTime(int.Parse(txtAño.Text), int.Parse(txtMes.Text), int.Parse(txtDia.Text));
            string horainicioReserva = (txtHorarioInicio.Text);
            string horafinReserva = (txtHorarioFin.Text);

            GestorReservaVisita.tomarGuias(idExpo, idEscuela, cantVisit, idSede, tipoVisita, fechaReserva, horainicioReserva, horafinReserva, idGuias);
            MessageBox.Show("Reserva agregada con exito");
            this.Close();
        }



//Funciones Auxiliares

        //Seleccion de sede desde pantalla
        private int tomarSelecSede2()
        {
            if (cmdSede.Text == "")
            {
                MessageBox.Show("Ingrese Sede");
            }
            else
            {
                int sede = int.Parse(cmdSede.SelectedValue.ToString());
                return sede;
            }
            return 0;
        }

        private void cmdTipoVisita_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
