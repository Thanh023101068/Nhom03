namespace QLPM_PTH
{
    partial class frmSuDungThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuDungThietBi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUserInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.cardSearch = new MaterialSkin.Controls.MaterialCard();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.cmbTrangThai = new MaterialSkin.Controls.MaterialComboBox();
            this.lblTrangThai = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPhong = new MaterialSkin.Controls.MaterialComboBox();
            this.lblPhong = new MaterialSkin.Controls.MaterialLabel();
            this.pnRightActions = new System.Windows.Forms.Panel();
            this.cardActions = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnBaoLoi = new MaterialSkin.Controls.MaterialButton();
            this.btnCheckIn = new MaterialSkin.Controls.MaterialButton();
            this.lblThaoTacTitle = new MaterialSkin.Controls.MaterialLabel();
            this.MaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnMain.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.cardSearch.SuspendLayout();
            this.pnRightActions.SuspendLayout();
            this.cardActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblUserInfo);
            this.panelHeader.Controls.Add(this.picAvatar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 64);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1034, 74);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Depth = 0;
            this.lblUserInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserInfo.Location = new System.Drawing.Point(413, 27);
            this.lblUserInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(21, 19);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = ".....";
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(357, 14);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(48, 47);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.tableLayoutPanelContent);
            this.pnMain.Controls.Add(this.pnRightActions);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(3, 138);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1034, 499);
            this.pnMain.TabIndex = 1;
            // 
            // tableLayoutPanelContent
            // 
            this.tableLayoutPanelContent.ColumnCount = 1;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Controls.Add(this.cardGrid, 0, 1);
            this.tableLayoutPanelContent.Controls.Add(this.cardSearch, 0, 0);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 2;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(684, 499);
            this.tableLayoutPanelContent.TabIndex = 0;
            // 
            // cardGrid
            // 
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardGrid.Controls.Add(this.dgvThietBi);
            this.cardGrid.Depth = 0;
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGrid.Location = new System.Drawing.Point(14, 194);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(14);
            this.cardGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(14);
            this.cardGrid.Size = new System.Drawing.Size(656, 291);
            this.cardGrid.TabIndex = 1;
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AllowUserToAddRows = false;
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.BackgroundColor = System.Drawing.Color.White;
            this.dgvThietBi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThietBi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThietBi.ColumnHeadersHeight = 55;
            this.dgvThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTB,
            this.TenTB,
            this.MaPhong,
            this.colNguoiDung,
            this.colThoiGian,
            this.colTinhTrang,
            this.TinhTrang});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThietBi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThietBi.EnableHeadersVisualStyles = false;
            this.dgvThietBi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvThietBi.Location = new System.Drawing.Point(14, 14);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.RowHeadersVisible = false;
            this.dgvThietBi.RowHeadersWidth = 51;
            this.dgvThietBi.RowTemplate.Height = 40;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(628, 263);
            this.dgvThietBi.TabIndex = 0;
            this.dgvThietBi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThietBi_CellContentClick);
            // 
            // cardSearch
            // 
            this.cardSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSearch.Controls.Add(this.txtTimKiem);
            this.cardSearch.Controls.Add(this.btnTimKiem);
            this.cardSearch.Controls.Add(this.cmbTrangThai);
            this.cardSearch.Controls.Add(this.lblTrangThai);
            this.cardSearch.Controls.Add(this.cmbPhong);
            this.cardSearch.Controls.Add(this.lblPhong);
            this.cardSearch.Depth = 0;
            this.cardSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardSearch.Location = new System.Drawing.Point(14, 14);
            this.cardSearch.Margin = new System.Windows.Forms.Padding(14);
            this.cardSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardSearch.Name = "cardSearch";
            this.cardSearch.Padding = new System.Windows.Forms.Padding(14);
            this.cardSearch.Size = new System.Drawing.Size(656, 152);
            this.cardSearch.TabIndex = 0;
            this.cardSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.cardSearch_Paint);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AnimateReadOnly = false;
            this.txtTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimKiem.HideSelection = true;
            this.txtTimKiem.Hint = "Nhập tên/mã thiết bị...";
            this.txtTimKiem.LeadingIcon = null;
            this.txtTimKiem.Location = new System.Drawing.Point(22, 85);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PrefixSuffixText = null;
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(300, 48);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TrailingIcon = null;
            this.txtTimKiem.UseSystemPasswordChar = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = false;
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiem.Depth = 0;
            this.btnTimKiem.HighEmphasis = true;
            this.btnTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Icon")));
            this.btnTimKiem.Location = new System.Drawing.Point(340, 88);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(160, 42);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.AutoResize = false;
            this.cmbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTrangThai.Depth = 0;
            this.cmbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTrangThai.DropDownHeight = 174;
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.DropDownWidth = 121;
            this.cmbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.IntegralHeight = false;
            this.cmbTrangThai.ItemHeight = 43;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "[Tất cả]",
            "Đang rảnh",
            "Đang sử dụng",
            "Đang báo lỗi"});
            this.cmbTrangThai.Location = new System.Drawing.Point(340, 17);
            this.cmbTrangThai.MaxDropDownItems = 4;
            this.cmbTrangThai.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(160, 49);
            this.cmbTrangThai.StartIndex = 0;
            this.cmbTrangThai.TabIndex = 3;
            this.cmbTrangThai.UseAccent = false;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Depth = 0;
            this.lblTrangThai.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTrangThai.Location = new System.Drawing.Point(260, 34);
            this.lblTrangThai.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(78, 19);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cmbPhong
            // 
            this.cmbPhong.AutoResize = false;
            this.cmbPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPhong.Depth = 0;
            this.cmbPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPhong.DropDownHeight = 174;
            this.cmbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhong.DropDownWidth = 121;
            this.cmbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.IntegralHeight = false;
            this.cmbPhong.ItemHeight = 43;
            this.cmbPhong.Items.AddRange(new object[] {
            "[Tất cả phòng]"});
            this.cmbPhong.Location = new System.Drawing.Point(90, 17);
            this.cmbPhong.MaxDropDownItems = 4;
            this.cmbPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(150, 49);
            this.cmbPhong.StartIndex = 0;
            this.cmbPhong.TabIndex = 1;
            this.cmbPhong.UseAccent = false;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Depth = 0;
            this.lblPhong.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPhong.Location = new System.Drawing.Point(22, 34);
            this.lblPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(51, 19);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Phòng:";
            // 
            // pnRightActions
            // 
            this.pnRightActions.Controls.Add(this.cardActions);
            this.pnRightActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRightActions.Location = new System.Drawing.Point(684, 0);
            this.pnRightActions.Name = "pnRightActions";
            this.pnRightActions.Padding = new System.Windows.Forms.Padding(0, 14, 14, 14);
            this.pnRightActions.Size = new System.Drawing.Size(350, 499);
            this.pnRightActions.TabIndex = 1;
            // 
            // cardActions
            // 
            this.cardActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardActions.Controls.Add(this.materialButton1);
            this.cardActions.Controls.Add(this.btnBaoLoi);
            this.cardActions.Controls.Add(this.btnCheckIn);
            this.cardActions.Controls.Add(this.lblThaoTacTitle);
            this.cardActions.Depth = 0;
            this.cardActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardActions.Location = new System.Drawing.Point(0, 14);
            this.cardActions.Margin = new System.Windows.Forms.Padding(14);
            this.cardActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardActions.Name = "cardActions";
            this.cardActions.Padding = new System.Windows.Forms.Padding(14);
            this.cardActions.Size = new System.Drawing.Size(336, 471);
            this.cardActions.TabIndex = 0;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.Location = new System.Drawing.Point(16, 145);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(302, 50);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "GHI NHẬN (SAU CA DẠY)";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // btnBaoLoi
            // 
            this.btnBaoLoi.AutoSize = false;
            this.btnBaoLoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoLoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoLoi.Depth = 0;
            this.btnBaoLoi.HighEmphasis = true;
            this.btnBaoLoi.Icon = ((System.Drawing.Image)(resources.GetObject("btnBaoLoi.Icon")));
            this.btnBaoLoi.Location = new System.Drawing.Point(17, 216);
            this.btnBaoLoi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaoLoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoLoi.Name = "btnBaoLoi";
            this.btnBaoLoi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoLoi.Size = new System.Drawing.Size(302, 50);
            this.btnBaoLoi.TabIndex = 3;
            this.btnBaoLoi.Text = "BÁO CÁO LỖI THIẾT BỊ";
            this.btnBaoLoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnBaoLoi.UseAccentColor = false;
            this.btnBaoLoi.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.AutoSize = false;
            this.btnCheckIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCheckIn.Depth = 0;
            this.btnCheckIn.HighEmphasis = true;
            this.btnCheckIn.Icon = ((System.Drawing.Image)(resources.GetObject("btnCheckIn.Icon")));
            this.btnCheckIn.Location = new System.Drawing.Point(17, 74);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheckIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCheckIn.Size = new System.Drawing.Size(302, 50);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "GHI NHẬN (TRƯỚC CA DẠY)";
            this.btnCheckIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCheckIn.UseAccentColor = false;
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lblThaoTacTitle
            // 
            this.lblThaoTacTitle.AutoSize = true;
            this.lblThaoTacTitle.Depth = 0;
            this.lblThaoTacTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblThaoTacTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblThaoTacTitle.Location = new System.Drawing.Point(17, 17);
            this.lblThaoTacTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblThaoTacTitle.Name = "lblThaoTacTitle";
            this.lblThaoTacTitle.Size = new System.Drawing.Size(171, 24);
            this.lblThaoTacTitle.TabIndex = 0;
            this.lblThaoTacTitle.Text = "THAO TÁC NHANH";
            // 
            // MaTB
            // 
            this.MaTB.DataPropertyName = "MaTB";
            this.MaTB.HeaderText = "Mã\nThiết Bị";
            this.MaTB.MinimumWidth = 6;
            this.MaTB.Name = "MaTB";
            this.MaTB.ReadOnly = true;
            // 
            // TenTB
            // 
            this.TenTB.DataPropertyName = "TenTB";
            this.TenTB.HeaderText = "Tên Thiết Bị";
            this.TenTB.MinimumWidth = 6;
            this.TenTB.Name = "TenTB";
            this.TenTB.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // colNguoiDung
            // 
            this.colNguoiDung.HeaderText = "Người\nĐang Dùng";
            this.colNguoiDung.MinimumWidth = 6;
            this.colNguoiDung.Name = "colNguoiDung";
            this.colNguoiDung.ReadOnly = true;
            // 
            // colThoiGian
            // 
            this.colThoiGian.HeaderText = "Thời Gian\nMượn";
            this.colThoiGian.MinimumWidth = 6;
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.ReadOnly = true;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.HeaderText = "Thời điểm";
            this.colTinhTrang.MinimumWidth = 6;
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TinhTrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmSuDungThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.Name = "frmSuDungThietBi";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SỬ DỤNG THIẾT BỊ";
            this.Load += new System.EventHandler(this.frmSuDungThietBi_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.cardSearch.ResumeLayout(false);
            this.cardSearch.PerformLayout();
            this.pnRightActions.ResumeLayout(false);
            this.cardActions.ResumeLayout(false);
            this.cardActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialLabel lblUserInfo;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContent;
        private MaterialSkin.Controls.MaterialCard cardSearch;
        private MaterialSkin.Controls.MaterialCard cardGrid;
        private System.Windows.Forms.Panel pnRightActions;
        private MaterialSkin.Controls.MaterialCard cardActions;
        private MaterialSkin.Controls.MaterialLabel lblThaoTacTitle;
        private MaterialSkin.Controls.MaterialButton btnCheckIn;
        private MaterialSkin.Controls.MaterialButton btnBaoLoi;
        private MaterialSkin.Controls.MaterialComboBox cmbPhong;
        private MaterialSkin.Controls.MaterialLabel lblPhong;
        private MaterialSkin.Controls.MaterialComboBox cmbTrangThai;
        private MaterialSkin.Controls.MaterialLabel lblTrangThai;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}
