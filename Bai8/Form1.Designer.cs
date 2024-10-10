namespace Bai8
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
            this.cbHoTen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbHoTen
            // 
            this.cbHoTen.FormattingEnabled = true;
            this.cbHoTen.Items.AddRange(new object[] {
            "Nguyễn Văn A",
            "Trần Văn C",
            "Lý Thị D"});
            this.cbHoTen.Location = new System.Drawing.Point(153, 81);
            this.cbHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHoTen.Name = "cbHoTen";
            this.cbHoTen.Size = new System.Drawing.Size(165, 30);
            this.cbHoTen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên:";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(169, 179);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(103, 32);
            this.btnHienThi.TabIndex = 2;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(472, 224);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHoTen);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHienThi;
    }
}

