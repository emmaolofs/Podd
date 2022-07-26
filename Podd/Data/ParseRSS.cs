using System;
using System.IO;
using System.Windows.Forms;
using Podd.Modeller;

namespace Podd.Data
{
    public class ParseRSS
    {
        public static void ParseRSSFile(string kategori, string titel, string url, int intervall)
        {
            string path2 = Directory.GetCurrentDirectory();
            string combinedPath = (path2 + "\\Podcasts");
            try
            {

                Podcast podd = new Podcast(kategori, titel, url, intervall);

                String[] lines = { podd.Kategori, podd.Titel, podd.Url, podd.Uppdateringsintervall.ToString() };
                string filename = string.Format(titel, ".xml");

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(combinedPath, filename)))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
                
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Filen kunde inte sparas" + ex);
            }
        }
    }
}


