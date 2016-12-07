using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MOD003263_SoftwareEngineering.Core;
using MOD003263_SoftwareEngineering.Debug;

namespace MOD003263_SoftwareEngineering.Meta {
    public class PDFConvert {
        private Logger _logger = Logger.Instance;
        public bool ConvertApplicantTemplateToPDF(Template template, Applicant app, bool accepted) {
            try {
                FileStream fs = new FileStream("A" + app.ApplicantID + ".pdf", FileMode.Create);
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);

                document.AddAuthor("Test Author");
                document.AddCreator("Sample Tester");
                document.AddTitle("Test Title");

                document.Open();
                document.AddTitle("Applicant Details");
                document.Add(new Paragraph("Applicant Name: " + app.FirstName + " " + app.LastName));
                document.Add(new Paragraph("Applicant Email: " + app.EmailAddress));
                document.Add(new Paragraph("Applicant Phone Number: " + app.PhoneNumber));
                document.Add(new Paragraph("Position Applied For: " + app.ApplicantPosition));
                if (accepted) { document.Add(new Paragraph("You have been Accepted")); }
                else { document.Add(new Paragraph("You have Not been Accepted")); }
                document.Add(new Paragraph(" "));
                document.AddTitle("Question Feedback");
                int a = 1;
                foreach (Question q in template.Questions) {
                    document.Add(new Paragraph("Question " + a));
                    document.Add(new Paragraph(q.Title + ": " + q.Score + "/5"));
                    document.Add(new Paragraph(q.PickedFeedback));
                    document.Add(new Paragraph(" "));
                    a++;
                }
                _logger.WriteLine("PDF File Successfully Created");
                document.Close();
                writer.Close();
                fs.Close();
                return true;
            } catch (Exception e) {
                _logger.WriteLine(e.Message);
                return false;
            }
        }

        public bool ConvertEmployeeTemplateToPDF(Template template, Employee emp) {
            try {
                FileStream fs = new FileStream("E" + emp.EmployeeID + ".pdf", FileMode.Create);
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);

                document.AddAuthor("Test Author");
                document.AddCreator("Sample Tester");
                document.AddTitle("Test Title");

                document.Open();
                document.AddTitle("Employee Details");
                document.Add(new Paragraph("Employee Name: " + emp.FirstName + " " + emp.LastName));
                document.Add(new Paragraph("Employee Email: " + emp.EmailAddress));
                document.Add(new Paragraph("Employee Phone Number: " + emp.PhoneNumber));
                document.Add(new Paragraph("Employee Position: " + emp.EmployeePosition));
                document.Add(new Paragraph(" "));
                document.AddTitle("Employee Feedback");
                int a = 1;
                foreach (Question q in template.Questions) {
                    document.Add(new Paragraph("Question " + a));
                    document.Add(new Paragraph(q.Title + ": " + q.Score + "/5"));
                    document.Add(new Paragraph(q.PickedFeedback));
                    document.Add(new Paragraph(" "));
                    a++;
                }
                _logger.WriteLine("PDF File Successfully Created");
                document.Close();
                writer.Close();
                fs.Close();
                return true;
            } catch (Exception e) {
                _logger.WriteLine(e.Message);
                return false;
            }
        }
    }
}
