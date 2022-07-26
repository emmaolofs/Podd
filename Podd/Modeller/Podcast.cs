using Podd.Data;
using System;
using System.Collections.Generic;

namespace Podd.Modeller
{
    public class Podcast : IKategori
    {
        public string Url { get; set; }
        public int Uppdateringsintervall { get; set; }
        public string Kategori { get; set; }
        public List<Episod> Episodes { get; set; }
        public string Titel { get; set; }

        System.Windows.Forms.Timer t;

        public Podcast(string url, int uppdateringsintervall, Kategori kategori, List<Episod> episods, string titel)
        {
            this.Titel = titel;
            this.Kategori = kategori.Name;
            this.Uppdateringsintervall = uppdateringsintervall;
            this.Url = url;
            this.Episodes = episods;
            setTimer(Uppdateringsintervall);
        }

        public Podcast(string kategori, string titel, string url, int intervall)
        {
            this.Titel = titel;
            this.Kategori = kategori;
            this.Uppdateringsintervall = intervall;
            this.Url = url;
            this.Kategori = kategori;
            setTimer(Uppdateringsintervall);
        }

        public void setTimer(int Intervall)
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = Intervall * 60000;
            t.Tick += new EventHandler(Tick);
            t.Start();
        }

        public void setNyTimer()
        {
            t.Dispose();
            setTimer(Uppdateringsintervall);
        }

        private void Tick(object sender, EventArgs e)
        {
            Episodes = EpisodHanterare.getEpisodes(Url);
        }

        public string GetKategoriNamn()
        {
            return Kategori;
        }

        public void SetKategoriNamn(string kategori)
        {

            if (Kategori.Trim().Length > 0 && Kategori.Length < 10)
            {
                this.Kategori = kategori;
            }
        }
    }
}
