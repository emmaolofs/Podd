using System.Collections.Generic;
using System.IO;
using System.Text;
using Podd.Modeller;

namespace Podd.Data
{
    public class ReadRSS : Serializer
    {
        public static List<Podcast> Read()
        {
            string path2 = Directory.GetCurrentDirectory();
            string combinedPath = (path2 + "\\Podcasts");
            Directory.SetCurrentDirectory(combinedPath);
            DirectoryInfo di = new DirectoryInfo(combinedPath);

            List<Podcast> inlastaPodcast = new List<Podcast>();
            foreach (var item in di.GetFiles("*"))
            {
                var fileStream = new FileStream(item.ToString(), FileMode.Open, FileAccess.Read);

                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    int counter = 0;
                    List<string> listan = new List<string>();
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        listan.Add(line);
                        counter++;
                    }
                    streamReader.Close();
                    string[] objektEgenskaper = listan.ToArray();
                    Podcast p = new Podcast(objektEgenskaper[0], objektEgenskaper[1], objektEgenskaper[2], int.Parse(objektEgenskaper[3]));
                    inlastaPodcast.Add(p);
                }
            }
            Directory.SetCurrentDirectory(path2);
            return inlastaPodcast;
        }

        public override List<Podcast> Podcasts()
        {
            var podcasts = ReadRSS.Read();
            return podcasts;

        }

    }
}


   