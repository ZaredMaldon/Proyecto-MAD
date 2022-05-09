using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MAD.Tools;

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
            db.Cargar_DatosDPTO_CB(2, CB_Dpto);
            
        }

        #region Botones
        private void Btn_AgregarPuesto_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                bool realizada = db.ControlPuestos(1, 0, TB_Nombre.Text, float.Parse(TB_NivelSalarial.Text), CB_Dpto.Text);
                if (realizada)
                {
                    MessageBox.Show("Registro Completado", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool Validaciones()
        {
            bool validaciones = true;

            if (TB_Nombre.Text == "" || TB_NivelSalarial.Text == "" || CB_Dpto.SelectedValue.ToString()=="")
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
                        bool realizada = db.ControlPuestos(3, 0, TB_Nombre.Text, float.Parse(TB_NivelSalarial.Text), CB_Dpto.Text);
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
        //cuando se presiona una tecla
        private void TB_NivelSalarial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) ||(e.KeyChar >=58 && e.KeyChar <= 255)|| (e.KeyChar ==47))
            {
                MessageBox.Show("Solo inserte numeros en Nivel salarial","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
          
        }

        private void TB_NivelSalarial_Leave(object sender, EventArgs e)
        {
            Lbl_Porcentaje.Text ="%"+ Tools_z.Porcentaje(TB_NivelSalarial.Text);
        }

        private void TB_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
           {
               MessageBox.Show("Ingrese solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               e.Handled = true;
               return;
           }       
        }
    }
}
