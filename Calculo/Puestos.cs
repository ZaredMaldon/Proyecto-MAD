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
            dt = db.DataTable_MostrarPuestos(4);
            Dgv_Puestos.DataSource = dt;
        }

        #region Botones
        private void Btn_AgregarPuesto_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                bool realizada = db.ControlPuestos(1, 0, TB_Nombre.Text, int.Parse(TB_NivelSalarial.Text), float.Parse(TB_SalarioDiario.Text));
                if (realizada)
                {
                    MessageBox.Show("Registro Completado", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool Validaciones()
        {
            bool validaciones = true;

            if (TB_Nombre.Text == "" || TB_NivelSalarial.Text == "" || TB_SalarioDiario.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }
            return validaciones;
        }

        private void Btn_ModificarPuesto_Click(object sender, EventArgs e)
        {
            if (!use)
            {
                MessageBox.Show("Seleccione primero un Puesto de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dR = MessageBox.Show("¿Esta seguro de modificar a este Puesto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    if (Validaciones())
                    {
                        bool realizada = db.ControlPuestos(3, 0, TB_Nombre.Text, int.Parse(TB_NivelSalarial.Text), float.Parse(TB_SalarioDiario.Text));
                        if (realizada)
                        {
                            MessageBox.Show("Se ha modificado el Puesto correctamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }           
        }

        private void Btn_EliminarPuesto_Click(object sender, EventArgs e)
        {
            if (!use)
            {
                MessageBox.Show("Seleccione primero un Puesto de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dR = MessageBox.Show("¿Esta seguro de eliminar a este Puesto?\n Al eliminarlo no podrá recuperar los datos de este por ningun medio", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    bool realizada = db.ControlPuesto(2, id);
                    if (realizada)
                    {
                        MessageBox.Show("Se ha eliminado el Puesto correctamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
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
