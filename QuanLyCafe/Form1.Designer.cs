namespace QuanLyCafe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dangnhap_dangKyBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dangnhap_close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dangnhap_userName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dangnhap_password = new System.Windows.Forms.TextBox();
            this.dangnhap_showPass = new System.Windows.Forms.CheckBox();
            this.dangnhap_dangNhapBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dangnhap_dangKyBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 484);
            this.panel1.TabIndex = 0;
            // 
            // dangnhap_dangKyBtn
            // 
            this.dangnhap_dangKyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.dangnhap_dangKyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhap_dangKyBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap_dangKyBtn.ForeColor = System.Drawing.Color.White;
            this.dangnhap_dangKyBtn.Location = new System.Drawing.Point(27, 439);
            this.dangnhap_dangKyBtn.Name = "dangnhap_dangKyBtn";
            this.dangnhap_dangKyBtn.Size = new System.Drawing.Size(287, 33);
            this.dangnhap_dangKyBtn.TabIndex = 7;
            this.dangnhap_dangKyBtn.Text = "ĐĂNG KÝ";
            this.dangnhap_dangKyBtn.UseVisualStyleBackColor = false;
            this.dangnhap_dangKyBtn.Click += new System.EventHandler(this.dangnhap_dangKyBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(106, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tạo một tài khoản";
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
            // dangnhap_close
            // 
            this.dangnhap_close.AutoSize = true;
            this.dangnhap_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dangnhap_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap_close.Location = new System.Drawing.Point(659, 6);
            this.dangnhap_close.Name = "dangnhap_close";
            this.dangnhap_close.Size = new System.Drawing.Size(18, 18);
            this.dangnhap_close.TabIndex = 1;
            this.dangnhap_close.Text = "X";
            this.dangnhap_close.Click += new System.EventHandler(this.dangnhap_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên người dùng:";
            // 
            // dangnhap_userName
            // 
            this.dangnhap_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap_userName.Location = new System.Drawing.Point(383, 181);
            this.dangnhap_userName.Name = "dangnhap_userName";
            this.dangnhap_userName.Size = new System.Drawing.Size(252, 26);
            this.dangnhap_userName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu:";
            // 
            // dangnhap_password
            // 
            this.dangnhap_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap_password.Location = new System.Drawing.Point(383, 258);
            this.dangnhap_password.Name = "dangnhap_password";
            this.dangnhap_password.PasswordChar = '*';
            this.dangnhap_password.Size = new System.Drawing.Size(252, 26);
            this.dangnhap_password.TabIndex = 3;
            // 
            // dangnhap_showPass
            // 
            this.dangnhap_showPass.AutoSize = true;
            this.dangnhap_showPass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap_showPass.Location = new System.Drawing.Point(383, 303);
            this.dangnhap_showPass.Name = "dangnhap_showPass";
            this.dangnhap_showPass.Size = new System.Drawing.Size(122, 22);
            this.dangnhap_showPass.TabIndex = 4;
            this.dangnhap_showPass.Text = "Hiện mật khẩu";
            this.dangnhap_showPass.UseVisualStyleBackColor = true;
            // 
            // dangnhap_dangNhapBtn
            // 
            this.dangnhap_dangNhapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.dangnhap_dangNhapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhap_dangNhapBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap_dangNhapBtn.ForeColor = System.Drawing.Color.White;
            this.dangnhap_dangNhapBtn.Location = new System.Drawing.Point(383, 343);
            this.dangnhap_dangNhapBtn.Name = "dangnhap_dangNhapBtn";
            this.dangnhap_dangNhapBtn.Size = new System.Drawing.Size(122, 33);
            this.dangnhap_dangNhapBtn.TabIndex = 5;
            this.dangnhap_dangNhapBtn.Text = "ĐĂNG NHẬP";
            this.dangnhap_dangNhapBtn.UseVisualStyleBackColor = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 484);
            this.Controls.Add(this.dangnhap_dangNhapBtn);
            this.Controls.Add(this.dangnhap_showPass);
            this.Controls.Add(this.dangnhap_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dangnhap_userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dangnhap_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dangnhap_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dangnhap_userName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dangnhap_password;
        private System.Windows.Forms.CheckBox dangnhap_showPass;
        private System.Windows.Forms.Button dangnhap_dangNhapBtn;
        private System.Windows.Forms.Button dangnhap_dangKyBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}

