using Proyecto_MAD.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MAD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Salir_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que quieres cerrar?","Salir",MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            User_TB.Text = "Usuario";
            Password_TB.Text = "Contraseña";
        }

        private bool validaciones()
        {
            bool permiso = true;

            if (User_TB.Text == "")
            {
                permiso = false;
            }

            if (Password_TB.Text == "")
            {
                permiso = false;
            }
            

            return permiso;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            bool permiso = true;

            permiso = validaciones();

            if (!permiso)
            {
                MessageBox.Show("Llene todos los campos","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                //Abre la ventana
                InicioEmpleados form = new InicioEmpleados();
                form.Show();
                this.Hide();
                

            }
        }

        private void Password_TB_TextChanged(object sender, EventArgs e)
        {

        }
        //private bool AlgoritmoContraseñaSegura(string password)
        //{
        //    bool mayuscula = false, minuscula = false, numero = false, carespecial = false;

        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        if (Char.IsUpper(password, i))
        //        {
        //            mayuscula = true;
        //        }
        //        else if (Char.IsLower(password, i))
        //        {
        //            minuscula = true;
        //        }
        //        else if (Char.IsDigit(password, i))
        //        {
        //            numero = true;
        //        }
        //        else
        //        {
        //            carespecial = true;
        //        }
        //    }
        //    if (mayuscula && minuscula && numero && carespecial && password.Length >= 8)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Su contraseña necesita:\n-Mínimo 8 caracteres\n-Al menos una letra minuscula\n-Al menos una letra mayúscula\n-Al menos un número\n-Al menos un caracter especial","Contraseña insegura",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        //        return false;
        //    }

        //}
    }
}
