using System;
using System.Windows.Forms;
using ConsoleApplication1.Core;
using ConsoleApplication1.Forms;

namespace ConsoleApplication1
{
    class Program {

        static void Main(string[] args) {
            testPDF();
            Console.ReadKey(true);
            //RunConsole();
            //RunForm();
        }

        static void testPDF() {
            Meta.PDFConvert pdf = new Meta.PDFConvert();
            pdf.ConvertToPDF();
        }

        static void RunConsole() {
            TemplateFactory factory = new TemplateFactory();
            TemplateEditor tempEditor = new TemplateEditor(factory);
            Template temp = tempEditor.RequestTemplate("CV");
            string name = temp.TemplateName;
            Console.WriteLine(name);
            for (int i = 0; i < temp.TemplateQuestions.Count; i++) {
                Console.WriteLine(temp.TemplateQuestions[i]);
            }
            Console.ReadKey(true);
        }

        static void RunForm() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TemplateForm());
        }
    }
}
