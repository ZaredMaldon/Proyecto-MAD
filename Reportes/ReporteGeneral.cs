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
    public partial class ReporteGeneral : Form
    {
        EnlaceDB.EnlaceDB dB=new EnlaceDB.EnlaceDB();
        public ReporteGeneral()
        {
            InitializeComponent();
        }

        private void ReporteGeneral_Load(object sender, EventArgs e)
        {
            CB_Mes.SelectedIndex=0;
            CB_Year.SelectedIndex=0;
            DGV_ReporteGeneralNoimina.DataSource = dB.DataTable_ReporteGeneralNomina(1,0,0);
        }

        private void Btn_Filtrar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                if (CB_Mes.SelectedIndex == 0 && CB_Year.SelectedIndex == 0)
                {
                    DGV_ReporteGeneralNoimina.DataSource = dB.DataTable_ReporteGeneralNomina(1, 0, 0);
                }
                else
                {
                    if (CB_Mes.SelectedIndex != 0 && CB_Year.SelectedIndex == 0)
                    {
                        int mes = CB_Mes.SelectedIndex;
                        DGV_ReporteGeneralNoimina.DataSource = dB.DataTable_ReporteGeneralNomina(2, mes, 0);
                    }
                    else if (CB_Mes.SelectedIndex == 0 && CB_Year.SelectedIndex != 0)
                    {
                        int year = int.Parse(CB_Year.Text);
                        DGV_ReporteGeneralNoimina.DataSource = dB.DataTable_ReporteGeneralNomina(3, 0, year);
                    }
                    else if (CB_Mes.SelectedIndex != 0 && CB_Year.SelectedIndex != 0)
                    {
                        int mes = CB_Mes.SelectedIndex;
                        int year = int.Parse(CB_Year.Text);
                        DGV_ReporteGeneralNoimina.DataSource = dB.DataTable_ReporteGeneralNomina(4, mes, year);
                    }
                }
            }
            
        }

        private bool Validaciones()
        {
            bool validaciones = true;

            if (CB_Mes.Text=="" || CB_Year.Text=="")
            {
                validaciones = false;
                MessageBox.Show("El combo box no tiene un valor predefinido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return validaciones;
        }

        private void Btn_Reinicio_Click(object sender, EventArgs e)
        {
            ReporteGeneral_Load(this, e);
        }
    }
}
