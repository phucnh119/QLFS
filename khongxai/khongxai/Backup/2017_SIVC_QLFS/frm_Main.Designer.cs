namespace _2017_SIVC_QLFS
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ts_HeTHong = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_User = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Branch = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Role = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Staff = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Manage = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Property = new System.Windows.Forms.ToolStripMenuItem();
            this.ts__ValuationCertificate = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Upload = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_HeTHong,
            this.ts_Manage,
            this.ts_Search});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // ts_HeTHong
            // 
            this.ts_HeTHong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_User,
            this.ts_Branch,
            this.ts_Role,
            this.ts_Staff});
            this.ts_HeTHong.Name = "ts_HeTHong";
            this.ts_HeTHong.Size = new System.Drawing.Size(65, 20);
            this.ts_HeTHong.Text = "Hệ Thống";
            // 
            // ts_User
            // 
            this.ts_User.Name = "ts_User";
            this.ts_User.Size = new System.Drawing.Size(196, 22);
            this.ts_User.Text = "Quản Lý Người Dùng";
            this.ts_User.Click += new System.EventHandler(this.ts_User_Click);
            // 
            // ts_Branch
            // 
            this.ts_Branch.Name = "ts_Branch";
            this.ts_Branch.Size = new System.Drawing.Size(196, 22);
            this.ts_Branch.Text = "Quản Lý Đơn Vị Công Tác";
            this.ts_Branch.Click += new System.EventHandler(this.ts_Branch_Click);
            // 
            // ts_Role
            // 
            this.ts_Role.Name = "ts_Role";
            this.ts_Role.Size = new System.Drawing.Size(196, 22);
            this.ts_Role.Text = "Quản Lý Quyền Truy Cập";
            this.ts_Role.Click += new System.EventHandler(this.ts_Role_Click);
            // 
            // ts_Staff
            // 
            this.ts_Staff.Name = "ts_Staff";
            this.ts_Staff.Size = new System.Drawing.Size(196, 22);
            this.ts_Staff.Text = "Quản Lý Nhân Viên";
            this.ts_Staff.Click += new System.EventHandler(this.ts_Staff_Click);
            // 
            // ts_Manage
            // 
            this.ts_Manage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Property,
            this.ts__ValuationCertificate,
            this.ts_Upload});
            this.ts_Manage.Name = "ts_Manage";
            this.ts_Manage.Size = new System.Drawing.Size(59, 20);
            this.ts_Manage.Text = "Quản Lý";
            // 
            // ts_Property
            // 
            this.ts_Property.Name = "ts_Property";
            this.ts_Property.Size = new System.Drawing.Size(159, 22);
            this.ts_Property.Text = "Thông Tin Tài Sản";
            this.ts_Property.Click += new System.EventHandler(this.ts_Property_Click);
            // 
            // ts__ValuationCertificate
            // 
            this.ts__ValuationCertificate.Name = "ts__ValuationCertificate";
            this.ts__ValuationCertificate.Size = new System.Drawing.Size(159, 22);
            this.ts__ValuationCertificate.Text = "Chứng Thư";
            this.ts__ValuationCertificate.Click += new System.EventHandler(this.ts__ValuationCertificate_Click);
            // 
            // ts_Upload
            // 
            this.ts_Upload.Name = "ts_Upload";
            this.ts_Upload.Size = new System.Drawing.Size(159, 22);
            this.ts_Upload.Text = "UpLoad";
            this.ts_Upload.Click += new System.EventHandler(this.ts_Upload_Click);
            // 
            // ts_Search
            // 
            this.ts_Search.Name = "ts_Search";
            this.ts_Search.Size = new System.Drawing.Size(112, 20);
            this.ts_Search.Text = "Truy Vấn Thông Tin";
            this.ts_Search.Click += new System.EventHandler(this.ts_Search_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Location = new System.Drawing.Point(1090, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frm_Main";
            this.Text = "Quản Lý Hồ Sơ Scan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ts_HeTHong;
        private System.Windows.Forms.ToolStripMenuItem ts_User;
        private System.Windows.Forms.ToolStripMenuItem ts_Branch;
        private System.Windows.Forms.ToolStripMenuItem ts_Role;
        private System.Windows.Forms.ToolStripMenuItem ts_Staff;
        private System.Windows.Forms.ToolStripMenuItem ts_Manage;
        private System.Windows.Forms.ToolStripMenuItem ts_Property;
        private System.Windows.Forms.ToolStripMenuItem ts_Search;
        private System.Windows.Forms.ToolStripMenuItem ts__ValuationCertificate;
        private System.Windows.Forms.ToolStripMenuItem ts_Upload;
        private System.Windows.Forms.Button button1;
    }
}



