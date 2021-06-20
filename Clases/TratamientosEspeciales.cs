using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DSI_3K2_PPAI.Clases;

namespace DSI_3K2_PPAI.Clases
{
    class TratamientosEspeciales
    {
        public enum Resultado { correcto, error }

        public Resultado Validar(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox001)item).Text == "")
                    {
                        MessageBox.Show(((TextBox001)item).Pp_MensajeError);
                        ((TextBox001)item).Focus();
                        return Resultado.error;
                    }
                }
                if (item.GetType().Name == "LabelText01")
                {
                    if (((LabelText01)item).Pp_Text == "")
                    {
                        MessageBox.Show(((LabelText01)item).Pp_mensajeError);
                        ((LabelText01)item).Focus();
                        return Resultado.error;
                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).SelectedIndex == -1)
                    {
                        MessageBox.Show(((ComboBox01)item).Pp_MensajeError);
                        ((ComboBox01)item).Focus();
                        return Resultado.error;
                    }
                }
            }
            return Resultado.correcto;
        }

        public string CostructorInsert(string NombreTabla, Control.ControlCollection controles)
        {
            string sql = "INSERT INTO " + NombreTabla + " (";
            string columna = "";
            string tipoDatoColumna = "";
            string valorColumna = "";
            string paqueteColumnas = "";
            string paqueteValores = "";
            DataTable Estructura = new DataTable();

            Estructura = BuscarEstructuraTabla(NombreTabla);

            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                columna = Estructura.Columns[i].Caption;
                tipoDatoColumna = Estructura.Columns[i].DataType.Name;
                valorColumna = BuscarColumnaEnControles(columna, controles);
                if (valorColumna != string.Empty)
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);

                    if (paqueteColumnas == "")
                    {
                        paqueteColumnas = columna;
                        paqueteValores = valorColumna;
                    }
                    else
                    {
                        paqueteColumnas += ", " + columna;
                        paqueteValores += ", " + valorColumna;
                    }
                }
            }

            sql += paqueteColumnas + ") VALUES (" + paqueteValores + ")";
            //MessageBox.Show(sql);
            return sql;
        }
        private DataTable BuscarEstructuraTabla(string NombreTabla)
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();
            return _BD.EjecutarSelect("SELECT TOP 1 * FROM " + NombreTabla);
        }
        private string BuscarColumnaEnControles(string campo, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox001)item).Pp_NombreCampo == campo)
                    {
                        return ((TextBox001)item).Text;
                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).Pp_NombreCampo == campo)
                    {
                        return ((ComboBox01)item).SelectedValue.ToString();
                    }
                }
            }
            return "";

        }
        private string FormatearDato(string valorColumna, string tipoDatoColumna)
        {
            switch (tipoDatoColumna)
            {
                case "String":
                    return "'" + valorColumna + "'";
                case "Int16":
                case "Int32":
                case "Int64":
                    return valorColumna;
                case "DateTime":
                    return "'" + valorColumna + "'";
                case "TIME":
                    return "'" + valorColumna + "'";
                default:
                    return valorColumna;
            }
        }

        public string RecuperarFecha()
        {
            BE_AccesoDatos _BD = new BE_AccesoDatos();
            return _BD.EjecutarSelect("select convert(char(10),getdate(),103)").Rows[0][0].ToString();
        }

        public Resultado ValidarFecha(string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return Resultado.correcto;
            }
            catch (Exception)
            {
                return Resultado.error;
            }
        }
        public Resultado ValidarNumero(string numero)
        {
            Int32 valor;
            if (Int32.TryParse(numero, out valor) == true)
                return Resultado.correcto;
            else
                return Resultado.error;
        }

    }
}

