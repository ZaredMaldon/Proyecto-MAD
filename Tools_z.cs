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

        //Sirve para cambiar un decimal a un porcentaje (ej. .8 a %80
        public static string Porcentaje(string numero)
        {
            string porcentaje = "";

            if (numero == "."||numero=="")
            {
                MessageBox.Show("Envie un número en Nivel salarial", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                float res = float.Parse(numero) * 100;
                string val1 = res.ToString();
                int ciclos = 0, band = 0, length = val1.Length;
                bool punto = false,inicio0=false;
                //encontrar le punto
                while (band <= length)
                {
                    if (numero.Contains('.'))
                    {
                        punto = true;
                        if (numero[band] == '.')
                        {

                            band = length + 1;
                        }
                        else
                        {
                            if (numero[0] == '0')
                            {
                                inicio0 = true;
                                band = length + 1;
                            }
                            else
                            {
                                band++;
                                ciclos++;
                            }
                           
                        }
                    }
                    else band = length + 1;


                }
                if (!inicio0)
                {
                    if (!punto)
                        porcentaje = val1;
                    else
                    {
                        int a = length - (ciclos + 5);

                        if (a < -1)
                            porcentaje = val1.Substring(0, ciclos + 2);
                        else if (a == -1)
                            porcentaje = val1.Substring(0, ciclos + 4);
                        else
                            porcentaje = val1.Substring(0, ciclos + 5);
                    }

                }
                else
                {
                    if (!punto)
                        porcentaje = val1;
                    else
                    {
                        int a = length - (ciclos + 4);

                        if (a < -1)
                            porcentaje = val1.Substring(0, ciclos + 2);
                        else if (a == -1)
                            porcentaje = val1.Substring(0, ciclos + 4);
                        else
                            porcentaje = val1.Substring(0, ciclos + 5);
                    }
                }
                
            }
            
            

            return porcentaje;
        }


    }
}
