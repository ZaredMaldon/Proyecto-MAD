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
using Proyecto_MAD.DAO;

namespace Proyecto_MAD.Gerente
{
    public partial class GestionEmpleado : Form
    {
        EnlaceDB.EnlaceDB dB=new EnlaceDB.EnlaceDB();
        DataTable dt = new DataTable();
        private int idEmp,cambiado=0;
        private bool use = false;
        
        public GestionEmpleado()
        {
            InitializeComponent();
        }
        //cuando inicia la pantalla
        private void GestionEmpleado_Load(object sender, EventArgs e)
        {
            //llenar Data grid view
            dt=dB.DataTable_MostrarEmpleado(4);
            Dgv_GestionEmpleados.DataSource=dt;

            //cargar combobox
            dB.Cargar_DatosMuni_CB(1,CB_Municipio);
            dB.Cargar_DatosDPTO_CB(2, CB_Dpto);
        }

        #region Botones
        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            //se necesita arreglar que no se pueda insertar dos veces el mismo empleado(rfc,nss,curp,node cuenta)
            if (Validaciones())
            {
                //inserta
                AgregarModificar(1,1);
            }
          
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            
            if (!use)
            {
                MessageBox.Show("Seleccione primero un Empleado de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dB.Toma_Datos_Empleado(5, idEmp);
                if (Validaciones())
                {
                    //modifica
                    AgregarModificar(2,2);
                }

            }
            
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (!use)
            {
                MessageBox.Show("Seleccione primero un Empleado de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dR = MessageBox.Show("¿Esta seguro de eliminar a este empleado?\n Al eliminarlo no podrá recuperar los datos de este por ningun medio", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                   //Aqui va la de eliminar
                   dB.ControldeEmpleados(3, idEmp);
                   MessageBox.Show("Empleado No."+ idEmp+" Eliminado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }
        #endregion
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

            if ((TB_Nombre.Text=="")||(TB_ApPat.Text=="")||(TB_CURP.Text=="")||(TB_NSS.Text=="")||(TB_RFC.Text=="")||(TB_Email.Text=="")||(TB_Telefono.Text=="")
                ||(TB_NoExt.Text=="")||(TB_Colonia.Text=="")||(TB_Calle.Text=="")||(TB_Banco.Text=="")||(TB_NoCuenta.Text=="")
                ||(TB_Usuario.Text=="")||(TB_Password.Text=="")||(Tb_Password2.Text==""))
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }
            if (CB_Dpto.Text == "" || CB_Municipio.Text == "" || CB_Puesto.Text=="")
            {
                MessageBox.Show("Falta seleccionar opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }

            if (!pword.IsMatch(TB_Password.Text))
            {
                MessageBox.Show("La contraseña debe contar con:\n-4 a 10 caracteres\n-Al menos un dígito\n-Al menos una Mayúscula\n-Al menos una minúscula\n-Al menos un caracter no alfanumérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;

            }

            if (Tb_Password2.Text!=TB_Password.Text)
            {
                MessageBox.Show("Las contrase;as deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!email.IsMatch(TB_Email.Text))
            {
                MessageBox.Show("El dato ingresado no es un EMAIL\nFavor de ingresar un email...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;

            }

            return validaciones;
        }

        private void AgregarModificar(int Opc,int message)
        {
            bool realizacion = true;

            if (TB_Telefono2.Text == "" || TB_NoInt.Text == "")//si alguno de los dos datos no esta
            {
                if (TB_Telefono2.Text == "" && TB_NoInt.Text == "")
                {
                    realizacion = dB.ControldeEmpleados(Opc, TB_Nombre.Text, TB_ApPat.Text, TB_ApMat.Text, DTP_FechaNacimiento.Value, TB_CURP.Text, TB_NSS.Text, TB_RFC.Text, TB_Email.Text, TB_Telefono.Text, DTP_Contratacion.Value, TB_Banco.Text, int.Parse(TB_NoCuenta.Text),
                        TB_Usuario.Text, TB_Password.Text, "Empleado", CB_Municipio.SelectedIndex, TB_Cp.Text, TB_Colonia.Text, TB_Calle.Text, short.Parse(TB_NoExt.Text),
                        idEmp, CB_Dpto.Text, CB_Puesto.Text);

                }
                else if (TB_Telefono2.Text == "")
                {
                    realizacion = dB.ControldeEmpleados(Opc, TB_Nombre.Text, TB_ApPat.Text, TB_ApMat.Text, DTP_FechaNacimiento.Value, TB_CURP.Text, TB_NSS.Text, TB_RFC.Text, TB_Email.Text, TB_Telefono.Text,
                        DTP_Contratacion.Value,TB_Banco.Text, int.Parse(TB_NoCuenta.Text), TB_Usuario.Text, TB_Password.Text, "Empleado", CB_Municipio.SelectedIndex, TB_Cp.Text, TB_Colonia.Text, TB_Calle.Text, short.Parse(TB_NoInt.Text), short.Parse(TB_NoExt.Text),
                        idEmp,CB_Dpto.Text, CB_Puesto.Text);

                }
                else if (TB_NoInt.Text == "")
                {
                    realizacion = dB.ControldeEmpleados(Opc, TB_Nombre.Text, TB_ApPat.Text, TB_ApMat.Text, DTP_FechaNacimiento.Value, TB_CURP.Text, TB_NSS.Text, TB_RFC.Text, TB_Email.Text, TB_Telefono.Text, TB_Telefono2.Text, DTP_Contratacion.Value,
                        TB_Banco.Text, int.Parse(TB_NoCuenta.Text), TB_Usuario.Text, TB_Password.Text, "Empleado", CB_Municipio.SelectedIndex, TB_Cp.Text, TB_Colonia.Text, TB_Calle.Text, short.Parse(TB_NoExt.Text),
                        idEmp, CB_Dpto.Text, CB_Puesto.Text);
                }
            }
            else//Si estan todos los datos
            {
                realizacion = dB.ControldeEmpleados(Opc, TB_Nombre.Text, TB_ApPat.Text, TB_ApMat.Text, DTP_FechaNacimiento.Value, TB_CURP.Text, TB_NSS.Text, TB_RFC.Text, TB_Email.Text, TB_Telefono.Text, TB_Telefono2.Text, DTP_Contratacion.Value,TB_Banco.Text, int.Parse(TB_NoCuenta.Text),
                    TB_Usuario.Text, TB_Password.Text, "Empleado", CB_Municipio.SelectedIndex, TB_Cp.Text, TB_Colonia.Text, TB_Calle.Text, short.Parse(TB_NoInt.Text), short.Parse(TB_NoExt.Text),
                    idEmp, CB_Dpto.Text, CB_Puesto.Text);

            }


            if (realizacion)
            {
                if (message == 1)
                {
                    MessageBox.Show("Registro Completado", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Modificación Realizada con exito", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        //Consigue idEmpleado de row seleccionado
        private void Dgv_GestionEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string aux = this.Dgv_GestionEmpleados.SelectedRows[0].Cells[0].Value.ToString();
            if (aux != "")
            {
                cambiado = 1;
                use = true;
                idEmp = Convert.ToInt32(this.Dgv_GestionEmpleados.SelectedRows[0].Cells[0].Value);
                DialogResult dR=MessageBox.Show("¿Quieres cargar los datos de este empleado?", "Cuestionamiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dR == DialogResult.Yes)
                {
                    CargarDatos();
                    cambiado=0;

                }
              
            }
        }

        private void CargarDatos()
        {
           
            dB.Toma_Datos_Empleado(5,idEmp);
            //cargar los datos de Dao_Empleados
           
                TB_Nombre.Text = DAO_Empleado.Nombre;
                TB_ApPat.Text = DAO_Empleado.ApPaterno;
                TB_ApMat.Text = DAO_Empleado.ApMaterno;
                TB_CURP.Text = DAO_Empleado.CURP;
                TB_NSS.Text = DAO_Empleado.NSS;
                TB_RFC.Text = DAO_Empleado.RFC;
                TB_Email.Text = DAO_Empleado.email;
                CB_Municipio.Text = DAO_Empleado.municipio;
                CB_Puesto.Text = DAO_Empleado.puesto;
                CB_Dpto.Text = DAO_Empleado.departamento;
                TB_Calle.Text = DAO_Empleado.Calle;
                TB_Colonia.Text = DAO_Empleado.Colonia;
                TB_Cp.Text = DAO_Empleado.Cp;
                TB_NoExt.Text = DAO_Empleado.numExt.ToString();
                TB_NoInt.Text = DAO_Empleado.numInt.ToString();
                DTP_FechaNacimiento.Value = DAO_Empleado.Fecha_nacimiento.Date;
                DTP_Contratacion.Value = DAO_Empleado.Fecha_Contratacion;
                TB_Telefono.Text = DAO_Empleado.Telefono1;
                TB_Telefono2.Text = DAO_Empleado.Telefono2;
                TB_Banco.Text = DAO_Empleado.Banco;
                TB_NoCuenta.Text = DAO_Empleado.NoCuenta.ToString();
                TB_Usuario.Text = DAO_Empleado.Usuario;
                TB_Password.Text = DAO_Empleado.Contraseña;
                Tb_Password2.Text = DAO_Empleado.Contraseña;
            
        }

        #region KeyPress
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

        private void TB_Colonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void TB_NSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo inserte numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TB_NoInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                MessageBox.Show("Solo inserte numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TB_Cp_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion

        private void CB_Dpto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cambiado==0)
            dB.Cargar_DatosPUESTOS_CB(3, CB_Dpto.Text, CB_Puesto);
        }
    }
}
