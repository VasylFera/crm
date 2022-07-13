using Microsoft.AspNetCore.Hosting;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.AcroForms;
using PdfSharpCore.Pdf.IO;
using System.IO;

namespace web.Services
{
    public class PdFEditingService
    {
        private IWebHostEnvironment _hostEnvironment;
        public PdFEditingService(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        public void TestPdf()
        {                     
            var inputPath = Path.Combine(_hostEnvironment.WebRootPath, "..//wwwroot//documents//Povistka2.pdf");
            var outputPath = Path.Combine(_hostEnvironment.WebRootPath, "..//wwwroot//tempDocument//Povistka2Output.pdf"); 

             PdfDocument myTemplate = PdfReader.Open(inputPath, PdfDocumentOpenMode.Modify);
            PdfAcroForm form = myTemplate.AcroForm;
            ConfigureForm(form);

            var nameField = (PdfTextField)(form.Fields["DateTime"]);
            nameField.Value = new PdfString("12/07/2022");

            var nameField1 = (PdfTextField)(form.Fields["FullName"]);
            nameField1.Value = new PdfString(" Столярчуку  Василю Степановичу", PdfStringEncoding.Unicode);

            var nameField2 = (PdfTextField)(form.Fields["FullAddress"]);
            nameField2.Value = new PdfString("Львівська обл, м.Радехів, вул. Стоянівська 39", PdfStringEncoding.Unicode);

            //var nameField3 = (PdfTextField)(form.Fields["DateofBirthday"]);
            //nameField3.Value = new PdfString("16/09/1984");
            

            myTemplate.Save(outputPath);

            void ConfigureForm(PdfAcroForm form)
            {
                if (form.Elements.ContainsKey("/NeedAppearances"))
                {
                    form.Elements["/NeedAppearances"] = new PdfBoolean(true);
                }
                else
                {
                    form.Elements.Add("/NeedAppearances", new PdfBoolean(true));
                }
            }

        }


    }
}
