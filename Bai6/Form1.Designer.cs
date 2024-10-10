namespace Bai6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lstName = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNen = new System.Windows.Forms.Button();
            this.btnChu = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 80);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 33);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(6, 26);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(253, 30);
            this.txtNhap.TabIndex = 2;
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.ItemHeight = 22;
            this.lstName.Items.AddRange(new object[] {
            "Phan Thanh Điền",
            "Nguyễn Thị Bích Ngọc",
            "Phùng Văn Sơn"});
            this.lstName.Location = new System.Drawing.Point(12, 119);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(259, 114);
            this.lstName.TabIndex = 3;
            this.lstName.SelectedIndexChanged += new System.EventHandler(this.lstName_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 62);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập chuỗi";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(283, 12);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(435, 116);
            this.txtKQ.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(173, 80);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 33);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNen
            // 
            this.btnNen.Location = new System.Drawing.Point(430, 147);
            this.btnNen.Name = "btnNen";
            this.btnNen.Size = new System.Drawing.Size(144, 43);
            this.btnNen.TabIndex = 7;
            this.btnNen.Text = "Chọn màu nền";
            this.btnNen.UseVisualStyleBackColor = true;
            this.btnNen.Click += new System.EventHandler(this.btnNen_Click);
            // 
            // btnChu
            // 
            this.btnChu.Location = new System.Drawing.Point(283, 147);
            this.btnChu.Name = "btnChu";
            this.btnChu.Size = new System.Drawing.Size(141, 43);
            this.btnChu.TabIndex = 6;
            this.btnChu.Text = "Chọn màu chữ";
            this.btnChu.UseVisualStyleBackColor = true;
            this.btnChu.Click += new System.EventHandler(this.btnChu_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(580, 147);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(138, 41);
            this.btnFont.TabIndex = 8;
            this.btnFont.Text = "Chọn Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(430, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 43);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(761, 264);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnNen);
            this.Controls.Add(this.btnChu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNen;
        private System.Windows.Forms.Button btnChu;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnClose;
    }
}

