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
        private void LBL_Mes_Click(object sender, EventArgs e)
        {

        }

        private void CB_Mes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_Btn_Click(object sender, EventArgs e)
        {

            if (use)
            {
                db.Toma_Datos_Empresa(1, 1);
                //db.Toma_Datos_Deducciones(2,DAO.DAO_GenerarRecibo.NoEmp,Tools_z.ConvertirStringFechas(CB_Año.Text, CB_Mes.Text));
                db.Toma_Datos_Recibo2(4, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina);
                db.Toma_Datos_Recibo(2, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina);//falta la toma de datos de percepciones
                R.GenerarRecibo(db.Toma_Datos_Deducciones(2, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina),
                                db.Toma_Datos_Percepciones(1, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina));
            }
            else
            {
               MessageBox.Show("Seleccione un empleado");
            }
           
            
        }

        private void lbl_Año_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Recibos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DGV_Recibos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DGV_Recibos.Rows.Count != 0)
            {
                fecha = DGV_Recibos.SelectedCells[3].Value.ToString();
                VistaPDF.FechaNomina = DateTime.Parse(fecha);
               
                if (fecha != "")
                {
                    use = true;
                    //fecha = Convert.ToInt32(this.DGV_Recibos.SelectedRows[0].Cells[3].Value).ToString();  
                }

            }

        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {
            db.Toma_Datos_Empresa(1, 1);
            db.Toma_Datos_Recibo2(4, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina);
            db.Toma_Datos_Recibo(2, DAO.DAO_GenerarRecibo.NoEmp, VistaPDF.FechaNomina);
            VistaPDF vistaPDF = new VistaPDF();
            vistaPDF.ShowDialog();
        }
    }
}
