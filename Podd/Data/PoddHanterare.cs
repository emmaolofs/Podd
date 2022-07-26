using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Podd.Data
{
    public class PoddHanterare
    {
        static string titeln = "";
        static bool titelnFinns = false;
        public static string titel(string url)
        {
            try
            {
                var xe = XElement.Load(url);
                titeln = xe.DescendantsAndSelf("channel").Elements("title").First().Value;
                titelnFinns = true;
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Titeln kunde inte hittas i den inlästa filen" + ex);
                titelnFinns = false;
            }
            return titeln;
        }

        public static bool getTitleExists()
        {
            return titelnFinns;
        }

        public static void TaBortPodcast(string url)
        {
            string path2 = Directory.GetCurrentDirectory();
            string combinedPath = (path2 + "\\Podcasts");
            Directory.SetCurrentDirectory(combinedPath);
            try
            {
                var titel = PoddHanterare.titel(url);

                File.Delete(titel);

            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("Filen kunde inte hittas och togs därför inte bort" + ex);
            }
            Directory.SetCurrentDirectory(path2);
        }

    }
}
