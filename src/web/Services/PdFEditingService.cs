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
            var inputPath = Path.Combine(_hostEnvironment.WebRootPath, "..//wwwroot//documents//Alfbet.pdf");
            var outputPath = Path.Combine(_hostEnvironment.WebRootPath, "..//wwwroot//tempDocument//AlfbetOutput.pdf"); 

             PdfDocument myTemplate = PdfReader.Open(inputPath, PdfDocumentOpenMode.Modify);
            PdfAcroForm form = myTemplate.AcroForm;
            ConfigureForm(form);

            var nameField = (PdfTextField)(form.Fields["IdentityNumber"]);
            nameField.Value = new PdfString("1234567890");
            
            var nameField1 = (PdfTextField)(form.Fields["LastName"]);
            nameField1.Value = new PdfString("Василь Столярчук");

            var nameField2 = (PdfTextField)(form.Fields["FatherName"]);
            nameField2.Value = new PdfString("Stepanovich");

            var nameField3 = (PdfTextField)(form.Fields["DateofBirthday"]);
            nameField3.Value = new PdfString("16/09/1984");
            

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
