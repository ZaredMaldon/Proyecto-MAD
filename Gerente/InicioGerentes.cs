using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MAD.Recibo;

namespace Proyecto_MAD.Gerente
{
    public partial class InicioGerentes : Form
    {
        public InicioGerentes()
        {
            InitializeComponent();
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

        private void AbrirFormHija(object formhija)//ABRIR EN EL PANEL UNA PANTALLA
        {
            if (this.Panel_Conten.Controls.Count > 0)
            {
                this.Panel_Conten.Controls.RemoveAt(0);
            }

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Conten.Controls.Add(fh);
            this.Panel_Conten.Tag = fh;
            fh.Show();
        }

        private void InicioGerentes_Load(object sender, EventArgs e)
        {
            Btn_Inicio_Click(null,e);
        }

        #region BotonesMenu
        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Empresa());
        }
        private void Btn_Asignación_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new PEDE_Empleado());
        }
        private void Btn_Reportes_Click_1(object sender, EventArgs e)
        {
            Panel_submenu.Visible = !Panel_submenu.Visible;
        }
        private void Btn_Empleados_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new GestionEmpleado());
        }

        private void Btn_Recibo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Recibo.GenerarRecibo());
        }




        #endregion

        #region Reportes
        private void Btn_RGeneral_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Reportes.ReporteGeneral());
        }
        private void Btn_RHeadcounter_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Reportes.ReporteHeadcounter());
        }

        private void Btn_Nómina_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Reportes.ReporteNómina());
        }




        #endregion

        private void Btn_Desconectar_Click(object sender, EventArgs e)
        {
            Login form = new Login();

            form.Show();
            this.Close();
        }

       
    }
}
