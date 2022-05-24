using System;
using System.Windows.Forms;
using System.IO;
using Apitron.PDF.Rasterizer;
using Proyecto_MAD.DAO;

namespace Proyecto_MAD.Empleados
{
    public partial class VistaPDF : Form
    {
        public static DateTime FechaNomina { get; set; }
        EnlaceDB.EnlaceDB db = new EnlaceDB.EnlaceDB();
        GeneracionRecibo R = new GeneracionRecibo();
        FileStream fs ;

        public VistaPDF()
        {
            InitializeComponent();
            
        }

        private void VistaPDF_Load(object sender, EventArgs e)
        {
            
            try
            {
                
                fs = new FileStream("../../Recibos PDF/Nomina_" + DAO.DAO_GenerarRecibo.Nombre + "_" + "01-" + FechaNomina.Month.ToString() + "-" + FechaNomina.Year.ToString() + ".pdf", FileMode.Open);
                pdfViewer1.Document = new Document(fs);
                 
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Verifique si existe un PDF\nPresione primero el Boton PDF","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
               
            }

           
        }

        private void VistaPDF_Leave(object sender, EventArgs e)
        {
                     

        }

      

        private void cerrar_Btn_Click(object sender, EventArgs e)
        {
            if (fs!=null)
            {
                fs.Close();
                
            }
            this.Close();
            this.Dispose();



        }

        private void VistaPDF_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrar_Btn_Click(this, e);
        }
    }
}
