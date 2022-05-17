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
using Proyecto_MAD.Tools;
using SpreadsheetLight;
//using System.Diagnostics;/*Es necesaria esta libreria para los procedimientos del explorador de archivos*/

namespace Proyecto_MAD.Percepciones_y_deducciones
{
    public partial class Percepciones : Form
    {
        EnlaceDB.EnlaceDB db = new EnlaceDB.EnlaceDB();
        private bool use = false;
        private int id;
       
        public Percepciones()
        {
            InitializeComponent();
        }

        private void Percepciones_Load(object sender, EventArgs e)
        {
            CHB_Porcentaje_CheckedChanged(this,e);
            DataTable dt = new DataTable();
            dt=db.DataTable_MostrarPercep(3);
            Dgv_Percepciones.DataSource=dt;
        }

        #region Botones

        private void btn_CargarExcel_Click(object sender, EventArgs e)//seleccionar archivo para cargar
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hoja de cálculo de Microsoft Excel|*.xlsx";
            openFileDialog.InitialDirectory = @"H:\Escuela documentos\semestre 6\MAD\proyecto\Proyecto MAD\Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int registro = 0;
                string direccion=openFileDialog.FileName;//obtienes el nombre del archivo 

                //Process process = new Process();/*Sirve si quieres abrir algun archivo*/
                //process.StartInfo.FileName = direccion;
                //process.Start();

                //Aqui debe estar la funcion para agregar masivamente
                SLDocument sL=new SLDocument(direccion);
                SLWorksheetStatistics propiedades=sL.GetWorksheetStatistics();
                int ultimaFila = propiedades.EndRowIndex;
                int Cantidad = ultimaFila + 1;//se le suma uno porque es sin contar el encabezado

                //recorre todos las filas del excel hasta el final
                for(int i = 2; i <= ultimaFila; i++)
                {
                    float Bn=0, Bpor=0;
                    string nombre = sL.GetCellValueAsString("A" + i);
                    string Bono   = sL.GetCellValueAsString("B" + i);
                    string BPorc  = sL.GetCellValueAsString("C" + i);
                    if (Bono != "" && BPorc != "")
                    {
                        Bn = float.Parse(Bono);
                        Bpor = float.Parse(BPorc);
                    }
                    bool realizado=db.ControldePercepciones(1, 0, nombre,Bn,Bpor);
                    if (realizado)
                        registro++;
                }

                MessageBox.Show("Registro de " +registro+"percepciones completado con exito\nFaltantes: "+(Cantidad-registro)+" percepciones", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void Btn_AgregarPercepcion_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                bool realizada=db.ControldePercepciones(1, 0, TB_Nombre.Text, float.Parse(TB_Bono.Text), float.Parse(TB_Porcentaje.Text));
                if (realizada)
                {
                    MessageBox.Show("Registro Completado", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            
        }

        private void Btn_EliminarPercepcion_Click(object sender, EventArgs e)
        {
            if (!use)
            {
                MessageBox.Show("Seleccione primero una Percepción de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dR = MessageBox.Show("¿Esta seguro de eliminar a esta Percepción?\n Al eliminarlo no podrá recuperar los datos de este por ningun medio", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    bool realizada = db.ControldePercepciones(2, id);
                    if (realizada)
                    {
                        MessageBox.Show("Se ha eliminado la Percepción correctamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
               
            }
        }

        #endregion
        private bool Validaciones()
        {
            bool validaciones = true;

            if(TB_Nombre.Text == "" || TB_Bono.Text == "" || TB_Porcentaje.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }

            return validaciones;
        }

        private void Dgv_Percepciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string aux = this.Dgv_Percepciones.SelectedRows[0].Cells[0].Value.ToString();
            if (aux != "")
            {
                use = true;
                id = Convert.ToInt32(this.Dgv_Percepciones.SelectedRows[0].Cells[0].Value);

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

        private void CHB_Porcentaje_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_Porcentaje.Checked == true)
            { 
                lbl_signo.Text = "%";
                TB_Porcentaje.Visible = true;
                Lbl_Porcentaje.Visible = true;

                Lbl_Bono.Visible = false;
                TB_Bono.Text = "";
                TB_Bono.Visible = false;

                TB_Porcentaje.Location = new System.Drawing.Point(269, 91);
                Lbl_Porcentaje.Location = new System.Drawing.Point(292, 75);
            }
            else
            {
                lbl_signo.Text = "$";
                TB_Porcentaje.Visible = false;
                Lbl_Porcentaje.Visible = false;

                Lbl_Bono.Visible = true;
                TB_Porcentaje.Text = "";
                TB_Bono.Visible = true;
            }
        }
    }
}
