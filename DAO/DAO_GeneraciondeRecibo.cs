using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAD.DAO
{
    internal class DAO_GeneraciondeRecibo
    {
       public static float SueldoBruto { get; set; }
        public static float SueldoNeto { get; set; }
        public static string Banco { get; set; }
        public static int NoCuenta { get; set; }
        public static DateTime FechaNomina { get; set; }

    }
}
