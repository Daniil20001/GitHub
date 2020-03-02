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

namespace Andreev_Kalc
{
    public partial class Form1 : Form
    {
        private bool point_was = false;
        private bool op_was = false;
        double a, b, res;
        int where_op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (op_was) ;
            else
            {
                textBox1.Text += "-";
                point_was = false;
                op_was = true;
                where_op = textBox1.Text.Length;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (op_was) ; else
            {
                textBox1.Text += "+";
                point_was = false;
                op_was = true;
                where_op = textBox1.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (op_was) ;
            else
            {
                textBox1.Text += "*";
                point_was = false;
                op_was = true;
                where_op = textBox1.Text.Length;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (op_was) ;
            else
            {
                textBox1.Text += "/";
                point_was = false;
                op_was = true;
                where_op = textBox1.Text.Length;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text.Substring(0, where_op - 1));
            b = Convert.ToDouble(textBox1.Text.Substring(where_op));
            switch (textBox1.Text[where_op-1])
            {
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                case '*':
                    res = a * b;
                    break;
                case '/':
                    if (b == 0) textBox1.Text = "На ноль делить нельзя,цуко!";
                
                    else res = a / b;
                    break;
            }
            if (!(b == 0 && textBox1.Text[where_op] == '/'))
            {
                label1.Text = textBox1.Text + " = " + Convert.ToString(res);
                textBox1.Text = Convert.ToString(res);
            }
            op_was = false;
            point_was = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            string patch = @"C:\Users\andrd\Desktop";
            DirectoryInfo dirinfo = new DirectoryInfo(patch);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            string text = textBox1.Text;

            using (FileStream fstream = new FileStream(@"C:\Users\andrd\Desktop\Подсчёт.txt", FileMode.OpenOrCreate)) 
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                fstream.Write(array, 0, array.Length);
            }
            using (FileStream fstream = File.OpenRead(@"C:\Users\andrd\Desktop\Подсчёт.txt"))
            {
                //convert 
                byte[] array = new byte[fstream.Length];
                //reading data 
                fstream.Read(array, 0, array.Length);
                //deconding 
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                label2.Text = textFromFile; 
            }
        }

        private void Стереть(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (point_was) ; else
            {
                textBox1.Text += ',';
                point_was = true;
            }
        }
    }
}
