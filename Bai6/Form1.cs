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

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập vào chuỗi");
                return;
            }
            else
            {
                this.lstName.Items.Add(this.txtNhap.Text);
                this.txtNhap.Clear();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           if(this.lstName.SelectedIndex > 0)
                this.lstName.Items.RemoveAt(this.lstName.SelectedIndex);
           else
                MessageBox.Show("Không tồn tại phần tử trong list");
        }

        private void btnChu_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                txtKQ.ForeColor = color.Color;
        }

        private void btnNen_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if(color.ShowDialog() == DialogResult.OK)
                txtKQ.BackColor = color.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                txtKQ.Font = fontDialog.Font;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void lstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstName.SelectedIndex > 0)
                txtKQ.Text = this.lstName.SelectedItem.ToString();
            else
                MessageBox.Show("Không tồn tại mục trong list");
        }
    }
}
