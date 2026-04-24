namespace MHSV
{
    partial class frmMHBaoCao
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMHBaoCao));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cardForm = new MaterialSkin.Controls.MaterialCard();
            this.btnGui = new MaterialSkin.Controls.MaterialButton();
            this.txtMoTa = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cboMay = new MaterialSkin.Controls.MaterialComboBox();
            this.cboPhong = new MaterialSkin.Controls.MaterialComboBox();
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
            this.panelHeader.Location = new System.Drawing.Point(3, 67);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1295, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Depth = 0;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUser.Location = new System.Drawing.Point(662, 22);
            this.lblUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(21, 19);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = ".....";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(616, 12);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(39, 38);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            // 
            // cardForm
            // 
            this.cardForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardForm.Controls.Add(this.btnGui);
            this.cardForm.Controls.Add(this.txtMoTa);
            this.cardForm.Controls.Add(this.cboMay);
            this.cardForm.Controls.Add(this.cboPhong);
            this.cardForm.Depth = 0;
            this.cardForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardForm.Location = new System.Drawing.Point(323, 135);
            this.cardForm.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.cardForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardForm.Name = "cardForm";
            this.cardForm.Padding = new System.Windows.Forms.Padding(33, 31, 33, 31);
            this.cardForm.Size = new System.Drawing.Size(655, 500);
            this.cardForm.TabIndex = 1;
            // 
            // btnGui
            // 
            this.btnGui.AutoSize = false;
            this.btnGui.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGui.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGui.Depth = 0;
            this.btnGui.HighEmphasis = true;
            this.btnGui.Icon = null;
            this.btnGui.Location = new System.Drawing.Point(218, 417);
            this.btnGui.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGui.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGui.Name = "btnGui";
            this.btnGui.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGui.Size = new System.Drawing.Size(218, 42);
            this.btnGui.TabIndex = 3;
            this.btnGui.Text = "GỬI BÁO CÁO";
            this.btnGui.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGui.UseAccentColor = false;
            // 
            // txtMoTa
            // 
            this.txtMoTa.AnimateReadOnly = false;
            this.txtMoTa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMoTa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.Depth = 0;
            this.txtMoTa.HideSelection = true;
            this.txtMoTa.Hint = "Mô tả chi tiết lỗi (Ví dụ: Bàn phím không gõ được, màn hình sọc...)";
            this.txtMoTa.Location = new System.Drawing.Point(55, 229);
            this.txtMoTa.MaxLength = 32767;
            this.txtMoTa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.ReadOnly = false;
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.SelectionLength = 0;
            this.txtMoTa.SelectionStart = 0;
            this.txtMoTa.ShortcutsEnabled = true;
            this.txtMoTa.Size = new System.Drawing.Size(545, 156);
            this.txtMoTa.TabIndex = 2;
            this.txtMoTa.TabStop = false;
            this.txtMoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMoTa.UseSystemPasswordChar = false;
            // 
            // cboMay
            // 
            this.cboMay.AutoResize = false;
            this.cboMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMay.Depth = 0;
            this.cboMay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboMay.DropDownHeight = 174;
            this.cboMay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMay.DropDownWidth = 121;
            this.cboMay.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboMay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboMay.Hint = "Chọn máy tính bị hỏng";
            this.cboMay.IntegralHeight = false;
            this.cboMay.ItemHeight = 43;
            this.cboMay.Location = new System.Drawing.Point(55, 135);
            this.cboMay.MaxDropDownItems = 4;
            this.cboMay.MouseState = MaterialSkin.MouseState.OUT;
            this.cboMay.Name = "cboMay";
            this.cboMay.Size = new System.Drawing.Size(545, 49);
            this.cboMay.StartIndex = 0;
            this.cboMay.TabIndex = 1;
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
            this.cboPhong.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboPhong.Hint = "Chọn phòng máy xảy ra sự cố";
            this.cboPhong.IntegralHeight = false;
            this.cboPhong.ItemHeight = 43;
            this.cboPhong.Location = new System.Drawing.Point(55, 47);
            this.cboPhong.MaxDropDownItems = 4;
            this.cboPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(545, 49);
            this.cboPhong.StartIndex = 0;
            this.cboPhong.TabIndex = 0;
            // 
            // frmMHBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 623);
            this.Controls.Add(this.cardForm);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMHBaoCao";
            this.Padding = new System.Windows.Forms.Padding(3, 67, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo sự cố";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.cardForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialCard cardForm;
        private MaterialSkin.Controls.MaterialComboBox cboPhong;
        private MaterialSkin.Controls.MaterialComboBox cboMay;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtMoTa;
        private MaterialSkin.Controls.MaterialButton btnGui;
        private MaterialSkin.Controls.MaterialLabel lblUser;
        private System.Windows.Forms.PictureBox picAvatar;
    }
}