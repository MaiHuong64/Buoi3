namespace Bai7
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTich = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThuong = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÉP TOÁN ĐƠN GIẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(58, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(72, 64);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 30);
            this.txtB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "b:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(72, 28);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 30);
            this.txtA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "a:";
            // 
            // txtKQ
            // 
            this.txtKQ.Enabled = false;
            this.txtKQ.Location = new System.Drawing.Point(130, 248);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(128, 30);
            this.txtKQ.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTong,
            this.mnHieu,
            this.mnTich,
            this.mnThuong});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(85, 24);
            this.toolStripMenuItem1.Text = "Tính toán";
            // 
            // mnTong
            // 
            this.mnTong.Name = "mnTong";
            this.mnTong.Size = new System.Drawing.Size(224, 26);
            this.mnTong.Text = "Tổng";
            this.mnTong.Click += new System.EventHandler(this.mnTong_Click);
            // 
            // mnHieu
            // 
            this.mnHieu.Name = "mnHieu";
            this.mnHieu.Size = new System.Drawing.Size(224, 26);
            this.mnHieu.Text = "Hiệu";
            this.mnHieu.Click += new System.EventHandler(this.mnHieu_Click);
            // 
            // mnTich
            // 
            this.mnTich.Name = "mnTich";
            this.mnTich.Size = new System.Drawing.Size(224, 26);
            this.mnTich.Text = "Tích";
            this.mnTich.Click += new System.EventHandler(this.mnTich_Click);
            // 
            // mnThuong
            // 
            this.mnThuong.Name = "mnThuong";
            this.mnThuong.Size = new System.Drawing.Size(224, 26);
            this.mnThuong.Text = "Thương";
            this.mnThuong.Click += new System.EventHandler(this.mnThuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(343, 348);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnTong;
        private System.Windows.Forms.ToolStripMenuItem mnHieu;
        private System.Windows.Forms.ToolStripMenuItem mnTich;
        private System.Windows.Forms.ToolStripMenuItem mnThuong;
    }
}

