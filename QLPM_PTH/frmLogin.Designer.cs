namespace QLPM_PTH
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Username = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Password = new MaterialSkin.Controls.MaterialTextBox();
            this.chk_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.btn_Login = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(125, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin đăng nhập";
            // 
            // txt_Username
            // 
            this.txt_Username.AnimateReadOnly = false;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Depth = 0;
            this.txt_Username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Username.Hint = "Tên đăng nhập";
            this.txt_Username.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txt_Username.LeadingIcon")));
            this.txt_Username.Location = new System.Drawing.Point(133, 175);
            this.txt_Username.MaxLength = 50;
            this.txt_Username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Username.Multiline = false;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(323, 50);
            this.txt_Username.TabIndex = 5;
            this.txt_Username.Text = "";
            this.txt_Username.TrailingIcon = null;
            this.txt_Username.UseAccent = false;
            // 
            // txt_Password
            // 
            this.txt_Password.AnimateReadOnly = false;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Depth = 0;
            this.txt_Password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Password.Hint = "Mật Khẩu";
            this.txt_Password.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txt_Password.LeadingIcon")));
            this.txt_Password.Location = new System.Drawing.Point(133, 270);
            this.txt_Password.MaxLength = 50;
            this.txt_Password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Password.Multiline = false;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(323, 50);
            this.txt_Password.TabIndex = 6;
            this.txt_Password.Text = "";
            this.txt_Password.TrailingIcon = null;
            this.txt_Password.UseAccent = false;
            // 
            // chk_HienMatKhau
            // 
            this.chk_HienMatKhau.AutoSize = true;
            this.chk_HienMatKhau.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HienMatKhau.Location = new System.Drawing.Point(133, 360);
            this.chk_HienMatKhau.Name = "chk_HienMatKhau";
            this.chk_HienMatKhau.Size = new System.Drawing.Size(183, 32);
            this.chk_HienMatKhau.TabIndex = 7;
            this.chk_HienMatKhau.Text = "Hiện mật khẩu";
            this.chk_HienMatKhau.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSize = false;
            this.btn_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Login.Depth = 0;
            this.btn_Login.HighEmphasis = true;
            this.btn_Login.Icon = null;
            this.btn_Login.Location = new System.Drawing.Point(133, 433);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Login.Size = new System.Drawing.Size(323, 36);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "ĐĂNG NHẬP";
            this.btn_Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Login.UseAccentColor = false;
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(497, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.chk_HienMatKhau);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     Quản lý Phòng máy tính/Phòng thực hành";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txt_Username;
        private MaterialSkin.Controls.MaterialTextBox txt_Password;
        private System.Windows.Forms.CheckBox chk_HienMatKhau;
        private MaterialSkin.Controls.MaterialButton btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

