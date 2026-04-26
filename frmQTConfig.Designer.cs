namespace ManHinhChinhQuanTri
{
    partial class frmQTConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQTConfig));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblAdminInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAdminAvatar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.cardCurrentConfig = new MaterialSkin.Controls.MaterialCard();
            this.dgvConfigs = new System.Windows.Forms.DataGridView();
            this.colConfigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardEditDetail = new MaterialSkin.Controls.MaterialCard();
            this.btnRestoreDefault = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveConfig = new MaterialSkin.Controls.MaterialButton();
            this.swAllowStudentBooking = new MaterialSkin.Controls.MaterialSwitch();
            this.txtSystemMessage = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtMaxEquipment = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMinCancelHours = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtAdvanceDays = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblEditTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.cardCurrentConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigs)).BeginInit();
            this.cardEditDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblAdminInfo);
            this.panelHeader.Controls.Add(this.picAdminAvatar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 67);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1412, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // lblAdminInfo
            // 
            this.lblAdminInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdminInfo.AutoSize = true;
            this.lblAdminInfo.Depth = 0;
            this.lblAdminInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAdminInfo.Location = new System.Drawing.Point(567, 24);
            this.lblAdminInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminInfo.Name = "lblAdminInfo";
            this.lblAdminInfo.Size = new System.Drawing.Size(21, 19);
            this.lblAdminInfo.TabIndex = 1;
            this.lblAdminInfo.Text = ".....";
            this.lblAdminInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picAdminAvatar
            // 
            this.picAdminAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAdminAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAdminAvatar.Image")));
            this.picAdminAvatar.Location = new System.Drawing.Point(521, 15);
            this.picAdminAvatar.Name = "picAdminAvatar";
            this.picAdminAvatar.Size = new System.Drawing.Size(39, 38);
            this.picAdminAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdminAvatar.TabIndex = 0;
            this.picAdminAvatar.TabStop = false;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.Controls.Add(this.cardCurrentConfig, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.cardEditDetail, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 132);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1412, 750);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // cardCurrentConfig
            // 
            this.cardCurrentConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardCurrentConfig.Controls.Add(this.dgvConfigs);
            this.cardCurrentConfig.Depth = 0;
            this.cardCurrentConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCurrentConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardCurrentConfig.Location = new System.Drawing.Point(15, 15);
            this.cardCurrentConfig.Margin = new System.Windows.Forms.Padding(15);
            this.cardCurrentConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardCurrentConfig.Name = "cardCurrentConfig";
            this.cardCurrentConfig.Padding = new System.Windows.Forms.Padding(15);
            this.cardCurrentConfig.Size = new System.Drawing.Size(817, 720);
            this.cardCurrentConfig.TabIndex = 0;
            // 
            // dgvConfigs
            // 
            this.dgvConfigs.AllowUserToAddRows = false;
            this.dgvConfigs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConfigs.BackgroundColor = System.Drawing.Color.White;
            this.dgvConfigs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConfigs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConfigs.ColumnHeadersHeight = 45;
            this.dgvConfigs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConfigName,
            this.colValue,
            this.colDescription});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConfigs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConfigs.EnableHeadersVisualStyles = false;
            this.dgvConfigs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvConfigs.Location = new System.Drawing.Point(15, 15);
            this.dgvConfigs.Name = "dgvConfigs";
            this.dgvConfigs.RowHeadersVisible = false;
            this.dgvConfigs.RowHeadersWidth = 51;
            this.dgvConfigs.RowTemplate.Height = 40;
            this.dgvConfigs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConfigs.Size = new System.Drawing.Size(787, 690);
            this.dgvConfigs.TabIndex = 0;
            // 
            // colConfigName
            // 
            this.colConfigName.HeaderText = "Tên Quy Định";
            this.colConfigName.MinimumWidth = 6;
            this.colConfigName.Name = "colConfigName";
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Giá Trị";
            this.colValue.MinimumWidth = 6;
            this.colValue.Name = "colValue";
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Ghi Chú / Mô Tả";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            // 
            // cardEditDetail
            // 
            this.cardEditDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardEditDetail.Controls.Add(this.btnRestoreDefault);
            this.cardEditDetail.Controls.Add(this.btnSaveConfig);
            this.cardEditDetail.Controls.Add(this.swAllowStudentBooking);
            this.cardEditDetail.Controls.Add(this.txtSystemMessage);
            this.cardEditDetail.Controls.Add(this.txtMaxEquipment);
            this.cardEditDetail.Controls.Add(this.txtMinCancelHours);
            this.cardEditDetail.Controls.Add(this.txtAdvanceDays);
            this.cardEditDetail.Controls.Add(this.lblEditTitle);
            this.cardEditDetail.Depth = 0;
            this.cardEditDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardEditDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardEditDetail.Location = new System.Drawing.Point(862, 15);
            this.cardEditDetail.Margin = new System.Windows.Forms.Padding(15);
            this.cardEditDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardEditDetail.Name = "cardEditDetail";
            this.cardEditDetail.Padding = new System.Windows.Forms.Padding(22, 21, 22, 21);
            this.cardEditDetail.Size = new System.Drawing.Size(535, 720);
            this.cardEditDetail.TabIndex = 1;
            // 
            // btnRestoreDefault
            // 
            this.btnRestoreDefault.AutoSize = false;
            this.btnRestoreDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRestoreDefault.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRestoreDefault.Depth = 0;
            this.btnRestoreDefault.HighEmphasis = false;
            this.btnRestoreDefault.Icon = null;
            this.btnRestoreDefault.Location = new System.Drawing.Point(25, 604);
            this.btnRestoreDefault.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRestoreDefault.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRestoreDefault.Name = "btnRestoreDefault";
            this.btnRestoreDefault.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRestoreDefault.Size = new System.Drawing.Size(480, 42);
            this.btnRestoreDefault.TabIndex = 7;
            this.btnRestoreDefault.Text = "KHÔI PHỤC THAM SỐ MẶC ĐỊNH";
            this.btnRestoreDefault.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRestoreDefault.UseAccentColor = false;
            this.btnRestoreDefault.UseVisualStyleBackColor = true;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.AutoSize = false;
            this.btnSaveConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveConfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveConfig.Depth = 0;
            this.btnSaveConfig.HighEmphasis = true;
            this.btnSaveConfig.Icon = null;
            this.btnSaveConfig.Location = new System.Drawing.Point(25, 542);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveConfig.Size = new System.Drawing.Size(480, 47);
            this.btnSaveConfig.TabIndex = 6;
            this.btnSaveConfig.Text = "LƯU CẤU HÌNH HỆ THỐNG";
            this.btnSaveConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveConfig.UseAccentColor = false;
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            // 
            // swAllowStudentBooking
            // 
            this.swAllowStudentBooking.AutoSize = true;
            this.swAllowStudentBooking.Depth = 0;
            this.swAllowStudentBooking.Font = new System.Drawing.Font("Roboto", 12F);
            this.swAllowStudentBooking.Location = new System.Drawing.Point(25, 458);
            this.swAllowStudentBooking.Margin = new System.Windows.Forms.Padding(0);
            this.swAllowStudentBooking.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swAllowStudentBooking.MouseState = MaterialSkin.MouseState.HOVER;
            this.swAllowStudentBooking.Name = "swAllowStudentBooking";
            this.swAllowStudentBooking.Ripple = true;
            this.swAllowStudentBooking.Size = new System.Drawing.Size(253, 37);
            this.swAllowStudentBooking.TabIndex = 5;
            this.swAllowStudentBooking.Text = "Cho phép sinh viên đăng ký";
            this.swAllowStudentBooking.UseVisualStyleBackColor = true;
            // 
            // txtSystemMessage
            // 
            this.txtSystemMessage.AnimateReadOnly = false;
            this.txtSystemMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSystemMessage.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSystemMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSystemMessage.Depth = 0;
            this.txtSystemMessage.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSystemMessage.HideSelection = true;
            this.txtSystemMessage.Hint = "Thông báo hệ thống cho sinh viên";
            this.txtSystemMessage.Location = new System.Drawing.Point(25, 281);
            this.txtSystemMessage.MaxLength = 32767;
            this.txtSystemMessage.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSystemMessage.Name = "txtSystemMessage";
            this.txtSystemMessage.PasswordChar = '\0';
            this.txtSystemMessage.ReadOnly = false;
            this.txtSystemMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSystemMessage.SelectedText = "";
            this.txtSystemMessage.SelectionLength = 0;
            this.txtSystemMessage.SelectionStart = 0;
            this.txtSystemMessage.ShortcutsEnabled = true;
            this.txtSystemMessage.Size = new System.Drawing.Size(480, 156);
            this.txtSystemMessage.TabIndex = 4;
            this.txtSystemMessage.TabStop = false;
            this.txtSystemMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSystemMessage.UseSystemPasswordChar = false;
            // 
            // txtMaxEquipment
            // 
            this.txtMaxEquipment.AnimateReadOnly = false;
            this.txtMaxEquipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaxEquipment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaxEquipment.Depth = 0;
            this.txtMaxEquipment.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMaxEquipment.HideSelection = true;
            this.txtMaxEquipment.Hint = "Hạn mức mượn thiết bị bổ sung";
            this.txtMaxEquipment.LeadingIcon = null;
            this.txtMaxEquipment.Location = new System.Drawing.Point(25, 208);
            this.txtMaxEquipment.MaxLength = 32767;
            this.txtMaxEquipment.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaxEquipment.Name = "txtMaxEquipment";
            this.txtMaxEquipment.PasswordChar = '\0';
            this.txtMaxEquipment.PrefixSuffixText = null;
            this.txtMaxEquipment.ReadOnly = false;
            this.txtMaxEquipment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaxEquipment.SelectedText = "";
            this.txtMaxEquipment.SelectionLength = 0;
            this.txtMaxEquipment.SelectionStart = 0;
            this.txtMaxEquipment.ShortcutsEnabled = true;
            this.txtMaxEquipment.Size = new System.Drawing.Size(480, 48);
            this.txtMaxEquipment.TabIndex = 3;
            this.txtMaxEquipment.TabStop = false;
            this.txtMaxEquipment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaxEquipment.TrailingIcon = null;
            this.txtMaxEquipment.UseSystemPasswordChar = false;
            // 
            // txtMinCancelHours
            // 
            this.txtMinCancelHours.AnimateReadOnly = false;
            this.txtMinCancelHours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMinCancelHours.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMinCancelHours.Depth = 0;
            this.txtMinCancelHours.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMinCancelHours.HideSelection = true;
            this.txtMinCancelHours.Hint = "Thời gian hủy lịch tối thiểu (Giờ)";
            this.txtMinCancelHours.LeadingIcon = null;
            this.txtMinCancelHours.Location = new System.Drawing.Point(25, 135);
            this.txtMinCancelHours.MaxLength = 32767;
            this.txtMinCancelHours.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMinCancelHours.Name = "txtMinCancelHours";
            this.txtMinCancelHours.PasswordChar = '\0';
            this.txtMinCancelHours.PrefixSuffixText = null;
            this.txtMinCancelHours.ReadOnly = false;
            this.txtMinCancelHours.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinCancelHours.SelectedText = "";
            this.txtMinCancelHours.SelectionLength = 0;
            this.txtMinCancelHours.SelectionStart = 0;
            this.txtMinCancelHours.ShortcutsEnabled = true;
            this.txtMinCancelHours.Size = new System.Drawing.Size(480, 48);
            this.txtMinCancelHours.TabIndex = 2;
            this.txtMinCancelHours.TabStop = false;
            this.txtMinCancelHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMinCancelHours.TrailingIcon = null;
            this.txtMinCancelHours.UseSystemPasswordChar = false;
            // 
            // txtAdvanceDays
            // 
            this.txtAdvanceDays.AnimateReadOnly = false;
            this.txtAdvanceDays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAdvanceDays.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdvanceDays.Depth = 0;
            this.txtAdvanceDays.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtAdvanceDays.HideSelection = true;
            this.txtAdvanceDays.Hint = "Số ngày được đặt trước tối đa";
            this.txtAdvanceDays.LeadingIcon = null;
            this.txtAdvanceDays.Location = new System.Drawing.Point(25, 62);
            this.txtAdvanceDays.MaxLength = 32767;
            this.txtAdvanceDays.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdvanceDays.Name = "txtAdvanceDays";
            this.txtAdvanceDays.PasswordChar = '\0';
            this.txtAdvanceDays.PrefixSuffixText = null;
            this.txtAdvanceDays.ReadOnly = false;
            this.txtAdvanceDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdvanceDays.SelectedText = "";
            this.txtAdvanceDays.SelectionLength = 0;
            this.txtAdvanceDays.SelectionStart = 0;
            this.txtAdvanceDays.ShortcutsEnabled = true;
            this.txtAdvanceDays.Size = new System.Drawing.Size(480, 48);
            this.txtAdvanceDays.TabIndex = 1;
            this.txtAdvanceDays.TabStop = false;
            this.txtAdvanceDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdvanceDays.TrailingIcon = null;
            this.txtAdvanceDays.UseSystemPasswordChar = false;
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Depth = 0;
            this.lblEditTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEditTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblEditTitle.Location = new System.Drawing.Point(22, 21);
            this.lblEditTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(157, 19);
            this.lblEditTitle.TabIndex = 0;
            this.lblEditTitle.Text = "CHỈNH SỬA THAM SỐ";
            // 
            // frmQTConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 885);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmQTConfig";
            this.Padding = new System.Windows.Forms.Padding(3, 67, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập Quy định & Tham số Hệ thống";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.cardCurrentConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigs)).EndInit();
            this.cardEditDetail.ResumeLayout(false);
            this.cardEditDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialLabel lblAdminInfo;
        private System.Windows.Forms.PictureBox picAdminAvatar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MaterialSkin.Controls.MaterialCard cardCurrentConfig;
        private System.Windows.Forms.DataGridView dgvConfigs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfigName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private MaterialSkin.Controls.MaterialCard cardEditDetail;
        private MaterialSkin.Controls.MaterialLabel lblEditTitle;
        private MaterialSkin.Controls.MaterialTextBox2 txtAdvanceDays;
        private MaterialSkin.Controls.MaterialTextBox2 txtMinCancelHours;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaxEquipment;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtSystemMessage;
        private MaterialSkin.Controls.MaterialSwitch swAllowStudentBooking;
        private MaterialSkin.Controls.MaterialButton btnSaveConfig;
        private MaterialSkin.Controls.MaterialButton btnRestoreDefault;
    }
}