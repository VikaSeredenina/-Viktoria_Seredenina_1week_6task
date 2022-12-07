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
    public partial class Задание_3 : Form
    {
        public Задание_3()
        {
            InitializeComponent();
        }

        static int[,] Input( ref int n)
        {
           
            int[,] a = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < n; ++i)
                    for (int j = 0; j < n; ++j)
                    {
                        
                        a[i, j] = r.Next(-100, 100);
                }

            return a;

        }


       void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    textBox2.Text += a[i,j] + "\t";
                }
            textBox2.Text += Environment.NewLine;
        }

        void Print1(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    textBox3.Text += a[i, j] + "\t";
                }
            textBox3.Text += Environment.NewLine;
        }

        static int[,] Rezalt(int[,] a)
        {

            if (a.GetLength(0) % 2 == 0)
            {
                for (int i = 0; i < a.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        int temp = a[i + 1, j];
                        a[i + 1, j] = a[i, j];
                        a[i, j] = temp;
                    }
                    i++;
                }
                return a;
            }
            else return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int n = int.Parse(textBox1.Text);
           

            if (n <= 0)
            {
                MessageBox.Show("Введите целое число больше 0");
                return;
            }
            int[,] myArray = Input(ref n);
            Print(myArray);
            int[,] res = new int[n, n];

            res = Rezalt(myArray);
            Print1(res);
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox3.Clear();
         
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }
        }
    }
}
