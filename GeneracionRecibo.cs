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
            //AgregarDatos2();
            //AgregarDatos3();
            //AgregarDatos4();

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
            //TextFragment Nombre = new TextFragment("LALAL");
            Nombre.Position = new Position(100,100);
            Nombre.TextState.FontSize = 12;
            Nombre.TextState.Font = FontRepository.FindFont("Century Gothic");
            Nombre.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            Nombre.TextState.FontStyle = FontStyles.Bold;

            //NSS EMPLEADO
            TextFragment NSSemp = new TextFragment(DAO_GenerarRecibo.NSS);
            NSSemp.Position = new Position(40, 540);
            NSSemp.TextState.FontSize = 12;
            NSSemp.TextState.Font = FontRepository.FindFont("Century Gothic");
            NSSemp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            NSSemp.TextState.FontStyle = FontStyles.Bold;

            //CURP EMPLEADO
            TextFragment CURPemp = new TextFragment(DAO_GenerarRecibo.CURP);
            CURPemp.Position = new Position(40, 530);
            CURPemp.TextState.FontSize = 12;
            CURPemp.TextState.Font = FontRepository.FindFont("Century Gothic");
            CURPemp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            CURPemp.TextState.FontStyle = FontStyles.Bold;

            //RFC EMPLEADO
            TextFragment RFCemp = new TextFragment(DAO_GenerarRecibo.RFCE);
            RFCemp.Position = new Position(40, 520);
            RFCemp.TextState.FontSize = 12;
            RFCemp.TextState.Font = FontRepository.FindFont("Century Gothic");
            RFCemp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            RFCemp.TextState.FontStyle = FontStyles.Bold;

            //NO. EMPLEADO
            TextFragment NoEmp = new TextFragment(DAO.DAO_GenerarRecibo.NoEmp.ToString());
            NoEmp.Position = new Position(40, 500);
            NoEmp.TextState.FontSize = 12;
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
            TextFragment RFCEm = new TextFragment(DAO_GenerarRecibo.RFCEm.ToString());
            RFCEm.Position = new Position(50, 200);
            RFCEm.TextState.FontSize = 12;
            RFCEm.TextState.Font = FontRepository.FindFont("Century Gothic");
            RFCEm.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            RFCEm.TextState.FontStyle = FontStyles.Bold;

            //Registro Patronal
            TextFragment RegistroPatronal = new TextFragment(DAO_GenerarRecibo.RegistroPatronal.ToString());
            RegistroPatronal.Position = new Position(50, 210);
            RegistroPatronal.TextState.FontSize = 12;
            RegistroPatronal.TextState.Font = FontRepository.FindFont("Century Gothic");
            RegistroPatronal.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            RegistroPatronal.TextState.FontStyle = FontStyles.Bold;

            //Fecha de Nomina
            TextFragment FechaNomina = new TextFragment(DAO_GenerarRecibo.FechaNomina.ToString());
            FechaNomina.Position = new Position(50, 220);
            FechaNomina.TextState.FontSize = 12;
            FechaNomina.TextState.Font = FontRepository.FindFont("Century Gothic");
            FechaNomina.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            FechaNomina.TextState.FontStyle = FontStyles.Bold;

            //puesto
            TextFragment Puesto = new TextFragment(DAO_GenerarRecibo.NombrePuesto);
            Puesto.Position = new Position(50, 230);
            Puesto.TextState.FontSize = 12;
            Puesto.TextState.Font = FontRepository.FindFont("Century Gothic");
            Puesto.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            Puesto.TextState.FontStyle = FontStyles.Bold;

            //departamento
            TextFragment Departamento = new TextFragment(DAO_GenerarRecibo.NombreDepto);
            Departamento.Position = new Position(50, 240);
            Departamento.TextState.FontSize = 12;
            Departamento.TextState.Font = FontRepository.FindFont("Century Gothic");
            Departamento.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            Departamento.TextState.FontStyle = FontStyles.Bold;

            TextBuilder txtBuild = new TextBuilder(page);
            txtBuild.AppendText(RFCEm);
            txtBuild.AppendText(RegistroPatronal);
            txtBuild.AppendText(FechaNomina);
            txtBuild.AppendText(Puesto);
            txtBuild.AppendText(Departamento);

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

        }

        public void AgregarDatos4()
        {
            Document pdfDocument = new Document("../../Recibos PDF/" + pdfName);
            Page page = pdfDocument.Pages[1];

            //Texto de Sueldo Bruto
            TextFragment SueldoBruto = new TextFragment(DAO_GenerarRecibo.SueldoBruto.ToString());
            SueldoBruto.Position = new Position(10, 10);
            SueldoBruto.TextState.FontSize = 12;
            SueldoBruto.TextState.Font = FontRepository.FindFont("Century Gothic");
            SueldoBruto.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            SueldoBruto.TextState.FontStyle = FontStyles.Bold;

            //Texto de Sueldo Neto
            TextFragment SueldoNeto = new TextFragment(DAO_GenerarRecibo.SueldoNeto.ToString());
            SueldoNeto.Position = new Position(20, 20);
            SueldoNeto.TextState.FontSize = 12;
            SueldoNeto.TextState.Font = FontRepository.FindFont("Century Gothic");
            SueldoNeto.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            SueldoNeto.TextState.FontStyle = FontStyles.Bold;

            //Texto de Banco
            TextFragment Banco = new TextFragment(DAO_GenerarRecibo.Banco);
            Banco.Position = new Position(30, 30);
            Banco.TextState.FontSize = 12;
            Banco.TextState.Font = FontRepository.FindFont("Century Gothic");
            Banco.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            Banco.TextState.FontStyle = FontStyles.Bold;

            //Texto de numero de cuenta
            TextFragment NoCuenta = new TextFragment(DAO_GenerarRecibo.NoCuenta.ToString());
            NoCuenta.Position = new Position(40, 40);
            NoCuenta.TextState.FontSize = 12;
            NoCuenta.TextState.Font = FontRepository.FindFont("Century Gothic");
            NoCuenta.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            NoCuenta.TextState.FontStyle = FontStyles.Bold;

            TextBuilder txtBuild = new TextBuilder(page);
            txtBuild.AppendText(SueldoNeto);
            txtBuild.AppendText(SueldoBruto);
            txtBuild.AppendText(Banco);
            txtBuild.AppendText(NoCuenta);

        }



    }



}
