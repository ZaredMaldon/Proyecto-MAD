using System;
using System.Windows.Forms;
using System.IO;
using Apitron.PDF.Rasterizer;


namespace Proyecto_MAD.Empleados
{
    public partial class VistaPDF : Form
    {
        
        
        public VistaPDF()
        {
            InitializeComponent();
            
        }

        private void VistaPDF_Load(object sender, EventArgs e)
        {
            FileStream fs= null;
            fs = new FileStream(@"H:\Escuela documentos\semestre 6\MAD\proyecto\Proyecto MAD\Recibos PDF\Nomina.pdf",FileMode.Open);
            
            pdfViewer1.Document = new Document(fs);
           
        }

        private void VistaPDF_Leave(object sender, EventArgs e)
        {
            this.Dispose();
            

        }
    }
}
