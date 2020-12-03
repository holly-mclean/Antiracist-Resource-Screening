//namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Document;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Antiracist_Resource_Screening
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           //sets license for system use
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
