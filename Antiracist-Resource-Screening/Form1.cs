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
using GemBox.Document;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System.Text.RegularExpressions;

namespace Antiracist_Resource_Screening
{
    public partial class Form1 : Form
    {
        public TargetFile MyFile { get; set; }
        public List<ProblematicLanguage> Database;

        public Form1()
        {
            InitializeComponent();

            MyFile = new TargetFile { Categories = new List<string>() };

            //Pseudo database of problem language
            Database = new List<ProblematicLanguage>
            {
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "peanut gallery", Resources = "According to linguistics experts, the origin of this phrase derives from the late 1800s Vaudeville era, a popular style of entertainment that included jugglers, comedians, singers and more. The 'peanut gallery' was the cheapest section of seats, usually occupied by people with limited means.  The 1940s and 1950s - era children's program 'Howdy Doody' used the term to refer to the groups of kids who participated in its audience. However, in the segregated South, seats in the back or upper balcony levels were mostly reserved for Black people.  Peanut gallery was in use in the 1880s, as a synonym for n______ gallery (1840s) or n______ heaven (1870s), the upper balcony where blacks sat, as in segregated theaters. ", Link = "https://abcnews.go.com/Politics/commonly-terms-racist-origins/story?id=71840410" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "eenie meenie", Resources = "The diverse origins of the first line “eeny, meeny, miney, moe” are plausible but contested. The second line in the American rhyme, 'catch a tiger by the toe,' has a clearer and more dismal ancestry that traces right back to the United States. Some of you may be surprised to learn that, in the 1880s, the object of the 'catch' wasn’t a tiger but a n______.  Even though slavery was officially over, the century after the Civil War ended would prove to be a time of tremendous racial tension in the US. Racial hatred and prejudice were sometimes reflected in the language, and even—as Eeny, Meeny indicates—articulated from the mouths of babes. ", Link = "https://www.dictionary.com/e/american-childrens-rhyme-isnt-american/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "master", Resources = "Words like 'slave' and' master' are so folded into our vocabulary and almost unconsciously speak to the history of racial slavery and racism in the US.", Link = "https://www.cnn.com/2020/07/06/us/racism-words-phrases-slavery-trnd/index.html" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "slave", Resources = "Words like 'slave' and' master' are so folded into our vocabulary and almost unconsciously speak to the history of racial slavery and racism in the US.", Link = "https://www.cnn.com/2020/07/06/us/racism-words-phrases-slavery-trnd/index.html" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "black sheep", Resources = "Everyday language reminds African Americans in matter-of-fact ways that our color is related to extortion (blackmail), disrepute (black mark), rejection (blackball), banishment (blacklist), impurity (not the driven snow), illicitness (black market), and death. Casting aspersions on black or darkness while praising white or light isn’t universal, and regardless of the intentions of the user of these expressions, such usage colludes with racism.", Link = "https://www.rd.com/list/everyday-expressions-that-are-racist/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "uppity", Resources = "When Black people were lynched, they'd use that term uppity, as in, they were acting uppity. That they didn't know their place. ", Link = "https://www.tmj4.com/news/local-news/responding-to-inequalities-common-words-or-phrases-with-racist-history" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "food coma", Resources = "This phrase directly alludes to the stereotype of laziness associated with African-Americans. It stems from a longer (and incredibly offensive) version — ni****itis. Modern vernacular dropped the racial slur, leaving a faux-scientific diagnosis for the tired feeling you get after eating way too much food. We recommend using the technical term instead: postprandial somnolence.", Link = "https://www.ebony.com/news/racist-and-offensive-terms-we-use-in-everyday-language-981/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "grandfathered", Resources = "This legal term broadly refers to the “grandfather clause” adopted by seven Southern states during the Reconstruction Era. Under it, anyone who was able to vote before 1867 was exempt from the literacy tests, property requirements and poll taxes needed for voting. But enslaved Black people were not freed until 1865, when the 13th Amendment passed, and weren’t granted the right to vote until the 15th Amendment was passed in 1870.  The grandfather clause effectively excluded them from voting — a practice that continued until the 1960s, according to Encyclopedia Britannica.  Now, 'grandfathered in' means that a person or company are exempt from following new laws, but 'grandfather clause' in its original context disenfranchised Black Americans for decades.", Link = "https://gooddaysacramento.cbslocal.com/2020/07/06/everyday-speech-racist-words/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "grandfather clause", Resources = "Under a 'grandfather clause', anyone who was able to vote before 1867 was exempt from the literacy tests, property requirements and poll taxes needed for voting. But enslaved Black people were not freed until 1865, when the 13th Amendment passed, and weren’t granted the right to vote until the 15th Amendment was passed in 1870.  The grandfather clause effectively excluded them from voting — a practice that continued until the 1960s, according to Encyclopedia Britannica.  Now, 'grandfathered in' means that a person or company are exempt from following new laws, but 'grandfather clause' in its original context disenfranchised Black Americans for decades.", Link = "https://gooddaysacramento.cbslocal.com/2020/07/06/everyday-speech-racist-words/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "cakewalk", Resources = "It’s what we call an easy victory, or something that’s easily accomplished.  The cakewalk originated as a dance performed by enslaved Black people on plantations before the Civil War. It was intended to be a mockery of the way White people danced, though plantation owners often interpreted slaves’ movements as unskillful attempts to be like them.  Owners held contests in which enslaved people competed for a cake. Later, the dance — and the idiom — was popularized through minstrel shows, characterized by a high - leg prance with a backward tilt of the head, shoulders and upper torso.", Link = "https://gooddaysacramento.cbslocal.com/2020/07/06/everyday-speech-racist-words/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "freehold", Resources = "The office of freeholder is unique to New Jersey, a title for politicians elected to one of the state’s 21 county legislative boards.  It dates back to New Jersey’s original Constitution of 1776, meaning those who had some form of an estate and at least '50 pounds of proclamation money.'  It also harkens back to a time when only white, male landowners could hold public office.", Link = "https://www.nytimes.com/2020/07/10/nyregion/Freeholder-new-jersey.html" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "jimmies", Resources = "There are competing opinions on the origin of the term. According to Wright, these brown sprinkles were called jimmies as a form of 'othering' from the regular sprinkles. The fact that they are brown suggests that they represent little Black people. Some etymologists believe that the term comes from the Jim Crow laws used to segregate the South, with jimmies representing those Black people bound by these laws.", Link = "https://www.today.com/tmrw/everyday-words-phrases-racist-offensive-backgrounds-t187422" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "thug", Resources = "Thug has a checkered history from its origins as a 19th-century Hindi word for thief to its present-day status as a racist dog whistle. But it’s always held a patina of otherness.", Link = "https://www.inquirer.com/opinion/commentary/thug-tupac-racism-language-reappropriation-20190417.html" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "ghetto", Resources = "There is a particular image of who lives in the ghetto or hood. That's still racially loaded terminology. It almost equals, when anyone says hood or very ghetto, they're trying to say it's very black. That's another way you're trying to say something without saying something.  ", Link = "https://www.tmj4.com/news/local-news/responding-to-inequalities-common-words-or-phrases-with-racist-history" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "hood", Resources = "There is a particular image of who lives in the ghetto or hood. That's still racially loaded terminology. It almost equals, when anyone says hood or very ghetto, they're trying to say it's very black. That's another way you're trying to say something without saying something.  ", Link = "https://www.tmj4.com/news/local-news/responding-to-inequalities-common-words-or-phrases-with-racist-history" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "articulate", Resources = "The remark suggests that a person of color in question would be less articulate — and the speaker is surprised to find out they aren't  Commenting on a black person's language or speaking habits has a complicated history, and this is a problem that African-Americans especially encounter in the workplace or school.  A white-dominant society expects black folks to be less competent and, when white people register surprise at a black individual's articulateness, we also send the not-so-subtle message that that person is part of a group that white people don't expect to see sitting at the table, taking on a leadership role. ", Link = "https://www.businessinsider.com/microaggression-unconscious-bias-at-work-2018-6#youre-so-articulate-1" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "well-spoken", Resources = "Well-spoken is code for black in America.  The discrimination that our country is plagued with now is sly. ", Link = "https://www.baltimoresun.com/opinion/op-ed/bs-ed-racism-20160904-story.html" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "well spoken", Resources = "Well spoken is code for black in America.  The discrimination that our country is plagued with now is sly. ", Link = "https://www.baltimoresun.com/opinion/op-ed/bs-ed-racism-20160904-story.html" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "tipping point", Resources = "When tipping point first began to be employed in general use, it was almost entirely in reference to the propensity of white families to move out of an area when a certain percentage of the neighborhood was composed of black families. It served as a precursor of sorts to the phenomenon of white flight.", Link = "https://www.merriam-webster.com/words-at-play/origin-of-the-phrase-tipping-point" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "nitty gritty", Resources = "It’s believed the phrase once had less palatable connotations, with many considering the term to have roots to be in the slave trade – its use is already banned in institutions like the police force.  Theories suggest the expression originally referred to the detritus found in the bottom of boats once a shipment of slaves had been removed from the hold.  A nit is the egg of a louse, a parasitic insect that would have been rife among the poor conditions those being transported for slavery would have been kept in.  And in American parlance, grits are coarse - ground grain, which would have been used as a cheap foodstuff to keep a slave ship’s cargo barely fed over the course of their long, transatlantic journeys.", Link = "https://www.yorkshirepost.co.uk/read-this/these-8-common-words-and-phrases-have-racist-connotations-you-might-not-know-about-2905266" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "gritty", Resources = "It’s believed the phrase once had less palatable connotations, with many considering the term to have roots to be in the slave trade – its use is already banned in institutions like the police force.  Theories suggest the expression originally referred to the detritus found in the bottom of boats once a shipment of slaves had been removed from the hold.  A nit is the egg of a louse, a parasitic insect that would have been rife among the poor conditions those being transported for slavery would have been kept in.  And in American parlance, grits are coarse - ground grain, which would have been used as a cheap foodstuff to keep a slave ship’s cargo barely fed over the course of their long, transatlantic journeys.", Link = "https://www.yorkshirepost.co.uk/read-this/these-8-common-words-and-phrases-have-racist-connotations-you-might-not-know-about-2905266" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "fuzzy wuzzy", Resources = "This is a late 1800's term used by British colonial soldiers to refer to the members of an East African tribe. It became a derogatory way to refer to natural hair texture of non-white people throughout Africa, English author and poet Rudyard Kipling's 1892 poem 'Fuzzy Wuzzy' opined on the brave actions of the Hadendoa warriors in colonial Sudan -- the phrase in the work of literature was a reference to their hairstyle and texture.", Link = "https://abcnews.go.com/Politics/commonly-terms-racist-origins/story?id=71840410"},
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "nappy", Resources = "Nappy, a historically derogatory term used to describe hair that is short and tightly coiled, is a preeminent example of how social and cultural ideas are transmitted through bodies.", Link = "https://www.commondreams.org/views/2007/04/12/why-nappy-offensive" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "sold down the river", Resources = "While this phrase now refers to a devastating betrayal, its history is more fraught.  In the 1800s, Black slaves were literally sold down the river. Slave traders traveled along the Mississippi River, selling enslaved people to plantation owners further south. There awaited inhumane conditions and brutal labor that often ended in death. Thus to be ‘sold down the river’ was to commence a life of crushing circumstances.  ", Link = "https://gooddaysacramento.cbslocal.com/2020/07/06/everyday-speech-racist-words/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "lynch mob", Resources = "The racist roots of the phrase are hidden in plain sight. Though it’s evolved into an umbrella term for an 'unjust attack,' lynch mobs originated as hordes of people, most always White, who’d torture and kill Black people — often by hanging them — as a form of vigilante justice.  In the 19th and 20th centuries, Black Americans could be lynched for speaking to a White person or being perceived as insubordinate.White Americans have since co - opted the term to characterize what they feel is undue punishment. This interpretation of the word that doesn’t fit the description from the Equal Justice Initiative, a group which fights racism in the criminal justice system.  Lynchings are defined as hangings that inflict terror and are usually racially motivated.", Link = "https://gooddaysacramento.cbslocal.com/2020/07/06/everyday-speech-racist-words/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "slaving", Resources = "Words like 'slave' and' master' are so folded into our vocabulary and almost unconsciously speak to the history of racial slavery and racism in the US.", Link = "https://www.cnn.com/2020/07/06/us/racism-words-phrases-slavery-trnd/index.html" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "a spade a spade", Resources = "In the late 1920s during the Harlem Renaissance, 'spade' began to evolve into code for a black person.  In the fourth edition of The American Language, H.L. Mencken's famous book about language in the United States, 'spade' is listed as one of the 'opprobrious' names for 'Negroes.'", Link = "https://www.npr.org/sections/codeswitch/2013/09/19/224183763/is-it-racist-to-call-a-spade-a-spade" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "blacklist", Resources = "Everyday language reminds African Americans in matter-of-fact ways that our color is related to extortion (blackmail), disrepute (black mark), rejection (blackball), banishment (blacklist), impurity (not the driven snow), illicitness (black market), and death. Casting aspersions on black or darkness while praising white or light isn’t universal, and regardless of the intentions of the user of these expressions, such usage colludes with racism.", Link = "https://www.rd.com/list/everyday-expressions-that-are-racist/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "black market", Resources = "Everyday language reminds African Americans in matter-of-fact ways that our color is related to extortion (blackmail), disrepute (black mark), rejection (blackball), banishment (blacklist), impurity (not the driven snow), illicitness (black market), and death. Casting aspersions on black or darkness while praising white or light isn’t universal, and regardless of the intentions of the user of these expressions, such usage colludes with racism.", Link = "https://www.rd.com/list/everyday-expressions-that-are-racist/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "blackball", Resources = "Everyday language reminds African Americans in matter-of-fact ways that our color is related to extortion (blackmail), disrepute (black mark), rejection (blackball), banishment (blacklist), impurity (not the driven snow), illicitness (black market), and death. Casting aspersions on black or darkness while praising white or light isn’t universal, and regardless of the intentions of the user of these expressions, such usage colludes with racism.", Link = "https://www.rd.com/list/everyday-expressions-that-are-racist/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Black", ProblemPhrase = "white trash", Resources = "White trash is used to describe a contradiction - white people who don't act like white people. We have all these racist stereotypes about black and brown people that they are poor and lazy and violent. But those same stereotypes don't exist for white people. So they're put into a whole different category.  This is a term that really has white supremacy baked into it because it's kind of like it's understood that if you're not white, you're trash.", Link = "https://www.npr.org/2018/07/30/633891473/why-its-time-to-retire-the-disparaging-term-white-trash" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "eskimo", Resources = "This was a term that Europeans used for a huge group of indigenous people living in the Arctic regions. Linguists believe the word came from the French word 'esquimaux,' referring to one who nets snowshoes.  European colonizers used the term broadly, lumping all Native Americans in that region into one ethnic group.", Link = "https://abcnews.go.com/Politics/commonly-terms-racist-origins/story?id=71840410" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "off the reservation", Resources = "Experts say this phrase, frequently used during the 19th and 20th centuries in American politics, refers to Native Americans who were forced into treaties that limited their mobility by placing them on reservations, so off the reservation would suggest they were placing themselves outside their allowed their legal, or social, parameters.  In its earliest evidence, experts explain that this phrase dealt with policing, killing and colonizing Native Americans and removing them from their native land.", Link = "https://abcnews.go.com/Politics/commonly-terms-racist-origins/story?id=71840410" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "indian giver", Resources = "Often a middle-school taunt for someone who gives a gift and promptly wants it back, 'Indian-giver' originated from the phrase 'Indian gift,' first used by Thomas Hutchinson in his 1765 book, 'The History of the Province of Massachusetts Bay.' During interactions with Native Americans, he defined the term as a present 'for which an equivalent return is expected.' But he and his fellow colonists probably just misunderstood bartering. ", Link = "https://www.businessinsider.com/offensive-phrases-that-people-still-use-2014-11" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "spirit animal", Resources = "Non-Native American people often claim that anything they love even a little, from wine, to Rihanna, to a chubby cat is their 'spirit animal.' This flattening of a Native American spiritual tradition that varies from tribe to tribe 'is concerning and often offensive to Native cultures.'", Link = "https://matadornetwork.com/read/indigenous-language-stop-appropriating/" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "long time no see", Resources = "A theory behind this seemingly innocent phrase’s origin says 'long time, no see' came from Native Americans speaking English, and reportedly first appeared in old Western novels.  The phrase could be seen as mimicking non-native English speakers’ attempts to speak the language.", Link = "https://www.yorkshirepost.co.uk/read-this/these-8-common-words-and-phrases-have-racist-connotations-you-might-not-know-about-2905266" },
                new ProblematicLanguage { Id = 2, Category = "Anti-Indigenous", ProblemPhrase = "long time, no see", Resources = "A theory behind this seemingly innocent phrase’s origin says 'long time, no see' came from Native Americans speaking English, and reportedly first appeared in old Western novels.  The phrase could be seen as mimicking non-native English speakers’ attempts to speak the language.", Link = "https://www.yorkshirepost.co.uk/read-this/these-8-common-words-and-phrases-have-racist-connotations-you-might-not-know-about-2905266" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Indigenous", ProblemPhrase = "squaw", Resources = "The word squaw is often viewed as a derogatory term for a woman, sometimes even viewed as a disrespectful reference to female anatomy, which might stem from the Mohawk ojiskwa, a courteous term for vagina. ", Link = "https://matadornetwork.com/read/indigenous-language-stop-appropriating/" },
                new ProblematicLanguage { Id = 1, Category = "Anti-Indigenous", ProblemPhrase = "tribe", Resources = "A tribe isn’t your squad or friends, and deeming it as such erases the battles these actual tribal communities fought to be federally recognized.", Link = "https://matadornetwork.com/read/indigenous-language-stop-appropriating/" }
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

            displayResultsLabel.Text = "";

        }

        private void categoryCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void submitButton_Click(object sender, EventArgs e)
        {
            string newFileName = "";

            foreach (object item in categoryCheckedList.CheckedItems)
            {
                MyFile.Categories.Add(item.ToString());
            }
            
            // Check the file extension, and markup the file
            if (MyFile.Extension == ".txt")
                newFileName = MyFile.EditTxtFile(Database);
            else if (MyFile.Extension == ".docx")
                newFileName = MyFile.EditDocxFile(Database);
            else if (MyFile.Extension == ".pdf")
                newFileName = MyFile.EditPdfFile(Database);
            else
                displayResultsLabel.Text = "Not a valid file type!";

            displayResultsLabel.Text = "Document has been scanned.  Please see new updated file:\n" + newFileName;

            MyFile.Categories.Clear();
        }


        // Class to hold info for each database entry
        public class ProblematicLanguage
        {
            public int Id { get; set; }
            public string Category { get; set; }
            public string ProblemPhrase { get; set; }
            public string Resources { get; set; }
            public string Link { get; set; }
        }

        // Class to hold data about the target file to be screened. Includes method to highlight strings in the file.
        public class TargetFile
        {
            public string FilePath { get; set; }
            public string Extension { get; set; }
            public List<string> Categories { get; set; }


            public string EditTxtFile(List<ProblematicLanguage> database)
            {
                int wordCount = 0;
                int arrayCount = 0;
                string newFilePath;
                List<string> keyHit = new List<string>();

                // Open the txt file
                string fileContents = File.ReadAllText(FilePath);

                foreach (var dbEntry in database)
                {
                    foreach (string category in Categories)
                    {
                        if (dbEntry.Category == category)
                        {
                            int index = fileContents.IndexOf(dbEntry.ProblemPhrase, StringComparison.CurrentCultureIgnoreCase);
                            if (index >= 0)
                            {
                                string modified = fileContents.Insert(index, "*");
                                fileContents = modified;
                                wordCount++;
                                //NEW
                                keyHit.Add(dbEntry.ProblemPhrase);
                                keyHit.Add(dbEntry.Resources);
                                keyHit.Add(dbEntry.Link);
                                arrayCount += 3;

                            }
                        }
                    }
                }

                string ext1 = FilePath.Substring(0, FilePath.LastIndexOf("."));
                newFilePath = (ext1 + "UPDATED.txt");

                if (wordCount > 0)
                {
                    StringBuilder s = new StringBuilder(fileContents);

                    for (int i = 0; i < arrayCount; i += 3)
                    {
                        s.Append("\n\n" + "*" + keyHit[i] + "* ->  " + keyHit[i + 1] + "\nPlease see the following link for further information:  " + keyHit[i + 2] + ".");
                    }

                    fileContents = s.ToString();

                    Console.WriteLine("\nFound {0} unique problematic terms.", wordCount);
                    Console.WriteLine("See new file:\n\n          {0} \n\nProblematic terms/phrases are highlighted with an asterisk ( term --> *term ).", newFilePath);

                }

                else
                    Console.WriteLine("\nNo problematic terms were found.");

                File.WriteAllText(newFilePath, fileContents);

                return newFilePath;
            }


            public string EditDocxFile(List<ProblematicLanguage> database)
            {
                int wordCount = 0;
                
                // Open the docx file
                var document = DocumentModel.Load(FilePath);
                document.Settings.Footnote.NumberStyle = NumberStyle.Decimal;

                foreach (var dbEntry in database)
                {
                    foreach (string category in Categories)
                    {
                        if (dbEntry.Category == category)
                        {
                            var keyTerm = dbEntry.ProblemPhrase;
                            var searchRegex = new Regex($@"\b{Regex.Escape(keyTerm)}\b", RegexOptions.IgnoreCase);
                            foreach (var foundContent in document.Content.Find(searchRegex).Reverse())
                            {
                                wordCount++;
                                var foundText = foundContent.ToString();
                                var foundTextLower = foundText.ToLower();
                                var foundFormat = ((Run)foundContent.Start.Parent).CharacterFormat;

                                var replaceFormat = foundFormat.Clone();
                                if (category == "Anti-Black")
                                    replaceFormat.HighlightColor = GemBox.Document.Color.Yellow;
                                if (category == "Anti-Indigenous")
                                    replaceFormat.HighlightColor = GemBox.Document.Color.Magenta;

                                var replaceContent = foundContent.LoadText(foundText, replaceFormat);

                                var footnote = new GemBox.Document.Note(document, NoteType.Footnote,
                                    new Paragraph(document,
                                        new Run(document, $" {foundTextLower}: {dbEntry.Resources}"),
                                        new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                                        new Run(document, "Please see the following link for further information: "),
                                        new GemBox.Document.Hyperlink(document, dbEntry.Link, foundTextLower),
                                        new SpecialCharacter(document, SpecialCharacterType.LineBreak)));

                                replaceContent.End.InsertRange(footnote.Content);
                            }
                        }
                    }
                }

                string ext2 = FilePath.Substring(0, FilePath.LastIndexOf("."));
                string newFilePath2 = (ext2 + "UPDATED.docx");
                document.Save(newFilePath2);

                if (wordCount > 0)
                    Console.WriteLine("\nFound {0} problematic terms.", wordCount);

                else
                    Console.WriteLine("\nNo problematic terms were found.");
                    
                Console.WriteLine("See new file:\n\n          {0}", newFilePath2);
                return newFilePath2;
            }


            public string EditPdfFile(List<ProblematicLanguage> database)
            {
                int wordCount = 0;
                // Open the PDF file
                Document pdfDoc = new Document(FilePath);
                TextSearchOptions textSearchOptions = new TextSearchOptions(true);
                            //DocumentBuilder builder = new DocumentBuilder(pdfDoc);
                TextFragmentCollection textFragmentCollection;

                // Add page to pages collection of PDF
                Page page = pdfDoc.Pages.Add();

//MAKES SOLID LINE A DASHED LINE
/*                
                // Create GraphInfo object
                Aspose.Pdf.GraphInfo graph = new Aspose.Pdf.GraphInfo();
                // Set line width as 2
                graph.LineWidth = 2;
                // Set the color for graph object
                graph.Color = Aspose.Pdf.Color.Black;
                // Set dash array value as 3
                graph.DashArray = new int[] { 3 };
                // Set dash phase value as 1
                graph.DashPhase = 1;
                // Set footnote line style for page as graph
                page.NoteLineStyle = graph;
*/

                foreach (var dbEntry in database)
                {
                    foreach (string category in Categories)
                    {
                        if (dbEntry.Category == category)
                        {
                        TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber(dbEntry.ProblemPhrase);
                        //TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber("(?i)cakewalk", new TextSearchOptions(true));
                        pdfDoc.Pages.Accept(textFragmentAbsorber);
                        textFragmentCollection = textFragmentAbsorber.TextFragments;
                        //TextFragment textFragment = new TextFragment(dbEntry.ProblemPhrase);
                        //TextFragment text = new TextFragment(dbEntry.ProblemPhrase);
                    
                            foreach (var textFragment in textFragmentCollection)
                            {
                                wordCount++;
                                if (dbEntry.Category == "Anti-Black")
                                    textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Yellow);
                                if (dbEntry.Category == "Anti-Indigenous")
                                    textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Magenta);

                                textFragment.FootNote = new Aspose.Pdf.Note(" " + dbEntry.ProblemPhrase + ": " + dbEntry.Resources + "  Please see the following link for further information: " + dbEntry.Link);
                                // Add TextFragment to paragraphs collection of first page of document
                                page.Paragraphs.Add(textFragment);
                            }
                        }
                    }
                }

                string ext3 = FilePath.Substring(0, FilePath.LastIndexOf("."));
                string newFilePath3 = (ext3 + "UPDATED.pdf");
                pdfDoc.Save(newFilePath3);

                if (wordCount > 0)
                    Console.WriteLine("\nFound {0} problematic terms.", wordCount);

                else
                    Console.WriteLine("\nNo problematic terms were found.");

                Console.WriteLine("See new file:\n\n          {0}", newFilePath3);
                Console.WriteLine("(Press any key to return to main menu)");

                return newFilePath3;
            }
        }
    }
}
