using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI_3K2_PPAI.Pantallas.GestionarReserva
{
    public partial class FrmGestionarReserva : Form
    {
        public FrmGestionarReserva()
        {
            InitializeComponent();
        }

        private void btm_Agregar_Click(object sender, EventArgs e)
        {
            AgregarReserva reserva = new AgregarReserva();
            reserva.ShowDialog();
        }

        private void btm_buscar_Click(object sender, EventArgs e)
        {
                try
                {
                    dataGrid_Reserva.DataSource = ObtenerReservas();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener persona");
                }

            

        }


        private DataTable ObtenerReservas()
        {
            


            string cadenaconexion = "Data Source=DESKTOP-CCTL5C4\\SQLEXPRESS01;Initial Catalog=DSI_PPAI;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaconexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Reserva";


                cmd.Parameters.Clear();
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }




            
        }

        private void dataGrid_Reserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            btm_eliminar.Enabled = true;
            DataGridViewRow filaSeleccionada = dataGrid_Reserva.Rows[index];
            string documento = filaSeleccionada.Cells["Id_Reserva"].Value.ToString();
            
            Txt_ID.Text = documento;
            
        }

        private void btm_eliminar_Click(object sender, EventArgs e)
        {
            EliminarCampos(int.Parse(Txt_ID.Text));
        }

        private void EliminarCampos(int id)
        {
            

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Reserva WHERE id_reserva=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                

            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}

