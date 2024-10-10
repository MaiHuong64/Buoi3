using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if((this.txtUser.Text == "") || (this.txtPass.Text == ""))
                MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
            else
            {
                if ((this.txtUser.Text == "nguyenvanhung") && (this.txtPass.Text == "abc12345"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    Form2 f = new Form2();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                    this.txtUser.Clear();
                    this.txtPass.Clear(); this.txtUser.Focus();
                }
            }
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
