namespace MHSV
{
    partial class frmMHDKPhong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMHDKPhong));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cardForm = new MaterialSkin.Controls.MaterialCard();
            this.btnXacNhan = new MaterialSkin.Controls.MaterialButton();
            this.txtMucDich = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cboCa = new MaterialSkin.Controls.MaterialComboBox();
            this.cboPhong = new MaterialSkin.Controls.MaterialComboBox();
            this.lblNgay = new MaterialSkin.Controls.MaterialLabel();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.cardForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblUser);
            this.panelHeader.Controls.Add(this.picAvatar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 64);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1164, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Depth = 0;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUser.Location = new System.Drawing.Point(575, 30);
            this.lblUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(21, 19);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = ".....";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(533, 13);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(36, 36);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            // 
            // cardForm
            // 
            this.cardForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardForm.Controls.Add(this.btnXacNhan);
            this.cardForm.Controls.Add(this.txtMucDich);
            this.cardForm.Controls.Add(this.cboCa);
            this.cardForm.Controls.Add(this.cboPhong);
            this.cardForm.Controls.Add(this.lblNgay);
            this.cardForm.Controls.Add(this.dtpNgayMuon);
            this.cardForm.Depth = 0;
            this.cardForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardForm.Location = new System.Drawing.Point(285, 130);
            this.cardForm.Margin = new System.Windows.Forms.Padding(14);
            this.cardForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardForm.Name = "cardForm";
            this.cardForm.Padding = new System.Windows.Forms.Padding(30);
            this.cardForm.Size = new System.Drawing.Size(600, 520);
            this.cardForm.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AutoSize = false;
            this.btnXacNhan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXacNhan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXacNhan.Depth = 0;
            this.btnXacNhan.HighEmphasis = true;
            this.btnXacNhan.Icon = null;
            this.btnXacNhan.Location = new System.Drawing.Point(175, 450);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXacNhan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXacNhan.Size = new System.Drawing.Size(250, 45);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "GỬI YÊU CẦU ĐĂNG KÝ";
            this.btnXacNhan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXacNhan.UseAccentColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtMucDich
            // 
            this.txtMucDich.AnimateReadOnly = false;
            this.txtMucDich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMucDich.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMucDich.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMucDich.Depth = 0;
            this.txtMucDich.HideSelection = true;
            this.txtMucDich.Hint = "Mô tả mục đích sử dụng";
            this.txtMucDich.Location = new System.Drawing.Point(50, 270);
            this.txtMucDich.MaxLength = 32767;
            this.txtMucDich.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMucDich.Name = "txtMucDich";
            this.txtMucDich.PasswordChar = '\0';
            this.txtMucDich.ReadOnly = false;
            this.txtMucDich.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMucDich.SelectedText = "";
            this.txtMucDich.SelectionLength = 0;
            this.txtMucDich.SelectionStart = 0;
            this.txtMucDich.ShortcutsEnabled = true;
            this.txtMucDich.Size = new System.Drawing.Size(500, 150);
            this.txtMucDich.TabIndex = 4;
            this.txtMucDich.TabStop = false;
            this.txtMucDich.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMucDich.UseSystemPasswordChar = false;
            // 
            // cboCa
            // 
            this.cboCa.AutoResize = false;
            this.cboCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCa.Depth = 0;
            this.cboCa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCa.DropDownHeight = 174;
            this.cboCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCa.DropDownWidth = 121;
            this.cboCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCa.Hint = "Chọn ca mượn";
            this.cboCa.IntegralHeight = false;
            this.cboCa.ItemHeight = 43;
            this.cboCa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboCa.Location = new System.Drawing.Point(50, 190);
            this.cboCa.MaxDropDownItems = 4;
            this.cboCa.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCa.Name = "cboCa";
            this.cboCa.Size = new System.Drawing.Size(500, 49);
            this.cboCa.StartIndex = 0;
            this.cboCa.TabIndex = 3;
            // 
            // cboPhong
            // 
            this.cboPhong.AutoResize = false;
            this.cboPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboPhong.Depth = 0;
            this.cboPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPhong.DropDownHeight = 174;
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.DropDownWidth = 121;
            this.cboPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboPhong.Hint = "Chọn phòng máy";
            this.cboPhong.IntegralHeight = false;
            this.cboPhong.ItemHeight = 43;
            this.cboPhong.Location = new System.Drawing.Point(50, 110);
            this.cboPhong.MaxDropDownItems = 4;
            this.cboPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(500, 49);
            this.cboPhong.StartIndex = 0;
            this.cboPhong.TabIndex = 2;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Depth = 0;
            this.lblNgay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNgay.Location = new System.Drawing.Point(50, 45);
            this.lblNgay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(104, 19);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày sử dụng:";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(180, 42);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(370, 30);
            this.dtpNgayMuon.TabIndex = 1;
            // 
            // frmMHDKPhong
            // 
            this.ClientSize = new System.Drawing.Size(1170, 707);
            this.Controls.Add(this.cardForm);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmMHDKPhong";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký sử dụng phòng";
            this.Load += new System.EventHandler(this.frmMHDKPhong_Load_1);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.cardForm.ResumeLayout(false);
            this.cardForm.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialCard cardForm;
        private MaterialSkin.Controls.MaterialComboBox cboPhong;
        private MaterialSkin.Controls.MaterialComboBox cboCa;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtMucDich;
        private MaterialSkin.Controls.MaterialButton btnXacNhan;
        private MaterialSkin.Controls.MaterialLabel lblNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private MaterialSkin.Controls.MaterialLabel lblUser;
        private System.Windows.Forms.PictureBox picAvatar;
    }
}