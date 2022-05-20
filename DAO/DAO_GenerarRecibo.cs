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
        public static string Periodo { get; set; }
        public static int NoNomina { get; set; }
        public static string SueldoBruto { get; set; }
        public static string SueldoNeto { get; set; }

        public static string SalarioDiario { get; set; }

        public static DateTime FechaNomina { get; set; }
        public static DateTime Contratacion { get; set; }

        public static int Dias {get;set;}

        //Empleado
        public static int NoEmp{ get; set; }
        public static string Nombre { get; set; }
        public static string NSS{ get; set; }
        public static string CURP{ get; set; }
        public static string RFCE{ get; set; }

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
