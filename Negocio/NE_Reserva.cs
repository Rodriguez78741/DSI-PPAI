using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_3K2_PPAI.Clases;
using System.Windows.Forms;

namespace DSI_3K2_PPAI.Negocio
{
    class NE_Reserva
    {
        BE_AccesoDatos _BD = new BE_AccesoDatos();



        public void Insertar_Reserva(Control.ControlCollection controles)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            _BD.Insertar(tratamientos.CostructorInsert("Reserva", controles));

        }

    }
}
