using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Podd.Modeller;

namespace Podd.Data
{
    public class KategoriHanterare
    {
        public int A;
        public string Z;
        public DateTime LastSaved;
        public int eon;
        private string dbpath;

        public static KategoriHanterare Load(string path)
        {
            KategoriHanterare kategoriHanterare;
            
            try
            {
                XmlSerializer s = new XmlSerializer(typeof(KategoriHanterare));

                using(StreamReader reader = File.OpenText(path))
                {
                    kategoriHanterare = (KategoriHanterare)s.Deserialize(reader);
                }
            }
            catch(Exception ex)
            {
                kategoriHanterare = new KategoriHanterare();
                MessageBox.Show("Något blev fel med inläsningen av kategorin" + ex);
            }

            kategoriHanterare.dbpath = path;
            return kategoriHanterare;
        }

        public void Spara(string kategoriNamn)
        {
            dbpath = kategoriNamn;

            try { 
                LastSaved = System.DateTime.Now;
                eon++;

                var s = new XmlSerializer(typeof(KategoriHanterare));
                var ns = new XmlSerializerNamespaces();

                ns.Add("", "");
                StreamWriter writer = File.CreateText(dbpath);

                s.Serialize(writer, this, ns);

                writer.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kategorin finns redan" + ex);
            }

        }

        public async Task TaBort(string kategoriNamn)
        {
            List<string> listan = new List<string>();

            var podcasts = ReadRSS.Read();

            if (podcasts.Count > 0)
            {
                foreach (var p in podcasts)
                {
                    var item = p.Kategori.ToString();
                    listan.Add(item);
                }
            }

            string path2 = Directory.GetCurrentDirectory();
            string combinedPath = (path2 + "\\kategorier");
            Directory.SetCurrentDirectory(combinedPath);

            if (kategoriNamn.Equals("Alla"))
            {
                MessageBox.Show("Den här kategorin går inte att ta bort!");
                return;
            }
            else if (listan.Contains(kategoriNamn))
            {
                MessageBox.Show("Kategorin tillhör en podcast och kan inte tas bort!");
            }
            else
            {
                File.Delete(kategoriNamn);
            }
        }

        public void fyllIKategorier(ListBox listbox)
        {
            listbox.Items.Clear();

            string path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);

            foreach (var item in di.GetFiles("*"))
            {
                listbox.Items.Add(item);
            }
 
        }

        public void fyllIKategorier(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            
            string path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);


            foreach (var item in di.GetFiles("*"))
            {
                comboBox.Items.Add(item);
            }
            
        }
    }
}

