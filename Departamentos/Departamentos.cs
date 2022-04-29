using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MAD.Calculo
{
    public partial class Departamentos : Form
    {
        EnlaceDB.EnlaceDB db = new EnlaceDB.EnlaceDB();
        private bool use = false;
        private int id;


        public Departamentos()
        {
            InitializeComponent();
        }
        private void Departamentos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.DataTable_MostrarPercep(3);
            Dgv_Deptos.DataSource = dt;
        }

        #region Botones
        private void Btn_AgregarDpto_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ModificarDpto_Click(object sender, EventArgs e)
        {

        }

        private void Btn_EliminarDpto_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void Dgv_Deptos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
