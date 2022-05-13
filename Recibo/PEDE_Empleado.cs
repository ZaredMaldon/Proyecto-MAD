using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MAD.Tools;
using Proyecto_MAD.EnlaceDB;

namespace Proyecto_MAD.Recibo
{
    public partial class PEDE_Empleado : Form
    {
        EnlaceDB.EnlaceDB dB=new EnlaceDB.EnlaceDB();
        private int id = 0;
        private bool use=false;
        public PEDE_Empleado()
        {
            InitializeComponent();
        }
        private void PEDE_Empleado_Load(object sender, EventArgs e)
        {
            dB.Cargar_DatosDeduc_CB(5,Cb_Deducciones);
            dB.Cargar_DatosPercep_CB(4, Cb_Percepciones);
            CB_Modo.SelectedIndex = 0;
            CB_Year.SelectedIndex = 0;
            CB_Mes.SelectedIndex = 0;
        }

        private void CB_Modo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(CB_Modo.SelectedIndex == 0)//Departamento
            {
                LBL_Datagrid.Text = "Lista de Departamentos";
                Dgv_EmpDep.DataSource= dB.DataTable_MostrarDeptos(4);

            }else if(CB_Modo.SelectedIndex == 1)//Empleado
            {
                LBL_Datagrid.Text = "Lista de Empleados";
                Dgv_EmpDep.DataSource = dB.DataTable_MostrarEmpleado(4);
            }
        }

        #region Botones
        //Agrega Percepción al list box percepciones
        private void BTN_APer_Click(object sender, EventArgs e)
        {
            string seleccion = "";
            seleccion = Cb_Percepciones.Text;

            if (!NoRepeticion(LB_Percepciones, seleccion))
            {
                MessageBox.Show("Este elemento ya ha sido agragado","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (seleccion != "Selecciona una Percepción")
                    LB_Percepciones.Items.Add(seleccion);
            }
            
        }
        //Agrega Deducción al list box deducciones
        private void BTN_ADed_Click(object sender, EventArgs e)
        {
            string seleccion = "";
            seleccion = Cb_Deducciones.Text;

            if (!NoRepeticion(LB_Deducciones, seleccion))
            {
                MessageBox.Show("Este elemento ya ha sido agragado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (seleccion != "Selecciona una Deduccion")
                    LB_Deducciones.Items.Add(seleccion);
            }
            
        }

        //Elimina los valores agregados de la lista deducciones
        private void Btn_ElimDeduc_Click(object sender, EventArgs e)
        {
            int indice=LB_Deducciones.SelectedIndex;
            if (indice != -1)
            {
                LB_Deducciones.Items.RemoveAt(indice);
            }

        }

        //Elimina los valores agregados de la lista percepciones
        private void Btn_ElimPercep_Click(object sender, EventArgs e)
        {
            int indice = LB_Percepciones.SelectedIndex;
            if (indice != -1)
            {
                LB_Percepciones.Items.RemoveAt(indice);
            }
        }

        //Agrega las percepciones y deducciones que tendra el empleado del mes correspondiente
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                bool acces = true;// true=Hay datos en lb_deducciones
                bool acces2 = true;//true= Hay datos en lb_percepciones

                if (LB_Deducciones.Items.Count <= 0)
                {
                    acces = false;
                }
                if (LB_Percepciones.Items.Count <= 0)
                {
                    acces2 = false;
                }

                if (!use)
                {
                    if (CB_Modo.SelectedIndex == 0)//Departamento
                    {
                        MessageBox.Show("Seleccione un Departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (CB_Modo.SelectedIndex == 1)//Empleado
                    {
                        MessageBox.Show("Seleccione un Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    if (CB_Modo.SelectedIndex == 0)//Departamento
                    {
                        if (acces)
                        {
                            Agregar_DeduccionesPercepciones(3, LB_Deducciones);
                        }
                        if (acces2)
                        {
                            Agregar_DeduccionesPercepciones(4, LB_Percepciones);
                        }
                    }
                    else if (CB_Modo.SelectedIndex == 1)//Empleado
                    {
                        if (acces)
                        {
                            Agregar_DeduccionesPercepciones(1, LB_Deducciones);
                        }
                        if (acces2)
                        {
                            Agregar_DeduccionesPercepciones(2, LB_Percepciones);
                        }

                    }
                }
            }
            
            
        }
        
        #endregion

        private bool NoRepeticion(ListBox listBox,string texto)
        {
            bool permiso = true;

            foreach(string s in listBox.Items)
            {
                if (s == texto)
                {
                    permiso=false;
                }
            }

            return permiso;

        }

        private void Dgv_EmpDep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string aux = this.Dgv_EmpDep.SelectedRows[0].Cells[0].Value.ToString();
            if (aux != "")
            {
                use = true;
                id = Convert.ToInt32(this.Dgv_EmpDep.SelectedRows[0].Cells[0].Value);       
            }
        }

        private void Agregar_DeduccionesPercepciones(int Opc,ListBox listbox)
        {
            switch (Opc)
            {
                case 1://por empleado deducciones
                    foreach (string deducciones in listbox.Items)
                    {
                        dB.ControlPEDE_Empleado(1, id, "", deducciones, 0, Tools_z.ConvertirStringFechas(CB_Year.Text, CB_Mes.Text));
                    }

                    break;
                case 2://por empleado percepciones
                    foreach (string percepciones in listbox.Items)
                    {
                        dB.ControlPEDE_Empleado(2, id, percepciones, "", 0, Tools_z.ConvertirStringFechas(CB_Year.Text, CB_Mes.Text));
                    }
                    break;
                case 3://por Departamento deducciones
                    foreach (string deducciones in listbox.Items)
                    {
                        dB.ControlPEDE_Empleado(3, 0, "", deducciones, id, Tools_z.ConvertirStringFechas(CB_Year.Text, CB_Mes.Text));
                    }
                    break;
                case 4://por Departamento percepciones
                    foreach (string percepciones in listbox.Items)
                    {
                        dB.ControlPEDE_Empleado(4, id, percepciones, "", 0, Tools_z.ConvertirStringFechas(CB_Year.Text, CB_Mes.Text));
                    }
                    break;
            }
            
           
        }

        private bool Validaciones()
        {
            bool validaciones = true;
            if (CB_Mes.Text == "" || CB_Year.Text == ""||CB_Modo.Text=="")
            {
                MessageBox.Show("Falta seleccionar opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones = false;
            }
            if (LB_Deducciones.Items.Count <= 0&& LB_Percepciones.Items.Count <= 0)
            {
                MessageBox.Show("Ambas Listas estan vacias\n Por favor, agrega desde el catálogo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validaciones =false;
            }
            
            return validaciones;
        }
    }
}
