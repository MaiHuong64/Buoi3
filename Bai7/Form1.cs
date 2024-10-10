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

namespace Bai7
{
    public partial class Form1 : Form
    {
        double a, b;
        public Form1()
        {
            InitializeComponent();
        }
        public void getNum()
        {
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                if (string.IsNullOrEmpty(txtA.Text) || string.IsNullOrEmpty(txtB.Text))
                {
                    MessageBox.Show("Ô tính không được để trống");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập sai định dạng");
                this.txtA.Text = " ";
                this.txtB.Text = " ";
                this.txtKQ.Text = " ";
            }
        }
        private void mnTong_Click(object sender, EventArgs e)
        { 
            getNum();
            txtKQ.Text = (a + b).ToString();
           
        }
        private void mnHieu_Click(object sender, EventArgs e)
        {
            getNum();
            txtKQ.Text = (a - b).ToString();
        }

        private void mnTich_Click(object sender, EventArgs e)
        {
            getNum();
            txtKQ.Text = (a * b).ToString();
        }
        private void mnThuong_Click(object sender, EventArgs e)
        {
            getNum();
            if (b == 0)
            {
                MessageBox.Show("Mẫu không được bằng 0");
                this.txtA.Clear();
                this.txtB.Clear();
                this.txtKQ.Clear();
                return;
            }
            else
                txtKQ.Text = (a / b).ToString();
        }
    }
}
