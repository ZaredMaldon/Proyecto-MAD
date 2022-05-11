using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MAD.Tools;
using Proyecto_MAD.EnlaceDB;

namespace Proyecto_MAD.Recibo
{
    public partial class PEDE_Empleado : Form
    {
        EnlaceDB.EnlaceDB dB=new EnlaceDB.EnlaceDB();
        public PEDE_Empleado()
        {
            InitializeComponent();
        }

        private void Btn_CSV_Click(object sender, EventArgs e)
        {
            DataTable dt = dB.DataTable_MostrarDeduccion(3);//cambiar 
            Tools_z.CrearCsv(dt,"nómina");
        }

        private void Cb_Deducciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
