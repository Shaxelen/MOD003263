using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ConsoleApplication1.Meta {
    public class PDFConvert {
        public void ConvertToPDF() {
            FileStream fs = new FileStream("E:\\PDFTest.pdf", FileMode.Create);
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            document.AddAuthor("Test Author");
            document.AddCreator("Sample Tester");
            document.AddTitle("Test Title");

            document.Open();
            document.Add(new Paragraph("Test PDF"));
            document.Close();
            writer.Close();
            fs.Close();
        }
    }
}
