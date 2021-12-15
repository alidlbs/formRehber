using System;
using System.Windows.Forms;
using System.IO;
namespace odev3
{
    public partial class eklem : Form
    {
        public eklem()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eklem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter dosyaYazici = new StreamWriter(".\\dosya.txt", true);
            dosyaYazici.WriteLine(textBox_AD.Text + "#" + textBox_SOY.Text + "#" + textBox_TLF.Text);
            dosyaYazici.Close();
            DialogResult dr = MessageBox.Show("Ekleme başarılı. Yeni ekleme yapacak mısınız?", "Başarılı", MessageBoxButtons.YesNo);
            if (textBox_AD.Text == ""|| textBox_SOY.Text==null||textBox_TLF.Text==null){

                MessageBox.Show("boşluk var ");
            }
            else
            {

                if (dr == DialogResult.Yes)
                {
                    textBox_AD.Text = "";
                    textBox_SOY.Text = "";
                    textBox_TLF.Text = "";

                }

                else
                {
                    this.Close();
                }

            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
