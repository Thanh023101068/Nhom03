namespace QLPM_PTH
{
    partial class frmQLYC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLYC));
            this.pnMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.dgvYeuCau = new System.Windows.Forms.DataGridView();
            this.cardSearch = new MaterialSkin.Controls.MaterialCard();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new MaterialSkin.Controls.MaterialLabel();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPhong = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbTrangThai = new MaterialSkin.Controls.MaterialComboBox();
            this.pnRightActions = new System.Windows.Forms.Panel();
            this.cardActions = new MaterialSkin.Controls.MaterialCard();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnTaoDatPhong = new MaterialSkin.Controls.MaterialButton();
            this.lblThaoTacTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUserInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.MaDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mucdich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnMain.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).BeginInit();
            this.cardSearch.SuspendLayout();
            this.pnRightActions.SuspendLayout();
            this.cardActions.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.tableLayoutPanelContent);
            this.pnMain.Controls.Add(this.pnRightActions);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(3, 124);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1294, 661);
            this.pnMain.TabIndex = 0;
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
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(944, 661);
            this.tableLayoutPanelContent.TabIndex = 0;
            this.tableLayoutPanelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelContent_Paint);
            // 
            // cardGrid
            // 
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardGrid.Controls.Add(this.dgvYeuCau);
            this.cardGrid.Depth = 0;
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGrid.Location = new System.Drawing.Point(14, 194);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(14);
            this.cardGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(14);
            this.cardGrid.Size = new System.Drawing.Size(916, 453);
            this.cardGrid.TabIndex = 1;
            // 
            // dgvYeuCau
            // 
            this.dgvYeuCau.AllowUserToAddRows = false;
            this.dgvYeuCau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYeuCau.BackgroundColor = System.Drawing.Color.White;
            this.dgvYeuCau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYeuCau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYeuCau.ColumnHeadersHeight = 55;
            this.dgvYeuCau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDK,
            this.Mucdich,
            this.MaPhong,
            this.NgaySuDung,
            this.colGioBatDau,
            this.colGioKetThuc,
            this.TrangThaiDuyet,
            this.colLyDo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvYeuCau.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvYeuCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYeuCau.EnableHeadersVisualStyles = false;
            this.dgvYeuCau.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvYeuCau.Location = new System.Drawing.Point(14, 14);
            this.dgvYeuCau.Name = "dgvYeuCau";
            this.dgvYeuCau.RowHeadersVisible = false;
            this.dgvYeuCau.RowHeadersWidth = 51;
            this.dgvYeuCau.RowTemplate.Height = 40;
            this.dgvYeuCau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYeuCau.Size = new System.Drawing.Size(888, 425);
            this.dgvYeuCau.TabIndex = 0;
            this.dgvYeuCau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYeuCau_CellContentClick);
            // 
            // cardSearch
            // 
            this.cardSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSearch.Controls.Add(this.btnTimKiem);
            this.cardSearch.Controls.Add(this.dtpDenNgay);
            this.cardSearch.Controls.Add(this.lblDenNgay);
            this.cardSearch.Controls.Add(this.dtpTuNgay);
            this.cardSearch.Controls.Add(this.lblTuNgay);
            this.cardSearch.Controls.Add(this.cmbPhong);
            this.cardSearch.Controls.Add(this.cmbTrangThai);
            this.cardSearch.Depth = 0;
            this.cardSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardSearch.Location = new System.Drawing.Point(14, 14);
            this.cardSearch.Margin = new System.Windows.Forms.Padding(14);
            this.cardSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardSearch.Name = "cardSearch";
            this.cardSearch.Padding = new System.Windows.Forms.Padding(14);
            this.cardSearch.Size = new System.Drawing.Size(916, 152);
            this.cardSearch.TabIndex = 0;
            this.cardSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.cardSearch_Paint);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = false;
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiem.Depth = 0;
            this.btnTimKiem.HighEmphasis = true;
            this.btnTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Icon")));
            this.btnTimKiem.Location = new System.Drawing.Point(743, 30);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(142, 36);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(546, 100);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(160, 29);
            this.dtpDenNgay.TabIndex = 6;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Depth = 0;
            this.lblDenNgay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDenNgay.Location = new System.Drawing.Point(462, 103);
            this.lblDenNgay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(72, 19);
            this.lblDenNgay.TabIndex = 5;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(546, 33);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(160, 29);
            this.dtpTuNgay.TabIndex = 4;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Depth = 0;
            this.lblTuNgay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTuNgay.Location = new System.Drawing.Point(462, 36);
            this.lblTuNgay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(64, 19);
            this.lblTuNgay.TabIndex = 3;
            this.lblTuNgay.Text = "Từ ngày:";
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
            this.cmbPhong.Hint = "Chọn phòng";
            this.cmbPhong.IntegralHeight = false;
            this.cmbPhong.ItemHeight = 43;
            this.cmbPhong.Location = new System.Drawing.Point(232, 17);
            this.cmbPhong.MaxDropDownItems = 4;
            this.cmbPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(180, 49);
            this.cmbPhong.StartIndex = 0;
            this.cmbPhong.TabIndex = 2;
            this.cmbPhong.UseAccent = false;
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
            this.cmbTrangThai.Hint = "Trạng thái";
            this.cmbTrangThai.IntegralHeight = false;
            this.cmbTrangThai.ItemHeight = 43;
            this.cmbTrangThai.Location = new System.Drawing.Point(22, 17);
            this.cmbTrangThai.MaxDropDownItems = 4;
            this.cmbTrangThai.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(190, 49);
            this.cmbTrangThai.StartIndex = 0;
            this.cmbTrangThai.TabIndex = 0;
            this.cmbTrangThai.UseAccent = false;
            // 
            // pnRightActions
            // 
            this.pnRightActions.Controls.Add(this.cardActions);
            this.pnRightActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRightActions.Location = new System.Drawing.Point(944, 0);
            this.pnRightActions.Name = "pnRightActions";
            this.pnRightActions.Padding = new System.Windows.Forms.Padding(0, 14, 14, 14);
            this.pnRightActions.Size = new System.Drawing.Size(350, 661);
            this.pnRightActions.TabIndex = 1;
            // 
            // cardActions
            // 
            this.cardActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardActions.Controls.Add(this.materialButton2);
            this.cardActions.Controls.Add(this.materialButton1);
            this.cardActions.Controls.Add(this.btnTaoDatPhong);
            this.cardActions.Controls.Add(this.lblThaoTacTitle);
            this.cardActions.Depth = 0;
            this.cardActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardActions.Location = new System.Drawing.Point(0, 14);
            this.cardActions.Margin = new System.Windows.Forms.Padding(14);
            this.cardActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardActions.Name = "cardActions";
            this.cardActions.Padding = new System.Windows.Forms.Padding(14);
            this.cardActions.Size = new System.Drawing.Size(336, 633);
            this.cardActions.TabIndex = 0;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton2.Icon")));
            this.materialButton2.Location = new System.Drawing.Point(16, 195);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(302, 50);
            this.materialButton2.TabIndex = 4;
            this.materialButton2.Text = "HỦY YÊU CẦU";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.Location = new System.Drawing.Point(16, 132);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(302, 50);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "THAY ĐỔI YÊU CẦU";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // btnTaoDatPhong
            // 
            this.btnTaoDatPhong.AutoSize = false;
            this.btnTaoDatPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTaoDatPhong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTaoDatPhong.Depth = 0;
            this.btnTaoDatPhong.HighEmphasis = true;
            this.btnTaoDatPhong.Icon = ((System.Drawing.Image)(resources.GetObject("btnTaoDatPhong.Icon")));
            this.btnTaoDatPhong.Location = new System.Drawing.Point(17, 74);
            this.btnTaoDatPhong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTaoDatPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTaoDatPhong.Name = "btnTaoDatPhong";
            this.btnTaoDatPhong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTaoDatPhong.Size = new System.Drawing.Size(302, 50);
            this.btnTaoDatPhong.TabIndex = 1;
            this.btnTaoDatPhong.Text = "TẠO YÊU CẦU ĐẶT PHÒNG";
            this.btnTaoDatPhong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTaoDatPhong.UseAccentColor = false;
            this.btnTaoDatPhong.UseVisualStyleBackColor = true;
            this.btnTaoDatPhong.Click += new System.EventHandler(this.btnTaoDatPhong_Click);
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
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblUserInfo);
            this.panelHeader.Controls.Add(this.picAvatar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 64);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1294, 60);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Depth = 0;
            this.lblUserInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserInfo.Location = new System.Drawing.Point(540, 22);
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
            this.picAvatar.Location = new System.Drawing.Point(494, 11);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(36, 38);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // MaDK
            // 
            this.MaDK.DataPropertyName = "MaDK";
            this.MaDK.HeaderText = "Mã YC";
            this.MaDK.MinimumWidth = 6;
            this.MaDK.Name = "MaDK";
            // 
            // Mucdich
            // 
            this.Mucdich.DataPropertyName = "MucDich";
            this.Mucdich.HeaderText = "Loại YC";
            this.Mucdich.MinimumWidth = 6;
            this.Mucdich.Name = "Mucdich";
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            // 
            // NgaySuDung
            // 
            this.NgaySuDung.DataPropertyName = "NgaySuDung";
            this.NgaySuDung.HeaderText = "Ngày";
            this.NgaySuDung.MinimumWidth = 6;
            this.NgaySuDung.Name = "NgaySuDung";
            // 
            // colGioBatDau
            // 
            this.colGioBatDau.HeaderText = "Giờ Bắt\nĐầu";
            this.colGioBatDau.MinimumWidth = 6;
            this.colGioBatDau.Name = "colGioBatDau";
            // 
            // colGioKetThuc
            // 
            this.colGioKetThuc.HeaderText = "Giờ Kết\nThúc";
            this.colGioKetThuc.MinimumWidth = 6;
            this.colGioKetThuc.Name = "colGioKetThuc";
            // 
            // TrangThaiDuyet
            // 
            this.TrangThaiDuyet.DataPropertyName = "TrangThaiDuyet";
            this.TrangThaiDuyet.HeaderText = "Trạng Thái";
            this.TrangThaiDuyet.MinimumWidth = 6;
            this.TrangThaiDuyet.Name = "TrangThaiDuyet";
            // 
            // colLyDo
            // 
            this.colLyDo.HeaderText = "Lý Do\n(Thay đổi hoặc hủy)";
            this.colLyDo.MinimumWidth = 6;
            this.colLyDo.Name = "colLyDo";
            // 
            // frmQLYC
            // 
            this.ClientSize = new System.Drawing.Size(1300, 788);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.Name = "frmQLYC";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ YÊU CẦU GIẢNG VIÊN";
            this.Load += new System.EventHandler(this.frmQLYC_Load);
            this.pnMain.ResumeLayout(false);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).EndInit();
            this.cardSearch.ResumeLayout(false);
            this.cardSearch.PerformLayout();
            this.pnRightActions.ResumeLayout(false);
            this.cardActions.ResumeLayout(false);
            this.cardActions.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContent;
        private MaterialSkin.Controls.MaterialCard cardSearch;
        private MaterialSkin.Controls.MaterialCard cardGrid;
        private System.Windows.Forms.Panel pnRightActions;
        private MaterialSkin.Controls.MaterialCard cardActions;
        private MaterialSkin.Controls.MaterialLabel lblThaoTacTitle;
        private MaterialSkin.Controls.MaterialButton btnTaoDatPhong;
        private MaterialSkin.Controls.MaterialComboBox cmbTrangThai;
        private MaterialSkin.Controls.MaterialComboBox cmbPhong;
        private MaterialSkin.Controls.MaterialLabel lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private MaterialSkin.Controls.MaterialLabel lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvYeuCau;
        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialLabel lblUserInfo;
        private System.Windows.Forms.PictureBox picAvatar;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mucdich;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiDuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDo;
    }
}
