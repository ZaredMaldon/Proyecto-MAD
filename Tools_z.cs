using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAD.Tools
{
    public class Tools_z
    {
        public static DateTime ConvertirStringFechas(string anio, string mes)
        {
            string fecha="01"+mes+anio;
            CultureInfo info = new CultureInfo("es-MX");
            DateTime Fecha=DateTime.Parse(fecha,info);

            return Fecha;
        }
        public static DateTime ConvertirStringFechas(string fecha)
        {
            CultureInfo info = new CultureInfo("es-MX");
            DateTime Fecha = DateTime.Parse(fecha, info);

            return Fecha;
        }
    }
}
