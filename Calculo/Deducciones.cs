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
using SpreadsheetLight;
using Proyecto_MAD.EnlaceDB;

namespace Proyecto_MAD.Percepciones_y_deducciones
{
    public partial class Deducciones : Form
    {
        EnlaceDB.EnlaceDB db = new EnlaceDB.EnlaceDB();
        private bool use = false;
        private int id;
        public Deducciones()
        {
            InitializeComponent();
        }
        private void Deducciones_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.DataTable_MostrarDeduccion(3);
            Dgv_Deducciones.DataSource = dt;
        }

        #region Botones
        private void btn_CargarExcel_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hoja de cálculo de Microsoft Excel|*.xlsx";
            openFileDialog.InitialDirectory = @"H:\Escuela documentos\semestre 6\MAD\proyecto\Proyecto MAD\Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int registro = 0;
                string direccion = openFileDialog.FileName;//obtienes el nombre del archivo 

                //Process process = new Process();/*Sirve si quieres abrir algun archivo*/
                //process.StartInfo.FileName = direccion;
                //process.Start();

                //Aqui debe estar la funcion para agregar masivamente
                SLDocument sL = new SLDocument(direccion);
                SLWorksheetStatistics propiedades = sL.GetWorksheetStatistics();
                int ultimaFila = propiedades.EndRowIndex;
               

                //recorre todos las filas del excel hasta el final
                for (int i = 2; i <= ultimaFila; i++)
                {
                    float des = 0, Dpor = 0;
                    string nombre = sL.GetCellValueAsString("A" + i);         
                    string Descuento = sL.GetCellValueAsString("B" + i);
                    string DPorc = sL.GetCellValueAsString("C" + i);
                    if (Descuento != "" && DPorc != "")
                    {
                        des = float.Parse(Descuento);
                        Dpor = float.Parse(DPorc);
                    }
                    bool realizado = db.ControlDeducciones(1, 0, nombre, des, Dpor);
                    if (realizado)
                        registro++;
                }

                int Cantidad = ultimaFila + 1;//se le suma uno porque es sin contar el encabezado
                MessageBox.Show("Registro de " + registro + "deducciones completado con exito\nFaltantes: " + (Cantidad - registro) + " deducciones", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Btn_AgregarDeduccion_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                bool realizada = db.ControlDeducciones(1, 0, TB_Nombre.Text, float.Parse(TB_Descuento.Text), float.Parse(TB_Porcentaje.Text));
                if (realizada)
                {
                    MessageBox.Show("Registro Completado", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void Btn_EliminarDeduccion_Click(object sender, EventArgs e)
        {
            if (!use)
            {
                MessageBox.Show("Seleccione primero una Deducción de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dR = MessageBox.Show("¿Esta seguro de eliminar a esta Deducción?\n Al eliminarlo no podrá recuperar los datos de este por ningun medio", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    bool realizada = db.ControlDeducciones(2, id);
                    if (realizada)
                    {
                        MessageBox.Show("Se ha eliminado la Deducción correctamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
        }

        #endregion

        private bool Validaciones()
        {
            bool validaciones = true;

            if (TB_Nombre.Text == "" || TB_Descuento.Text == "" || TB_Porcentaje.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }


            return validaciones;
        }

        private void Dgv_Deducciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string aux = this.Dgv_Deducciones.SelectedRows[0].Cells[0].Value.ToString();
            if (aux != "")
            {
                use = true;
                id = Convert.ToInt32(this.Dgv_Deducciones.SelectedRows[0].Cells[0].Value);

            }
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
