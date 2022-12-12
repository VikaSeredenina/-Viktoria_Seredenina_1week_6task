using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadania_6__form_
{
    public partial class Задание_2 : Form
    {
        public Задание_2()
        {
            InitializeComponent();
        }
       
        void Print(double[] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                textBox10.Text += a[i] + "\t";
            }
            textBox10.Text += Environment.NewLine;
        }
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            if (n <= 0)
            {
                MessageBox.Show("Введите целое число больше 0");
                return;
            }
            try
            {
                string[] elem = textBox2.Text.Split(' ');
                if (elem.Length != n)
                {
                    MessageBox.Show("Длина массива не соответсвует введенному!");
                    return;
                }
                List<double> doubles = new List<double>();

                foreach (string str in elem)
                {
                    try
                    {
                        doubles.Add(double.Parse(str));
                    }
                    catch
                    {
                        continue;
                    }
                }

                string result = "";

                foreach (double nums in doubles)
                {
                    result += nums + " ";

                }
                textBox10.Text += result;

                double[] myArray = new double[n];
                for (int i =0; i <n; i++)
                {
                    myArray[i] = double.Parse(elem[i]);
                }
                var min = Array.IndexOf(myArray, myArray.Min()); //нахождение минимального элемента
                var max = Array.IndexOf(myArray, myArray.Max()); //нахождение максимального элемента
                double sum = 0;

                if (min > max)
                {
                    for (int i = max + 1; i < min; i++)
                        sum += myArray[i];
                    textBox5.Text += sum;
                }
                else
                {
                    MessageBox.Show("Максимальный элемент встречается позже минимального");
                    return;
                }
            }
            catch
            {

            }
        }
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox10.Text = "";
            textBox10.Clear();
            textBox5.Text = "";
            textBox5.Clear();
            textBox2.Text = "";
            textBox2.Clear();
        }
    }  
}

