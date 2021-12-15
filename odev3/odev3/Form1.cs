using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eklem frm = new eklem();
            frm.ShowDialog();

        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            liste frm = new liste();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete frm = new delete();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guncelleme frm = new guncelleme();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
