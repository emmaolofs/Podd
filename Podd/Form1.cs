using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Podd.Modeller;
using Podd.Data;
using System.IO;

namespace Podd
{
    public partial class Form1 : Form
    {
        private List<Podcast> podcastListan;
        private List<Episod> episodListan;
        private int rowIndex;

        public Form1()
        {
            InitializeComponent();
            
            KategoriHanterare kategoriHanterare = new KategoriHanterare();

            string path2 = Directory.GetCurrentDirectory();
            string combinedPath = (path2 + "\\kategorier");
            Directory.SetCurrentDirectory(combinedPath);

            kategoriHanterare.fyllIKategorier(lbKategori);
            kategoriHanterare.fyllIKategorier(cbKategori);

            Directory.SetCurrentDirectory(path2);

            fyllIPoddar();
            podcastListan = new List<Podcast>();
            episodListan = new List<Episod>();

            Directory.SetCurrentDirectory(path2);
        }

        public void fyllIPoddar()
        {
            lvPoddar.Items.Clear();

            podcastListan = ReadRSS.Read();

            if (podcastListan.Count > 0)
            {
                foreach (var p in podcastListan)
                {
                    var item = new ListViewItem(new[] { p.Url, p.Titel, p.Kategori, p.Uppdateringsintervall.ToString() });
                    lvPoddar.Items.Add(item);
                }
            }
        }

        public void fyllIPoddar(List<Podcast> podcasts)
        {
            lvPoddar.Items.Clear();

            if (podcasts.Count > 0)
            {
                foreach (var p in podcasts)
                {
                    var item = new ListViewItem(new[] { p.Url, p.Titel, p.Kategori, p.Uppdateringsintervall.ToString() });
                    lvPoddar.Items.Add(item);
                }
            }
        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            string path2 = Directory.GetCurrentDirectory();
            string combinedPath = (path2 + "\\kategorier");
            Directory.SetCurrentDirectory(combinedPath);

            String kategoriNamn = txtKategori.Text;

            if (!File.Exists(kategoriNamn))
            {
                KategoriHanterare kategoriHanterare = new KategoriHanterare();
                kategoriHanterare.Spara(kategoriNamn);


                kategoriHanterare.fyllIKategorier(lbKategori);
                kategoriHanterare.fyllIKategorier(cbKategori);

            }
            else
            {
                MessageBox.Show("Kategorin finns redan");
            }
            txtKategori.Clear();
            Directory.SetCurrentDirectory(path2);
        }

        private void lbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Podcast> listan = new List<Podcast>();
            var podcasts = ReadRSS.Read();
            String item = "";

            foreach (int i in lbKategori.SelectedIndices)
            {
                item += lbKategori.Items[i] + Environment.NewLine;
            }
            txtKategori.Text = item;

            foreach (var p in podcasts)
            {
                if (p.Kategori.Equals(lbKategori.SelectedItem.ToString()))
                {
                    listan.Add(p);
                }
            }
            if (lbKategori.SelectedItem.ToString().Equals("Alla"))
            {
                fyllIPoddar();
            }
            else
            {
                fyllIPoddar(listan);
            }

        }

        private async void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            KategoriHanterare kategoriHanterare = new KategoriHanterare();
            string path2 = Directory.GetCurrentDirectory();

            String kategoriNamn = lbKategori.SelectedItems[0].ToString();

            await kategoriHanterare.TaBort(kategoriNamn);
            lbKategori.Items.Clear();
            cbKategori.Items.Clear();
            txtKategori.Clear();

           
            kategoriHanterare.fyllIKategorier(lbKategori);
            kategoriHanterare.fyllIKategorier(cbKategori);
            Directory.SetCurrentDirectory(path2);
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            string path2 = Directory.GetCurrentDirectory();
            string combinedPath = (path2 + "\\kategorier");
            Directory.SetCurrentDirectory(combinedPath);

            KategoriHanterare kategoriHanterare = new KategoriHanterare();
            String kategoriNamn = txtKategori.Text;

            var item = lbKategori.SelectedItem;

            File.Delete(item.ToString());
            kategoriHanterare.Spara(kategoriNamn);

            txtKategori.Clear();


            kategoriHanterare.fyllIKategorier(lbKategori);
            kategoriHanterare.fyllIKategorier(cbKategori);

            Directory.SetCurrentDirectory(path2);
        }

        private void btnNyPodd_Click(object sender, EventArgs e)
        {
            string path2 = Directory.GetCurrentDirectory();

            lvPoddar.Items.Clear();
            string url = txtURL.Text;

            string titel = PoddHanterare.titel(url);
            var frekvens = cbUppdateringsfrekvens.SelectedItem.ToString();
            int intervall = Convert.ToInt32(frekvens);

            Kategori kategori = new Kategori(cbKategori.SelectedItem.ToString());
            string kat = kategori.Name.ToString();

            Podcast podd = new Podcast(kat, titel, url, intervall);
            podd.setTimer(intervall);
            ParseRSS.ParseRSSFile(kat, titel, url, intervall);

            podcastListan.Add(podd);

            if(podcastListan.Count > 0)
            {
                foreach(var p in podcastListan)
                {
                    var item = new ListViewItem(new[] { p.Url, p.Titel, p.Kategori, p.Uppdateringsintervall.ToString() });
                    lvPoddar.Items.Add(item);
                }
            }
            txtURL.Clear();
            fyllIPoddar();
            Directory.SetCurrentDirectory(path2);
        }

        private void lvPoddar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvAvsnitt.Items.Clear();
            rbtBeskrivning.Clear();
            if (lvPoddar.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lvPoddar.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                String url = lvPoddar.Items[intselectedindex].Text;
                var episodes = EpisodHanterare.getEpisodes(url);
                foreach (var ep in episodes)
                {
                    lvAvsnitt.Items.Add(ep.Namn);
                    episodListan.Add(ep);
                }

                ListViewItem item = lvPoddar.SelectedItems[0];
                rowIndex = item.Index;
                txtURL.Text = item.SubItems[0].Text;
                cbKategori.Text = item.SubItems[2].Text;
                cbUppdateringsfrekvens.Text = item.SubItems[3].Text;
            }
        }

        private void lvAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAvsnitt.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lvAvsnitt.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                String titel = lvAvsnitt.Items[intselectedindex].Text;
                var Beskrivning = "";

                foreach (var episod in episodListan)
                {

                    if (titel == episod.Namn)
                    {
                        Beskrivning = episod.Beskrivning;
                    }
                }
                rbtBeskrivning.Clear();
                rbtBeskrivning.AppendText(Beskrivning);
                rbtBeskrivning.Update();
            }
        }

        private void btnTaBortPodd_Click(object sender, EventArgs e)
        {
            string path2 = Directory.GetCurrentDirectory();
            string url = txtURL.Text;

            foreach (var p in podcastListan)
            {
                if (p.Url == url)
                {
                    PoddHanterare.TaBortPodcast(url);
                    podcastListan.Remove(p);
                    break;
                }
            }

            lvAvsnitt.Clear();
            txtURL.Clear();
            fyllIPoddar();
            Directory.SetCurrentDirectory(path2);
        }

        private void btnSparaPodd_Click(object sender, EventArgs e)
        {
            
            string path2 = Directory.GetCurrentDirectory();
            string url = txtURL.Text;
            string titel = PoddHanterare.titel(url);
            var frekvens = cbUppdateringsfrekvens.SelectedItem.ToString();
            int intervall = Convert.ToInt32(frekvens);
            Modeller.Kategori kategori = new Modeller.Kategori(cbKategori.SelectedItem.ToString());
            string kat = kategori.Name.ToString();

            foreach (var p in podcastListan)
            {
                if (p.Url == lvPoddar.SelectedItems[0].Text)
                {

                    podcastListan.Remove(p);
                    string u = p.Url;
                    PoddHanterare.TaBortPodcast(u);
                    break;
                }
            }

            Podcast podd = new Podcast(kat, titel, url, intervall);
            podd.setNyTimer();
            ParseRSS.ParseRSSFile(kat, titel, url, intervall);

            podcastListan.Add(podd);

            if (podcastListan.Count > 0)
            {
                foreach (var p in podcastListan)
                {
                    var x = new ListViewItem(new[] { p.Url, p.Titel, p.Kategori, p.Uppdateringsintervall.ToString() });
                    lvPoddar.Items.Add(x);
                }
            }
            txtURL.Clear();
            fyllIPoddar();
            Directory.SetCurrentDirectory(path2);
        }
    }
}
