using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI_3K2_PPAI.Clases
{
    public partial class TextBox001 : TextBox
    {
        public string Pp_NombreCampo { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }
        public string Pp_NombreTabla { get; set; }
    }
}
