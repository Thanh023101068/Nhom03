namespace ManHinhChinhQuanTri
{
    partial class frmQTData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQTData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblAdminInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAdminAvatar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.cardHistory = new MaterialSkin.Controls.MaterialCard();
            this.lblHistoryTitle = new MaterialSkin.Controls.MaterialLabel();
            this.dgvDataHistory = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActions = new System.Windows.Forms.Panel();
            this.cardBackup = new MaterialSkin.Controls.MaterialCard();
            this.btnBrowseBackup = new MaterialSkin.Controls.MaterialButton();
            this.btnExecuteBackup = new MaterialSkin.Controls.MaterialButton();
            this.txtBackupPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblBackupTitle = new MaterialSkin.Controls.MaterialLabel();
            this.cardRestore = new MaterialSkin.Controls.MaterialCard();
            this.lblRestoreWarning = new MaterialSkin.Controls.MaterialLabel();
            this.btnBrowseRestore = new MaterialSkin.Controls.MaterialButton();
            this.btnExecuteRestore = new MaterialSkin.Controls.MaterialButton();
            this.txtRestoreFile = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblRestoreTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.cardHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataHistory)).BeginInit();
            this.panelActions.SuspendLayout();
            this.cardBackup.SuspendLayout();
            this.cardRestore.SuspendLayout();
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
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.Controls.Add(this.cardHistory, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelActions, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 132);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1412, 750);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // cardHistory
            // 
            this.cardHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardHistory.Controls.Add(this.lblHistoryTitle);
            this.cardHistory.Controls.Add(this.dgvDataHistory);
            this.cardHistory.Depth = 0;
            this.cardHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardHistory.Location = new System.Drawing.Point(15, 15);
            this.cardHistory.Margin = new System.Windows.Forms.Padding(15);
            this.cardHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardHistory.Name = "cardHistory";
            this.cardHistory.Padding = new System.Windows.Forms.Padding(15);
            this.cardHistory.Size = new System.Drawing.Size(817, 720);
            this.cardHistory.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Depth = 0;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHistoryTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblHistoryTitle.Location = new System.Drawing.Point(19, 18);
            this.lblHistoryTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(235, 19);
            this.lblHistoryTitle.TabIndex = 1;
            this.lblHistoryTitle.Text = "NHẬT KÝ SAO LƯU & KHÔI PHỤC";
            // 
            // dgvDataHistory
            // 
            this.dgvDataHistory.AllowUserToAddRows = false;
            this.dgvDataHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataHistory.ColumnHeadersHeight = 45;
            this.dgvDataHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTime,
            this.colAction,
            this.colFilePath,
            this.colStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataHistory.EnableHeadersVisualStyles = false;
            this.dgvDataHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDataHistory.Location = new System.Drawing.Point(15, 52);
            this.dgvDataHistory.Name = "dgvDataHistory";
            this.dgvDataHistory.RowHeadersVisible = false;
            this.dgvDataHistory.RowHeadersWidth = 51;
            this.dgvDataHistory.RowTemplate.Height = 40;
            this.dgvDataHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataHistory.Size = new System.Drawing.Size(786, 653);
            this.dgvDataHistory.TabIndex = 0;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Thời gian thực hiện";
            this.colTime.MinimumWidth = 6;
            this.colTime.Name = "colTime";
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Tác vụ";
            this.colAction.MinimumWidth = 6;
            this.colAction.Name = "colAction";
            // 
            // colFilePath
            // 
            this.colFilePath.HeaderText = "Đường dẫn tệp tin";
            this.colFilePath.MinimumWidth = 6;
            this.colFilePath.Name = "colFilePath";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.cardBackup);
            this.panelActions.Controls.Add(this.cardRestore);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActions.Location = new System.Drawing.Point(850, 3);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(559, 744);
            this.panelActions.TabIndex = 1;
            // 
            // cardBackup
            // 
            this.cardBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardBackup.Controls.Add(this.btnBrowseBackup);
            this.cardBackup.Controls.Add(this.btnExecuteBackup);
            this.cardBackup.Controls.Add(this.txtBackupPath);
            this.cardBackup.Controls.Add(this.lblBackupTitle);
            this.cardBackup.Depth = 0;
            this.cardBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardBackup.Location = new System.Drawing.Point(12, 11);
            this.cardBackup.Margin = new System.Windows.Forms.Padding(15);
            this.cardBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardBackup.Name = "cardBackup";
            this.cardBackup.Padding = new System.Windows.Forms.Padding(15);
            this.cardBackup.Size = new System.Drawing.Size(531, 292);
            this.cardBackup.TabIndex = 0;
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.AutoSize = false;
            this.btnBrowseBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBrowseBackup.Depth = 0;
            this.btnBrowseBackup.HighEmphasis = false;
            this.btnBrowseBackup.Icon = null;
            this.btnBrowseBackup.Location = new System.Drawing.Point(382, 62);
            this.btnBrowseBackup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowseBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBrowseBackup.Size = new System.Drawing.Size(131, 50);
            this.btnBrowseBackup.TabIndex = 3;
            this.btnBrowseBackup.Text = "CHỌN NƠI LƯU";
            this.btnBrowseBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnBrowseBackup.UseAccentColor = false;
            this.btnBrowseBackup.UseVisualStyleBackColor = true;
            // 
            // btnExecuteBackup
            // 
            this.btnExecuteBackup.AutoSize = false;
            this.btnExecuteBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExecuteBackup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExecuteBackup.Depth = 0;
            this.btnExecuteBackup.HighEmphasis = true;
            this.btnExecuteBackup.Icon = null;
            this.btnExecuteBackup.Location = new System.Drawing.Point(19, 135);
            this.btnExecuteBackup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExecuteBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExecuteBackup.Name = "btnExecuteBackup";
            this.btnExecuteBackup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExecuteBackup.Size = new System.Drawing.Size(494, 47);
            this.btnExecuteBackup.TabIndex = 2;
            this.btnExecuteBackup.Text = "THỰC HIỆN SAO LƯU (.BAK)";
            this.btnExecuteBackup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExecuteBackup.UseAccentColor = false;
            this.btnExecuteBackup.UseVisualStyleBackColor = true;
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.AnimateReadOnly = false;
            this.txtBackupPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBackupPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBackupPath.Depth = 0;
            this.txtBackupPath.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBackupPath.HideSelection = true;
            this.txtBackupPath.Hint = "Đường dẫn lưu trữ tập tin dự phòng";
            this.txtBackupPath.LeadingIcon = null;
            this.txtBackupPath.Location = new System.Drawing.Point(19, 62);
            this.txtBackupPath.MaxLength = 32767;
            this.txtBackupPath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.PasswordChar = '\0';
            this.txtBackupPath.PrefixSuffixText = null;
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackupPath.SelectedText = "";
            this.txtBackupPath.SelectionLength = 0;
            this.txtBackupPath.SelectionStart = 0;
            this.txtBackupPath.ShortcutsEnabled = true;
            this.txtBackupPath.Size = new System.Drawing.Size(349, 48);
            this.txtBackupPath.TabIndex = 1;
            this.txtBackupPath.TabStop = false;
            this.txtBackupPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBackupPath.TrailingIcon = null;
            this.txtBackupPath.UseSystemPasswordChar = false;
            // 
            // lblBackupTitle
            // 
            this.lblBackupTitle.AutoSize = true;
            this.lblBackupTitle.Depth = 0;
            this.lblBackupTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBackupTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblBackupTitle.Location = new System.Drawing.Point(19, 18);
            this.lblBackupTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBackupTitle.Name = "lblBackupTitle";
            this.lblBackupTitle.Size = new System.Drawing.Size(128, 19);
            this.lblBackupTitle.TabIndex = 0;
            this.lblBackupTitle.Text = "SAO LƯU DỮ LIỆU";
            // 
            // cardRestore
            // 
            this.cardRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardRestore.Controls.Add(this.lblRestoreWarning);
            this.cardRestore.Controls.Add(this.btnBrowseRestore);
            this.cardRestore.Controls.Add(this.btnExecuteRestore);
            this.cardRestore.Controls.Add(this.txtRestoreFile);
            this.cardRestore.Controls.Add(this.lblRestoreTitle);
            this.cardRestore.Depth = 0;
            this.cardRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRestore.Location = new System.Drawing.Point(12, 318);
            this.cardRestore.Margin = new System.Windows.Forms.Padding(15);
            this.cardRestore.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardRestore.Name = "cardRestore";
            this.cardRestore.Padding = new System.Windows.Forms.Padding(15);
            this.cardRestore.Size = new System.Drawing.Size(531, 410);
            this.cardRestore.TabIndex = 1;
            // 
            // lblRestoreWarning
            // 
            this.lblRestoreWarning.Depth = 0;
            this.lblRestoreWarning.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRestoreWarning.ForeColor = System.Drawing.Color.Red;
            this.lblRestoreWarning.Location = new System.Drawing.Point(19, 208);
            this.lblRestoreWarning.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRestoreWarning.Name = "lblRestoreWarning";
            this.lblRestoreWarning.Size = new System.Drawing.Size(494, 62);
            this.lblRestoreWarning.TabIndex = 4;
            this.lblRestoreWarning.Text = "Cảnh báo: Hành động khôi phục sẽ ghi đè hoàn toàn dữ liệu hiện tại bằng dữ liệu t" +
    "ừ tệp tin dự phòng. Vui lòng kiểm tra kỹ trước khi thực hiện.";
            // 
            // btnBrowseRestore
            // 
            this.btnBrowseRestore.AutoSize = false;
            this.btnBrowseRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseRestore.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBrowseRestore.Depth = 0;
            this.btnBrowseRestore.HighEmphasis = false;
            this.btnBrowseRestore.Icon = null;
            this.btnBrowseRestore.Location = new System.Drawing.Point(382, 62);
            this.btnBrowseRestore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowseRestore.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseRestore.Name = "btnBrowseRestore";
            this.btnBrowseRestore.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBrowseRestore.Size = new System.Drawing.Size(131, 50);
            this.btnBrowseRestore.TabIndex = 3;
            this.btnBrowseRestore.Text = "CHỌN TỆP TIN";
            this.btnBrowseRestore.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnBrowseRestore.UseAccentColor = false;
            this.btnBrowseRestore.UseVisualStyleBackColor = true;
            // 
            // btnExecuteRestore
            // 
            this.btnExecuteRestore.AutoSize = false;
            this.btnExecuteRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExecuteRestore.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExecuteRestore.Depth = 0;
            this.btnExecuteRestore.HighEmphasis = true;
            this.btnExecuteRestore.Icon = null;
            this.btnExecuteRestore.Location = new System.Drawing.Point(19, 292);
            this.btnExecuteRestore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExecuteRestore.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExecuteRestore.Name = "btnExecuteRestore";
            this.btnExecuteRestore.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExecuteRestore.Size = new System.Drawing.Size(494, 47);
            this.btnExecuteRestore.TabIndex = 2;
            this.btnExecuteRestore.Text = "XÁC NHẬN KHÔI PHỤC HỆ THỐNG";
            this.btnExecuteRestore.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExecuteRestore.UseAccentColor = true;
            this.btnExecuteRestore.UseVisualStyleBackColor = true;
            // 
            // txtRestoreFile
            // 
            this.txtRestoreFile.AnimateReadOnly = false;
            this.txtRestoreFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRestoreFile.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRestoreFile.Depth = 0;
            this.txtRestoreFile.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRestoreFile.HideSelection = true;
            this.txtRestoreFile.Hint = "Chọn tệp tin dự phòng (.bak)";
            this.txtRestoreFile.LeadingIcon = null;
            this.txtRestoreFile.Location = new System.Drawing.Point(19, 62);
            this.txtRestoreFile.MaxLength = 32767;
            this.txtRestoreFile.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRestoreFile.Name = "txtRestoreFile";
            this.txtRestoreFile.PasswordChar = '\0';
            this.txtRestoreFile.PrefixSuffixText = null;
            this.txtRestoreFile.ReadOnly = true;
            this.txtRestoreFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRestoreFile.SelectedText = "";
            this.txtRestoreFile.SelectionLength = 0;
            this.txtRestoreFile.SelectionStart = 0;
            this.txtRestoreFile.ShortcutsEnabled = true;
            this.txtRestoreFile.Size = new System.Drawing.Size(349, 48);
            this.txtRestoreFile.TabIndex = 1;
            this.txtRestoreFile.TabStop = false;
            this.txtRestoreFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRestoreFile.TrailingIcon = null;
            this.txtRestoreFile.UseSystemPasswordChar = false;
            // 
            // lblRestoreTitle
            // 
            this.lblRestoreTitle.AutoSize = true;
            this.lblRestoreTitle.Depth = 0;
            this.lblRestoreTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRestoreTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblRestoreTitle.Location = new System.Drawing.Point(19, 18);
            this.lblRestoreTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRestoreTitle.Name = "lblRestoreTitle";
            this.lblRestoreTitle.Size = new System.Drawing.Size(144, 19);
            this.lblRestoreTitle.TabIndex = 0;
            this.lblRestoreTitle.Text = "KHÔI PHỤC DỮ LIỆU";
            // 
            // frmQTData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 885);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmQTData";
            this.Padding = new System.Windows.Forms.Padding(3, 67, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị Dữ liệu Hệ thống - Sao lưu & Khôi phục";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.cardHistory.ResumeLayout(false);
            this.cardHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataHistory)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.cardBackup.ResumeLayout(false);
            this.cardBackup.PerformLayout();
            this.cardRestore.ResumeLayout(false);
            this.cardRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialLabel lblAdminInfo;
        private System.Windows.Forms.PictureBox picAdminAvatar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MaterialSkin.Controls.MaterialCard cardHistory;
        private MaterialSkin.Controls.MaterialLabel lblHistoryTitle;
        private System.Windows.Forms.DataGridView dgvDataHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel panelActions;
        private MaterialSkin.Controls.MaterialCard cardBackup;
        private MaterialSkin.Controls.MaterialLabel lblBackupTitle;
        private MaterialSkin.Controls.MaterialTextBox2 txtBackupPath;
        private MaterialSkin.Controls.MaterialButton btnBrowseBackup;
        private MaterialSkin.Controls.MaterialButton btnExecuteBackup;
        private MaterialSkin.Controls.MaterialCard cardRestore;
        private MaterialSkin.Controls.MaterialLabel lblRestoreTitle;
        private MaterialSkin.Controls.MaterialTextBox2 txtRestoreFile;
        private MaterialSkin.Controls.MaterialButton btnBrowseRestore;
        private MaterialSkin.Controls.MaterialButton btnExecuteRestore;
        private MaterialSkin.Controls.MaterialLabel lblRestoreWarning;
    }
}