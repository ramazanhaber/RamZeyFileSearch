using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamZeyFileSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path = txtDosyaYolu.Text;
            allFileInDirectory(path, txtAranilacakText.Text, txtDosyaTip.Text.Split(','));

            MessageBox.Show("Arama Bitti");
        }
        public void allFileInDirectory(string path, string bul, string[] buluncaklar)
        {
            foreach (var item in buluncaklar)
            {
                string[] allfiles = Directory.GetFiles(path, item, SearchOption.AllDirectories);

                foreach (var file in allfiles)
                {
                    FileInfo info = new FileInfo(file);
                    string fullname = info.FullName.ToString();
                    string content = File.ReadAllText(fullname);
                    if (content.ToLower().Contains(bul.ToLower()))
                    {
                        //Console.WriteLine(fullname);
                        listBox1.Items.Add(fullname);
                    }
                }
            }
        }




        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                string s = listBox1.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, s);

                //MessageBox.Show("DOSYA YOLU KOPYALANDI !");
            }

        }
    }
}
