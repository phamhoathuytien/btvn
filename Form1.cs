using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            int start = Math.Min(a, b);
            int end = Math.Max(a, b);

            int tong = 0;

            for (int i = start; i <= end; i++)
            {
                tong += i;
            }

            lblKQ.Text = "Tổng các số từ " + start + " đến " + end + " là " + tong;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lblKQ.Text = "";
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
