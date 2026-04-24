namespace QLPM_PTH
{
    partial class frmDanhSachThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachThietBi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUserInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.colMaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCauHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThaoTacSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colThaoTacXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cardSearch = new MaterialSkin.Controls.MaterialCard();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.cmbTrangThai = new MaterialSkin.Controls.MaterialComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cmbLoai = new MaterialSkin.Controls.MaterialComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.pnRightActions = new System.Windows.Forms.Panel();
            this.cardActions = new MaterialSkin.Controls.MaterialCard();
            this.btnXuatExcel = new MaterialSkin.Controls.MaterialButton();
            this.btnNhapExcel = new MaterialSkin.Controls.MaterialButton();
            this.btnThemThietBi = new MaterialSkin.Controls.MaterialButton();
            this.lblThaoTacTitle = new MaterialSkin.Controls.MaterialLabel();
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
            this.panelHeader.Location = new System.Drawing.Point(4, 79);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lblUserInfo.Location = new System.Drawing.Point(720, 27);
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
            this.picAvatar.Location = new System.Drawing.Point(659, 14);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.pnMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tableLayoutPanelContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cardGrid.Controls.Add(this.dgvThietBi);
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
            // dgvThietBi
            // 
            this.dgvThietBi.AllowUserToAddRows = false;
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.BackgroundColor = System.Drawing.Color.White;
            this.dgvThietBi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThietBi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThietBi.ColumnHeadersHeight = 45;
            this.dgvThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTB,
            this.colTenTB,
            this.colLoai,
            this.colCauHinh,
            this.colNgayNhap,
            this.colTrangThai,
            this.colThaoTacSua,
            this.colThaoTacXoa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThietBi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThietBi.EnableHeadersVisualStyles = false;
            this.dgvThietBi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvThietBi.Location = new System.Drawing.Point(19, 17);
            this.dgvThietBi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.RowHeadersVisible = false;
            this.dgvThietBi.RowHeadersWidth = 51;
            this.dgvThietBi.RowTemplate.Height = 40;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(1182, 538);
            this.dgvThietBi.TabIndex = 0;
            // 
            // colMaTB
            // 
            this.colMaTB.FillWeight = 80F;
            this.colMaTB.HeaderText = "Mã Thiết Bị";
            this.colMaTB.MinimumWidth = 6;
            this.colMaTB.Name = "colMaTB";
            this.colMaTB.ReadOnly = true;
            // 
            // colTenTB
            // 
            this.colTenTB.HeaderText = "Tên Thiết Bị";
            this.colTenTB.MinimumWidth = 6;
            this.colTenTB.Name = "colTenTB";
            this.colTenTB.ReadOnly = true;
            // 
            // colLoai
            // 
            this.colLoai.HeaderText = "Loại Thiết Bị";
            this.colLoai.MinimumWidth = 6;
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            // 
            // colCauHinh
            // 
            this.colCauHinh.FillWeight = 120F;
            this.colCauHinh.HeaderText = "Mô tả / Cấu hình";
            this.colCauHinh.MinimumWidth = 6;
            this.colCauHinh.Name = "colCauHinh";
            this.colCauHinh.ReadOnly = true;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.HeaderText = "Ngày Nhập";
            this.colNgayNhap.MinimumWidth = 6;
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // colThaoTacSua
            // 
            this.colThaoTacSua.HeaderText = "Thao Tác";
            this.colThaoTacSua.MinimumWidth = 6;
            this.colThaoTacSua.Name = "colThaoTacSua";
            this.colThaoTacSua.ReadOnly = true;
            // 
            // colThaoTacXoa
            // 
            this.colThaoTacXoa.HeaderText = "";
            this.colThaoTacXoa.MinimumWidth = 6;
            this.colThaoTacXoa.Name = "colThaoTacXoa";
            this.colThaoTacXoa.ReadOnly = true;
            // 
            // cardSearch
            // 
            this.cardSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSearch.Controls.Add(this.txtTimKiem);
            this.cardSearch.Controls.Add(this.btnTimKiem);
            this.cardSearch.Controls.Add(this.cmbTrangThai);
            this.cardSearch.Controls.Add(this.lblTrangThai);
            this.cardSearch.Controls.Add(this.cmbLoai);
            this.cardSearch.Controls.Add(this.lblLoai);
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
            this.txtTimKiem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.HideSelection = true;
            this.txtTimKiem.Hint = "Nhập tên / mã thiết bị...";
            this.txtTimKiem.LeadingIcon = null;
            this.txtTimKiem.Location = new System.Drawing.Point(427, 21);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtTimKiem.Size = new System.Drawing.Size(333, 48);
            this.txtTimKiem.TabIndex = 9;
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
            this.btnTimKiem.Location = new System.Drawing.Point(787, 26);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(160, 52);
            this.btnTimKiem.TabIndex = 8;
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
            this.cmbTrangThai.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.IntegralHeight = false;
            this.cmbTrangThai.ItemHeight = 43;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "[Tất cả]",
            "Tốt / Rảnh",
            "Đang sử dụng",
            "Hư hỏng",
            "Đang sửa chữa",
            "Thanh lý"});
            this.cmbTrangThai.Location = new System.Drawing.Point(147, 108);
            this.cmbTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTrangThai.MaxDropDownItems = 4;
            this.cmbTrangThai.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(212, 49);
            this.cmbTrangThai.StartIndex = 0;
            this.cmbTrangThai.TabIndex = 3;
            this.cmbTrangThai.UseAccent = false;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(23, 129);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(98, 23);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cmbLoai
            // 
            this.cmbLoai.AutoResize = false;
            this.cmbLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLoai.Depth = 0;
            this.cmbLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLoai.DropDownHeight = 174;
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.DropDownWidth = 121;
            this.cmbLoai.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.IntegralHeight = false;
            this.cmbLoai.ItemHeight = 43;
            this.cmbLoai.Items.AddRange(new object[] {
            "[Tất cả loại]",
            "Máy tính PC",
            "Màn hình",
            "Máy chiếu",
            "Bàn ghế",
            "Thiết bị mạng"});
            this.cmbLoai.Location = new System.Drawing.Point(147, 21);
            this.cmbLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLoai.MaxDropDownItems = 4;
            this.cmbLoai.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(212, 49);
            this.cmbLoai.StartIndex = 0;
            this.cmbLoai.TabIndex = 1;
            this.cmbLoai.UseAccent = false;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(23, 42);
            this.lblLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(51, 23);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Loại:";
            // 
            // pnRightActions
            // 
            this.pnRightActions.Controls.Add(this.cardActions);
            this.pnRightActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRightActions.Location = new System.Drawing.Point(1258, 0);
            this.pnRightActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnRightActions.Name = "pnRightActions";
            this.pnRightActions.Padding = new System.Windows.Forms.Padding(0, 17, 19, 17);
            this.pnRightActions.Size = new System.Drawing.Size(467, 828);
            this.pnRightActions.TabIndex = 1;
            // 
            // cardActions
            // 
            this.cardActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardActions.Controls.Add(this.btnXuatExcel);
            this.cardActions.Controls.Add(this.btnNhapExcel);
            this.cardActions.Controls.Add(this.btnThemThietBi);
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
            this.btnXuatExcel.Location = new System.Drawing.Point(23, 266);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXuatExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXuatExcel.Size = new System.Drawing.Size(403, 62);
            this.btnXuatExcel.TabIndex = 3;
            this.btnXuatExcel.Text = "XUẤT DANH SÁCH (EXCEL)";
            this.btnXuatExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnXuatExcel.UseAccentColor = false;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnNhapExcel
            // 
            this.btnNhapExcel.AutoSize = false;
            this.btnNhapExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNhapExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNhapExcel.Depth = 0;
            this.btnNhapExcel.HighEmphasis = true;
            this.btnNhapExcel.Icon = ((System.Drawing.Image)(resources.GetObject("btnNhapExcel.Icon")));
            this.btnNhapExcel.Location = new System.Drawing.Point(23, 178);
            this.btnNhapExcel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnNhapExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhapExcel.Name = "btnNhapExcel";
            this.btnNhapExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNhapExcel.Size = new System.Drawing.Size(403, 62);
            this.btnNhapExcel.TabIndex = 2;
            this.btnNhapExcel.Text = "NHẬP TỪ EXCEL (IMPORT)";
            this.btnNhapExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnNhapExcel.UseAccentColor = false;
            this.btnNhapExcel.UseVisualStyleBackColor = true;
            // 
            // btnThemThietBi
            // 
            this.btnThemThietBi.AutoSize = false;
            this.btnThemThietBi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemThietBi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemThietBi.Depth = 0;
            this.btnThemThietBi.HighEmphasis = true;
            this.btnThemThietBi.Icon = ((System.Drawing.Image)(resources.GetObject("btnThemThietBi.Icon")));
            this.btnThemThietBi.Location = new System.Drawing.Point(23, 91);
            this.btnThemThietBi.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThemThietBi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemThietBi.Name = "btnThemThietBi";
            this.btnThemThietBi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemThietBi.Size = new System.Drawing.Size(403, 62);
            this.btnThemThietBi.TabIndex = 1;
            this.btnThemThietBi.Text = "THÊM THIẾT BỊ MỚI";
            this.btnThemThietBi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemThietBi.UseAccentColor = false;
            this.btnThemThietBi.UseVisualStyleBackColor = true;
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
            // frmDanhSachThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 985);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmDanhSachThietBi";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ DANH SÁCH THIẾT BỊ";
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
        private MaterialSkin.Controls.MaterialButton btnThemThietBi;
        private MaterialSkin.Controls.MaterialButton btnNhapExcel;
        private MaterialSkin.Controls.MaterialButton btnXuatExcel;
        private System.Windows.Forms.Label lblLoai;
        private MaterialSkin.Controls.MaterialComboBox cmbLoai;
        private System.Windows.Forms.Label lblTrangThai;
        private MaterialSkin.Controls.MaterialComboBox cmbTrangThai;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCauHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colThaoTacSua;
        private System.Windows.Forms.DataGridViewButtonColumn colThaoTacXoa;
    }
}