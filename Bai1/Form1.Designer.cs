namespace Bai1
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
            this.chkNho = new System.Windows.Forms.CheckBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // chkNho
            // 
            this.chkNho.AutoSize = true;
            this.chkNho.Location = new System.Drawing.Point(48, 100);
            this.chkNho.Margin = new System.Windows.Forms.Padding(4);
            this.chkNho.Name = "chkNho";
            this.chkNho.Size = new System.Drawing.Size(95, 26);
            this.chkNho.TabIndex = 1;
            this.chkNho.Text = "Ghi nhớ";
            this.chkNho.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtUser.Location = new System.Drawing.Point(175, 25);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(210, 32);
            this.txtUser.TabIndex = 2;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.Wheat;
            this.btnDangnhap.Location = new System.Drawing.Point(48, 134);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(115, 32);
            this.btnDangnhap.TabIndex = 3;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPass.Location = new System.Drawing.Point(175, 65);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(210, 33);
            this.txtPass.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Wheat;
            this.btnXoa.Location = new System.Drawing.Point(171, 134);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 32);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDung
            // 
            this.btnDung.BackColor = System.Drawing.Color.Wheat;
            this.btnDung.Location = new System.Drawing.Point(282, 134);
            this.btnDung.Margin = new System.Windows.Forms.Padding(4);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(103, 32);
            this.btnDung.TabIndex = 7;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = false;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(412, 194);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.chkNho);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNho;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDung;
    }
}

