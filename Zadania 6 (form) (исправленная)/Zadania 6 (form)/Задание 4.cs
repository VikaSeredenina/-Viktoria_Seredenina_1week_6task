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
    public partial class Задание_4 : Form
    {
        public Задание_4()
        {
            InitializeComponent();
        }

        static int[][] Input(int n)
        {
            Random r = new Random();
            int[][] a = new int[n][];
            
                for (int i = 0; i < n; ++i)
                {
                    a[i] = new int[n];
                    for (int j = 0; j < n; ++j)
                    {
                        a[i][j] = r.Next(-100, 100);
                }
                }
            return a;
        }

         void Print1(int[] a)
        {
           
            for (int i = 0; i < a.Length; ++i,textBox4.Text+=Environment.NewLine)
                textBox4.Text += a[i];
        }

         void Print2(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i,textBox2.Text +=Environment.NewLine)
                for (int j = 0; j < a[i].Length; ++j)
                    textBox2.Text += a[i][j] + "\t";
        }

        static int[] F(int num, int[][] array)
        {
            int[] res = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int counting = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] >= num)
                    {
                        counting++;

                    }
                    res[i] = counting;
                }

            }
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox3.Text);
            if (num <= 0)
            {
                MessageBox.Show("Введите целое число больше 0");
                return;
            }
            int n = int.Parse(textBox1.Text);
            if (n <= 0)
            {
                MessageBox.Show("Введите целое число больше 0");
                return;
            }
           
            int[][] myArray = Input(n);
           
            Print2(myArray);
            int[] rez = new int[myArray.Length];

            rez = F(num, myArray);
          
            Print1(rez);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox3.Clear();
            textBox4.Text = "";
            textBox4.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }
        }
    }
}

            