using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MAD;

namespace Proyecto_MAD.Empleados
{
    public partial class ConsultaRecibo : Form
    {

        EnlaceDB.EnlaceDB db = new EnlaceDB.EnlaceDB();
        GeneracionRecibo R = new GeneracionRecibo();

        public ConsultaRecibo()
        {
            InitializeComponent();
        }

        private void LBL_Mes_Click(object sender, EventArgs e)
        {

        }

        private void CB_Mes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_Btn_Click(object sender, EventArgs e)
        {
            db.Toma_Datos_Empresa(1, 1);
            db.Toma_Datos_Recibo(2, DAO.DAO_GenerarRecibo.NoEmp);
            R.GenerarRecibo();
            //VistaPDF vistaPDF=new VistaPDF();
            //vistaPDF.ShowDialog();
        }
       
    }
}
