using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chinatsu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayilar = new int[20];
        Random ran = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = ran.Next(100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in sayilar)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = sayilar.Max().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = sayilar.Min().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = sayilar.Sum().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = sayilar.Average().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s = int.Parse(textBox1.Text);
            if (sayilar[s]%2==0)
            {
                label1.Text = "Sayı Çifttir";
            }
            else
            {
                label1.Text = "Sayı Tektir";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string[] meyveler = new string[5] { "Elma", "Armut", "Kivi", "Muz", "Üzüm" };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in meyveler)
            {
                listBox3.Items.Add(item);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] kopyaMeyveler = new string[5];
            for (int i = 0; i < meyveler.Length; i++)
            {
                kopyaMeyveler[i] = meyveler[i];
            }
            foreach (var item in kopyaMeyveler)
            {
                listBox2.Items.Add(item);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
