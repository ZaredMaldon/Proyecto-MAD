using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MAD.EnlaceDB;

namespace Proyecto_MAD.Reportes
{
    public partial class ReporteNómina : Form
    {
        EnlaceDB.EnlaceDB dB=new EnlaceDB.EnlaceDB();
        public ReporteNómina()
        {
            InitializeComponent();
        }

        private void ReporteNómina_Load(object sender, EventArgs e)
        {
            DGV_ReporteNomina.DataSource=dB.DataTable_ReporteNomina(0);
            CB_Year.SelectedIndex = 0;
        }
        private void Btn_Filtrar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                if (CB_Year.SelectedIndex==0)//no hay nada seleccionado
                {
                    DGV_ReporteNomina.DataSource = dB.DataTable_ReporteNomina(0);
                }
                else
                {
                    string texto= CB_Year.Text;
                    int anio=Convert.ToInt32(texto);
                    DGV_ReporteNomina.DataSource = dB.DataTable_ReporteNomina(anio);
                }
            }
        }

        private void Btn_Reinicio_Click(object sender, EventArgs e)
        {
            ReporteNómina_Load(this, e);
        }

        private bool Validaciones()
        {
            bool validaciones = true;
            if (CB_Year.Text == "")
            {
                MessageBox.Show("El combo box no tiene un valor predefinido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }
            return validaciones;
        }
    }
}
