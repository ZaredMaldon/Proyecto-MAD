using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MAD.Tools;
using SpreadsheetLight;
using Proyecto_MAD.EnlaceDB;
using System.Data;
using System;

namespace Proyecto_MAD.Departamentos
{
    public partial class RegistroDeptos 
    {
        EnlaceDB.EnlaceDB db = new EnlaceDB.EnlaceDB();
        private bool use = false;
        private int id;

        public RegistroDeptos()
        {
            //InitializeComponent();
        }

        private void Deptos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.DataTable_MostrarDepartamentos(3);
            Dgv_Deptos.DataSource = dt;
        }


        private void Dgv_Deptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string aux = this.Dgv_Deptos.SelectedRows[0].Cells[0].Value.ToString();
            if (aux != "")
            {
                use = true;
                id = Convert.ToInt32(this.Dgv_Deptos.SelectedRows[0].Cells[0].Value);

            }
        }




    }
}


