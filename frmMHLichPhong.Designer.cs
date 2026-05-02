namespace MHSV
{
    partial class frmMHLichPhong
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMHLichPhong));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cardFilter = new MaterialSkin.Controls.MaterialCard();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.cboCaHoc = new MaterialSkin.Controls.MaterialComboBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lblChonNgay = new MaterialSkin.Controls.MaterialLabel();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.lstLich = new MaterialSkin.Controls.MaterialListView();
            this.colPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.cardFilter.SuspendLayout();
            this.cardGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblUser);
            this.panelHeader.Controls.Add(this.picAvatar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 64);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1094, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Depth = 0;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUser.Location = new System.Drawing.Point(545, 21);
            this.lblUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(21, 19);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = ".....";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(503, 12);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(36, 36);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // cardFilter
            // 
            this.cardFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardFilter.Controls.Add(this.btnTimKiem);
            this.cardFilter.Controls.Add(this.cboCaHoc);
            this.cardFilter.Controls.Add(this.dtpNgay);
            this.cardFilter.Controls.Add(this.lblChonNgay);
            this.cardFilter.Depth = 0;
            this.cardFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardFilter.Location = new System.Drawing.Point(3, 129);
            this.cardFilter.Margin = new System.Windows.Forms.Padding(14);
            this.cardFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardFilter.Name = "cardFilter";
            this.cardFilter.Padding = new System.Windows.Forms.Padding(14);
            this.cardFilter.Size = new System.Drawing.Size(1094, 100);
            this.cardFilter.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = false;
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiem.Depth = 0;
            this.btnTimKiem.HighEmphasis = true;
            this.btnTimKiem.Icon = null;
            this.btnTimKiem.Location = new System.Drawing.Point(763, 24);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(150, 40);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "TRA CỨU";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboCaHoc
            // 
            this.cboCaHoc.AutoResize = false;
            this.cboCaHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCaHoc.Depth = 0;
            this.cboCaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCaHoc.DropDownHeight = 174;
            this.cboCaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaHoc.DropDownWidth = 121;
            this.cboCaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCaHoc.Hint = "Chọn ca học";
            this.cboCaHoc.IntegralHeight = false;
            this.cboCaHoc.ItemHeight = 43;
            this.cboCaHoc.Location = new System.Drawing.Point(406, 24);
            this.cboCaHoc.MaxDropDownItems = 4;
            this.cboCaHoc.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCaHoc.Name = "cboCaHoc";
            this.cboCaHoc.Size = new System.Drawing.Size(350, 49);
            this.cboCaHoc.StartIndex = 0;
            this.cboCaHoc.TabIndex = 2;
            this.cboCaHoc.SelectedIndexChanged += new System.EventHandler(this.cboCaHoc_SelectedIndexChanged);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(120, 40);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(250, 22);
            this.dtpNgay.TabIndex = 1;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // lblChonNgay
            // 
            this.lblChonNgay.AutoSize = true;
            this.lblChonNgay.Depth = 0;
            this.lblChonNgay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblChonNgay.Location = new System.Drawing.Point(20, 42);
            this.lblChonNgay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChonNgay.Name = "lblChonNgay";
            this.lblChonNgay.Size = new System.Drawing.Size(81, 19);
            this.lblChonNgay.TabIndex = 0;
            this.lblChonNgay.Text = "Chọn ngày:";
            this.lblChonNgay.Click += new System.EventHandler(this.lblChonNgay_Click);
            // 
            // cardGrid
            // 
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardGrid.Controls.Add(this.lstLich);
            this.cardGrid.Depth = 0;
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGrid.Location = new System.Drawing.Point(3, 229);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(14);
            this.cardGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(14);
            this.cardGrid.Size = new System.Drawing.Size(1094, 556);
            this.cardGrid.TabIndex = 2;
            // 
            // lstLich
            // 
            this.lstLich.AutoSizeTable = false;
            this.lstLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstLich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLich.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPhong,
            this.colCa,
            this.colMon,
            this.colTrangThai});
            this.lstLich.Depth = 0;
            this.lstLich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLich.FullRowSelect = true;
            this.lstLich.HideSelection = false;
            this.lstLich.Location = new System.Drawing.Point(14, 14);
            this.lstLich.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstLich.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstLich.MouseState = MaterialSkin.MouseState.OUT;
            this.lstLich.Name = "lstLich";
            this.lstLich.OwnerDraw = true;
            this.lstLich.Size = new System.Drawing.Size(1066, 528);
            this.lstLich.TabIndex = 0;
            this.lstLich.UseCompatibleStateImageBehavior = false;
            this.lstLich.View = System.Windows.Forms.View.Details;
            this.lstLich.SelectedIndexChanged += new System.EventHandler(this.lstLich_SelectedIndexChanged);
            // 
            // colPhong
            // 
            this.colPhong.Text = "Phòng Máy";
            this.colPhong.Width = 200;
            // 
            // colCa
            // 
            this.colCa.Text = "Ca Học";
            this.colCa.Width = 200;
            // 
            // colMon
            // 
            this.colMon.Text = "Môn Học";
            this.colMon.Width = 400;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Text = "Trạng Thái";
            this.colTrangThai.Width = 250;
            // 
            // frmMHLichPhong
            // 
            this.ClientSize = new System.Drawing.Size(1100, 788);
            this.Controls.Add(this.cardGrid);
            this.Controls.Add(this.cardFilter);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmMHLichPhong";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem lịch phòng máy";
            this.Load += new System.EventHandler(this.frmMHLichPhong_Load_1);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.cardFilter.ResumeLayout(false);
            this.cardFilter.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialCard cardFilter;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialComboBox cboCaHoc;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private MaterialSkin.Controls.MaterialLabel lblChonNgay;
        private MaterialSkin.Controls.MaterialCard cardGrid;
        private MaterialSkin.Controls.MaterialListView lstLich;
        private System.Windows.Forms.ColumnHeader colPhong;
        private System.Windows.Forms.ColumnHeader colCa;
        private System.Windows.Forms.ColumnHeader colMon;
        private System.Windows.Forms.ColumnHeader colTrangThai;
        private MaterialSkin.Controls.MaterialLabel lblUser;
        private System.Windows.Forms.PictureBox picAvatar;
    }
}