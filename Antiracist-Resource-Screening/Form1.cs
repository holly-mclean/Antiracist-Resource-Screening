using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Antiracist_Resource_Screening
{
    public partial class Form1 : Form
    {
        public TargetFile MyFile { get; set; }
        public List<ProblematicLanguage> Database;

        public Form1()
        {
            InitializeComponent();

            MyFile = new TargetFile();
            MyFile.Categories = new List<string>();

            // Pseudo database of problem language
            Database = new List<ProblematicLanguage>
            {
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "peanut gallery", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "eenie meenie", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "master", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "slave", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "black sheep", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "uppity", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "food coma", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "grandfathered", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "grandfather clause", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "cakewalk", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "freehold", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "jimmies", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "thug", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "ghetto", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "hood", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "articulate", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "well-spoken", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "well spoken", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "tipping point", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "nitty gritty", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "gritty", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "fuzzy wuzzy", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "nappy", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "sold down the river", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "lynch mob", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "slaving", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "call a spade a spade", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "blacklist", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "black market", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "blackball", Resources = "" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "white trash", Resources = "" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "eskimo", Resources = "" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "off the reservation", Resources = "" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "indian style", Resources = "" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "indian giver", Resources = "" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "spirit animal", Resources = "" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "long time no see", Resources = "" }
            };
        }

        public void selectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string[] pathStrings = filePath.Split('\\');
                string fileName = pathStrings[pathStrings.Length - 1];

                displayFileNameLabel.Text = fileName;

                MyFile.FilePath = filePath;
                MyFile.Extension = Path.GetExtension(filePath);
            }
        }

        private void categoryCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void submitButton_Click(object sender, EventArgs e)
        {
            foreach (object item in categoryCheckedList.CheckedItems)
            {
                MyFile.Categories.Add(item.ToString());
            }

            //Console.WriteLine("MyFile data:");
            //Console.WriteLine("Filepath: {0}", MyFile.FilePath);
            //Console.WriteLine("Extension: {0}", MyFile.Extension);
            //Console.WriteLine("Categories: ");

            //foreach (string item in MyFile.Categories)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(" ");
            //}

            displayResultsLabel.Text = "Document has been scanned and saved.";

            MyFile.Categories.Clear();
        }
    }

    // Class to hold info for each database entry
    public class ProblematicLanguage
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string ProblemPhrase { get; set; }
        public string Resources { get; set; }
    }

    // Class to hold data about the target file to be screened. Includes method to highlight strings in the file.
    public class TargetFile
    {
        public string FilePath { get; set; }
        public string Extension { get; set; }
        public List<string> Categories { get; set; }


        public void EditTxtFile(List<ProblematicLanguage> database)
        {
            
        }

        
        public void EditDocxFile(List<ProblematicLanguage> database)
        {
            
        }


        public void EditPdfFile(List<ProblematicLanguage> database)
        {
            
        }
    }
}
