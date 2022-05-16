using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAD.DAO
{
    class DAO_GenerarRecibo
    {
        //Nomina
        public static float SueldoBruto { get; set; }
        public static float SueldoNeto { get; set; }
        public static string Banco { get; set; }
        public static int NoCuenta { get; set; }
        public static DateTime FechaNomina { get; set; }

        //Empleado

        public static int IdEmp{ get; set; }
        public static string Nombre { get; set; }
        public static int NSS{ get; set; }
        public static int CURP{ get; set; }
        public static int RFCE{ get; set; }
        public static int NoEmp{ get; set; }

        //PuestoDepartamento
        public static string NombrePuesto{ get; set; }
        public static string NombreDepto{ get; set; }


        //Empresa
        public static int RFCEm{ get; set; }
        public static int RegistroPatronal{ get; set; }

        //PER Y DED
        public static int idPer{ get; set; }
        public static string NombrePer{ get; set; }
        public static int idDed{ get; set; }
        public static string Nombreded{ get; set; }





    }
}
