using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập n");
                return;
            }

            n = int.Parse(txt1.Text);

            if (n <= 0)
            {
                MessageBox.Show("n phải > 0");
                return;
            }

            a = new int[n];

            string s = "";

            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(1, 101);
                s += a[i] + " ";
            }

            txt2.Text = s;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
                MessageBox.Show("Hãy nhập dãy số trước");
                return;
            }

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }

            txt3.Text = sum.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
                MessageBox.Show("Hãy nhập dãy số trước");
                return;
            }

            Array.Sort(a);

            string s = "";

            for (int i = 0; i < n; i++)
            {
                s += a[i] + " ";
            }

            txt4.Text = s;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();

            txt1.Focus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
