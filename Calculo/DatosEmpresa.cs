using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MAD.DAO;


namespace Proyecto_MAD.Calculo
{
    public partial class DatosEmpresa : Form
    {

        EnlaceDB.EnlaceDB db = new EnlaceDB.EnlaceDB();
        private bool use = false;
        private int id;
        public DatosEmpresa()
        {
            InitializeComponent();
        }

        private void TB_Info_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatosEmpresa_Load(object sender, EventArgs e)
        {
            // cargar datos
           db.Toma_Datos_Empresa(1, id);
            TB_RazonSocial.Text= DAO_Empresa.RazonSocial;
            TB_Direccion.Text= DAO_Empresa.Direccion;
            TB_Email.Text = DAO_Empresa.email;
            TB_Telefono.Text = DAO_Empresa.Telefono.ToString();
            TB_RegistroPatronal.Text = DAO_Empresa.RegistroPatronal;
            TB_RFC.Text = DAO_Empresa.RFC.ToString();
            TB_Fecha.Text = DAO_Empresa.FechaIniOp.ToString();
            //comentario para commit
        }

        private void LBL_ApMat_Click(object sender, EventArgs e)
        {

        }
    }
}
