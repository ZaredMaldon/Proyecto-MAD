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
        private void PEDE_Empleado_Load(object sender, EventArgs e)
        {
            dB.Cargar_DatosDeduc_CB(5,Cb_Deducciones);
            dB.Cargar_DatosPercep_CB(4, Cb_Percepciones);
        }

        private void CB_Modo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a=CB_Modo.SelectedIndex;

            if(CB_Modo.SelectedIndex == 0)
            {

            }else if(CB_Modo.SelectedIndex == 1)//Departamento
            {

            }
        }
    }
}
