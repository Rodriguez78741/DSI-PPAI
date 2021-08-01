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

        //Tomar Opcion Registrar Reserva Visitas
        private void PantallaReservaVisita_Load(object sender, EventArgs e)
        {
            DataTable tabla = GestorReservaVisita.tomarRegReservaVisita();
            MostrarEscuela(tabla);
        }

        //Mostrar Escuela
        private void MostrarEscuela(DataTable tabla)
        {
            cmdEscuelas.DataSource = tabla;
            cmdEscuelas.DisplayMember = "Nombre";
            cmdEscuelas.ValueMember = "Id";
            cmdEscuelas.SelectedIndex = -1;   
        }

        //Tomar Seleccion de escuela
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
        
        private void tomarSeleccionEscuela()
        {
            int id = int.Parse(cmdEscuelas.SelectedValue.ToString());
            GestorReservaVisita.tomarEscuela();
        }

        //Solicitar Cantidad de visitantes
        private void solicitarCantidadVisitantes()
        {
            panelCantidadDeVisitantes.Visible = true;
            panelEscuelas.Enabled = false;
        }

        private void btnSeleccionarCantidad_Click(object sender, EventArgs e)
        {
            tomarCantidadVisitantes();
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
        private void btnSeleccionarSede_Click(object sender, EventArgs e)
        {
            tomarSelecSede();
            
        }

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
            DataTable tabla = GestorReservaVisita.TomarSede();

            cmdTipoVisita.DataSource = tabla;
            cmdTipoVisita.DisplayMember = "Nombre";
            cmdTipoVisita.ValueMember = "Id";
            cmdTipoVisita.SelectedIndex = -1;

            panelTipoVisitas.Visible = true;
            panelSedes.Enabled = false;
        }

        //Tomar Seleccion tipo visita
        private void btnSeleccionarTipoVisita_Click(object sender, EventArgs e)
        {
            tomarSelecTipoVisita();
        }

        private void tomarSelecTipoVisita()
        {
            if (cmdTipoVisita.Text == "")
            {
                MessageBox.Show("Ingrese TipoVisita");
            }
            else
            {
                int tipoVisita = int.Parse(cmdTipoVisita.SelectedValue.ToString());
               
                MostrarDatosExpoTempVig();                
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
        private void btnAgregarExpo_Click(object sender, EventArgs e)
        {
            if (txtIdExpo.Text == "")
            {
                MessageBox.Show("Falta informacion");
            }
            else
            {
                dataGridViewExpo.Rows.Add(txtIdExpo.Text, txtDetalle.Text, txtPublico.Text, txtTemporal.Text);
            }
        }

        private void btnBuscarExpo_Click(object sender, EventArgs e)
        {
            DataTable tabla = GestorReservaVisita.tomarTipoVisita(int.Parse(cmdSede.SelectedValue.ToString()));
            for(var c = 0; c<tabla.Rows.Count; c++)
            {
                if (tabla.Rows[c][0].ToString() == cmdExposicion.SelectedValue.ToString())
                {
                    txtIdExpo.Text = tabla.Rows[c][0].ToString();
                    txtDetalle.Text = tabla.Rows[c][3].ToString();
                    txtPublico.Text = tabla.Rows[c][2].ToString();
                    txtTemporal.Text = tabla.Rows[c][1].ToString();
                }
            }
        }

        private void btnSeleccionarExposicion_Click(object sender, EventArgs e)
        {
            tomarSelecExposicion();
            solicitarFechaHoraRes();
        }

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
        private void btnSeleccionarHorario_Click(object sender, EventArgs e)
        {
            tomarFechaHoraRes();
        }

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
        private void btnAgregarGuia_Click(object sender, EventArgs e)
        {
            if(txtIdGuia.Text == "")
            {
                MessageBox.Show("Informacion incompleta");
            }
            else
            {
                dataGridViewGuias.Rows.Add(txtIdGuia.Text, txtNombre.Text, txtApellido.Text, txtCuil.Text);
            }
        }

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

        private void btnAgregarReserva_Click(object sender, EventArgs e)
        {
            tomarSelecionGuias();
        }

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
            int tipoVisita = (int)cmdTipoVisita.SelectedValue;
            DateTime fechaReserva = new DateTime(int.Parse(txtAño.Text), int.Parse(txtMes.Text), int.Parse(txtDia.Text));
            string horainicioReserva = (txtHorarioInicio.Text);
            string horafinReserva = (txtHorarioFin.Text);

            GestorReservaVisita.tomarGuias(idExpo, idEscuela, cantVisit, idSede, tipoVisita, fechaReserva, horainicioReserva, horafinReserva, idGuias);
        }

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
    }
}
