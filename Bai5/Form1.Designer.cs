namespace Bai5
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(146, 45);
            this.txtN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(136, 30);
            this.txtN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập n =";
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad1.Location = new System.Drawing.Point(8, 29);
            this.rad1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(260, 26);
            this.rad1.TabIndex = 2;
            this.rad1.TabStop = true;
            this.rad1.Text = "Các ước số chung của n và m";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.Violet;
            this.btnTinh.Location = new System.Drawing.Point(17, 228);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(103, 32);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad2);
            this.groupBox1.Controls.Add(this.rad1);
            this.groupBox1.Location = new System.Drawing.Point(301, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(336, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập m =";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(146, 106);
            this.txtM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(136, 30);
            this.txtM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả là:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(13, 176);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(624, 30);
            this.txtKQ.TabIndex = 7;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(8, 65);
            this.rad2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(297, 26);
            this.rad2.TabIndex = 3;
            this.rad2.TabStop = true;
            this.rad2.Text = "Ước số chung lớn nhất của n và m";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Violet;
            this.btnXoa.Location = new System.Drawing.Point(258, 228);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Violet;
            this.btnThoat.Location = new System.Drawing.Point(503, 228);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 32);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(677, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
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

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

