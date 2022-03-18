using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MAD.Empleados
{
    public partial class InicioEmpleados : Form
    {
        public InicioEmpleados()
        {
            InitializeComponent();
        }
        private void AbrirFormHija(object formhija)//ABRIR EN EL PANEL UNA PANTALLA
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
            {
                this.Panel_Contenedor.Controls.RemoveAt(0);
            }

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Contenedor.Controls.Add(fh);
            this.Panel_Contenedor.Tag = fh;
            fh.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Cerrar,Minimizar,Maximizar
        private void Salir_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que quieres cerrar?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        #region MenuEmpleados
        private void Inicio_Btn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Home());
        }
        private void DatosPer_Btn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new DatosPersonales());
        }
        private void Recibo_Btn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ConsultaRecibo());
        }
        #endregion


      

      
    }
}
