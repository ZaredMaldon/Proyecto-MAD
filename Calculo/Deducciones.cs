using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MAD.Percepciones_y_deducciones
{
    public partial class Deducciones : Form
    {
        public Deducciones()
        {
            InitializeComponent();
        }

        private void Panel_Background_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBL_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void TB_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CargarExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hoja de cálculo de Microsoft Excel|*.xlsx";
            openFileDialog.InitialDirectory = @"H:\Escuela documentos\semestre 6\MAD\proyecto\Proyecto MAD\Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string direccion = openFileDialog.FileName;//obtienes el nombre del archivo 

                //Aqui debe estar la funcion para agregar masivamente

            }
        }
    }
}
