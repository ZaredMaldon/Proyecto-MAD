using Proyecto_MAD.Empleados;
using Proyecto_MAD.Gerente;
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
using System.Text.RegularExpressions;

namespace Proyecto_MAD
{
    public partial class Login : Form
    {
        EnlaceDB.EnlaceDB query= new EnlaceDB.EnlaceDB();
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
            Regex rx = new Regex(@"^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{4,10}$");
            //Validaciones campos no vacios
            bool permiso = true;

            if (User_TB.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                permiso = false;
            }

            if (Password_TB.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                permiso = false;
            }
            if (CB_Tipo.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                permiso = false;
            }
            //Validaciones para textos
            //if (!rx.IsMatch(Password_TB.Text))
            //{
            //    MessageBox.Show("La contraseña debe contar con:\n-4 a 10 caracteres\n-Al menos un dígito\n-Al menos una Mayúscula\n-Al menos una minúscula\n-Al menos un caracter no alfanumérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    permiso = false;

            //}

            return permiso;
        }

        //boton entrar
        private void Login_btn_Click(object sender, EventArgs e)
        {
            bool permiso = true;


            permiso = validaciones();

           
            if(permiso)
            {
                //Login
                if (CB_Tipo.Text == "Gerente")
                {  
                    bool existencia = query.Autentificar(User_TB.Text, Password_TB.Text,1);
                    if (existencia)
                    {
                                              
                        InicioGerentes form = new InicioGerentes();

                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos\nIntente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }else if (CB_Tipo.Text == "Empleado")
                {
                    bool existencia = query.Autentificar(User_TB.Text, Password_TB.Text,2);
                    if (existencia)
                    {
                        
                        InicioEmpleados form = new InicioEmpleados();
               
                        form.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos\nIntente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void Password_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
