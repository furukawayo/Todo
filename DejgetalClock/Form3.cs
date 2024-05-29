using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DejgetalClock
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.textBox1.Text = Properties.Settings.Default.check1;
            this.textBox2.Text = Properties.Settings.Default.check2;
            this.textBox3.Text = Properties.Settings.Default.check3;
            this.textBox4.Text = Properties.Settings.Default.check4;

            this.textBox5.Text = Properties.Settings.Default.button1;
            this.textBox6.Text = Properties.Settings.Default.button2;

            this.textBox7.Text = Properties.Settings.Default.url1;
            this.textBox8.Text = Properties.Settings.Default.url2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.check1 = this.textBox1.Text;
            Properties.Settings.Default.check2 = this.textBox2.Text;
            Properties.Settings.Default.check3 = this.textBox3.Text;
            Properties.Settings.Default.check4 = this.textBox4.Text;

            Properties.Settings.Default.button1 = this.textBox5.Text;
            Properties.Settings.Default.button2 = this.textBox6.Text;

            Properties.Settings.Default.url1 = this.textBox7.Text;
            Properties.Settings.Default.url2 = this.textBox8.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
