namespace QLPM_PTH
{
    partial class frmLichPhongHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichPhongHoc));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUserInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.lstLich = new MaterialSkin.Controls.MaterialListView();
            this.colThoiGian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colA1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colA2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colA3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardSearch = new MaterialSkin.Controls.MaterialCard();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPhong = new MaterialSkin.Controls.MaterialComboBox();
            this.lblPhong = new MaterialSkin.Controls.MaterialLabel();
            this.pnRightActions = new System.Windows.Forms.Panel();
            this.cardActions = new MaterialSkin.Controls.MaterialCard();
            this.btnBaoLoi = new MaterialSkin.Controls.MaterialButton();
            this.btnDangKy = new MaterialSkin.Controls.MaterialButton();
            this.lblThaoTac = new MaterialSkin.Controls.MaterialLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnMain.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.cardGrid.SuspendLayout();
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
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1034, 60);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Depth = 0;
            this.lblUserInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserInfo.Location = new System.Drawing.Point(439, 22);
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
            this.picAvatar.Location = new System.Drawing.Point(397, 11);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(36, 38);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.tableLayoutPanelContent);
            this.pnMain.Controls.Add(this.pnRightActions);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(3, 124);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1034, 513);
            this.pnMain.TabIndex = 3;
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
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(684, 513);
            this.tableLayoutPanelContent.TabIndex = 0;
            this.tableLayoutPanelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelContent_Paint);
            // 
            // cardGrid
            // 
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardGrid.Controls.Add(this.lstLich);
            this.cardGrid.Depth = 0;
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGrid.Location = new System.Drawing.Point(14, 124);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(14);
            this.cardGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(14);
            this.cardGrid.Size = new System.Drawing.Size(656, 375);
            this.cardGrid.TabIndex = 1;
            // 
            // lstLich
            // 
            this.lstLich.AutoSizeTable = false;
            this.lstLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstLich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLich.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colThoiGian,
            this.colA1,
            this.colA2,
            this.colA3});
            this.lstLich.Depth = 0;
            this.lstLich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLich.FullRowSelect = true;
            this.lstLich.HideSelection = false;
            this.lstLich.Location = new System.Drawing.Point(14, 14);
            this.lstLich.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstLich.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstLich.MouseState = MaterialSkin.MouseState.OUT;
            this.lstLich.Name = "lstLich";
            this.lstLich.OwnerDraw = true;
            this.lstLich.Size = new System.Drawing.Size(628, 347);
            this.lstLich.TabIndex = 0;
            this.lstLich.UseCompatibleStateImageBehavior = false;
            this.lstLich.View = System.Windows.Forms.View.Details;
            // 
            // colThoiGian
            // 
            this.colThoiGian.Text = "Thời Gian";
            this.colThoiGian.Width = 120;
            // 
            // colA1
            // 
            this.colA1.Text = "Phòng A1";
            this.colA1.Width = 200;
            // 
            // colA2
            // 
            this.colA2.Text = "Phòng A2";
            this.colA2.Width = 200;
            // 
            // colA3
            // 
            this.colA3.Text = "Phòng A3";
            this.colA3.Width = 200;
            // 
            // cardSearch
            // 
            this.cardSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSearch.Controls.Add(this.btnTimKiem);
            this.cardSearch.Controls.Add(this.dtpNgay);
            this.cardSearch.Controls.Add(this.lblNgay);
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
            this.cardSearch.Size = new System.Drawing.Size(656, 82);
            this.cardSearch.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = false;
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiem.Depth = 0;
            this.btnTimKiem.HighEmphasis = true;
            this.btnTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Icon")));
            this.btnTimKiem.Location = new System.Drawing.Point(549, 21);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(120, 42);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(379, 28);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(150, 29);
            this.dtpNgay.TabIndex = 3;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Depth = 0;
            this.lblNgay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNgay.Location = new System.Drawing.Point(289, 34);
            this.lblNgay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(81, 19);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "Chọn ngày:";
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
            "[Tất cả phòng]",
            "Phòng A1",
            "Phòng A2",
            "Phòng A3"});
            this.cmbPhong.Location = new System.Drawing.Point(120, 17);
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
            this.lblPhong.Size = new System.Drawing.Size(91, 19);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Chọn phòng:";
            // 
            // pnRightActions
            // 
            this.pnRightActions.Controls.Add(this.cardActions);
            this.pnRightActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRightActions.Location = new System.Drawing.Point(684, 0);
            this.pnRightActions.Name = "pnRightActions";
            this.pnRightActions.Padding = new System.Windows.Forms.Padding(0, 14, 14, 14);
            this.pnRightActions.Size = new System.Drawing.Size(350, 513);
            this.pnRightActions.TabIndex = 1;
            // 
            // cardActions
            // 
            this.cardActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardActions.Controls.Add(this.btnBaoLoi);
            this.cardActions.Controls.Add(this.btnDangKy);
            this.cardActions.Controls.Add(this.lblThaoTac);
            this.cardActions.Depth = 0;
            this.cardActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardActions.Location = new System.Drawing.Point(0, 14);
            this.cardActions.Margin = new System.Windows.Forms.Padding(14);
            this.cardActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardActions.Name = "cardActions";
            this.cardActions.Padding = new System.Windows.Forms.Padding(14);
            this.cardActions.Size = new System.Drawing.Size(336, 485);
            this.cardActions.TabIndex = 0;
            // 
            // btnBaoLoi
            // 
            this.btnBaoLoi.AutoSize = false;
            this.btnBaoLoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaoLoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaoLoi.Depth = 0;
            this.btnBaoLoi.HighEmphasis = true;
            this.btnBaoLoi.Icon = ((System.Drawing.Image)(resources.GetObject("btnBaoLoi.Icon")));
            this.btnBaoLoi.Location = new System.Drawing.Point(17, 145);
            this.btnBaoLoi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaoLoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaoLoi.Name = "btnBaoLoi";
            this.btnBaoLoi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaoLoi.Size = new System.Drawing.Size(302, 50);
            this.btnBaoLoi.TabIndex = 2;
            this.btnBaoLoi.Text = "BÁO CÁO LỖI THIẾT BỊ";
            this.btnBaoLoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnBaoLoi.UseAccentColor = false;
            this.btnBaoLoi.UseVisualStyleBackColor = true;
            this.btnBaoLoi.Click += new System.EventHandler(this.btnBaoLoi_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.AutoSize = false;
            this.btnDangKy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDangKy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDangKy.Depth = 0;
            this.btnDangKy.HighEmphasis = true;
            this.btnDangKy.Icon = ((System.Drawing.Image)(resources.GetObject("btnDangKy.Icon")));
            this.btnDangKy.Location = new System.Drawing.Point(17, 74);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDangKy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDangKy.Size = new System.Drawing.Size(302, 50);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "ĐĂNG KÝ PHÒNG MỚI";
            this.btnDangKy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDangKy.UseAccentColor = false;
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // lblThaoTac
            // 
            this.lblThaoTac.AutoSize = true;
            this.lblThaoTac.Depth = 0;
            this.lblThaoTac.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblThaoTac.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblThaoTac.Location = new System.Drawing.Point(17, 17);
            this.lblThaoTac.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblThaoTac.Name = "lblThaoTac";
            this.lblThaoTac.Size = new System.Drawing.Size(171, 24);
            this.lblThaoTac.TabIndex = 0;
            this.lblThaoTac.Text = "THAO TÁC NHANH";
            // 
            // frmLichPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.Name = "frmLichPhongHoc";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỊCH PHÒNG HỌC THỰC HÀNH";
            this.Load += new System.EventHandler(this.frmLichPhongHoc_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.cardGrid.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialLabel lblThaoTac;
        private MaterialSkin.Controls.MaterialButton btnDangKy;
        private MaterialSkin.Controls.MaterialButton btnBaoLoi;
        private MaterialSkin.Controls.MaterialLabel lblPhong;
        private MaterialSkin.Controls.MaterialComboBox cmbPhong;
        private MaterialSkin.Controls.MaterialLabel lblNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialListView lstLich;
        private System.Windows.Forms.ColumnHeader colThoiGian;
        private System.Windows.Forms.ColumnHeader colA1;
        private System.Windows.Forms.ColumnHeader colA2;
        private System.Windows.Forms.ColumnHeader colA3;
    }
}
