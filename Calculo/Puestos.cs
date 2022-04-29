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
    public partial class Puestos : Form
    {

        EnlaceDB.EnlaceDB db = new EnlaceDB.EnlaceDB();
        private bool use = false;
        private int id;

        public Puestos()
        {
            InitializeComponent();
        }
        private void Puestos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.DataTable_MostrarPercep(3);
            Dgv_Puestos.DataSource = dt;
        }

        #region Botones
        private void Btn_AgregarPuesto_Click(object sender, EventArgs e)
        {
            bool realizada = db.ControlPuesto(1, 0, TB_Nombre.Text, float.Parse(TB_Bono.Text));
        }

        private void Btn_ModificarPuesto_Click(object sender, EventArgs e)
        {

        }

        private void Btn_EliminarPuesto_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void Dgv_Puestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string aux = this.Dgv_Puestos.SelectedRows[0].Cells[0].Value.ToString();
            if (aux != "")
            {
                use = true;
                id = Convert.ToInt32(this.Dgv_Puestos.SelectedRows[0].Cells[0].Value);

            }
        }
    }
}
