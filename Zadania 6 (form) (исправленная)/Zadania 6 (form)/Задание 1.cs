using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania_6__form_
{
    public partial class Задание_1 : Form
    {

        public Задание_1()
        {
            InitializeComponent();
        }
        //ОДНОМЕРНЫЙ МАССИВ
        static int[] Input(ref int min, ref int max, int n, string[] elem)
        {

            int[] a = new int[n];


            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(elem[i]);
            }
            return a;
        }

        void Print(int[] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                textBox10.Text += a[i] + "\t";
            }
            textBox10.Text += Environment.NewLine;
        }

        static int Sum(int[] a, int min, int max)
        {
            int summa = 0;
            foreach (int elem in a)
            {
                if (elem > min && elem < max)
                    summa += elem;
            }
            return summa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = int.Parse(textBox3.Text);
            int max = int.Parse(textBox4.Text);
            if (min >= max)
            {
                MessageBox.Show("Верхняя граница должна быть больше нижней");
                return;
            }
            int n = int.Parse(textBox1.Text);
            if (n <= 0)
            {
                MessageBox.Show("Введите целое число больше 0");
                return;
            }

            try
            {
                string[] elem = textBox12.Text.Split(' ');
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
                int[] myArray = Input(ref min, ref max, n, elem);

                textBox5.Text += Sum(myArray, min, max);
            }
            catch
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox3.Text = "";
            textBox3.Clear();
            textBox4.Text = "";
            textBox4.Clear();
            textBox5.Text = "";
            textBox5.Clear();
            textBox10.Text = "";
            textBox10.Clear();
            textBox12.Text = "";
            textBox12.Clear();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }
        }


        //ДВУМЕРНЫЙ МАССИВ


        static int[,] Input1(ref int min, ref int max, int n, int m, string[,] elem)
        {


            int[,] a = new int[n, m];

            Random r = new Random();

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    a[i,j] = int.Parse(elem[i,j]);
                }
            return a;
        }

        void Print1(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    textBox11.Text += a[i, j] + "\t";
                }
                textBox11.Text += Environment.NewLine;
            }

        }

        static int Sum1(int[,] a, int min, int max)
        {
            int summa = 0;
            foreach (int elem in a)
            {
                if (elem > min && elem < max)
                    summa += elem;
            }
            return summa;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int min = int.Parse(textBox7.Text);
            int max = int.Parse(textBox6.Text);
            int m = int.Parse(textBox9.Text);
            if (min > max)
            {
                MessageBox.Show("Верхняя граница должна быть больше нижней");
                return;
            }

            int n = int.Parse(textBox8.Text);


            if (n <= 0)
            {
                MessageBox.Show("Введите целое число больше 0");
                return;
            }
            if (m <= 0)
            {
                MessageBox.Show("Введите целое число больше 0");
                return;
            }

            try
            {



                var sNums = new string[n, m];

                var arr1 = textBox13.Text.Split('\n');
                if (arr1.Length != n)
                {
                    MessageBox.Show("Длина массива не соответствует введенному");
                    return;
                }
                for (int i = 0; i < n; i++)
                {
                    var arr2 = arr1[i].Split(' ');
                    if (arr2.Length != m)
                    {
                        MessageBox.Show("Длина массива не соответствует введенному");
                        return;
                    }
                    for (int j = 0; j < m; j++)
                    {

                        sNums[i, j] = arr2[j];
                    }
                }

                int[,] myArray = Input1(ref min, ref max, n, m,sNums);

                Print1(myArray);
                textBox2.Text += Sum1(myArray, min, max);
            }
            catch
            {

            }
            }
        
       

      

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox8.Clear();
            textBox9.Text = "";
            textBox9.Clear();
            textBox6.Text = "";
            textBox6.Clear();
            textBox7.Text = "";
            textBox7.Clear();
            textBox11.Text = "";
            textBox11.Clear();
            textBox13.Text = "";
            textBox13.Clear();
            textBox2.Text = "";
            textBox2.Clear();
        }

        private void textBox8_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }
        }
    }
}

