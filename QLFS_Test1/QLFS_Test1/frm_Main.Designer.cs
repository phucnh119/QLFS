namespace QLFS_Test1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ts_System = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Branch = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_User = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Staff = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_LogUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Manage = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Property = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_NumberedVC = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_DestroyVC = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_VCScan = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_VCSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ReportVCScan = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ReportVCSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ReportVCPublish = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_reportVCNotPublish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_System,
            this.ts_Manage,
            this.ts_Report,
            this.ts_Search});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1362, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ts_System
            // 
            this.ts_System.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Branch,
            this.ts_User,
            this.ts_Staff,
            this.ts_LogUser});
            this.ts_System.Name = "ts_System";
            this.ts_System.Size = new System.Drawing.Size(72, 19);
            this.ts_System.Text = "&Hệ Thống";
            // 
            // ts_Branch
            // 
            this.ts_Branch.Name = "ts_Branch";
            this.ts_Branch.Size = new System.Drawing.Size(186, 22);
            this.ts_Branch.Text = "Quản Lý Chi Nhánh";
            // 
            // ts_User
            // 
            this.ts_User.Name = "ts_User";
            this.ts_User.Size = new System.Drawing.Size(186, 22);
            this.ts_User.Text = "Quản Lý Người Dùng";
            // 
            // ts_Staff
            // 
            this.ts_Staff.Name = "ts_Staff";
            this.ts_Staff.Size = new System.Drawing.Size(186, 22);
            this.ts_Staff.Text = "Quản Lý Nhân Viên";
            // 
            // ts_LogUser
            // 
            this.ts_LogUser.Name = "ts_LogUser";
            this.ts_LogUser.Size = new System.Drawing.Size(186, 22);
            this.ts_LogUser.Text = "Nhật Ký Người Dùng";
            // 
            // ts_Manage
            // 
            this.ts_Manage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Property,
            this.ts_NumberedVC,
            this.ts_DestroyVC,
            this.ts_VCScan,
            this.ts_VCSave});
            this.ts_Manage.Name = "ts_Manage";
            this.ts_Manage.Size = new System.Drawing.Size(63, 19);
            this.ts_Manage.Text = "&Quản Lý";
            // 
            // ts_Property
            // 
            this.ts_Property.Name = "ts_Property";
            this.ts_Property.Size = new System.Drawing.Size(180, 22);
            this.ts_Property.Text = "Tài Sản Thẩm Định";
            // 
            // ts_NumberedVC
            // 
            this.ts_NumberedVC.Name = "ts_NumberedVC";
            this.ts_NumberedVC.Size = new System.Drawing.Size(180, 22);
            this.ts_NumberedVC.Text = "Cấp Số Chứng Thư";
            // 
            // ts_DestroyVC
            // 
            this.ts_DestroyVC.Name = "ts_DestroyVC";
            this.ts_DestroyVC.Size = new System.Drawing.Size(180, 22);
            this.ts_DestroyVC.Text = "Chứng Thư Hủy";
            // 
            // ts_VCScan
            // 
            this.ts_VCScan.Name = "ts_VCScan";
            this.ts_VCScan.Size = new System.Drawing.Size(180, 22);
            this.ts_VCScan.Text = "Chứng Thư Scan";
            // 
            // ts_VCSave
            // 
            this.ts_VCSave.Name = "ts_VCSave";
            this.ts_VCSave.Size = new System.Drawing.Size(180, 22);
            this.ts_VCSave.Text = "Chứng Thư Lưu";
            // 
            // ts_Report
            // 
            this.ts_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_ReportVCScan,
            this.ts_ReportVCSave,
            this.ts_ReportVCPublish,
            this.ts_reportVCNotPublish});
            this.ts_Report.Name = "ts_Report";
            this.ts_Report.Size = new System.Drawing.Size(70, 19);
            this.ts_Report.Text = "&Thống Kê";
            // 
            // ts_Search
            // 
            this.ts_Search.Name = "ts_Search";
            this.ts_Search.Size = new System.Drawing.Size(66, 19);
            this.ts_Search.Text = "Truy &Vấn";
            // 
            // ts_ReportVCScan
            // 
            this.ts_ReportVCScan.Name = "ts_ReportVCScan";
            this.ts_ReportVCScan.Size = new System.Drawing.Size(260, 22);
            this.ts_ReportVCScan.Text = "Báo cáo chứng thư scan";
            // 
            // ts_ReportVCSave
            // 
            this.ts_ReportVCSave.Name = "ts_ReportVCSave";
            this.ts_ReportVCSave.Size = new System.Drawing.Size(260, 22);
            this.ts_ReportVCSave.Text = "Báo cáo chứng thư lưu";
            // 
            // ts_ReportVCPublish
            // 
            this.ts_ReportVCPublish.Name = "ts_ReportVCPublish";
            this.ts_ReportVCPublish.Size = new System.Drawing.Size(260, 22);
            this.ts_ReportVCPublish.Text = "Báo cáo chứng thư phát hành";
            // 
            // ts_reportVCNotPublish
            // 
            this.ts_reportVCNotPublish.Name = "ts_reportVCNotPublish";
            this.ts_reportVCNotPublish.Size = new System.Drawing.Size(260, 22);
            this.ts_reportVCNotPublish.Text = "Báo cáo chứng thư chưa phát hành";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hồ sơ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ts_System;
        private System.Windows.Forms.ToolStripMenuItem ts_Manage;
        private System.Windows.Forms.ToolStripMenuItem ts_Branch;
        private System.Windows.Forms.ToolStripMenuItem ts_User;
        private System.Windows.Forms.ToolStripMenuItem ts_Staff;
        private System.Windows.Forms.ToolStripMenuItem ts_LogUser;
        private System.Windows.Forms.ToolStripMenuItem ts_Property;
        private System.Windows.Forms.ToolStripMenuItem ts_NumberedVC;
        private System.Windows.Forms.ToolStripMenuItem ts_DestroyVC;
        private System.Windows.Forms.ToolStripMenuItem ts_VCScan;
        private System.Windows.Forms.ToolStripMenuItem ts_VCSave;
        private System.Windows.Forms.ToolStripMenuItem ts_Report;
        private System.Windows.Forms.ToolStripMenuItem ts_Search;
        private System.Windows.Forms.ToolStripMenuItem ts_ReportVCScan;
        private System.Windows.Forms.ToolStripMenuItem ts_ReportVCSave;
        private System.Windows.Forms.ToolStripMenuItem ts_ReportVCPublish;
        private System.Windows.Forms.ToolStripMenuItem ts_reportVCNotPublish;
    }
}

