namespace ManHinhChinhQuanTri
{
    partial class frmMHQT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMHQT));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogOut = new MaterialSkin.Controls.MaterialButton();
            this.lblAdminInfo = new MaterialSkin.Controls.MaterialLabel();
            this.picAdminAvatar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.cardUser = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserMgmt = new MaterialSkin.Controls.MaterialLabel();
            this.cardRoom = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRoomMgmt = new MaterialSkin.Controls.MaterialLabel();
            this.cardConfig = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblConfigMgmt = new MaterialSkin.Controls.MaterialLabel();
            this.cardData = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblDataMgmt = new MaterialSkin.Controls.MaterialLabel();
            this.cardReport = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblReportMgmt = new MaterialSkin.Controls.MaterialLabel();
            this.cardNotice = new MaterialSkin.Controls.MaterialCard();
            this.lblNoticeTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.cardUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cardRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cardConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.cardData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.cardReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.cardNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnLogOut);
            this.panelHeader.Controls.Add(this.lblAdminInfo);
            this.panelHeader.Controls.Add(this.picAdminAvatar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 67);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1412, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogOut.Depth = 0;
            this.btnLogOut.HighEmphasis = true;
            this.btnLogOut.Icon = null;
            this.btnLogOut.Location = new System.Drawing.Point(1285, 15);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogOut.Size = new System.Drawing.Size(103, 36);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "ĐĂNG XUẤT";
            this.btnLogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogOut.UseAccentColor = false;
            this.btnLogOut.UseVisualStyleBackColor = true;
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
            this.lblAdminInfo.Size = new System.Drawing.Size(17, 19);
            this.lblAdminInfo.TabIndex = 1;
            this.lblAdminInfo.Text = "....";
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
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelMain.Controls.Add(this.cardUser, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.cardRoom, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.cardConfig, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.cardData, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.cardReport, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.cardNotice, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 132);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1412, 750);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // cardUser
            // 
            this.cardUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardUser.Controls.Add(this.pictureBox1);
            this.cardUser.Controls.Add(this.lblUserMgmt);
            this.cardUser.Depth = 0;
            this.cardUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardUser.Location = new System.Drawing.Point(11, 10);
            this.cardUser.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.cardUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardUser.Name = "cardUser";
            this.cardUser.Padding = new System.Windows.Forms.Padding(15);
            this.cardUser.Size = new System.Drawing.Size(472, 130);
            this.cardUser.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserMgmt
            // 
            this.lblUserMgmt.AutoSize = true;
            this.lblUserMgmt.Depth = 0;
            this.lblUserMgmt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserMgmt.Location = new System.Drawing.Point(76, 42);
            this.lblUserMgmt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserMgmt.Name = "lblUserMgmt";
            this.lblUserMgmt.Size = new System.Drawing.Size(197, 19);
            this.lblUserMgmt.TabIndex = 0;
            this.lblUserMgmt.Text = "TÀI KHOẢN & PHÂN QUYỀN";
            // 
            // cardRoom
            // 
            this.cardRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardRoom.Controls.Add(this.pictureBox2);
            this.cardRoom.Controls.Add(this.lblRoomMgmt);
            this.cardRoom.Depth = 0;
            this.cardRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRoom.Location = new System.Drawing.Point(11, 160);
            this.cardRoom.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.cardRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardRoom.Name = "cardRoom";
            this.cardRoom.Padding = new System.Windows.Forms.Padding(15);
            this.cardRoom.Size = new System.Drawing.Size(472, 130);
            this.cardRoom.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblRoomMgmt
            // 
            this.lblRoomMgmt.AutoSize = true;
            this.lblRoomMgmt.Depth = 0;
            this.lblRoomMgmt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRoomMgmt.Location = new System.Drawing.Point(76, 42);
            this.lblRoomMgmt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRoomMgmt.Name = "lblRoomMgmt";
            this.lblRoomMgmt.Size = new System.Drawing.Size(178, 19);
            this.lblRoomMgmt.TabIndex = 0;
            this.lblRoomMgmt.Text = "DANH MỤC PHÒNG MÁY";
            // 
            // cardConfig
            // 
            this.cardConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardConfig.Controls.Add(this.pictureBox3);
            this.cardConfig.Controls.Add(this.lblConfigMgmt);
            this.cardConfig.Depth = 0;
            this.cardConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardConfig.Location = new System.Drawing.Point(11, 310);
            this.cardConfig.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.cardConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardConfig.Name = "cardConfig";
            this.cardConfig.Padding = new System.Windows.Forms.Padding(15);
            this.cardConfig.Size = new System.Drawing.Size(472, 130);
            this.cardConfig.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // lblConfigMgmt
            // 
            this.lblConfigMgmt.AutoSize = true;
            this.lblConfigMgmt.Depth = 0;
            this.lblConfigMgmt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConfigMgmt.Location = new System.Drawing.Point(76, 42);
            this.lblConfigMgmt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConfigMgmt.Name = "lblConfigMgmt";
            this.lblConfigMgmt.Size = new System.Drawing.Size(154, 19);
            this.lblConfigMgmt.TabIndex = 0;
            this.lblConfigMgmt.Text = "THIẾT LẬP QUY ĐỊNH";
            // 
            // cardData
            // 
            this.cardData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardData.Controls.Add(this.pictureBox4);
            this.cardData.Controls.Add(this.lblDataMgmt);
            this.cardData.Depth = 0;
            this.cardData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardData.Location = new System.Drawing.Point(11, 460);
            this.cardData.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.cardData.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardData.Name = "cardData";
            this.cardData.Padding = new System.Windows.Forms.Padding(15);
            this.cardData.Size = new System.Drawing.Size(472, 130);
            this.cardData.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // lblDataMgmt
            // 
            this.lblDataMgmt.AutoSize = true;
            this.lblDataMgmt.Depth = 0;
            this.lblDataMgmt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDataMgmt.Location = new System.Drawing.Point(76, 42);
            this.lblDataMgmt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataMgmt.Name = "lblDataMgmt";
            this.lblDataMgmt.Size = new System.Drawing.Size(165, 19);
            this.lblDataMgmt.TabIndex = 0;
            this.lblDataMgmt.Text = "SAO LƯU & KHÔI PHỤC";
            // 
            // cardReport
            // 
            this.cardReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardReport.Controls.Add(this.pictureBox5);
            this.cardReport.Controls.Add(this.lblReportMgmt);
            this.cardReport.Depth = 0;
            this.cardReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardReport.Location = new System.Drawing.Point(11, 610);
            this.cardReport.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.cardReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardReport.Name = "cardReport";
            this.cardReport.Padding = new System.Windows.Forms.Padding(15);
            this.cardReport.Size = new System.Drawing.Size(472, 130);
            this.cardReport.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(22, 31);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // lblReportMgmt
            // 
            this.lblReportMgmt.AutoSize = true;
            this.lblReportMgmt.Depth = 0;
            this.lblReportMgmt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReportMgmt.Location = new System.Drawing.Point(76, 42);
            this.lblReportMgmt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReportMgmt.Name = "lblReportMgmt";
            this.lblReportMgmt.Size = new System.Drawing.Size(150, 19);
            this.lblReportMgmt.TabIndex = 0;
            this.lblReportMgmt.Text = "BÁO CÁO TỔNG HỢP";
            // 
            // cardNotice
            // 
            this.cardNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardNotice.Controls.Add(this.lblNoticeTitle);
            this.cardNotice.Depth = 0;
            this.cardNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardNotice.Location = new System.Drawing.Point(509, 15);
            this.cardNotice.Margin = new System.Windows.Forms.Padding(15);
            this.cardNotice.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardNotice.Name = "cardNotice";
            this.cardNotice.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanelMain.SetRowSpan(this.cardNotice, 5);
            this.cardNotice.Size = new System.Drawing.Size(888, 720);
            this.cardNotice.TabIndex = 6;
            // 
            // lblNoticeTitle
            // 
            this.lblNoticeTitle.AutoSize = true;
            this.lblNoticeTitle.Depth = 0;
            this.lblNoticeTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNoticeTitle.Location = new System.Drawing.Point(22, 21);
            this.lblNoticeTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoticeTitle.Name = "lblNoticeTitle";
            this.lblNoticeTitle.Size = new System.Drawing.Size(90, 19);
            this.lblNoticeTitle.TabIndex = 0;
            this.lblNoticeTitle.Text = "THÔNG BÁO";
            // 
            // frmMHQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 885);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMHQT";
            this.Padding = new System.Windows.Forms.Padding(3, 67, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng Máy/Phòng Thực Hành";
            this.Load += new System.EventHandler(this.frmMHQT_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.cardUser.ResumeLayout(false);
            this.cardUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cardRoom.ResumeLayout(false);
            this.cardRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cardConfig.ResumeLayout(false);
            this.cardConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.cardData.ResumeLayout(false);
            this.cardData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.cardReport.ResumeLayout(false);
            this.cardReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.cardNotice.ResumeLayout(false);
            this.cardNotice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialLabel lblAdminInfo;
        private System.Windows.Forms.PictureBox picAdminAvatar;
        private MaterialSkin.Controls.MaterialButton btnLogOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MaterialSkin.Controls.MaterialCard cardUser;
        private MaterialSkin.Controls.MaterialLabel lblUserMgmt;
        private MaterialSkin.Controls.MaterialCard cardRoom;
        private MaterialSkin.Controls.MaterialLabel lblRoomMgmt;
        private MaterialSkin.Controls.MaterialCard cardConfig;
        private MaterialSkin.Controls.MaterialLabel lblConfigMgmt;
        private MaterialSkin.Controls.MaterialCard cardData;
        private MaterialSkin.Controls.MaterialLabel lblDataMgmt;
        private MaterialSkin.Controls.MaterialCard cardReport;
        private MaterialSkin.Controls.MaterialLabel lblReportMgmt;
        private MaterialSkin.Controls.MaterialCard cardNotice;
        private MaterialSkin.Controls.MaterialLabel lblNoticeTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}