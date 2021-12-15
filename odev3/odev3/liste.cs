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
namespace odev3
{
    public partial class liste : Form
    {
        public liste()
        {
            InitializeComponent();
        }

        private void liste_Load(object sender, EventArgs e)
        {
            StreamReader dosyaOkuyucu = new StreamReader(".\\dosya.txt");
            int i = 1;
            while (dosyaOkuyucu.EndOfStream == false)
            {
                richTextBox1.Text += i.ToString() + ". Ad - Soyad - TELEFONU\n";
                //richTextBox1.Text = richTextBox1.Text + dosyaOkuyucu.ReadLine().Replace('#',' ') + "\n";
                string satir = dosyaOkuyucu.ReadLine();
                string[] bilgiler = satir.Split('#');
                richTextBox1.Text = richTextBox1.Text + bilgiler[0] + "        " + bilgiler[1] + "          " + bilgiler[2] + "\n";
                i++;
            }
            dosyaOkuyucu.Close();
        }
    }
}
