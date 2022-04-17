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

namespace Proyecto_MAD.Gerente
{
    public partial class GestionEmpleado : Form
    {
        EnlaceDB.EnlaceDB dB=new EnlaceDB.EnlaceDB();
        DataTable dt = new DataTable();
        public GestionEmpleado()
        {
            InitializeComponent();
        }
        private void GestionEmpleado_Load(object sender, EventArgs e)
        {
            //llenar Data grid view
            dt=dB.DataTable_MostrarEmpleado(4);
            Dgv_GestionEmpleados.DataSource=dt;

            //cargar combobox municipio
            dB.Cargar_DatosMuni_CB(1,CB_Municipio);
        }
        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
           
           bool realizacion= dB.ControldeEmpleados(1,TB_Nombre.Text,TB_ApPat.Text, TB_ApMat.Text,DTP_FechaNacimiento.Value, TB_CURP.Text, TB_NSS.Text, TB_RFC.Text, TB_Email.Text,int.Parse(TB_Telefono.Text),int.Parse(TB_Telefono2.Text),DTP_Contratacion.Value, float.Parse("57.85"),TB_Banco.Text,int.Parse(TB_NoCuenta.Text), TB_Usuario.Text, TB_Password.Text,"Empleado",1/*Este es el municipio,despues lo inserto*/, TB_Cp.Text,TB_Colonia.Text,TB_Calle.Text, short.Parse(TB_NoInt.Text), short.Parse(TB_NoExt.Text));

            if (realizacion)
            {
                MessageBox.Show("RegistroCompletado", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

        }
        private bool Validaciones()
        {
            //regex de contraseña
            Regex rx = new Regex(@"^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{4,10}$");
            //regex de Curp
            //regex de Nss
            //regex de RFC
            //regex de Email
            //regex de numero de cuenta
            //regex de usuario

            bool validaciones = true;

            if ((TB_Nombre.Text=="")&&(TB_ApPat.Text=="")&&(TB_CURP.Text=="")&&(TB_NSS.Text=="")&&(TB_RFC.Text=="")&&(TB_Email.Text=="")&&(TB_Telefono.Text=="")
                &&(TB_NoExt.Text=="")&&(TB_Colonia.Text=="")&&(TB_Calle.Text=="")&&(TB_Banco.Text=="")&&(TB_NoCuenta.Text=="")
                &&(TB_Usuario.Text=="")&&(TB_Password.Text=="")&&(Tb_Password2.Text==""))
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }
            if (CB_Dpto.SelectedItem == null && CB_Municipio.SelectedItem == null && CB_Puesto.SelectedItem == null)
            {
                MessageBox.Show("Falta seleccionar opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }

            if (!rx.IsMatch(TB_Password.Text))
            {
                MessageBox.Show("La contraseña debe contar con:\n-4 a 10 caracteres\n-Al menos un dígito\n-Al menos una Mayúscula\n-Al menos una minúscula\n-Al menos un caracter no alfanumérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;

            }

            if (Tb_Password2.Text!=TB_Password.Text)
            {
                MessageBox.Show("Las contrase;as deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return validaciones;
        }

        
    }
}
