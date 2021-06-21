using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_3K2_PPAI.Pantallas;
using DSI_3K2_PPAI.Negocio;

namespace DSI_3K2_PPAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombreUsu.Text == "")
            {
                MessageBox.Show("El campo de usuario esta vacio");
            }
            if (txtPass.Text == "") 
            {
                MessageBox.Show("El campo de usuario esta vacio");
            }
            
                //validacion con sql
            NE_Usuarios users = new NE_Usuarios();
            if (users.Validar_user(txtNombreUsu.Text, txtPass.Text) == NE_Usuarios.Respuesta.validacion_correcta)
            {
               this.Close();
               this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Intento de acceso sin exito: " + "\nNombre de usuario o contraseña incorrectos",
                "ERROR DE USUARIO",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
                //this.Close();
                //this.DialogResult = DialogResult.OK;
           
            Principal inicio = new Principal();
            inicio.ShowDialog();
        }
    }
}
