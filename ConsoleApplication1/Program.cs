using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApplication1
{
    class Program {

        static void Main(string[] args) {

            //RunConsole();
            RunForm();
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
