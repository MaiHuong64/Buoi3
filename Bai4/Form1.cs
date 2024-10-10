using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoTen.Focus();
            }
            else
            {
                string hoten = this.txtHoTen.Text;
                if (this.rad1.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToLower();
                }
                if (this.rad2.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToUpper();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.txtKQ.Clear();
            this.rad1.Checked = false;
            this.rad2.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
