namespace ManHinhChinhQuanTri
{
    partial class frmQTReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQTReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblAdminInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAdminAvatar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.cardFilters = new MaterialSkin.Controls.MaterialCard();
            this.btnExport = new MaterialSkin.Controls.MaterialButton();
            this.btnViewReport = new MaterialSkin.Controls.MaterialButton();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new MaterialSkin.Controls.MaterialLabel();
            this.cmbReportType = new MaterialSkin.Controls.MaterialComboBox();
            this.lblFilterTitle = new MaterialSkin.Controls.MaterialLabel();
            this.cardReportContent = new MaterialSkin.Controls.MaterialCard();
            this.dgvSummaryData = new System.Windows.Forms.DataGridView();
            this.colCriteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChartPlaceholder = new MaterialSkin.Controls.MaterialLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.cardFilters.SuspendLayout();
            this.cardReportContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummaryData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblAdminInfo);
            this.panelHeader.Controls.Add(this.picAdminAvatar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 67);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1412, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // lblAdminInfo
            // 
            this.lblAdminInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdminInfo.AutoSize = true;
            this.lblAdminInfo.Depth = 0;
            this.lblAdminInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAdminInfo.Location = new System.Drawing.Point(567, 24);
            this.lblAdminInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminInfo.Name = "lblAdminInfo";
            this.lblAdminInfo.Size = new System.Drawing.Size(37, 19);
            this.lblAdminInfo.TabIndex = 1;
            this.lblAdminInfo.Text = ".........";
            this.lblAdminInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picAdminAvatar
            // 
            this.picAdminAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAdminAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAdminAvatar.Image")));
            this.picAdminAvatar.Location = new System.Drawing.Point(521, 15);
            this.picAdminAvatar.Name = "picAdminAvatar";
            this.picAdminAvatar.Size = new System.Drawing.Size(39, 38);
            this.picAdminAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdminAvatar.TabIndex = 0;
            this.picAdminAvatar.TabStop = false;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.cardFilters, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.cardReportContent, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 132);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1412, 750);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // cardFilters
            // 
            this.cardFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardFilters.Controls.Add(this.btnExport);
            this.cardFilters.Controls.Add(this.btnViewReport);
            this.cardFilters.Controls.Add(this.dtpToDate);
            this.cardFilters.Controls.Add(this.lblTo);
            this.cardFilters.Controls.Add(this.dtpFromDate);
            this.cardFilters.Controls.Add(this.lblFrom);
            this.cardFilters.Controls.Add(this.cmbReportType);
            this.cardFilters.Controls.Add(this.lblFilterTitle);
            this.cardFilters.Depth = 0;
            this.cardFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardFilters.Location = new System.Drawing.Point(15, 15);
            this.cardFilters.Margin = new System.Windows.Forms.Padding(15);
            this.cardFilters.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardFilters.Name = "cardFilters";
            this.cardFilters.Padding = new System.Windows.Forms.Padding(15);
            this.cardFilters.Size = new System.Drawing.Size(1382, 95);
            this.cardFilters.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.AutoSize = false;
            this.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExport.Depth = 0;
            this.btnExport.HighEmphasis = false;
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(1190, 42);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExport.Name = "btnExport";
            this.btnExport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExport.Size = new System.Drawing.Size(164, 42);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "XUẤT BÁO CÁO";
            this.btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnExport.UseAccentColor = false;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewReport.AutoSize = false;
            this.btnViewReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnViewReport.Depth = 0;
            this.btnViewReport.HighEmphasis = true;
            this.btnViewReport.Icon = null;
            this.btnViewReport.Location = new System.Drawing.Point(1005, 42);
            this.btnViewReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnViewReport.Size = new System.Drawing.Size(164, 42);
            this.btnViewReport.TabIndex = 7;
            this.btnViewReport.Text = "XEM KẾT QUẢ";
            this.btnViewReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnViewReport.UseAccentColor = false;
            this.btnViewReport.UseVisualStyleBackColor = true;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Roboto", 12F);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(775, 49);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(163, 32);
            this.dtpToDate.TabIndex = 4;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Depth = 0;
            this.lblTo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTo.Location = new System.Drawing.Point(687, 53);
            this.lblTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(72, 19);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "Đến ngày:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Roboto", 12F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(502, 49);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(163, 32);
            this.dtpFromDate.TabIndex = 2;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Depth = 0;
            this.lblFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFrom.Location = new System.Drawing.Point(420, 53);
            this.lblFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(64, 19);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "Từ ngày:";
            // 
            // cmbReportType
            // 
            this.cmbReportType.AutoResize = false;
            this.cmbReportType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbReportType.Depth = 0;
            this.cmbReportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbReportType.DropDownHeight = 174;
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.DropDownWidth = 121;
            this.cmbReportType.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbReportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbReportType.Hint = "Chọn loại báo cáo";
            this.cmbReportType.IntegralHeight = false;
            this.cmbReportType.ItemHeight = 43;
            this.cmbReportType.Items.AddRange(new object[] {
            "Hiệu suất sử dụng tài sản công",
            "Tần suất mượn phòng theo học kỳ",
            "Thống kê thiết bị hỏng theo quý",
            "Báo cáo tỷ lệ lấp đầy phòng máy"});
            this.cmbReportType.Location = new System.Drawing.Point(19, 35);
            this.cmbReportType.MaxDropDownItems = 4;
            this.cmbReportType.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(381, 49);
            this.cmbReportType.StartIndex = 0;
            this.cmbReportType.TabIndex = 1;
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Depth = 0;
            this.lblFilterTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFilterTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblFilterTitle.Location = new System.Drawing.Point(19, 10);
            this.lblFilterTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(119, 17);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "TIÊU CHÍ BÁO CÁO";
            // 
            // cardReportContent
            // 
            this.cardReportContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardReportContent.Controls.Add(this.dgvSummaryData);
            this.cardReportContent.Controls.Add(this.lblChartPlaceholder);
            this.cardReportContent.Depth = 0;
            this.cardReportContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardReportContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardReportContent.Location = new System.Drawing.Point(15, 140);
            this.cardReportContent.Margin = new System.Windows.Forms.Padding(15);
            this.cardReportContent.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardReportContent.Name = "cardReportContent";
            this.cardReportContent.Padding = new System.Windows.Forms.Padding(15);
            this.cardReportContent.Size = new System.Drawing.Size(1382, 595);
            this.cardReportContent.TabIndex = 1;
            // 
            // dgvSummaryData
            // 
            this.dgvSummaryData.AllowUserToAddRows = false;
            this.dgvSummaryData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSummaryData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSummaryData.BackgroundColor = System.Drawing.Color.White;
            this.dgvSummaryData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSummaryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSummaryData.ColumnHeadersHeight = 45;
            this.dgvSummaryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCriteria,
            this.colValue,
            this.colPercentage});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSummaryData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSummaryData.EnableHeadersVisualStyles = false;
            this.dgvSummaryData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSummaryData.Location = new System.Drawing.Point(19, 312);
            this.dgvSummaryData.Name = "dgvSummaryData";
            this.dgvSummaryData.RowHeadersVisible = false;
            this.dgvSummaryData.RowHeadersWidth = 51;
            this.dgvSummaryData.RowTemplate.Height = 40;
            this.dgvSummaryData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSummaryData.Size = new System.Drawing.Size(1345, 261);
            this.dgvSummaryData.TabIndex = 1;
            // 
            // colCriteria
            // 
            this.colCriteria.HeaderText = "Tiêu Chí Thống Kê";
            this.colCriteria.MinimumWidth = 6;
            this.colCriteria.Name = "colCriteria";
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Giá Trị / Số Lượng";
            this.colValue.MinimumWidth = 6;
            this.colValue.Name = "colValue";
            // 
            // colPercentage
            // 
            this.colPercentage.HeaderText = "Tỷ Lệ (%)";
            this.colPercentage.MinimumWidth = 6;
            this.colPercentage.Name = "colPercentage";
            // 
            // lblChartPlaceholder
            // 
            this.lblChartPlaceholder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChartPlaceholder.Depth = 0;
            this.lblChartPlaceholder.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblChartPlaceholder.Location = new System.Drawing.Point(437, 104);
            this.lblChartPlaceholder.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChartPlaceholder.Name = "lblChartPlaceholder";
            this.lblChartPlaceholder.Size = new System.Drawing.Size(508, 156);
            this.lblChartPlaceholder.TabIndex = 0;
            this.lblChartPlaceholder.Text = "Load biểu đồ ở đây";
            this.lblChartPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 885);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmQTReport";
            this.Padding = new System.Windows.Forms.Padding(3, 67, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Tổng hợp";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.cardFilters.ResumeLayout(false);
            this.cardFilters.PerformLayout();
            this.cardReportContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummaryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialLabel lblAdminInfo;
        private System.Windows.Forms.PictureBox picAdminAvatar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MaterialSkin.Controls.MaterialCard cardFilters;
        private MaterialSkin.Controls.MaterialLabel lblFilterTitle;
        private MaterialSkin.Controls.MaterialComboBox cmbReportType;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private MaterialSkin.Controls.MaterialLabel lblFrom;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private MaterialSkin.Controls.MaterialLabel lblTo;
        private MaterialSkin.Controls.MaterialButton btnExport;
        private MaterialSkin.Controls.MaterialButton btnViewReport;
        private MaterialSkin.Controls.MaterialCard cardReportContent;
        private MaterialSkin.Controls.MaterialLabel lblChartPlaceholder;
        private System.Windows.Forms.DataGridView dgvSummaryData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCriteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercentage;
    }
}