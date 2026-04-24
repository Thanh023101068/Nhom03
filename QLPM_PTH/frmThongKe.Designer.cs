namespace QLPM_PTH
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUserInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHangMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoatDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaoTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHuHong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardSearch = new MaterialSkin.Controls.MaterialCard();
            this.btnThongKe = new MaterialSkin.Controls.MaterialButton();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.cmbKhuVuc = new MaterialSkin.Controls.MaterialComboBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.cmbLoaiThongKe = new MaterialSkin.Controls.MaterialComboBox();
            this.lblLoaiThongKe = new System.Windows.Forms.Label();
            this.pnRightActions = new System.Windows.Forms.Panel();
            this.cardActions = new MaterialSkin.Controls.MaterialCard();
            this.btnXuatPDF = new MaterialSkin.Controls.MaterialButton();
            this.btnXuatExcel = new MaterialSkin.Controls.MaterialButton();
            this.btnXemBieuDo = new MaterialSkin.Controls.MaterialButton();
            this.lblThaoTacTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnMain.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
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
            this.panelHeader.Location = new System.Drawing.Point(4, 79);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1725, 74);
            this.panelHeader.TabIndex = 0;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Depth = 0;
            this.lblUserInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserInfo.Location = new System.Drawing.Point(759, 27);
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
            this.picAvatar.Location = new System.Drawing.Point(703, 14);
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
            this.pnMain.Location = new System.Drawing.Point(4, 153);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1725, 828);
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
            this.tableLayoutPanelContent.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 2;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(1258, 828);
            this.tableLayoutPanelContent.TabIndex = 0;
            // 
            // cardGrid
            // 
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardGrid.Controls.Add(this.dgvThongKe);
            this.cardGrid.Depth = 0;
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGrid.Location = new System.Drawing.Point(19, 239);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardGrid.Size = new System.Drawing.Size(1220, 572);
            this.cardGrid.TabIndex = 1;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongKe.ColumnHeadersHeight = 45;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colHangMuc,
            this.colTongSo,
            this.colHoatDong,
            this.colBaoTri,
            this.colHuHong,
            this.colTyLe});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe.EnableHeadersVisualStyles = false;
            this.dgvThongKe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvThongKe.Location = new System.Drawing.Point(19, 17);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 40;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(1182, 538);
            this.dgvThongKe.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.FillWeight = 40F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colHangMuc
            // 
            this.colHangMuc.FillWeight = 120F;
            this.colHangMuc.HeaderText = "Tên Hạng Mục";
            this.colHangMuc.MinimumWidth = 6;
            this.colHangMuc.Name = "colHangMuc";
            this.colHangMuc.ReadOnly = true;
            // 
            // colTongSo
            // 
            this.colTongSo.HeaderText = "Tổng Số";
            this.colTongSo.MinimumWidth = 6;
            this.colTongSo.Name = "colTongSo";
            this.colTongSo.ReadOnly = true;
            // 
            // colHoatDong
            // 
            this.colHoatDong.HeaderText = "Đang Hoạt Động";
            this.colHoatDong.MinimumWidth = 6;
            this.colHoatDong.Name = "colHoatDong";
            this.colHoatDong.ReadOnly = true;
            // 
            // colBaoTri
            // 
            this.colBaoTri.HeaderText = "Đang Bảo Trì";
            this.colBaoTri.MinimumWidth = 6;
            this.colBaoTri.Name = "colBaoTri";
            this.colBaoTri.ReadOnly = true;
            // 
            // colHuHong
            // 
            this.colHuHong.HeaderText = "Hư Hỏng / Báo Lỗi";
            this.colHuHong.MinimumWidth = 6;
            this.colHuHong.Name = "colHuHong";
            this.colHuHong.ReadOnly = true;
            // 
            // colTyLe
            // 
            this.colTyLe.FillWeight = 80F;
            this.colTyLe.HeaderText = "Tỷ Lệ (%)";
            this.colTyLe.MinimumWidth = 6;
            this.colTyLe.Name = "colTyLe";
            this.colTyLe.ReadOnly = true;
            // 
            // cardSearch
            // 
            this.cardSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSearch.Controls.Add(this.btnThongKe);
            this.cardSearch.Controls.Add(this.dtpDenNgay);
            this.cardSearch.Controls.Add(this.lblDenNgay);
            this.cardSearch.Controls.Add(this.dtpTuNgay);
            this.cardSearch.Controls.Add(this.lblTuNgay);
            this.cardSearch.Controls.Add(this.cmbKhuVuc);
            this.cardSearch.Controls.Add(this.lblKhuVuc);
            this.cardSearch.Controls.Add(this.cmbLoaiThongKe);
            this.cardSearch.Controls.Add(this.lblLoaiThongKe);
            this.cardSearch.Depth = 0;
            this.cardSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardSearch.Location = new System.Drawing.Point(19, 17);
            this.cardSearch.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardSearch.Name = "cardSearch";
            this.cardSearch.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardSearch.Size = new System.Drawing.Size(1220, 188);
            this.cardSearch.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoSize = false;
            this.btnThongKe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThongKe.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThongKe.Depth = 0;
            this.btnThongKe.HighEmphasis = true;
            this.btnThongKe.Icon = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Icon")));
            this.btnThongKe.Location = new System.Drawing.Point(740, 112);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThongKe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThongKe.Size = new System.Drawing.Size(200, 42);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "XEM THỐNG KÊ";
            this.btnThongKe.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThongKe.UseAccentColor = false;
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(470, 117);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(220, 32);
            this.dtpDenNgay.TabIndex = 7;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(370, 122);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(93, 23);
            this.lblDenNgay.TabIndex = 6;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(130, 117);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(230, 32);
            this.dtpTuNgay.TabIndex = 5;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(30, 122);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(82, 23);
            this.lblTuNgay.TabIndex = 4;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // cmbKhuVuc
            // 
            this.cmbKhuVuc.AutoResize = false;
            this.cmbKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbKhuVuc.Depth = 0;
            this.cmbKhuVuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbKhuVuc.DropDownHeight = 174;
            this.cmbKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhuVuc.DropDownWidth = 121;
            this.cmbKhuVuc.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbKhuVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbKhuVuc.FormattingEnabled = true;
            this.cmbKhuVuc.IntegralHeight = false;
            this.cmbKhuVuc.ItemHeight = 43;
            this.cmbKhuVuc.Items.AddRange(new object[] {
            "[Tất cả khu vực]",
            "Tòa nhà A",
            "Tòa nhà B"});
            this.cmbKhuVuc.Location = new System.Drawing.Point(470, 24);
            this.cmbKhuVuc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhuVuc.MaxDropDownItems = 4;
            this.cmbKhuVuc.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbKhuVuc.Name = "cmbKhuVuc";
            this.cmbKhuVuc.Size = new System.Drawing.Size(220, 49);
            this.cmbKhuVuc.StartIndex = 0;
            this.cmbKhuVuc.TabIndex = 3;
            this.cmbKhuVuc.UseAccent = false;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuVuc.Location = new System.Drawing.Point(370, 37);
            this.lblKhuVuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(83, 23);
            this.lblKhuVuc.TabIndex = 2;
            this.lblKhuVuc.Text = "Khu vực:";
            // 
            // cmbLoaiThongKe
            // 
            this.cmbLoaiThongKe.AutoResize = false;
            this.cmbLoaiThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLoaiThongKe.Depth = 0;
            this.cmbLoaiThongKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLoaiThongKe.DropDownHeight = 174;
            this.cmbLoaiThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiThongKe.DropDownWidth = 121;
            this.cmbLoaiThongKe.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbLoaiThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbLoaiThongKe.FormattingEnabled = true;
            this.cmbLoaiThongKe.IntegralHeight = false;
            this.cmbLoaiThongKe.ItemHeight = 43;
            this.cmbLoaiThongKe.Items.AddRange(new object[] {
            "Tình trạng thiết bị",
            "Tần suất sử dụng phòng",
            "Sự cố và Bảo trì"});
            this.cmbLoaiThongKe.Location = new System.Drawing.Point(130, 24);
            this.cmbLoaiThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoaiThongKe.MaxDropDownItems = 4;
            this.cmbLoaiThongKe.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLoaiThongKe.Name = "cmbLoaiThongKe";
            this.cmbLoaiThongKe.Size = new System.Drawing.Size(230, 49);
            this.cmbLoaiThongKe.StartIndex = 0;
            this.cmbLoaiThongKe.TabIndex = 1;
            this.cmbLoaiThongKe.UseAccent = false;
            // 
            // lblLoaiThongKe
            // 
            this.lblLoaiThongKe.AutoSize = true;
            this.lblLoaiThongKe.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiThongKe.Location = new System.Drawing.Point(30, 37);
            this.lblLoaiThongKe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiThongKe.Name = "lblLoaiThongKe";
            this.lblLoaiThongKe.Size = new System.Drawing.Size(93, 23);
            this.lblLoaiThongKe.TabIndex = 0;
            this.lblLoaiThongKe.Text = "Thống kê:";
            // 
            // pnRightActions
            // 
            this.pnRightActions.Controls.Add(this.cardActions);
            this.pnRightActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRightActions.Location = new System.Drawing.Point(1258, 0);
            this.pnRightActions.Margin = new System.Windows.Forms.Padding(4);
            this.pnRightActions.Name = "pnRightActions";
            this.pnRightActions.Padding = new System.Windows.Forms.Padding(0, 17, 19, 17);
            this.pnRightActions.Size = new System.Drawing.Size(467, 828);
            this.pnRightActions.TabIndex = 1;
            // 
            // cardActions
            // 
            this.cardActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardActions.Controls.Add(this.btnXuatPDF);
            this.cardActions.Controls.Add(this.btnXuatExcel);
            this.cardActions.Controls.Add(this.btnXemBieuDo);
            this.cardActions.Controls.Add(this.lblThaoTacTitle);
            this.cardActions.Depth = 0;
            this.cardActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardActions.Location = new System.Drawing.Point(0, 17);
            this.cardActions.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardActions.Name = "cardActions";
            this.cardActions.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardActions.Size = new System.Drawing.Size(448, 794);
            this.cardActions.TabIndex = 0;
            // 
            // btnXuatPDF
            // 
            this.btnXuatPDF.AutoSize = false;
            this.btnXuatPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXuatPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXuatPDF.Depth = 0;
            this.btnXuatPDF.HighEmphasis = true;
            this.btnXuatPDF.Icon = ((System.Drawing.Image)(resources.GetObject("btnXuatPDF.Icon")));
            this.btnXuatPDF.Location = new System.Drawing.Point(23, 265);
            this.btnXuatPDF.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXuatPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXuatPDF.Name = "btnXuatPDF";
            this.btnXuatPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXuatPDF.Size = new System.Drawing.Size(403, 62);
            this.btnXuatPDF.TabIndex = 3;
            this.btnXuatPDF.Text = "XUẤT BÁO CÁO (PDF)";
            this.btnXuatPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnXuatPDF.UseAccentColor = false;
            this.btnXuatPDF.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.AutoSize = false;
            this.btnXuatExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXuatExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXuatExcel.Depth = 0;
            this.btnXuatExcel.HighEmphasis = true;
            this.btnXuatExcel.Icon = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Icon")));
            this.btnXuatExcel.Location = new System.Drawing.Point(23, 178);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXuatExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXuatExcel.Size = new System.Drawing.Size(403, 62);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "XUẤT BÁO CÁO (EXCEL)";
            this.btnXuatExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnXuatExcel.UseAccentColor = false;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnXemBieuDo
            // 
            this.btnXemBieuDo.AutoSize = false;
            this.btnXemBieuDo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXemBieuDo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXemBieuDo.Depth = 0;
            this.btnXemBieuDo.HighEmphasis = true;
            this.btnXemBieuDo.Icon = ((System.Drawing.Image)(resources.GetObject("btnXemBieuDo.Icon")));
            this.btnXemBieuDo.Location = new System.Drawing.Point(23, 91);
            this.btnXemBieuDo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXemBieuDo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXemBieuDo.Name = "btnXemBieuDo";
            this.btnXemBieuDo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXemBieuDo.Size = new System.Drawing.Size(403, 62);
            this.btnXemBieuDo.TabIndex = 1;
            this.btnXemBieuDo.Text = "XEM BIỂU ĐỒ TRỰC QUAN";
            this.btnXemBieuDo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXemBieuDo.UseAccentColor = false;
            this.btnXemBieuDo.UseVisualStyleBackColor = true;
            // 
            // lblThaoTacTitle
            // 
            this.lblThaoTacTitle.AutoSize = true;
            this.lblThaoTacTitle.Depth = 0;
            this.lblThaoTacTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblThaoTacTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblThaoTacTitle.Location = new System.Drawing.Point(23, 21);
            this.lblThaoTacTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThaoTacTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblThaoTacTitle.Name = "lblThaoTacTitle";
            this.lblThaoTacTitle.Size = new System.Drawing.Size(171, 24);
            this.lblThaoTacTitle.TabIndex = 0;
            this.lblThaoTacTitle.Text = "THAO TÁC NHANH";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 985);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmThongKe";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ & BÁO CÁO";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
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
        private MaterialSkin.Controls.MaterialButton btnXemBieuDo;
        private MaterialSkin.Controls.MaterialButton btnXuatExcel;
        private MaterialSkin.Controls.MaterialButton btnXuatPDF;
        private System.Windows.Forms.Label lblKhuVuc;
        private MaterialSkin.Controls.MaterialComboBox cmbKhuVuc;
        private System.Windows.Forms.Label lblLoaiThongKe;
        private MaterialSkin.Controls.MaterialComboBox cmbLoaiThongKe;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private MaterialSkin.Controls.MaterialButton btnThongKe;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHangMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoatDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaoTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHuHong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTyLe;
    }
}