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
        static int[] Input(ref int min, ref int max,int n)
        {
           

            int[] a = new int[n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(-100, 100);
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
            int n = int.Parse(textBox1.Text);
            if (min >= max)
            {
                MessageBox.Show("Верхняя граница должна быть больше нижней");
                return;
            }

            if (n <= 0)
            {
                MessageBox.Show("Введите целое число больше 0");
                return;
            }
            int[] myArray = Input(ref min, ref max, n);

            Print(myArray);
            textBox5.Text += Sum(myArray, min, max);
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

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }
        }


        //ДВУМЕРНЫЙ МАССИВ


        static int[,] Input1(ref int min, ref int max, int n, int m)
        {


            int[,] a = new int[n, m];

            Random r = new Random();

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    a[i, j] = r.Next(-100, 100);
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
            int n = int.Parse(textBox8.Text);
            int m = int.Parse(textBox9.Text);
            if (min > max)
            {
                MessageBox.Show("Верхняя граница должна быть больше нижней");
                return;
            }


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
            int[,] myArray = Input1(ref min, ref max, n,m);

            Print1(myArray);
            textBox2.Text += Sum1(myArray, min, max);
        }

        private void button3_Click(object sender, EventArgs e)
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
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

