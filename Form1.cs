using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Пример 1");
            comboBox1.Items.Add("Пример 2");
            comboBox1.Items.Add("Пример 3");
            comboBox1.Items.Add("Пример 4");
            comboBox1.Items.Add("Пример 5");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пример 1")
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                double z = double.Parse(textBox3.Text);
                double pow = 2;
                double res = ((2 * (Math.Cos(x - (Math.PI / 6)))) / (0.5 + (Math.Pow(Math.Sin(y), pow)))) * (1 + ((Math.Pow(z, pow)) / 3 - ((Math.Pow(z, pow) / 5))));
                textBox4.Text = res.ToString();
            }
            else if (comboBox1.Text == "Пример 2")
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                double res = (x + y) * (x - y);
                textBox4.Text = res.ToString();
            }
            else if (comboBox1.Text == "Пример 3")
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                double res = Math.Pow(x, 3) + Math.Pow(y, 3);
                textBox4.Text = res.ToString();
            }
            else if (comboBox1.Text == "Пример 4")
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                double res = (x * Math.Sin(y)) + Math.Cos(x);
                textBox4.Text = res.ToString();
            }
            else if (comboBox1.Text == "Пример 5")
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                double z = double.Parse(textBox3.Text);
                double res = (x + y + z) / 3;
                textBox4.Text = res.ToString();
            }
        }
    }
}