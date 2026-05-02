namespace MHSV
{
    partial class frmMHSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMHSV));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnDangXuat = new MaterialSkin.Controls.MaterialButton();
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cardNotice = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cardSchedule = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardRegister = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cardReport = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.cardNotice.SuspendLayout();
            this.cardSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cardRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.cardReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnDangXuat);
            this.panelHeader.Controls.Add(this.lblUser);
            this.panelHeader.Controls.Add(this.picAvatar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 64);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1194, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDangXuat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDangXuat.Depth = 0;
            this.btnDangXuat.HighEmphasis = true;
            this.btnDangXuat.Icon = null;
            this.btnDangXuat.Location = new System.Drawing.Point(1077, 14);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDangXuat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDangXuat.Size = new System.Drawing.Size(103, 36);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDangXuat.UseAccentColor = false;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Depth = 0;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUser.Location = new System.Drawing.Point(566, 23);
            this.lblUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(21, 19);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = ".....";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(524, 14);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(36, 36);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.cardNotice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cardSchedule, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cardRegister, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cardReport, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 129);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 568);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cardNotice
            // 
            this.cardNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardNotice.Controls.Add(this.materialLabel4);
            this.cardNotice.Depth = 0;
            this.cardNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardNotice.Location = new System.Drawing.Point(372, 14);
            this.cardNotice.Margin = new System.Windows.Forms.Padding(14);
            this.cardNotice.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardNotice.Name = "cardNotice";
            this.cardNotice.Padding = new System.Windows.Forms.Padding(14);
            this.tableLayoutPanel1.SetRowSpan(this.cardNotice, 3);
            this.cardNotice.Size = new System.Drawing.Size(808, 540);
            this.cardNotice.TabIndex = 4;
            this.cardNotice.Paint += new System.Windows.Forms.PaintEventHandler(this.cardNotice_Paint);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(17, 17);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(114, 24);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "THÔNG BÁO";
            // 
            // cardSchedule
            // 
            this.cardSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSchedule.Controls.Add(this.materialLabel1);
            this.cardSchedule.Controls.Add(this.pictureBox2);
            this.cardSchedule.Depth = 0;
            this.cardSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardSchedule.Location = new System.Drawing.Point(14, 14);
            this.cardSchedule.Margin = new System.Windows.Forms.Padding(14);
            this.cardSchedule.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardSchedule.Name = "cardSchedule";
            this.cardSchedule.Padding = new System.Windows.Forms.Padding(14);
            this.cardSchedule.Size = new System.Drawing.Size(330, 161);
            this.cardSchedule.TabIndex = 1;
            this.cardSchedule.Click += new System.EventHandler(this.cardSchedule_Click);
            this.cardSchedule.Paint += new System.Windows.Forms.PaintEventHandler(this.cardSchedule_Paint);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(117, 72);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "LỊCH PHÒNG";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // cardRegister
            // 
            this.cardRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardRegister.Controls.Add(this.materialLabel2);
            this.cardRegister.Controls.Add(this.pictureBox3);
            this.cardRegister.Depth = 0;
            this.cardRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRegister.Location = new System.Drawing.Point(14, 203);
            this.cardRegister.Margin = new System.Windows.Forms.Padding(14);
            this.cardRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardRegister.Name = "cardRegister";
            this.cardRegister.Padding = new System.Windows.Forms.Padding(14);
            this.cardRegister.Size = new System.Drawing.Size(330, 161);
            this.cardRegister.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(117, 73);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(126, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "ĐĂNG KÝ PHÒNG";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(42, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // cardReport
            // 
            this.cardReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardReport.Controls.Add(this.materialLabel3);
            this.cardReport.Controls.Add(this.pictureBox4);
            this.cardReport.Depth = 0;
            this.cardReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardReport.Location = new System.Drawing.Point(14, 392);
            this.cardReport.Margin = new System.Windows.Forms.Padding(14);
            this.cardReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardReport.Name = "cardReport";
            this.cardReport.Padding = new System.Windows.Forms.Padding(14);
            this.cardReport.Size = new System.Drawing.Size(330, 162);
            this.cardReport.TabIndex = 3;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(117, 72);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(117, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "BÁO CÁO SỰ CỐ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(42, 58);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // frmMHSV
            // 
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmMHSV";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng Máy Tính/Phòng Thực Hành";
            this.Load += new System.EventHandler(this.frmMHSV_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cardNotice.ResumeLayout(false);
            this.cardNotice.PerformLayout();
            this.cardSchedule.ResumeLayout(false);
            this.cardSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cardRegister.ResumeLayout(false);
            this.cardRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.cardReport.ResumeLayout(false);
            this.cardReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private MaterialSkin.Controls.MaterialLabel lblUser;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard cardSchedule;
        private MaterialSkin.Controls.MaterialCard cardRegister;
        private MaterialSkin.Controls.MaterialCard cardReport;
        private MaterialSkin.Controls.MaterialCard cardNotice;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnDangXuat;
    }
}