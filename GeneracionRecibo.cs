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
        string pdfName = "Nomina.pdf";

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
            pdfDocument.Save("../../Recibos PDF/" + pdfName);
            AgregarDatos1();
            AgregarDatos2();
            //AgregarDatos3();
            AgregarDatos4();

            MessageBox.Show("PDF creado","Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Guardar el documento, solamente con la imagen de fondo


            return pdfName;
        }

        //Agregar datos personales
        private void AgregarDatos1()
        {

            Document pdfDocument = new Document("../../Recibos PDF/" + pdfName);
            Page page = pdfDocument.Pages[1];

            //Texto del nombre completo empleado
            TextFragment Nombre = new TextFragment(DAO_GenerarRecibo.Nombre);
            Nombre.Position = new Position(65,640);
            Nombre.TextState.FontSize = 8;
            Nombre.TextState.Font = FontRepository.FindFont("Century Gothic");
            Nombre.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            Nombre.TextState.FontStyle = FontStyles.Bold;

            //NSS EMPLEADO
            TextFragment NSSemp = new TextFragment(DAO_GenerarRecibo.NSS);
            NSSemp.Position = new Position(220, 640);
            NSSemp.TextState.FontSize = 8;
            NSSemp.TextState.Font = FontRepository.FindFont("Century Gothic");
            NSSemp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            NSSemp.TextState.FontStyle = FontStyles.Bold;

            //CURP EMPLEADO
            TextFragment CURPemp = new TextFragment(DAO_GenerarRecibo.CURP);
            CURPemp.Position = new Position(300, 640);
            CURPemp.TextState.FontSize = 8;
            CURPemp.TextState.Font = FontRepository.FindFont("Century Gothic");
            CURPemp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            CURPemp.TextState.FontStyle = FontStyles.Bold;

            //RFC EMPLEADO
            TextFragment RFCemp = new TextFragment(DAO_GenerarRecibo.RFCE);
            RFCemp.Position = new Position(450, 640);
            RFCemp.TextState.FontSize = 8;
            RFCemp.TextState.Font = FontRepository.FindFont("Century Gothic");
            RFCemp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            RFCemp.TextState.FontStyle = FontStyles.Bold;

            //NO. EMPLEADO
            TextFragment NoEmp = new TextFragment(DAO.DAO_GenerarRecibo.NoEmp.ToString());
            NoEmp.Position = new Position(185, 615);
            NoEmp.TextState.FontSize = 8;
            NoEmp.TextState.Font = FontRepository.FindFont("Century Gothic");
            NoEmp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            NoEmp.TextState.FontStyle = FontStyles.Bold;

            TextBuilder txtBuild = new TextBuilder(page);
            txtBuild.AppendText(Nombre);
            txtBuild.AppendText(NSSemp);
            txtBuild.AppendText(CURPemp);
            txtBuild.AppendText(RFCemp);
            txtBuild.AppendText(NoEmp);


            pdfDocument.Save("../../Recibos PDF/" + pdfName);

        }
        /*  public void prueba()
          {
              string dataDir = "../../Recibos PDF/";

              // Initialize document object
              Document document = new Document();
              // Add page
              Page page = document.Pages.Add();
              // Add text to new page
              page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Hello World!"));
              // Save updated PDF
              document.Save(dataDir + "HelloWorld_out.pdf");
          }*/

        public void AgregarDatos2()
        {
            Document pdfDocument = new Document("../../Recibos PDF/" + pdfName);
            Page page = pdfDocument.Pages[1];

            //Texto de RFC Empres
            TextFragment RFCEm = new TextFragment(DAO_Empresa.RFC.ToString());
            RFCEm.Position = new Position(90, 719);
            RFCEm.TextState.FontSize = 8;
            RFCEm.TextState.Font = FontRepository.FindFont("Century Gothic");
            RFCEm.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            RFCEm.TextState.FontStyle = FontStyles.Bold;

            //Registro Patronal
            TextFragment RegistroPatronal = new TextFragment(DAO_Empresa.RegistroPatronal.ToString());
            RegistroPatronal.Position = new Position(270, 719);
            RegistroPatronal.TextState.FontSize = 8;
            RegistroPatronal.TextState.Font = FontRepository.FindFont("Century Gothic");
            RegistroPatronal.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            RegistroPatronal.TextState.FontStyle = FontStyles.Bold;

            //Fecha de Nomina
            TextFragment FechaNomina = new TextFragment(DAO_GenerarRecibo.FechaNomina.ToString());
            FechaNomina.Position = new Position(150, 700);
            FechaNomina.TextState.FontSize = 8;
            FechaNomina.TextState.Font = FontRepository.FindFont("Century Gothic");
            FechaNomina.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            FechaNomina.TextState.FontStyle = FontStyles.Bold;

            //puesto
            TextFragment Puesto = new TextFragment(DAO_GenerarRecibo.NombrePuesto);
            Puesto.Position = new Position(268, 615);
            Puesto.TextState.FontSize = 8;
            Puesto.TextState.Font = FontRepository.FindFont("Century Gothic");
            Puesto.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            Puesto.TextState.FontStyle = FontStyles.Bold;

            //departamento
            TextFragment Departamento = new TextFragment(DAO_GenerarRecibo.NombreDepto);
            Departamento.Position = new Position(410, 615);
            Departamento.TextState.FontSize = 8;
            Departamento.TextState.Font = FontRepository.FindFont("Century Gothic");
            Departamento.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            Departamento.TextState.FontStyle = FontStyles.Bold;

            TextBuilder txtBuild = new TextBuilder(page);
            txtBuild.AppendText(RFCEm);
            txtBuild.AppendText(RegistroPatronal);
            txtBuild.AppendText(FechaNomina);
            txtBuild.AppendText(Puesto);
            txtBuild.AppendText(Departamento);

            pdfDocument.Save("../../Recibos PDF/" + pdfName);

        }

        public void AgregarDatos3()
        {
            Document pdfDocument = new Document("../../Recibos PDF/" + pdfName);
            Page page = pdfDocument.Pages[1];

            //Texto de ID Percepcion
            TextFragment idPer = new TextFragment(DAO_GenerarRecibo.idPer.ToString());
            idPer.Position = new Position(70, 100);
            idPer.TextState.FontSize = 12;
            idPer.TextState.Font = FontRepository.FindFont("Century Gothic");
            idPer.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            idPer.TextState.FontStyle = FontStyles.Bold;

            //Texto de Concepto Percepcion
            TextFragment NombrePer = new TextFragment(DAO_GenerarRecibo.NombrePer);
            NombrePer.Position = new Position(80, 100);
            NombrePer.TextState.FontSize = 12;
            NombrePer.TextState.Font = FontRepository.FindFont("Century Gothic");
            NombrePer.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            NombrePer.TextState.FontStyle = FontStyles.Bold;

            //Texto de ID Deduccion
            TextFragment idDed = new TextFragment(DAO_GenerarRecibo.idDed.ToString());
            idDed.Position = new Position(90, 100);
            idDed.TextState.FontSize = 12;
            idDed.TextState.Font = FontRepository.FindFont("Century Gothic");
            idDed.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            idDed.TextState.FontStyle = FontStyles.Bold;

            //Texto de Concepto Deduccion
            TextFragment NombreDed = new TextFragment(DAO_GenerarRecibo.Nombreded);
            NombreDed.Position = new Position(100, 100);
            NombreDed.TextState.FontSize = 12;
            NombreDed.TextState.Font = FontRepository.FindFont("Century Gothic");
            NombreDed.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            NombreDed.TextState.FontStyle = FontStyles.Bold;

            TextBuilder txtBuild = new TextBuilder(page);
            txtBuild.AppendText(idPer);
            txtBuild.AppendText(NombrePer);
            txtBuild.AppendText(idDed);
            txtBuild.AppendText(NombreDed);

            pdfDocument.Save("../../Recibos PDF/" + pdfName);
        }

        public void AgregarDatos4()
        {
            Document pdfDocument = new Document("../../Recibos PDF/" + pdfName);
            Page page = pdfDocument.Pages[1];

            //Texto de Sueldo Bruto
            TextFragment SueldoBruto = new TextFragment(DAO_GenerarRecibo.SueldoBruto.ToString());
            SueldoBruto.Position = new Position(500, 364);
            SueldoBruto.TextState.FontSize = 8
                ;
            SueldoBruto.TextState.Font = FontRepository.FindFont("Century Gothic");
            SueldoBruto.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            SueldoBruto.TextState.FontStyle = FontStyles.Bold;

            //Texto de Sueldo Neto
            TextFragment SueldoNeto = new TextFragment(DAO_GenerarRecibo.SueldoNeto.ToString());
            SueldoNeto.Position = new Position(500, 354);
            SueldoNeto.TextState.FontSize = 8;
            SueldoNeto.TextState.Font = FontRepository.FindFont("Century Gothic");
            SueldoNeto.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            SueldoNeto.TextState.FontStyle = FontStyles.Bold;

            //Dias trabajados
            TextFragment Dias = new TextFragment(DAO_GenerarRecibo.Dias.ToString());
            Dias.Position = new Position(70, 582);
            Dias.TextState.FontSize = 8;
            Dias.TextState.Font = FontRepository.FindFont("Century Gothic");
            Dias.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            Dias.TextState.FontStyle = FontStyles.Bold;

            //SalarioDiario
            //TextFragment SalarioDiario = new TextFragment(DAO_GenerarRecibo.SalarioDiario.ToString());
            //SalarioDiario.Position = new Position(220, 550);
            //SalarioDiario.TextState.FontSize = 8;
            //SalarioDiario.TextState.Font = FontRepository.FindFont("Century Gothic");
            //SalarioDiario.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            //SalarioDiario.TextState.FontStyle = FontStyles.Bold;

            //Fecha de Contratacion
            TextFragment Contratacion = new TextFragment(DAO_GenerarRecibo.Contratacion.ToString());
            Contratacion.Position = new Position(440, 582);
            Contratacion.TextState.FontSize = 8;
            Contratacion.TextState.Font = FontRepository.FindFont("Century Gothic");
            Contratacion.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            Contratacion.TextState.FontStyle = FontStyles.Bold;


            TextBuilder txtBuild = new TextBuilder(page);
            txtBuild.AppendText(Dias);
            //txtBuild.AppendText(SalarioDiario);
            txtBuild.AppendText(Contratacion);
            txtBuild.AppendText(SueldoNeto);
            txtBuild.AppendText(SueldoBruto);

            pdfDocument.Save("../../Recibos PDF/" + pdfName);

        }    

    }



}
