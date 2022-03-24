using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MAD.Gerente;


namespace Proyecto_MAD.Gerente
{
    public partial class Empresa : Form
    {
        InicioGerentes inicioGerentes = new InicioGerentes();
        public Empresa()
        {
            InitializeComponent();
        }
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
        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #region Menu
        private void Btn_Departamento_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Calculo.Departamentos());
        }

        private void Btn_Puesto_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Calculo.Puestos());
        }

        private void Btn_Deducciones_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Percepciones_y_deducciones.Deducciones());
        }

        private void Btn_Percepciones_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Percepciones_y_deducciones.Percepciones());
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Calculo.DatosEmpresa());
        }
        #endregion

        private void Empresa_Load(object sender, EventArgs e)
        {
            Btn_Home_Click(null, e);
        }

        
    }
}
