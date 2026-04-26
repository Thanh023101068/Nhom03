namespace ManHinhChinhQuanTri
{
    partial class frmQTPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQTPhong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblAdminInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAdminAvatar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.cardRoomList = new MaterialSkin.Controls.MaterialCard();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardSearch = new MaterialSkin.Controls.MaterialCard();
            this.txtSearchRoom = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.cardRoomInfo = new MaterialSkin.Controls.MaterialCard();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.swRoomStatus = new MaterialSkin.Controls.MaterialSwitch();
            this.txtViTri = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSucChua = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTenPhong = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMaPhong = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblFormTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.cardRoomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.cardSearch.SuspendLayout();
            this.cardRoomInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblAdminInfo);
            this.panelHeader.Controls.Add(this.picAdminAvatar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 64);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1294, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // lblAdminInfo
            // 
            this.lblAdminInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdminInfo.AutoSize = true;
            this.lblAdminInfo.Depth = 0;
            this.lblAdminInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAdminInfo.Location = new System.Drawing.Point(520, 23);
            this.lblAdminInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminInfo.Name = "lblAdminInfo";
            this.lblAdminInfo.Size = new System.Drawing.Size(21, 19);
            this.lblAdminInfo.TabIndex = 1;
            this.lblAdminInfo.Text = ".....";
            this.lblAdminInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picAdminAvatar
            // 
            this.picAdminAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAdminAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAdminAvatar.Image")));
            this.picAdminAvatar.Location = new System.Drawing.Point(478, 14);
            this.picAdminAvatar.Name = "picAdminAvatar";
            this.picAdminAvatar.Size = new System.Drawing.Size(36, 36);
            this.picAdminAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdminAvatar.TabIndex = 0;
            this.picAdminAvatar.TabStop = false;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMain.Controls.Add(this.cardRoomList, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.cardSearch, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.cardRoomInfo, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 129);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1294, 718);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // cardRoomList
            // 
            this.cardRoomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardRoomList.Controls.Add(this.dgvRooms);
            this.cardRoomList.Depth = 0;
            this.cardRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRoomList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRoomList.Location = new System.Drawing.Point(14, 114);
            this.cardRoomList.Margin = new System.Windows.Forms.Padding(14);
            this.cardRoomList.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardRoomList.Name = "cardRoomList";
            this.cardRoomList.Padding = new System.Windows.Forms.Padding(14);
            this.cardRoomList.Size = new System.Drawing.Size(813, 590);
            this.cardRoomList.TabIndex = 1;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRooms.ColumnHeadersHeight = 45;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colSucChua,
            this.colViTri,
            this.colTrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRooms.EnableHeadersVisualStyles = false;
            this.dgvRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRooms.Location = new System.Drawing.Point(14, 14);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowHeadersWidth = 51;
            this.dgvRooms.RowTemplate.Height = 40;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(785, 562);
            this.dgvRooms.TabIndex = 0;
            // 
            // colMaPhong
            // 
            this.colMaPhong.HeaderText = "Mã Phòng";
            this.colMaPhong.MinimumWidth = 6;
            this.colMaPhong.Name = "colMaPhong";
            // 
            // colTenPhong
            // 
            this.colTenPhong.HeaderText = "Tên Phòng";
            this.colTenPhong.MinimumWidth = 6;
            this.colTenPhong.Name = "colTenPhong";
            // 
            // colSucChua
            // 
            this.colSucChua.HeaderText = "Sức Chứa";
            this.colSucChua.MinimumWidth = 6;
            this.colSucChua.Name = "colSucChua";
            // 
            // colViTri
            // 
            this.colViTri.HeaderText = "Vị Trí";
            this.colViTri.MinimumWidth = 6;
            this.colViTri.Name = "colViTri";
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // cardSearch
            // 
            this.cardSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSearch.Controls.Add(this.txtSearchRoom);
            this.cardSearch.Controls.Add(this.btnSearch);
            this.cardSearch.Depth = 0;
            this.cardSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardSearch.Location = new System.Drawing.Point(14, 14);
            this.cardSearch.Margin = new System.Windows.Forms.Padding(14);
            this.cardSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardSearch.Name = "cardSearch";
            this.cardSearch.Padding = new System.Windows.Forms.Padding(14);
            this.cardSearch.Size = new System.Drawing.Size(813, 72);
            this.cardSearch.TabIndex = 0;
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.AnimateReadOnly = false;
            this.txtSearchRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearchRoom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchRoom.Depth = 0;
            this.txtSearchRoom.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSearchRoom.HideSelection = true;
            this.txtSearchRoom.Hint = "Tìm kiếm theo mã hoặc tên phòng...";
            this.txtSearchRoom.LeadingIcon = null;
            this.txtSearchRoom.Location = new System.Drawing.Point(17, 12);
            this.txtSearchRoom.MaxLength = 32767;
            this.txtSearchRoom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.PasswordChar = '\0';
            this.txtSearchRoom.PrefixSuffixText = null;
            this.txtSearchRoom.ReadOnly = false;
            this.txtSearchRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchRoom.SelectedText = "";
            this.txtSearchRoom.SelectionLength = 0;
            this.txtSearchRoom.SelectionStart = 0;
            this.txtSearchRoom.ShortcutsEnabled = true;
            this.txtSearchRoom.Size = new System.Drawing.Size(600, 48);
            this.txtSearchRoom.TabIndex = 0;
            this.txtSearchRoom.TabStop = false;
            this.txtSearchRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchRoom.TrailingIcon = null;
            this.txtSearchRoom.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(640, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(140, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cardRoomInfo
            // 
            this.cardRoomInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardRoomInfo.Controls.Add(this.btnClear);
            this.cardRoomInfo.Controls.Add(this.btnDelete);
            this.cardRoomInfo.Controls.Add(this.btnSave);
            this.cardRoomInfo.Controls.Add(this.swRoomStatus);
            this.cardRoomInfo.Controls.Add(this.txtViTri);
            this.cardRoomInfo.Controls.Add(this.txtSucChua);
            this.cardRoomInfo.Controls.Add(this.txtTenPhong);
            this.cardRoomInfo.Controls.Add(this.txtMaPhong);
            this.cardRoomInfo.Controls.Add(this.lblFormTitle);
            this.cardRoomInfo.Depth = 0;
            this.cardRoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRoomInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRoomInfo.Location = new System.Drawing.Point(855, 14);
            this.cardRoomInfo.Margin = new System.Windows.Forms.Padding(14);
            this.cardRoomInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardRoomInfo.Name = "cardRoomInfo";
            this.cardRoomInfo.Padding = new System.Windows.Forms.Padding(14);
            this.tableLayoutPanelMain.SetRowSpan(this.cardRoomInfo, 2);
            this.cardRoomInfo.Size = new System.Drawing.Size(425, 690);
            this.cardRoomInfo.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = false;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = false;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(20, 500);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(385, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "LÀM MỚI BIỂU MẪU";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(20, 440);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(385, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "XÓA PHÒNG MÁY";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnDelete.UseAccentColor = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(20, 380);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(385, 45);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "LƯU THÔNG TIN PHÒNG";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // swRoomStatus
            // 
            this.swRoomStatus.AutoSize = true;
            this.swRoomStatus.Depth = 0;
            this.swRoomStatus.Font = new System.Drawing.Font("Roboto", 12F);
            this.swRoomStatus.Location = new System.Drawing.Point(20, 310);
            this.swRoomStatus.Margin = new System.Windows.Forms.Padding(0);
            this.swRoomStatus.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swRoomStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.swRoomStatus.Name = "swRoomStatus";
            this.swRoomStatus.Ripple = true;
            this.swRoomStatus.Size = new System.Drawing.Size(208, 37);
            this.swRoomStatus.TabIndex = 5;
            this.swRoomStatus.Text = "Trạng thái hoạt động";
            this.swRoomStatus.UseVisualStyleBackColor = true;
            // 
            // txtViTri
            // 
            this.txtViTri.AnimateReadOnly = false;
            this.txtViTri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtViTri.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtViTri.Depth = 0;
            this.txtViTri.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtViTri.HideSelection = true;
            this.txtViTri.Hint = "Vị trí (Tầng / Dãy)";
            this.txtViTri.LeadingIcon = null;
            this.txtViTri.Location = new System.Drawing.Point(20, 240);
            this.txtViTri.MaxLength = 32767;
            this.txtViTri.MouseState = MaterialSkin.MouseState.OUT;
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.PasswordChar = '\0';
            this.txtViTri.PrefixSuffixText = null;
            this.txtViTri.ReadOnly = false;
            this.txtViTri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtViTri.SelectedText = "";
            this.txtViTri.SelectionLength = 0;
            this.txtViTri.SelectionStart = 0;
            this.txtViTri.ShortcutsEnabled = true;
            this.txtViTri.Size = new System.Drawing.Size(385, 48);
            this.txtViTri.TabIndex = 4;
            this.txtViTri.TabStop = false;
            this.txtViTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtViTri.TrailingIcon = null;
            this.txtViTri.UseSystemPasswordChar = false;
            // 
            // txtSucChua
            // 
            this.txtSucChua.AnimateReadOnly = false;
            this.txtSucChua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSucChua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSucChua.Depth = 0;
            this.txtSucChua.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSucChua.HideSelection = true;
            this.txtSucChua.Hint = "Sức chứa (Số máy/chỗ ngồi)";
            this.txtSucChua.LeadingIcon = null;
            this.txtSucChua.Location = new System.Drawing.Point(20, 180);
            this.txtSucChua.MaxLength = 32767;
            this.txtSucChua.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.PasswordChar = '\0';
            this.txtSucChua.PrefixSuffixText = null;
            this.txtSucChua.ReadOnly = false;
            this.txtSucChua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSucChua.SelectedText = "";
            this.txtSucChua.SelectionLength = 0;
            this.txtSucChua.SelectionStart = 0;
            this.txtSucChua.ShortcutsEnabled = true;
            this.txtSucChua.Size = new System.Drawing.Size(385, 48);
            this.txtSucChua.TabIndex = 3;
            this.txtSucChua.TabStop = false;
            this.txtSucChua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSucChua.TrailingIcon = null;
            this.txtSucChua.UseSystemPasswordChar = false;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.AnimateReadOnly = false;
            this.txtTenPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenPhong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenPhong.Depth = 0;
            this.txtTenPhong.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTenPhong.HideSelection = true;
            this.txtTenPhong.Hint = "Tên phòng máy";
            this.txtTenPhong.LeadingIcon = null;
            this.txtTenPhong.Location = new System.Drawing.Point(20, 120);
            this.txtTenPhong.MaxLength = 32767;
            this.txtTenPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.PasswordChar = '\0';
            this.txtTenPhong.PrefixSuffixText = null;
            this.txtTenPhong.ReadOnly = false;
            this.txtTenPhong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenPhong.SelectedText = "";
            this.txtTenPhong.SelectionLength = 0;
            this.txtTenPhong.SelectionStart = 0;
            this.txtTenPhong.ShortcutsEnabled = true;
            this.txtTenPhong.Size = new System.Drawing.Size(385, 48);
            this.txtTenPhong.TabIndex = 2;
            this.txtTenPhong.TabStop = false;
            this.txtTenPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenPhong.TrailingIcon = null;
            this.txtTenPhong.UseSystemPasswordChar = false;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.AnimateReadOnly = false;
            this.txtMaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaPhong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaPhong.Depth = 0;
            this.txtMaPhong.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMaPhong.HideSelection = true;
            this.txtMaPhong.Hint = "Mã phòng máy";
            this.txtMaPhong.LeadingIcon = null;
            this.txtMaPhong.Location = new System.Drawing.Point(20, 60);
            this.txtMaPhong.MaxLength = 32767;
            this.txtMaPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.PasswordChar = '\0';
            this.txtMaPhong.PrefixSuffixText = null;
            this.txtMaPhong.ReadOnly = false;
            this.txtMaPhong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaPhong.SelectedText = "";
            this.txtMaPhong.SelectionLength = 0;
            this.txtMaPhong.SelectionStart = 0;
            this.txtMaPhong.ShortcutsEnabled = true;
            this.txtMaPhong.Size = new System.Drawing.Size(385, 48);
            this.txtMaPhong.TabIndex = 1;
            this.txtMaPhong.TabStop = false;
            this.txtMaPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaPhong.TrailingIcon = null;
            this.txtMaPhong.UseSystemPasswordChar = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Depth = 0;
            this.lblFormTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFormTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblFormTitle.Location = new System.Drawing.Point(17, 17);
            this.lblFormTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(180, 19);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "THÔNG TIN PHÒNG MÁY";
            // 
            // frmQTPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 850);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQTPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Danh mục Phòng thực hành / Phòng máy";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.cardRoomList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.cardSearch.ResumeLayout(false);
            this.cardRoomInfo.ResumeLayout(false);
            this.cardRoomInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialLabel lblAdminInfo;
        private System.Windows.Forms.PictureBox picAdminAvatar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MaterialSkin.Controls.MaterialCard cardSearch;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearchRoom;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialCard cardRoomList;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private MaterialSkin.Controls.MaterialCard cardRoomInfo;
        private MaterialSkin.Controls.MaterialLabel lblFormTitle;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaPhong;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenPhong;
        private MaterialSkin.Controls.MaterialTextBox2 txtSucChua;
        private MaterialSkin.Controls.MaterialTextBox2 txtViTri;
        private MaterialSkin.Controls.MaterialSwitch swRoomStatus;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnClear;
    }
}