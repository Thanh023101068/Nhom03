namespace QLPM_PTH
{
    partial class frmTrangThaiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangThaiPhong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUserInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.dgvTrangThai = new System.Windows.Forms.DataGridView();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThaoTac = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cardSearch = new MaterialSkin.Controls.MaterialCard();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.cmbTrangThai = new MaterialSkin.Controls.MaterialComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cmbKhuVuc = new MaterialSkin.Controls.MaterialComboBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.pnRightActions = new System.Windows.Forms.Panel();
            this.cardActions = new MaterialSkin.Controls.MaterialCard();
            this.btnBaoTri = new MaterialSkin.Controls.MaterialButton();
            this.btnSanSang = new MaterialSkin.Controls.MaterialButton();
            this.lblThaoTacTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnMain.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThai)).BeginInit();
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
            this.lblUserInfo.Location = new System.Drawing.Point(707, 27);
            this.lblUserInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.picAvatar.Location = new System.Drawing.Point(640, 14);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(53, 49);
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
            this.cardGrid.Controls.Add(this.dgvTrangThai);
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
            // dgvTrangThai
            // 
            this.dgvTrangThai.AllowUserToAddRows = false;
            this.dgvTrangThai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrangThai.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrangThai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrangThai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrangThai.ColumnHeadersHeight = 45;
            this.dgvTrangThai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colLoaiPhong,
            this.colSucChua,
            this.colTrangThai,
            this.colGhiChu,
            this.colThaoTac});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrangThai.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrangThai.EnableHeadersVisualStyles = false;
            this.dgvTrangThai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTrangThai.Location = new System.Drawing.Point(19, 17);
            this.dgvTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTrangThai.Name = "dgvTrangThai";
            this.dgvTrangThai.RowHeadersVisible = false;
            this.dgvTrangThai.RowHeadersWidth = 51;
            this.dgvTrangThai.RowTemplate.Height = 40;
            this.dgvTrangThai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrangThai.Size = new System.Drawing.Size(1182, 538);
            this.dgvTrangThai.TabIndex = 0;
            // 
            // colMaPhong
            // 
            this.colMaPhong.FillWeight = 80F;
            this.colMaPhong.HeaderText = "Mã Phòng";
            this.colMaPhong.MinimumWidth = 6;
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.ReadOnly = true;
            // 
            // colTenPhong
            // 
            this.colTenPhong.HeaderText = "Tên Phòng";
            this.colTenPhong.MinimumWidth = 6;
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.ReadOnly = true;
            // 
            // colLoaiPhong
            // 
            this.colLoaiPhong.HeaderText = "Loại Phòng";
            this.colLoaiPhong.MinimumWidth = 6;
            this.colLoaiPhong.Name = "colLoaiPhong";
            this.colLoaiPhong.ReadOnly = true;
            // 
            // colSucChua
            // 
            this.colSucChua.FillWeight = 80F;
            this.colSucChua.HeaderText = "Sức Chứa";
            this.colSucChua.MinimumWidth = 6;
            this.colSucChua.Name = "colSucChua";
            this.colSucChua.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // colThaoTac
            // 
            this.colThaoTac.FillWeight = 90F;
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
            this.cardSearch.Controls.Add(this.cmbTrangThai);
            this.cardSearch.Controls.Add(this.lblTrangThai);
            this.cardSearch.Controls.Add(this.cmbKhuVuc);
            this.cardSearch.Controls.Add(this.lblKhuVuc);
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
            this.txtTimKiem.Hint = "Nhập tên phòng...";
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
            this.txtTimKiem.Size = new System.Drawing.Size(267, 48);
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
            this.btnTimKiem.Location = new System.Drawing.Point(720, 26);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(173, 52);
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
            "Sẵn sàng",
            "Đang sử dụng",
            "Đang bảo trì"});
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
            this.cmbKhuVuc.Location = new System.Drawing.Point(147, 21);
            this.cmbKhuVuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKhuVuc.MaxDropDownItems = 4;
            this.cmbKhuVuc.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbKhuVuc.Name = "cmbKhuVuc";
            this.cmbKhuVuc.Size = new System.Drawing.Size(212, 49);
            this.cmbKhuVuc.StartIndex = 0;
            this.cmbKhuVuc.TabIndex = 1;
            this.cmbKhuVuc.UseAccent = false;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuVuc.Location = new System.Drawing.Point(23, 42);
            this.lblKhuVuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(83, 23);
            this.lblKhuVuc.TabIndex = 0;
            this.lblKhuVuc.Text = "Khu vực:";
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
            this.cardActions.Controls.Add(this.btnBaoTri);
            this.cardActions.Controls.Add(this.btnSanSang);
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
            // btnBaoTri
            // 
            this.btnBaoTri.AutoSize = false;
            this.btnBaoTri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoTri.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoTri.Depth = 0;
            this.btnBaoTri.HighEmphasis = true;
            this.btnBaoTri.Icon = ((System.Drawing.Image)(resources.GetObject("btnBaoTri.Icon")));
            this.btnBaoTri.Location = new System.Drawing.Point(23, 178);
            this.btnBaoTri.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBaoTri.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoTri.Size = new System.Drawing.Size(403, 62);
            this.btnBaoTri.TabIndex = 2;
            this.btnBaoTri.Text = "CHUYỂN SANG: ĐANG BẢO TRÌ";
            this.btnBaoTri.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnBaoTri.UseAccentColor = false;
            this.btnBaoTri.UseVisualStyleBackColor = true;
            // 
            // btnSanSang
            // 
            this.btnSanSang.AutoSize = false;
            this.btnSanSang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSanSang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSanSang.Depth = 0;
            this.btnSanSang.HighEmphasis = true;
            this.btnSanSang.Icon = ((System.Drawing.Image)(resources.GetObject("btnSanSang.Icon")));
            this.btnSanSang.Location = new System.Drawing.Point(23, 91);
            this.btnSanSang.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSanSang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSanSang.Name = "btnSanSang";
            this.btnSanSang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSanSang.Size = new System.Drawing.Size(403, 62);
            this.btnSanSang.TabIndex = 1;
            this.btnSanSang.Text = "CHUYỂN SANG: SẴN SÀNG";
            this.btnSanSang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSanSang.UseAccentColor = false;
            this.btnSanSang.UseVisualStyleBackColor = true;
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
            // frmTrangThaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 985);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmTrangThaiPhong";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT TRẠNG THÁI PHÒNG";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThai)).EndInit();
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
        private MaterialSkin.Controls.MaterialButton btnSanSang;
        private MaterialSkin.Controls.MaterialButton btnBaoTri;
        private System.Windows.Forms.Label lblTrangThai;
        private MaterialSkin.Controls.MaterialComboBox cmbTrangThai;
        private System.Windows.Forms.Label lblKhuVuc;
        private MaterialSkin.Controls.MaterialComboBox cmbKhuVuc;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewButtonColumn colThaoTac;
    }
}