using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Họ tên: {txtHoTen.Text}\n" +
                            $"Giới tính:{(radNam.Checked ? "Nam" : "Nữ")}\n" +
                            $"Ngày sinh: {dateTime.Text}\n" +
                            $"Địa chỉ: {txtDiaChi.Text}\n" +
                            $"Điện thoại: {txtDienThoai.Text}\n" +
                            $"Email: {txtEmail.Text}\n" +
                            $"Tình trạng: {(chkDiHoc.Checked ? "Đang đi học" : "Đang đi làm")}");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif|All Files (*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string imgPath = ofd.FileName;
                Image img  = Image.FromFile(imgPath);
                ptAnh.Image = img;
                ptAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
