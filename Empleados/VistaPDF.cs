using System;
using System.Windows.Forms;
using System.IO;
using Apitron.PDF.Rasterizer;


namespace Proyecto_MAD.Empleados
{
    public partial class VistaPDF : Form
    {

        EnlaceDB.EnlaceDB db = new EnlaceDB.EnlaceDB();
        GeneracionRecibo R = new GeneracionRecibo();

        public VistaPDF()
        {
            InitializeComponent();
            
        }

        private void VistaPDF_Load(object sender, EventArgs e)
        {
            FileStream fs= null;
            fs = new FileStream("../../Recibos PDF/Nomina.pdf",FileMode.Open);
            
            pdfViewer1.Document = new Document(fs);
           
        }

        private void VistaPDF_Leave(object sender, EventArgs e)
        {
            this.Dispose();           

        }

        private void Inicio_Btn_Click(object sender, EventArgs e)
        {
           // db.Toma_Datos_Recibo(2, DAO.DAO_GenerarRecibo.NoEmp);
           // R.GenerarRecibo();

        }
    }
}
