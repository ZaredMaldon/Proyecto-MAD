using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAD.DAO
{
    public class DAO_Empleado
    {
        public static int id { get; set; }
        public static string Nombre { get; set; }
        public static string ApPaterno { get; set; }
        public static string ApMaterno { get; set; }
        public static string CURP { get; set; }
        public static string NSS { get; set; }
        public static string RFC { get; set; }
        public static string email { get; set; }
        public static string municipio { get; set; }
        public static string puesto { get; set; }
        public static string departamento { get; set; }
        public static string Calle { get; set; }
        public static string Colonia { get; set; }
        public static string Cp { get; set; }
        public static short numExt { get; set; }
        public static short numInt { get; set; }
        public static DateTime Fecha_nacimiento { get; set; }
        public static DateTime Fecha_Contratacion { get; set; }
        public static string Telefono1 { get; set; }
        public static string Telefono2 { get; set; }
        public static string Banco { get; set; }
        public static int NoCuenta { get; set; }
        public static string Usuario { get; set; }
        public static string Contraseña { get; set; }
        public static decimal SalarioDiario { get; set; }

    }
}
