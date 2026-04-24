namespace QLPM_PTH
{
    partial class frmNhatKyBaoTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhatKyBaoTri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUserInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.dgvNhatKyBaoTri = new System.Windows.Forms.DataGridView();
            this.colMaBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBaoTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiPhuTrach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThaoTac = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cardSearch = new MaterialSkin.Controls.MaterialCard();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.cmbTrangThai = new MaterialSkin.Controls.MaterialComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cmbPhong = new MaterialSkin.Controls.MaterialComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.pnRightActions = new System.Windows.Forms.Panel();
            this.cardActions = new MaterialSkin.Controls.MaterialCard();
            this.btnXuatExcel = new MaterialSkin.Controls.MaterialButton();
            this.btnCapNhat = new MaterialSkin.Controls.MaterialButton();
            this.btnTaoPhieu = new MaterialSkin.Controls.MaterialButton();
            this.lblThaoTacTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnMain.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKyBaoTri)).BeginInit();
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
            this.cardGrid.Controls.Add(this.dgvNhatKyBaoTri);
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
            // dgvNhatKyBaoTri
            // 
            this.dgvNhatKyBaoTri.AllowUserToAddRows = false;
            this.dgvNhatKyBaoTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhatKyBaoTri.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhatKyBaoTri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhatKyBaoTri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhatKyBaoTri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhatKyBaoTri.ColumnHeadersHeight = 45;
            this.dgvNhatKyBaoTri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBT,
            this.colThietBi,
            this.colPhong,
            this.colNgayBaoTri,
            this.colNguoiPhuTrach,
            this.colChiPhi,
            this.colTrangThai,
            this.colThaoTac});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhatKyBaoTri.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhatKyBaoTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhatKyBaoTri.EnableHeadersVisualStyles = false;
            this.dgvNhatKyBaoTri.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNhatKyBaoTri.Location = new System.Drawing.Point(19, 17);
            this.dgvNhatKyBaoTri.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhatKyBaoTri.Name = "dgvNhatKyBaoTri";
            this.dgvNhatKyBaoTri.RowHeadersVisible = false;
            this.dgvNhatKyBaoTri.RowHeadersWidth = 51;
            this.dgvNhatKyBaoTri.RowTemplate.Height = 40;
            this.dgvNhatKyBaoTri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhatKyBaoTri.Size = new System.Drawing.Size(1182, 538);
            this.dgvNhatKyBaoTri.TabIndex = 0;
            // 
            // colMaBT
            // 
            this.colMaBT.FillWeight = 80F;
            this.colMaBT.HeaderText = "Mã Bảo Trì";
            this.colMaBT.MinimumWidth = 6;
            this.colMaBT.Name = "colMaBT";
            this.colMaBT.ReadOnly = true;
            // 
            // colThietBi
            // 
            this.colThietBi.HeaderText = "Tên Thiết Bị";
            this.colThietBi.MinimumWidth = 6;
            this.colThietBi.Name = "colThietBi";
            this.colThietBi.ReadOnly = true;
            // 
            // colPhong
            // 
            this.colPhong.FillWeight = 80F;
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.MinimumWidth = 6;
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            // 
            // colNgayBaoTri
            // 
            this.colNgayBaoTri.HeaderText = "Ngày Bảo Trì";
            this.colNgayBaoTri.MinimumWidth = 6;
            this.colNgayBaoTri.Name = "colNgayBaoTri";
            this.colNgayBaoTri.ReadOnly = true;
            // 
            // colNguoiPhuTrach
            // 
            this.colNguoiPhuTrach.HeaderText = "Người Phụ Trách";
            this.colNguoiPhuTrach.MinimumWidth = 6;
            this.colNguoiPhuTrach.Name = "colNguoiPhuTrach";
            this.colNguoiPhuTrach.ReadOnly = true;
            // 
            // colChiPhi
            // 
            this.colChiPhi.FillWeight = 90F;
            this.colChiPhi.HeaderText = "Chi Phí (VNĐ)";
            this.colChiPhi.MinimumWidth = 6;
            this.colChiPhi.Name = "colChiPhi";
            this.colChiPhi.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // colThaoTac
            // 
            this.colThaoTac.FillWeight = 80F;
            this.colThaoTac.HeaderText = "Thao Tác";
            this.colThaoTac.MinimumWidth = 6;
            this.colThaoTac.Name = "colThaoTac";
            this.colThaoTac.ReadOnly = true;
            // 
            // cardSearch
            // 
            this.cardSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSearch.Controls.Add(this.txtTimKiem);
            this.cardSearch.Controls.Add(this.btnTimKiem);
            this.cardSearch.Controls.Add(this.dtpDenNgay);
            this.cardSearch.Controls.Add(this.lblDenNgay);
            this.cardSearch.Controls.Add(this.dtpTuNgay);
            this.cardSearch.Controls.Add(this.lblTuNgay);
            this.cardSearch.Controls.Add(this.cmbTrangThai);
            this.cardSearch.Controls.Add(this.lblTrangThai);
            this.cardSearch.Controls.Add(this.cmbPhong);
            this.cardSearch.Controls.Add(this.lblPhong);
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
            // txtTimKiem
            // 
            this.txtTimKiem.AnimateReadOnly = false;
            this.txtTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimKiem.HideSelection = true;
            this.txtTimKiem.Hint = "Nhập tên/mã thiết bị...";
            this.txtTimKiem.LeadingIcon = null;
            this.txtTimKiem.Location = new System.Drawing.Point(680, 24);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtTimKiem.Size = new System.Drawing.Size(280, 48);
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TrailingIcon = null;
            this.txtTimKiem.UseAccent = false;
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
            this.btnTimKiem.Location = new System.Drawing.Point(680, 112);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(150, 42);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(440, 117);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 32);
            this.dtpDenNgay.TabIndex = 7;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(340, 122);
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
            this.dtpTuNgay.Size = new System.Drawing.Size(180, 32);
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
            // cmbTrangThai
            // 
            this.cmbTrangThai.AutoResize = false;
            this.cmbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTrangThai.Depth = 0;
            this.cmbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTrangThai.DropDownHeight = 174;
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.DropDownWidth = 121;
            this.cmbTrangThai.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.IntegralHeight = false;
            this.cmbTrangThai.ItemHeight = 43;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "[Tất cả]",
            "Đang chờ kiểm tra",
            "Đang bảo trì",
            "Đã hoàn thành",
            "Không thể sửa chữa"});
            this.cmbTrangThai.Location = new System.Drawing.Point(440, 24);
            this.cmbTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrangThai.MaxDropDownItems = 4;
            this.cmbTrangThai.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(200, 49);
            this.cmbTrangThai.StartIndex = 0;
            this.cmbTrangThai.TabIndex = 3;
            this.cmbTrangThai.UseAccent = false;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(340, 37);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(98, 23);
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
            this.cmbPhong.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.IntegralHeight = false;
            this.cmbPhong.ItemHeight = 43;
            this.cmbPhong.Items.AddRange(new object[] {
            "[Tất cả phòng]",
            "Phòng A1",
            "Phòng A2",
            "Phòng A3"});
            this.cmbPhong.Location = new System.Drawing.Point(130, 24);
            this.cmbPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPhong.MaxDropDownItems = 4;
            this.cmbPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(180, 49);
            this.cmbPhong.StartIndex = 0;
            this.cmbPhong.TabIndex = 1;
            this.cmbPhong.UseAccent = false;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(30, 37);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(69, 23);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Phòng:";
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
            this.cardActions.Controls.Add(this.btnXuatExcel);
            this.cardActions.Controls.Add(this.btnCapNhat);
            this.cardActions.Controls.Add(this.btnTaoPhieu);
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
            // btnXuatExcel
            // 
            this.btnXuatExcel.AutoSize = false;
            this.btnXuatExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXuatExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXuatExcel.Depth = 0;
            this.btnXuatExcel.HighEmphasis = true;
            this.btnXuatExcel.Icon = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Icon")));
            this.btnXuatExcel.Location = new System.Drawing.Point(23, 265);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXuatExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXuatExcel.Size = new System.Drawing.Size(403, 62);
            this.btnXuatExcel.TabIndex = 3;
            this.btnXuatExcel.Text = "XUẤT NHẬT KÝ (EXCEL)";
            this.btnXuatExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnXuatExcel.UseAccentColor = false;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = false;
            this.btnCapNhat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapNhat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCapNhat.Depth = 0;
            this.btnCapNhat.HighEmphasis = true;
            this.btnCapNhat.Icon = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Icon")));
            this.btnCapNhat.Location = new System.Drawing.Point(23, 178);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnCapNhat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Size = new System.Drawing.Size(403, 62);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "CẬP NHẬT TRẠNG THÁI";
            this.btnCapNhat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCapNhat.UseAccentColor = false;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.AutoSize = false;
            this.btnTaoPhieu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTaoPhieu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTaoPhieu.Depth = 0;
            this.btnTaoPhieu.HighEmphasis = true;
            this.btnTaoPhieu.Icon = ((System.Drawing.Image)(resources.GetObject("btnTaoPhieu.Icon")));
            this.btnTaoPhieu.Location = new System.Drawing.Point(23, 91);
            this.btnTaoPhieu.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnTaoPhieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTaoPhieu.Size = new System.Drawing.Size(403, 62);
            this.btnTaoPhieu.TabIndex = 1;
            this.btnTaoPhieu.Text = "TẠO PHIẾU BẢO TRÌ MỚI";
            this.btnTaoPhieu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTaoPhieu.UseAccentColor = false;
            this.btnTaoPhieu.UseVisualStyleBackColor = true;
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
            // frmNhatKyBaoTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 985);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNhatKyBaoTri";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHẬT KÝ BẢO TRÌ THIẾT BỊ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKyBaoTri)).EndInit();
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
        private MaterialSkin.Controls.MaterialButton btnTaoPhieu;
        private MaterialSkin.Controls.MaterialButton btnCapNhat;
        private MaterialSkin.Controls.MaterialButton btnXuatExcel;
        private System.Windows.Forms.Label lblTrangThai;
        private MaterialSkin.Controls.MaterialComboBox cmbTrangThai;
        private System.Windows.Forms.Label lblPhong;
        private MaterialSkin.Controls.MaterialComboBox cmbPhong;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvNhatKyBaoTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBaoTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiPhuTrach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colThaoTac;
    }
}