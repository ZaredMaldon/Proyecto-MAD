using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Proyecto_MAD.Tools
{
    public class Tools_z
    {
        #region Convertir Fechas
        public static DateTime ConvertirStringFechas(string anio, string mes)
        {
            string fecha = "01" + mes + anio;
            CultureInfo info = new CultureInfo("es-MX");
            DateTime Fecha = DateTime.Parse(fecha, info);

            return Fecha;
        }
        public static DateTime ConvertirStringFechas(string fecha)
        {
            CultureInfo info = new CultureInfo("es-MX");
            DateTime Fecha = DateTime.Parse(fecha, info);

            return Fecha;
        }
        #endregion

        #region CSV
        public static void CrearCsv(DataTable datatable,string path) 
        {
            string separador = ",";
            string direccion = @"H:\Escuela documentos\semestre 6\MAD\proyecto\Proyecto MAD\Csv\" + path+".csv";//revisar direccion
            List<string> lineas = new List<string>(), columnas = new List<string>();

            foreach(DataColumn col in datatable.Columns)
            {
               columnas.Add(col.ColumnName);
            }

            lineas.Add(string.Join(separador, columnas));

            foreach(DataRow fila in datatable.Rows)
            {
                List<string> celdas=new List<string>();

                foreach (object celda in fila.ItemArray)
                    celdas.Add(celda.ToString());

                lineas.Add(string.Join(separador,celdas));

            }
            File.WriteAllLines(direccion, lineas);
            MessageBox.Show("Archivo " + path + ".csv ha sido creado");
            
        
        }

        #endregion

    }
}
