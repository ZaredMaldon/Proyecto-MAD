using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MAD.DAO;


namespace Proyecto_MAD.Empleados
{
    public partial class CambiarContra : Form
    {
        EnlaceDB.EnlaceDB dB = new EnlaceDB.EnlaceDB();
        public CambiarContra()
        {
            InitializeComponent();
        }

        private void LBL_Mes_Click(object sender, EventArgs e)
        {

        }

        private void CB_Mes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TB_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Cambiar_Click(object sender, EventArgs e) // UPDATE A TABLA EMPLEADO SOLO US Y CONTRA
        {
            if (Validaciones())
            {
                bool realizacion = dB.ControldeEmpleados(6, DAO_GenerarRecibo.NoEmp, TB_Usuario.Text, TB_Password.Text);
                if (realizacion)
                    MessageBox.Show("Usuario modificado", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
              
        }

        private void CambiarContra_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {

            dB.Toma_Datos_Empleado(5, DAO_GenerarRecibo.NoEmp);
            //cargar los datos de Dao_Empleados

            TB_Usuario.Text = DAO_Empleado.Usuario;
            TB_Password.Text = DAO_Empleado.Contraseña;
            TB_Password2.Text = DAO_Empleado.Contraseña;

        }

        private bool Validaciones()
        {
            Regex pword = new Regex(@"^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{4,10}$");
            bool validaciones = true;
            if (!pword.IsMatch(TB_Password.Text))
            {
                MessageBox.Show("La contraseña debe contar con:\n-4 a 10 caracteres\n-Al menos un dígito\n-Al menos una Mayúscula\n-Al menos una minúscula\n-Al menos un caracter no alfanumérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;

            }

            if (TB_Password2.Text != TB_Password.Text)
            {
                MessageBox.Show("Las contrase;as deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones=false;
            }
            return validaciones;
        }

    }
}
