namespace QLPM_PTH
{
    partial class frmXuatBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatBaoCao));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUserInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.pnPreviewBackground = new System.Windows.Forms.Panel();
            this.pnPaper = new System.Windows.Forms.Panel();
            this.lblPreviewHint = new System.Windows.Forms.Label();
            this.cardSearch = new MaterialSkin.Controls.MaterialCard();
            this.btnXemTruoc = new MaterialSkin.Controls.MaterialButton();
            this.txtNguoiLap = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.cmbLoaiBaoCao = new MaterialSkin.Controls.MaterialComboBox();
            this.lblLoaiBaoCao = new System.Windows.Forms.Label();
            this.pnRightActions = new System.Windows.Forms.Panel();
            this.cardActions = new MaterialSkin.Controls.MaterialCard();
            this.btnInTrucTiep = new MaterialSkin.Controls.MaterialButton();
            this.btnXuatExcel = new MaterialSkin.Controls.MaterialButton();
            this.btnXuatPDF = new MaterialSkin.Controls.MaterialButton();
            this.lblThaoTacTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnMain.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.cardGrid.SuspendLayout();
            this.pnPreviewBackground.SuspendLayout();
            this.pnPaper.SuspendLayout();
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
            this.cardGrid.Controls.Add(this.pnPreviewBackground);
            this.cardGrid.Depth = 0;
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGrid.Location = new System.Drawing.Point(19, 239);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Size = new System.Drawing.Size(1220, 572);
            this.cardGrid.TabIndex = 1;
            // 
            // pnPreviewBackground
            // 
            this.pnPreviewBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnPreviewBackground.Controls.Add(this.pnPaper);
            this.pnPreviewBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPreviewBackground.Location = new System.Drawing.Point(0, 0);
            this.pnPreviewBackground.Name = "pnPreviewBackground";
            this.pnPreviewBackground.Size = new System.Drawing.Size(1220, 572);
            this.pnPreviewBackground.TabIndex = 0;
            // 
            // pnPaper
            // 
            this.pnPaper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPaper.BackColor = System.Drawing.Color.White;
            this.pnPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPaper.Controls.Add(this.lblPreviewHint);
            this.pnPaper.Location = new System.Drawing.Point(180, 30);
            this.pnPaper.Name = "pnPaper";
            this.pnPaper.Size = new System.Drawing.Size(860, 512);
            this.pnPaper.TabIndex = 0;
            // 
            // lblPreviewHint
            // 
            this.lblPreviewHint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreviewHint.AutoSize = true;
            this.lblPreviewHint.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewHint.ForeColor = System.Drawing.Color.Gray;
            this.lblPreviewHint.Location = new System.Drawing.Point(120, 240);
            this.lblPreviewHint.Name = "lblPreviewHint";
            this.lblPreviewHint.Size = new System.Drawing.Size(607, 33);
            this.lblPreviewHint.TabIndex = 0;
            this.lblPreviewHint.Text = "BẢN XEM TRƯỚC BÁO CÁO SẼ HIỂN THỊ TẠI ĐÂY";
            // 
            // cardSearch
            // 
            this.cardSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSearch.Controls.Add(this.btnXemTruoc);
            this.cardSearch.Controls.Add(this.txtNguoiLap);
            this.cardSearch.Controls.Add(this.dtpDenNgay);
            this.cardSearch.Controls.Add(this.lblDenNgay);
            this.cardSearch.Controls.Add(this.dtpTuNgay);
            this.cardSearch.Controls.Add(this.lblTuNgay);
            this.cardSearch.Controls.Add(this.cmbLoaiBaoCao);
            this.cardSearch.Controls.Add(this.lblLoaiBaoCao);
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
            // btnXemTruoc
            // 
            this.btnXemTruoc.AutoSize = false;
            this.btnXemTruoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXemTruoc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXemTruoc.Depth = 0;
            this.btnXemTruoc.HighEmphasis = true;
            this.btnXemTruoc.Icon = ((System.Drawing.Image)(resources.GetObject("btnXemTruoc.Icon")));
            this.btnXemTruoc.Location = new System.Drawing.Point(680, 112);
            this.btnXemTruoc.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXemTruoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXemTruoc.Name = "btnXemTruoc";
            this.btnXemTruoc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXemTruoc.Size = new System.Drawing.Size(280, 42);
            this.btnXemTruoc.TabIndex = 8;
            this.btnXemTruoc.Text = "TẠO BẢN XEM TRƯỚC";
            this.btnXemTruoc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXemTruoc.UseAccentColor = false;
            this.btnXemTruoc.UseVisualStyleBackColor = true;
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.AnimateReadOnly = false;
            this.txtNguoiLap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNguoiLap.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNguoiLap.Depth = 0;
            this.txtNguoiLap.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNguoiLap.HideSelection = true;
            this.txtNguoiLap.Hint = "Người lập báo cáo...";
            this.txtNguoiLap.LeadingIcon = null;
            this.txtNguoiLap.Location = new System.Drawing.Point(540, 24);
            this.txtNguoiLap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNguoiLap.MaxLength = 32767;
            this.txtNguoiLap.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.PasswordChar = '\0';
            this.txtNguoiLap.PrefixSuffixText = null;
            this.txtNguoiLap.ReadOnly = false;
            this.txtNguoiLap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNguoiLap.SelectedText = "";
            this.txtNguoiLap.SelectionLength = 0;
            this.txtNguoiLap.SelectionStart = 0;
            this.txtNguoiLap.ShortcutsEnabled = true;
            this.txtNguoiLap.Size = new System.Drawing.Size(420, 48);
            this.txtNguoiLap.TabIndex = 9;
            this.txtNguoiLap.TabStop = false;
            this.txtNguoiLap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNguoiLap.TrailingIcon = null;
            this.txtNguoiLap.UseSystemPasswordChar = false;
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
            // cmbLoaiBaoCao
            // 
            this.cmbLoaiBaoCao.AutoResize = false;
            this.cmbLoaiBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLoaiBaoCao.Depth = 0;
            this.cmbLoaiBaoCao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLoaiBaoCao.DropDownHeight = 174;
            this.cmbLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiBaoCao.DropDownWidth = 121;
            this.cmbLoaiBaoCao.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbLoaiBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbLoaiBaoCao.FormattingEnabled = true;
            this.cmbLoaiBaoCao.IntegralHeight = false;
            this.cmbLoaiBaoCao.ItemHeight = 43;
            this.cmbLoaiBaoCao.Items.AddRange(new object[] {
            "Báo cáo tổng hợp trang thiết bị",
            "Báo cáo tần suất sử dụng phòng",
            "Nhật ký bảo trì và chi phí sửa chữa",
            "Danh sách sự cố chưa khắc phục"});
            this.cmbLoaiBaoCao.Location = new System.Drawing.Point(170, 24);
            this.cmbLoaiBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoaiBaoCao.MaxDropDownItems = 4;
            this.cmbLoaiBaoCao.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLoaiBaoCao.Name = "cmbLoaiBaoCao";
            this.cmbLoaiBaoCao.Size = new System.Drawing.Size(350, 49);
            this.cmbLoaiBaoCao.StartIndex = 0;
            this.cmbLoaiBaoCao.TabIndex = 1;
            this.cmbLoaiBaoCao.UseAccent = false;
            // 
            // lblLoaiBaoCao
            // 
            this.lblLoaiBaoCao.AutoSize = true;
            this.lblLoaiBaoCao.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiBaoCao.Location = new System.Drawing.Point(30, 37);
            this.lblLoaiBaoCao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiBaoCao.Name = "lblLoaiBaoCao";
            this.lblLoaiBaoCao.Size = new System.Drawing.Size(124, 23);
            this.lblLoaiBaoCao.TabIndex = 0;
            this.lblLoaiBaoCao.Text = "Loại báo cáo:";
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
            this.cardActions.Controls.Add(this.btnInTrucTiep);
            this.cardActions.Controls.Add(this.btnXuatExcel);
            this.cardActions.Controls.Add(this.btnXuatPDF);
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
            // btnInTrucTiep
            // 
            this.btnInTrucTiep.AutoSize = false;
            this.btnInTrucTiep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInTrucTiep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInTrucTiep.Depth = 0;
            this.btnInTrucTiep.HighEmphasis = true;
            this.btnInTrucTiep.Icon = ((System.Drawing.Image)(resources.GetObject("btnInTrucTiep.Icon")));
            this.btnInTrucTiep.Location = new System.Drawing.Point(23, 265);
            this.btnInTrucTiep.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnInTrucTiep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInTrucTiep.Name = "btnInTrucTiep";
            this.btnInTrucTiep.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInTrucTiep.Size = new System.Drawing.Size(403, 62);
            this.btnInTrucTiep.TabIndex = 3;
            this.btnInTrucTiep.Text = "IN TRỰC TIẾP (PRINT)";
            this.btnInTrucTiep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnInTrucTiep.UseAccentColor = false;
            this.btnInTrucTiep.UseVisualStyleBackColor = true;
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
            this.btnXuatExcel.Text = "XUẤT RA FILE EXCEL";
            this.btnXuatExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnXuatExcel.UseAccentColor = false;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnXuatPDF
            // 
            this.btnXuatPDF.AutoSize = false;
            this.btnXuatPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXuatPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXuatPDF.Depth = 0;
            this.btnXuatPDF.HighEmphasis = true;
            this.btnXuatPDF.Icon = ((System.Drawing.Image)(resources.GetObject("btnXuatPDF.Icon")));
            this.btnXuatPDF.Location = new System.Drawing.Point(23, 91);
            this.btnXuatPDF.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXuatPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXuatPDF.Name = "btnXuatPDF";
            this.btnXuatPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXuatPDF.Size = new System.Drawing.Size(403, 62);
            this.btnXuatPDF.TabIndex = 1;
            this.btnXuatPDF.Text = "XUẤT BÁO CÁO (PDF)";
            this.btnXuatPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXuatPDF.UseAccentColor = false;
            this.btnXuatPDF.UseVisualStyleBackColor = true;
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
            this.lblThaoTacTitle.Size = new System.Drawing.Size(172, 24);
            this.lblThaoTacTitle.TabIndex = 0;
            this.lblThaoTacTitle.Text = "HÀNH ĐỘNG XUẤT";
            // 
            // frmXuatBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 985);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmXuatBaoCao";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẤU HÌNH VÀ XUẤT BÁO CÁO";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.cardGrid.ResumeLayout(false);
            this.pnPreviewBackground.ResumeLayout(false);
            this.pnPaper.ResumeLayout(false);
            this.pnPaper.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton btnXuatPDF;
        private MaterialSkin.Controls.MaterialButton btnXuatExcel;
        private MaterialSkin.Controls.MaterialButton btnInTrucTiep;
        private System.Windows.Forms.Label lblLoaiBaoCao;
        private MaterialSkin.Controls.MaterialComboBox cmbLoaiBaoCao;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private MaterialSkin.Controls.MaterialTextBox2 txtNguoiLap;
        private MaterialSkin.Controls.MaterialButton btnXemTruoc;
        private System.Windows.Forms.Panel pnPreviewBackground;
        private System.Windows.Forms.Panel pnPaper;
        private System.Windows.Forms.Label lblPreviewHint;
    }
}