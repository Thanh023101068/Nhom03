namespace ManHinhChinhQuanTri
{
    partial class frmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogOut = new MaterialSkin.Controls.MaterialButton();
            this.lblAdminInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAdminAvatar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.cardAccountList = new MaterialSkin.Controls.MaterialCard();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardPermissionDetail = new MaterialSkin.Controls.MaterialCard();
            this.btnResetPassword = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdatePermission = new MaterialSkin.Controls.MaterialButton();
            this.swActiveAccount = new MaterialSkin.Controls.MaterialSwitch();
            this.cmbNewRole = new MaterialSkin.Controls.MaterialComboBox();
            this.lblSelectedUser = new MaterialSkin.Controls.MaterialLabel();
            this.lblDetailTitle = new MaterialSkin.Controls.MaterialLabel();
            this.cardSearch = new MaterialSkin.Controls.MaterialCard();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtSearchAccount = new MaterialSkin.Controls.MaterialTextBox2();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.cardAccountList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.cardPermissionDetail.SuspendLayout();
            this.cardSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnLogOut);
            this.panelHeader.Controls.Add(this.lblAdminInfo);
            this.panelHeader.Controls.Add(this.picAdminAvatar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 67);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1412, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogOut.Depth = 0;
            this.btnLogOut.HighEmphasis = true;
            this.btnLogOut.Icon = null;
            this.btnLogOut.Location = new System.Drawing.Point(1285, 15);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogOut.Size = new System.Drawing.Size(103, 36);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "ĐĂNG XUẤT";
            this.btnLogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogOut.UseAccentColor = false;
            this.btnLogOut.UseVisualStyleBackColor = true;
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
            this.lblAdminInfo.Size = new System.Drawing.Size(25, 19);
            this.lblAdminInfo.TabIndex = 1;
            this.lblAdminInfo.Text = "......";
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
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMain.Controls.Add(this.cardAccountList, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.cardPermissionDetail, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.cardSearch, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 132);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1412, 750);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // cardAccountList
            // 
            this.cardAccountList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardAccountList.Controls.Add(this.dgvAccounts);
            this.cardAccountList.Depth = 0;
            this.cardAccountList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAccountList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardAccountList.Location = new System.Drawing.Point(15, 119);
            this.cardAccountList.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.cardAccountList.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardAccountList.Name = "cardAccountList";
            this.cardAccountList.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.cardAccountList.Size = new System.Drawing.Size(887, 616);
            this.cardAccountList.TabIndex = 1;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccounts.ColumnHeadersHeight = 45;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colFullName,
            this.colCurrentRole,
            this.colStatus});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.EnableHeadersVisualStyles = false;
            this.dgvAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAccounts.Location = new System.Drawing.Point(15, 15);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowHeadersWidth = 51;
            this.dgvAccounts.RowTemplate.Height = 40;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(857, 586);
            this.dgvAccounts.TabIndex = 0;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Tên đăng nhập";
            this.colUsername.MinimumWidth = 6;
            this.colUsername.Name = "colUsername";
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Họ tên người dùng";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            // 
            // colCurrentRole
            // 
            this.colCurrentRole.HeaderText = "Vai trò hiện tại";
            this.colCurrentRole.MinimumWidth = 6;
            this.colCurrentRole.Name = "colCurrentRole";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            // 
            // cardPermissionDetail
            // 
            this.cardPermissionDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardPermissionDetail.Controls.Add(this.btnResetPassword);
            this.cardPermissionDetail.Controls.Add(this.btnUpdatePermission);
            this.cardPermissionDetail.Controls.Add(this.swActiveAccount);
            this.cardPermissionDetail.Controls.Add(this.cmbNewRole);
            this.cardPermissionDetail.Controls.Add(this.lblSelectedUser);
            this.cardPermissionDetail.Controls.Add(this.lblDetailTitle);
            this.cardPermissionDetail.Depth = 0;
            this.cardPermissionDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPermissionDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardPermissionDetail.Location = new System.Drawing.Point(932, 15);
            this.cardPermissionDetail.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.cardPermissionDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardPermissionDetail.Name = "cardPermissionDetail";
            this.cardPermissionDetail.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.tableLayoutPanelMain.SetRowSpan(this.cardPermissionDetail, 2);
            this.cardPermissionDetail.Size = new System.Drawing.Size(465, 720);
            this.cardPermissionDetail.TabIndex = 2;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.AutoSize = false;
            this.btnResetPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetPassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResetPassword.Depth = 0;
            this.btnResetPassword.HighEmphasis = true;
            this.btnResetPassword.Icon = null;
            this.btnResetPassword.Location = new System.Drawing.Point(22, 323);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResetPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResetPassword.Size = new System.Drawing.Size(420, 47);
            this.btnResetPassword.TabIndex = 5;
            this.btnResetPassword.Text = "KHÔI PHỤC MẬT KHẨU MẶC ĐỊNH";
            this.btnResetPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnResetPassword.UseAccentColor = true;
            this.btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePermission
            // 
            this.btnUpdatePermission.AutoSize = false;
            this.btnUpdatePermission.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdatePermission.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdatePermission.Depth = 0;
            this.btnUpdatePermission.HighEmphasis = true;
            this.btnUpdatePermission.Icon = null;
            this.btnUpdatePermission.Location = new System.Drawing.Point(22, 260);
            this.btnUpdatePermission.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdatePermission.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdatePermission.Name = "btnUpdatePermission";
            this.btnUpdatePermission.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdatePermission.Size = new System.Drawing.Size(420, 47);
            this.btnUpdatePermission.TabIndex = 4;
            this.btnUpdatePermission.Text = "CẬP NHẬT QUYỀN HẠN";
            this.btnUpdatePermission.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdatePermission.UseAccentColor = false;
            this.btnUpdatePermission.UseVisualStyleBackColor = true;
            // 
            // swActiveAccount
            // 
            this.swActiveAccount.AutoSize = true;
            this.swActiveAccount.Depth = 0;
            this.swActiveAccount.Font = new System.Drawing.Font("Roboto", 12F);
            this.swActiveAccount.Location = new System.Drawing.Point(22, 188);
            this.swActiveAccount.Margin = new System.Windows.Forms.Padding(0);
            this.swActiveAccount.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swActiveAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.swActiveAccount.Name = "swActiveAccount";
            this.swActiveAccount.Ripple = true;
            this.swActiveAccount.Size = new System.Drawing.Size(195, 37);
            this.swActiveAccount.TabIndex = 3;
            this.swActiveAccount.Text = "Kích hoạt tài khoản";
            this.swActiveAccount.UseVisualStyleBackColor = true;
            // 
            // cmbNewRole
            // 
            this.cmbNewRole.AutoResize = false;
            this.cmbNewRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbNewRole.Depth = 0;
            this.cmbNewRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbNewRole.DropDownHeight = 174;
            this.cmbNewRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewRole.DropDownWidth = 121;
            this.cmbNewRole.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbNewRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbNewRole.Hint = "Chọn vai trò mới";
            this.cmbNewRole.IntegralHeight = false;
            this.cmbNewRole.ItemHeight = 43;
            this.cmbNewRole.Items.AddRange(new object[] {
            "Admin (Quản trị)",
            "Giảng viên",
            "Sinh viên",
            "Chuyên viên quản lý"});
            this.cmbNewRole.Location = new System.Drawing.Point(22, 115);
            this.cmbNewRole.MaxDropDownItems = 4;
            this.cmbNewRole.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbNewRole.Name = "cmbNewRole";
            this.cmbNewRole.Size = new System.Drawing.Size(420, 49);
            this.cmbNewRole.StartIndex = -1;
            this.cmbNewRole.TabIndex = 2;
            // 
            // lblSelectedUser
            // 
            this.lblSelectedUser.AutoSize = true;
            this.lblSelectedUser.Depth = 0;
            this.lblSelectedUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelectedUser.Location = new System.Drawing.Point(22, 62);
            this.lblSelectedUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelectedUser.Name = "lblSelectedUser";
            this.lblSelectedUser.Size = new System.Drawing.Size(172, 19);
            this.lblSelectedUser.TabIndex = 1;
            this.lblSelectedUser.Text = "Tài khoản đang chọn: ...";
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Depth = 0;
            this.lblDetailTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDetailTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblDetailTitle.Location = new System.Drawing.Point(19, 18);
            this.lblDetailTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(169, 19);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "THIẾT LẬP QUYỀN HẠN";
            // 
            // cardSearch
            // 
            this.cardSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSearch.Controls.Add(this.btnSearch);
            this.cardSearch.Controls.Add(this.txtSearchAccount);
            this.cardSearch.Depth = 0;
            this.cardSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardSearch.Location = new System.Drawing.Point(15, 15);
            this.cardSearch.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.cardSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardSearch.Name = "cardSearch";
            this.cardSearch.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.cardSearch.Size = new System.Drawing.Size(887, 74);
            this.cardSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(698, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(153, 38);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "TÌM TÀI KHOẢN";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.AnimateReadOnly = false;
            this.txtSearchAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearchAccount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchAccount.Depth = 0;
            this.txtSearchAccount.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSearchAccount.HideSelection = true;
            this.txtSearchAccount.Hint = "Nhập tên đăng nhập hoặc họ tên để tìm...";
            this.txtSearchAccount.LeadingIcon = null;
            this.txtSearchAccount.Location = new System.Drawing.Point(19, 12);
            this.txtSearchAccount.MaxLength = 32767;
            this.txtSearchAccount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.PasswordChar = '\0';
            this.txtSearchAccount.PrefixSuffixText = null;
            this.txtSearchAccount.ReadOnly = false;
            this.txtSearchAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchAccount.SelectedText = "";
            this.txtSearchAccount.SelectionLength = 0;
            this.txtSearchAccount.SelectionStart = 0;
            this.txtSearchAccount.ShortcutsEnabled = true;
            this.txtSearchAccount.Size = new System.Drawing.Size(655, 48);
            this.txtSearchAccount.TabIndex = 0;
            this.txtSearchAccount.TabStop = false;
            this.txtSearchAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchAccount.TrailingIcon = null;
            this.txtSearchAccount.UseSystemPasswordChar = false;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 885);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmPhanQuyen";
            this.Padding = new System.Windows.Forms.Padding(3, 67, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền & Quản trị Tài khoản Hệ thống";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.cardAccountList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.cardPermissionDetail.ResumeLayout(false);
            this.cardPermissionDetail.PerformLayout();
            this.cardSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialLabel lblAdminInfo;
        private System.Windows.Forms.PictureBox picAdminAvatar;
        private MaterialSkin.Controls.MaterialButton btnLogOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MaterialSkin.Controls.MaterialCard cardSearch;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearchAccount;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialCard cardAccountList;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private MaterialSkin.Controls.MaterialCard cardPermissionDetail;
        private MaterialSkin.Controls.MaterialLabel lblDetailTitle;
        private MaterialSkin.Controls.MaterialLabel lblSelectedUser;
        private MaterialSkin.Controls.MaterialComboBox cmbNewRole;
        private MaterialSkin.Controls.MaterialSwitch swActiveAccount;
        private MaterialSkin.Controls.MaterialButton btnUpdatePermission;
        private MaterialSkin.Controls.MaterialButton btnResetPassword;
    }
}