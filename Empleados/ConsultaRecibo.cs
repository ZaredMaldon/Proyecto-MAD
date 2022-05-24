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
using Proyecto_MAD.Tools;

namespace Proyecto_MAD.Empleados
{
    public partial class ConsultaRecibo : Form
    {

        EnlaceDB.EnlaceDB db = new EnlaceDB.EnlaceDB();
        GeneracionRecibo R = new GeneracionRecibo();
        
        string fecha = "";
        bool use = false;

        public ConsultaRecibo()
        {
            InitializeComponent();
        }
        private void ConsultaRecibo_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.DataTable_MostrarNomina(2,DAO.DAO_GenerarRecibo.NoEmp);
            DGV_Recibos.DataSource = dt;

        }

        #region Botones

        private void Inicio_Btn_Click(object sender, EventArgs e)
        {

            if (use)
            {
                
                db.Toma_Datos_Empresa(1, 1);
                db.Toma_Datos_Recibo2(4, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina);
                db.Toma_Datos_Recibo(2, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina);//falta la toma de datos de percepciones
                string a = DAO.DAO_GenerarRecibo.SueldoBruto.Substring(1);
                float SueldoBruto=float.Parse(a);
                db.Toma_Datos_TotalPEDE(1, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina,SueldoBruto);//Percepciones
                db.Toma_Datos_TotalPEDE(2, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina,SueldoBruto);//Deducciones
                R.GenerarRecibo(db.Toma_Datos_Deducciones(2, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina),
                                db.Toma_Datos_Percepciones(1, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina));
            }
            else
            {
               MessageBox.Show("Seleccione un Recibo");
            }
           
            
        }
        private void btn_Ver_Click(object sender, EventArgs e)
        {
            if (use)
            {
                db.Toma_Datos_Empresa(1, 1);
                db.Toma_Datos_Recibo2(4, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina);
                db.Toma_Datos_Recibo(2, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina);
                string a = DAO.DAO_GenerarRecibo.SueldoBruto.Substring(1);
                float SueldoBruto = float.Parse(a);
                db.Toma_Datos_TotalPEDE(1, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina, SueldoBruto);//Percepciones
                db.Toma_Datos_TotalPEDE(2, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina, SueldoBruto);//Deducciones
                VistaPDF vistaPDF = new VistaPDF();
                vistaPDF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un Recibo");
            }
        }

        #endregion
        private void DGV_Recibos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DGV_Recibos.Rows.Count != 0)
            {
                Lbl_Seleccionado.Text=DGV_Recibos.SelectedCells[0].Value.ToString();
                fecha = DGV_Recibos.SelectedCells[3].Value.ToString();
                VistaPDF.FechaNomina = DateTime.Parse(fecha);
               
                if (fecha != "")
                {
                    use = true;
          
                }

            }

        }


      
    }
}
