using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Proyecto_MAD.DAO;

namespace Proyecto_MAD
{
    class GeneracionRecibo
    {
        string pdfName = "Nomina" + DAO_GenerarRecibo.Nombre + ".pdf";

        public string GenerarRecibo()
        {

            //Generar un nuevo documento
            Document pdfDocument = new Document();

            //Generar una nueva página y guardar la referencia en page1
            Page page1 = pdfDocument.Pages.Add();

            //Cargar la imagen de fondo
            BackgroundArtifact background = new BackgroundArtifact();
            background.BackgroundImage = File.OpenRead("Recibo.png");

            //Añadir la imagen de fondo a la página
            page1.Artifacts.Add(background);

            AgregarDatos1();

            //Guardar el documento, solamente con la imagen de fondo
            pdfDocument.Save("Recibos PDF/" + pdfName);

            return pdfName;
        }

        //Agregar datos personales
        private void AgregarDatos1()
        {

            Document pdfDocument = new Document("Recibos PDF/" + pdfName);
            Page page = pdfDocument.Pages[1];

            //Texto de los apellidos del cliente
            TextFragment Nombre = new TextFragment("si jala");
            Nombre.Position = new Position(40, 690);
            Nombre.TextState.FontSize = 16;
            Nombre.TextState.Font = FontRepository.FindFont("Century Gothic");
            Nombre.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            Nombre.TextState.FontStyle = FontStyles.Bold;

            TextBuilder txtBuild = new TextBuilder(page);
            txtBuild.AppendText(Nombre);

            pdfDocument.Save("Recibos PDF/" + pdfName);

        }


    }



}
