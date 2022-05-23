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

namespace Proyecto_MAD.Empleados
{
    public partial class Home : Form
    {
        EnlaceDB.EnlaceDB db = new EnlaceDB.EnlaceDB();
        public Home()
        {
            InitializeComponent();
        }

        private void LBL_Title_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            db.Toma_Datos_Empresa(1, 1);
            TB_RazonSocial.Text = DAO_Empresa.RazonSocial;
            TB_Direccion.Text = DAO_Empresa.Direccion;
            TB_Email.Text = DAO_Empresa.email;
            TB_Telefono.Text = "81" + DAO_Empresa.Telefono.ToString();
           
        }
    }
}
