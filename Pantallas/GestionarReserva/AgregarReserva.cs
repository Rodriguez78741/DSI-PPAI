using System;
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
using System.Data.SqlClient;

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
            CargarComboEmpleados();
            CargarComboExpo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamientos = new TratamientosEspeciales();

            if (Tratamientos.Validar(this.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Reserva reserva = new NE_Reserva();
                //reserva.Insertar_Reserva(this.Controls);

                reserva.Pp_id_tipo_visita = comboBox011.SelectedValue.ToString();
                reserva.Pp_id_escuela = comboBox012.SelectedValue.ToString();
                reserva.Pp_fecha_reserva = textBox0011.Text;
                reserva.Pp_hora_inicio = textBox0012.Text;
                reserva.Pp_hora_fin = textBox0013.Text;
                reserva.Pp_hora_incio_real = textBox0014.Text;
                reserva.Pp_hora_fin_real = textBox0015.Text;
                reserva.Pp_cant_alumnos_confirm = textBox0016.Text;



                //generar lista empleados

                List<int>ListaEmpleados = new List<int>();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    ListaEmpleados.Add(int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                }





                //generar lista exposiciones
                List<int> listaExpo = new List<int>();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    listaExpo.Add(int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()));
                }




                reserva.Insertar_Reserva(listaExpo, ListaEmpleados);

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }



        private void CargarComboEmpleados()
        {


            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {

                
                cmbGuia.DataSource = NE_Reserva.ObtenerGuia();
                cmbGuia.DisplayMember = "nombre";
                cmbGuia.ValueMember = "id_empleado";
                cmbGuia.SelectedIndex = -1;


            }
            catch
            {
                throw;
            }

           
        }


        private void CargarComboExpo()
        {

            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {

                
                cmbExposicion.DataSource = NE_Reserva.ObtenerExpo();
                cmbExposicion.DisplayMember = "nombre";
                cmbExposicion.ValueMember = "id_expo";
                cmbExposicion.SelectedIndex = -1;



            }
            catch
            {
                throw;
            }

        }

        private void btnAgregarGuia_Click(object sender, EventArgs e)
        {
            if(cmbGuia.SelectedValue.Equals(-1))
            {
                MessageBox.Show("Seleccione un guia");
            }
            else
            {
                dataGridView1.Rows.Add(cmbGuia.SelectedValue, txtNombreEmpleado.Text, txtApellidoEmpleado.Text);

            }

        }

        private void btnAgregarExposicion_Click(object sender, EventArgs e)
        {
            if (cmbExposicion.SelectedValue.Equals(-1))
            {
                MessageBox.Show("Seleccione una exposicion");
            }
            else
            {
                dataGridView2.Rows.Add(cmbExposicion.SelectedValue,txtNombreExpo.Text,txtApellidoExpo.Text);

            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbGuia.SelectedValue.ToString());
            DataTable tabla = NE_Reserva.ObtenerGuiaEspecifica(id);

            txtNombreEmpleado.Text = tabla.Rows[0][1].ToString();
            txtApellidoEmpleado.Text = tabla.Rows[0][2].ToString();
        }

        private void btnBuscarExposicion_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbExposicion.SelectedValue.ToString());
            DataTable tabla = NE_Reserva.ObtenerExpoEspecifica(id);

            txtNombreExpo.Text = tabla.Rows[0][1].ToString();
            txtApellidoExpo.Text = tabla.Rows[0][2].ToString();
        }
    }   

}

