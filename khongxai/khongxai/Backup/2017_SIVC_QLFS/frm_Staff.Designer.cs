namespace _2017_SIVC_QLFS
{
    partial class frm_Staff
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IDStaff = new System.Windows.Forms.TextBox();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.cbo_IDBranch = new System.Windows.Forms.ComboBox();
            this.dg_Show = new System.Windows.Forms.DataGridView();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.cmd_Update = new System.Windows.Forms.Button();
            this.cmd_Delete = new System.Windows.Forms.Button();
            this.cmd_Save = new System.Windows.Forms.Button();
            this.cmd_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1245, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn Vị Công Tác";
            // 
            // txt_IDStaff
            // 
            this.txt_IDStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_IDStaff.Location = new System.Drawing.Point(579, 156);
            this.txt_IDStaff.Name = "txt_IDStaff";
            this.txt_IDStaff.Size = new System.Drawing.Size(273, 35);
            this.txt_IDStaff.TabIndex = 4;
            // 
            // txt_FullName
            // 
            this.txt_FullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_FullName.Location = new System.Drawing.Point(579, 214);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(273, 35);
            this.txt_FullName.TabIndex = 5;
            // 
            // cbo_IDBranch
            // 
            this.cbo_IDBranch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_IDBranch.FormattingEnabled = true;
            this.cbo_IDBranch.Location = new System.Drawing.Point(579, 263);
            this.cbo_IDBranch.Name = "cbo_IDBranch";
            this.cbo_IDBranch.Size = new System.Drawing.Size(273, 35);
            this.cbo_IDBranch.TabIndex = 6;
            // 
            // dg_Show
            // 
            this.dg_Show.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dg_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Show.Location = new System.Drawing.Point(16, 408);
            this.dg_Show.Name = "dg_Show";
            this.dg_Show.RowTemplate.Height = 24;
            this.dg_Show.Size = new System.Drawing.Size(1245, 225);
            this.dg_Show.TabIndex = 7;
            this.dg_Show.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Show_RowEnter);
            // 
            // cmd_Add
            // 
            this.cmd_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmd_Add.ForeColor = System.Drawing.Color.Lavender;
            this.cmd_Add.Location = new System.Drawing.Point(328, 356);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(85, 33);
            this.cmd_Add.TabIndex = 8;
            this.cmd_Add.Text = "Thêm";
            this.cmd_Add.UseVisualStyleBackColor = false;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // cmd_Update
            // 
            this.cmd_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmd_Update.ForeColor = System.Drawing.Color.Lavender;
            this.cmd_Update.Location = new System.Drawing.Point(452, 356);
            this.cmd_Update.Name = "cmd_Update";
            this.cmd_Update.Size = new System.Drawing.Size(85, 33);
            this.cmd_Update.TabIndex = 9;
            this.cmd_Update.Text = "Sửa";
            this.cmd_Update.UseVisualStyleBackColor = false;
            this.cmd_Update.Click += new System.EventHandler(this.cmd_Update_Click);
            // 
            // cmd_Delete
            // 
            this.cmd_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmd_Delete.ForeColor = System.Drawing.Color.Lavender;
            this.cmd_Delete.Location = new System.Drawing.Point(606, 356);
            this.cmd_Delete.Name = "cmd_Delete";
            this.cmd_Delete.Size = new System.Drawing.Size(85, 33);
            this.cmd_Delete.TabIndex = 10;
            this.cmd_Delete.Text = "Xóa";
            this.cmd_Delete.UseVisualStyleBackColor = false;
            this.cmd_Delete.Click += new System.EventHandler(this.cmd_Delete_Click);
            // 
            // cmd_Save
            // 
            this.cmd_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmd_Save.ForeColor = System.Drawing.Color.Lavender;
            this.cmd_Save.Location = new System.Drawing.Point(738, 356);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(85, 33);
            this.cmd_Save.TabIndex = 11;
            this.cmd_Save.Text = "Lưu";
            this.cmd_Save.UseVisualStyleBackColor = false;
            this.cmd_Save.Click += new System.EventHandler(this.cmd_Save_Click);
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmd_Exit.ForeColor = System.Drawing.Color.Lavender;
            this.cmd_Exit.Location = new System.Drawing.Point(859, 356);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(85, 33);
            this.cmd_Exit.TabIndex = 12;
            this.cmd_Exit.Text = "Thoát";
            this.cmd_Exit.UseVisualStyleBackColor = false;
            this.cmd_Exit.Click += new System.EventHandler(this.cmd_Exit_Click);
            // 
            // frm_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1273, 672);
            this.Controls.Add(this.cmd_Exit);
            this.Controls.Add(this.cmd_Save);
            this.Controls.Add(this.cmd_Delete);
            this.Controls.Add(this.cmd_Update);
            this.Controls.Add(this.cmd_Add);
            this.Controls.Add(this.dg_Show);
            this.Controls.Add(this.cbo_IDBranch);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.txt_IDStaff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Staff";
            this.Text = "Quản Lý Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IDStaff;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.ComboBox cbo_IDBranch;
        private System.Windows.Forms.DataGridView dg_Show;
        private System.Windows.Forms.Button cmd_Add;
        private System.Windows.Forms.Button cmd_Update;
        private System.Windows.Forms.Button cmd_Delete;
        private System.Windows.Forms.Button cmd_Save;
        private System.Windows.Forms.Button cmd_Exit;
    }
}