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
            dt = db.DataTable_MostrarDeptos(4);
            Dgv_Deptos.DataSource = dt;
        }

        #region Botones
        private void Btn_AgregarDpto_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                bool realizada = db.ControlDepto(1, 0, TB_Nombre.Text, int.Parse(TB_SueldoBase.Text));
                if (realizada)
                {
                    MessageBox.Show("Registro Completado", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private bool Validaciones()
        {
            bool validaciones = true;

            if (TB_Nombre.Text == "" || TB_SueldoBase.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }
            return validaciones;
        }

        private void Btn_ModificarDpto_Click(object sender, EventArgs e)
        {
        }

        private void Btn_EliminarDpto_Click(object sender, EventArgs e)
        {
            if (!use)
            {
                MessageBox.Show("Seleccione primero un Departamento de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dR = MessageBox.Show("¿Esta seguro de eliminar a este Departamento?\n Al eliminarlo no podrá recuperar los datos de este por ningun medio", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    bool realizada = db.ControlDeptos(2, id);
                    if (realizada)
                    {
                        MessageBox.Show("Se ha eliminado el Departamento correctamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
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

        private void TB_SueldoBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_SueldoBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo inserte numeros en Sueldo Base", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TB_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
           {
              MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              e.Handled = true;
              return;
           }
        }
    }
}
