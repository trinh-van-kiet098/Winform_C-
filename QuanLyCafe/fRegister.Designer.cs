namespace QuanLyCafe
{
    partial class fRegister
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dangky_dangNhapBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dangky_dangkyBtn = new System.Windows.Forms.Button();
            this.dangky_showPass = new System.Windows.Forms.CheckBox();
            this.dangky_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dangky_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dangky_close = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dangky_cPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCafe.Properties.Resources.Cafe_2;
            this.pictureBox1.Location = new System.Drawing.Point(108, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dangky_dangNhapBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 484);
            this.panel1.TabIndex = 6;
            // 
            // dangky_dangNhapBtn
            // 
            this.dangky_dangNhapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.dangky_dangNhapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangky_dangNhapBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangky_dangNhapBtn.ForeColor = System.Drawing.Color.White;
            this.dangky_dangNhapBtn.Location = new System.Drawing.Point(27, 439);
            this.dangky_dangNhapBtn.Name = "dangky_dangNhapBtn";
            this.dangky_dangNhapBtn.Size = new System.Drawing.Size(287, 33);
            this.dangky_dangNhapBtn.TabIndex = 7;
            this.dangky_dangNhapBtn.Text = "ĐĂNG NHẬP";
            this.dangky_dangNhapBtn.UseVisualStyleBackColor = false;
            this.dangky_dangNhapBtn.Click += new System.EventHandler(this.dangky_dangNhapBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(97, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bạn đã có tài khoản ư?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hệ thống quản lý quán cafe";
            // 
            // dangky_dangkyBtn
            // 
            this.dangky_dangkyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.dangky_dangkyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangky_dangkyBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangky_dangkyBtn.ForeColor = System.Drawing.Color.White;
            this.dangky_dangkyBtn.Location = new System.Drawing.Point(387, 390);
            this.dangky_dangkyBtn.Name = "dangky_dangkyBtn";
            this.dangky_dangkyBtn.Size = new System.Drawing.Size(122, 33);
            this.dangky_dangkyBtn.TabIndex = 14;
            this.dangky_dangkyBtn.Text = "ĐĂNG KÝ";
            this.dangky_dangkyBtn.UseVisualStyleBackColor = false;
            // 
            // dangky_showPass
            // 
            this.dangky_showPass.AutoSize = true;
            this.dangky_showPass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangky_showPass.Location = new System.Drawing.Point(387, 351);
            this.dangky_showPass.Name = "dangky_showPass";
            this.dangky_showPass.Size = new System.Drawing.Size(122, 22);
            this.dangky_showPass.TabIndex = 13;
            this.dangky_showPass.Text = "Hiện mật khẩu";
            this.dangky_showPass.UseVisualStyleBackColor = true;
            // 
            // dangky_password
            // 
            this.dangky_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangky_password.Location = new System.Drawing.Point(387, 246);
            this.dangky_password.Name = "dangky_password";
            this.dangky_password.PasswordChar = '*';
            this.dangky_password.Size = new System.Drawing.Size(252, 26);
            this.dangky_password.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu:";
            // 
            // dangky_username
            // 
            this.dangky_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangky_username.Location = new System.Drawing.Point(387, 181);
            this.dangky_username.Name = "dangky_username";
            this.dangky_username.Size = new System.Drawing.Size(252, 26);
            this.dangky_username.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên người dùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "ĐĂNG KÝ";
            // 
            // dangky_close
            // 
            this.dangky_close.AutoSize = true;
            this.dangky_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dangky_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangky_close.Location = new System.Drawing.Point(660, 6);
            this.dangky_close.Name = "dangky_close";
            this.dangky_close.Size = new System.Drawing.Size(18, 18);
            this.dangky_close.TabIndex = 7;
            this.dangky_close.Text = "X";
            this.dangky_close.Click += new System.EventHandler(this.dangky_close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Xác nhận mật khẩu:";
            // 
            // dangky_cPassword
            // 
            this.dangky_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangky_cPassword.Location = new System.Drawing.Point(387, 310);
            this.dangky_cPassword.Name = "dangky_cPassword";
            this.dangky_cPassword.PasswordChar = '*';
            this.dangky_cPassword.Size = new System.Drawing.Size(252, 26);
            this.dangky_cPassword.TabIndex = 11;
            // 
            // fRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dangky_dangkyBtn);
            this.Controls.Add(this.dangky_showPass);
            this.Controls.Add(this.dangky_cPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dangky_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dangky_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dangky_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fRegister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dangky_dangNhapBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dangky_dangkyBtn;
        private System.Windows.Forms.CheckBox dangky_showPass;
        private System.Windows.Forms.TextBox dangky_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dangky_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dangky_close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dangky_cPassword;
    }
}