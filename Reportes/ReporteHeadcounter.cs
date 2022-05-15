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
    public partial class ReporteHeadcounter : Form
    {
        EnlaceDB.EnlaceDB dB=new EnlaceDB.EnlaceDB();
       
        public ReporteHeadcounter()
        {
            InitializeComponent();
        }

        private void ReporteHeadcounter_Load(object sender, EventArgs e)
        {
            DGV_Parte1.DataSource = dB.DataTable_ReporteHeadcounter(1, 0, 0, null);
            DGV_Parte2.DataSource= dB.DataTable_ReporteHeadcounter(5, 0, 0,null);
            dB.Cargar_DatosDPTO_CB(2, CB_Departamentos);
            CB_Departamentos.SelectedIndex=0;
            CB_Mes.SelectedIndex=0;
            CB_Year.SelectedIndex=0;

        }

        private void Btn_Filtrar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                Parte1();
                Parte2();
            }
        }

        private void Btn_Reinicio_Click(object sender, EventArgs e)
        {
            ReporteHeadcounter_Load(this, e);
        }

        private bool Validaciones()
        {
            bool validaciones = true;

            if (CB_Mes.Text == "" || CB_Year.Text == ""||CB_Departamentos.Text=="")
            {
                validaciones = false;
                MessageBox.Show("Un combo box no tiene un valor predefinido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return validaciones;
        }

        #region partes
        private void Parte1()
        {
            int mes = 0,anio=0;
            string Departamento = "";

            if (CB_Departamentos.SelectedIndex != 0)
            {
                Departamento = CB_Departamentos.Text;
            }
            else
            {
                Departamento = null;
            }



            if ((CB_Mes.SelectedIndex == 0 && CB_Year.SelectedIndex == 0) && Departamento==null)
            {
                mes = 0;
                anio = 0;
                DGV_Parte1.DataSource = dB.DataTable_ReporteHeadcounter(1, mes, anio, Departamento);
            }
            else
            {
                if (CB_Mes.SelectedIndex != 0 && CB_Year.SelectedIndex == 0)//solo mes
                {
                    mes = CB_Mes.SelectedIndex;
                    anio = 0;
                    if (Departamento == null)
                    {
                       
                        DGV_Parte1.DataSource = dB.DataTable_ReporteHeadcounter(10, mes, anio, Departamento);
                    }
                    else
                    {
                        
                        DGV_Parte1.DataSource = dB.DataTable_ReporteHeadcounter(3, mes, anio, Departamento);
                    }
                    
                }
                else if (CB_Mes.SelectedIndex == 0 && CB_Year.SelectedIndex != 0)//solo anio
                {
                    mes = 0;
                    anio = int.Parse(CB_Year.Text);
                    if (Departamento == null)
                    {
                        
                        DGV_Parte1.DataSource = dB.DataTable_ReporteHeadcounter(11, mes, anio, Departamento);
                    }
                    else
                    {
                        
                        DGV_Parte1.DataSource = dB.DataTable_ReporteHeadcounter(4, mes, anio, Departamento);
                    }
                }
                else if (CB_Mes.SelectedIndex != 0 && CB_Year.SelectedIndex != 0)//todos los datos para filtrar
                {
                    mes = CB_Mes.SelectedIndex;
                    anio = int.Parse(CB_Year.Text);

                    if (Departamento != null)
                    {
                        
                        DGV_Parte1.DataSource = dB.DataTable_ReporteHeadcounter(2, mes, anio, Departamento);
                    }
                    else
                    {
                        
                        DGV_Parte1.DataSource = dB.DataTable_ReporteHeadcounter(9, mes, anio, Departamento);
                    }
                }
            }
        }

        private void Parte2()
        {
            int mes = 0, anio = 0;
            string Departamento = "";

            if (CB_Departamentos.SelectedIndex != 0)
            {
                Departamento = CB_Departamentos.Text;
            }
            else
            {
                Departamento = null;
            }



            if ((CB_Mes.SelectedIndex == 0 && CB_Year.SelectedIndex == 0) && Departamento == null)
            {
                mes = 0;
                anio = 0;
                DGV_Parte2.DataSource = dB.DataTable_ReporteHeadcounter(5, mes, anio, Departamento);
            }
            else
            {
                if (CB_Mes.SelectedIndex != 0 && CB_Year.SelectedIndex == 0)//solo mes
                {
                    mes = CB_Mes.SelectedIndex;
                    anio = 0;
                    if (Departamento == null)
                    {

                        DGV_Parte2.DataSource = dB.DataTable_ReporteHeadcounter(13, mes, anio, Departamento);
                    }
                    else
                    {

                        DGV_Parte2.DataSource = dB.DataTable_ReporteHeadcounter(7, mes, anio, Departamento);
                    }

                }
                else if (CB_Mes.SelectedIndex == 0 && CB_Year.SelectedIndex != 0)//solo anio
                {
                    mes = 0;
                    anio = int.Parse(CB_Year.Text);
                    if (Departamento == null)
                    {

                        DGV_Parte2.DataSource = dB.DataTable_ReporteHeadcounter(14, mes, anio, Departamento);
                    }
                    else
                    {

                        DGV_Parte2.DataSource = dB.DataTable_ReporteHeadcounter(8, mes, anio, Departamento);
                    }
                }
                else if (CB_Mes.SelectedIndex != 0 && CB_Year.SelectedIndex != 0)//todos los datos para filtrar
                {
                    mes = CB_Mes.SelectedIndex;
                    anio = int.Parse(CB_Year.Text);

                    if (Departamento == null)
                    {

                        DGV_Parte2.DataSource = dB.DataTable_ReporteHeadcounter(12, mes, anio, Departamento);
                    }
                    else
                    {

                        DGV_Parte2.DataSource = dB.DataTable_ReporteHeadcounter(6, mes, anio, Departamento);
                    }
                }
            }
        }

        #endregion
    }
}
