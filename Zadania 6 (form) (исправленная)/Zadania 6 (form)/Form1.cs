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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Задание_1 one = new Задание_1();
            one.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Задание_2 two = new Задание_2();
            two.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Задание_3 tree = new Задание_3();
            tree.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Задание_4 fore = new Задание_4();
            fore.Show();
        }
    }
}
 