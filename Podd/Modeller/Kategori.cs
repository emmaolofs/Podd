using System.Collections.Generic;

namespace Podd.Modeller
{
    public class Kategori
    {
        public string Name { get; set; }
        public List<Podcast> Podcasts { get; set; }

        public Kategori(string name)
        {
            this.Name = name;
        }
    }
}
