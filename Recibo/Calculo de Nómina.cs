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
    public partial class GenerarRecibo : Form
    {
        EnlaceDB.EnlaceDB dB=new EnlaceDB.EnlaceDB();
        public GenerarRecibo()
        {
            InitializeComponent();
        }
        private void GenerarRecibo_Load(object sender, EventArgs e)
        {
            Dgv_Nominas.DataSource = dB.DataTable_MostrarNomina(1);
            CB_Mes.SelectedIndex = 0;
            CB_Year.SelectedIndex = 0;

        }
        private void Btn_CSV_Click(object sender, EventArgs e)
        {
            DataTable dt = dB.DataTable_MostrarNomina(1);//cambiar 
            Tools_z.CrearCsv(dt,"Nómina");
        }

        private void Btn_Calculo_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                bool correcto = false;
                correcto = dB.Calculo_de_Nomina(Tools_z.ConvertirStringFechas(CB_Year.Text, CB_Mes.Text));//checar lo de el procedure del calculo para poder lograr que solo meta la fecha de nomina 
                if (correcto)
                    MessageBox.Show("Calculo Realizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool Validaciones()
        {
            bool permiso = true;
            if (CB_Mes.Text == "" || CB_Year.Text == "")
            {
                permiso = false;
            }

            return permiso;
        }
       
    }
}
