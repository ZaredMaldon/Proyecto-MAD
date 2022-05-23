using Proyecto_MAD.DAO;
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

namespace Proyecto_MAD.Empleados
{
    public partial class DatosPersonales : Form
    {
        EnlaceDB.EnlaceDB dB = new EnlaceDB.EnlaceDB();
        public DatosPersonales()
        {
            InitializeComponent();
        }
        private void DatosPersonales_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private bool Validaciones()
        {
            //regex de contraseña
            Regex pword = new Regex(@"^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{4,10}$");
            Regex email = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$");
            //regex de Curp
            //regex de Nss
            //regex de RFC
            //regex de numero de cuenta
            //regex de usuario

            bool validaciones = true;

            if ((TB_Nombre.Text == "") || (TB_ApPat.Text == "") || (TB_CURP.Text == "") || (TB_NSS.Text == "") || (TB_RFC.Text == "") || (TB_Email.Text == "") || (TB_Telefono.Text == "")
                || (TB_NoExt.Text == "") || (TB_Colonia.Text == "") || (TB_Calle.Text == "") || (TB_Banco.Text == "") || (TB_NoCuenta.Text == "") )
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }
            if (CB_Municipio.Text == "" )
            {
                MessageBox.Show("Falta seleccionar opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }

           

            if (!email.IsMatch(TB_Email.Text))
            {
                MessageBox.Show("El dato ingresado no es un EMAIL\nFavor de ingresar un email...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;

            }

            return validaciones;
        }

        #region keypress
        private void TB_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }



        private void TB_ApPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TB_ApMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TB_NSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo inserte numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TB_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo inserte numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TB_Telefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo inserte numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TB_NoExt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_NoExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo inserte numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TB_Banco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TB_NoCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo inserte numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion

        private void CargarDatos()
        {

            dB.Toma_Datos_Empleado(5,DAO_GenerarRecibo.NoEmp);
            //cargar los datos de Dao_Empleados
            TB_NoEmpleado.Text = DAO_GenerarRecibo.NoEmp.ToString();
            TB_Nombre.Text = DAO_Empleado.Nombre;
            TB_ApPat.Text = DAO_Empleado.ApPaterno;
            TB_ApMat.Text = DAO_Empleado.ApMaterno;
            TB_CURP.Text = DAO_Empleado.CURP;
            TB_NSS.Text = DAO_Empleado.NSS;
            TB_RFC.Text = DAO_Empleado.RFC;
            TB_Email.Text = DAO_Empleado.email;
            CB_Municipio.Text = DAO_Empleado.municipio;
            TB_Puesto.Text = DAO_Empleado.puesto;
            TB_Departamento.Text = DAO_Empleado.departamento;
            TB_Calle.Text = DAO_Empleado.Calle;
            TB_Colonia.Text = DAO_Empleado.Colonia;
            TB_CP.Text = DAO_Empleado.Cp;
            TB_NoExt.Text = DAO_Empleado.numExt.ToString();
            TB_NoInt.Text = DAO_Empleado.numInt.ToString();
            DTP_FechaNacimiento.Value = DAO_Empleado.Fecha_nacimiento.Date;       
            TB_Telefono.Text = DAO_Empleado.Telefono1;
            TB_Telefono2.Text = DAO_Empleado.Telefono2;
            TB_Banco.Text = DAO_Empleado.Banco;
            TB_NoCuenta.Text = DAO_Empleado.NoCuenta.ToString();
       

        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            int Opc = 7;
            bool realizacion = false;
            if (TB_Telefono2.Text == "" || TB_NoInt.Text == "")//si alguno de los dos datos no esta
            {
                
                
                if (TB_Telefono2.Text == "" && TB_NoInt.Text == "")
                {
                    realizacion = dB.ControldeEmpleados(Opc, TB_Nombre.Text, TB_ApPat.Text, TB_ApMat.Text, DTP_FechaNacimiento.Value, TB_CURP.Text, TB_NSS.Text, TB_RFC.Text, TB_Email.Text, TB_Telefono.Text,TB_Banco.Text, int.Parse(TB_NoCuenta.Text),
                        "Empleado", CB_Municipio.SelectedIndex, TB_CP.Text, TB_Colonia.Text, TB_Calle.Text, short.Parse(TB_NoExt.Text),
                        DAO_GenerarRecibo.NoEmp);

                }
                else if (TB_Telefono2.Text == "")
                {
                    realizacion = dB.ControldeEmpleados(Opc, TB_Nombre.Text, TB_ApPat.Text, TB_ApMat.Text, DTP_FechaNacimiento.Value, TB_CURP.Text, TB_NSS.Text, TB_RFC.Text, TB_Email.Text, TB_Telefono.Text,
                        TB_Banco.Text, int.Parse(TB_NoCuenta.Text),  "Empleado", CB_Municipio.SelectedIndex, TB_CP.Text, TB_Colonia.Text, TB_Calle.Text, short.Parse(TB_NoInt.Text), short.Parse(TB_NoExt.Text),
                        DAO_GenerarRecibo.NoEmp);

                }
                else if (TB_NoInt.Text == "")
                {
                    realizacion = dB.ControldeEmpleados(Opc, TB_Nombre.Text, TB_ApPat.Text, TB_ApMat.Text, DTP_FechaNacimiento.Value, TB_CURP.Text, TB_NSS.Text, TB_RFC.Text, TB_Email.Text, TB_Telefono.Text, TB_Telefono2.Text,
                        TB_Banco.Text, int.Parse(TB_NoCuenta.Text), "Empleado", CB_Municipio.SelectedIndex, TB_CP.Text, TB_Colonia.Text, TB_Calle.Text, short.Parse(TB_NoExt.Text),
                        DAO_GenerarRecibo.NoEmp);
                }
            }
            else//Si estan todos los datos
            {
                realizacion = dB.ControldeEmpleados(Opc, TB_Nombre.Text, TB_ApPat.Text, TB_ApMat.Text, DTP_FechaNacimiento.Value, TB_CURP.Text, TB_NSS.Text, TB_RFC.Text, TB_Email.Text, TB_Telefono.Text, TB_Telefono2.Text, TB_Banco.Text, int.Parse(TB_NoCuenta.Text),
                    "Empleado", CB_Municipio.SelectedIndex, TB_CP.Text, TB_Colonia.Text, TB_Calle.Text, short.Parse(TB_NoInt.Text), short.Parse(TB_NoExt.Text),
                    DAO_GenerarRecibo.NoEmp);

            }
            if (realizacion)
            {
                MessageBox.Show("Modificación Realizada con exito", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
