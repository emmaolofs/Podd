using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podd.Data
{
    public class kHanterare2
    {
        public static void skapaKategori(string kategori)
        {
            string path1 = Directory.GetCurrentDirectory();
            string path2 = Path.Combine(path1, kategori);

            Directory.CreateDirectory(path2);
            string filename = kategori;
        }

        public void fillKat(ListBox listbox)
        {
            string path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);

            DirectoryInfo[] folders = di.GetDirectories();

            foreach (DirectoryInfo cat in folders)
            {
                listbox.Items.Add(cat);
            }
        }

        public void fillKat(ComboBox comboBox)
        {
            string path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);

            DirectoryInfo[] folders = di.GetDirectories();

            foreach (DirectoryInfo cat in folders)
            {
                comboBox.Items.Add(cat);
            }
        }

    }
}
