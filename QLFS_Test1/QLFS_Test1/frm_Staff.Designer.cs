﻿namespace QLFS_Test1
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
            this.cmd_Exit = new System.Windows.Forms.Button();
            this.cmd_Save = new System.Windows.Forms.Button();
            this.cmd_Delete = new System.Windows.Forms.Button();
            this.cmd_Update = new System.Windows.Forms.Button();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.dg_Show = new System.Windows.Forms.DataGridView();
            this.cbo_IDBranch = new System.Windows.Forms.ComboBox();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.txt_IDStaff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Exit.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Exit.ForeColor = System.Drawing.Color.Black;
            this.cmd_Exit.Location = new System.Drawing.Point(871, 309);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(85, 33);
            this.cmd_Exit.TabIndex = 25;
            this.cmd_Exit.Text = "Thoát";
            this.cmd_Exit.UseVisualStyleBackColor = false;
            // 
            // cmd_Save
            // 
            this.cmd_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Save.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Save.ForeColor = System.Drawing.Color.Black;
            this.cmd_Save.Location = new System.Drawing.Point(750, 309);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(85, 33);
            this.cmd_Save.TabIndex = 24;
            this.cmd_Save.Text = "Lưu";
            this.cmd_Save.UseVisualStyleBackColor = false;
            // 
            // cmd_Delete
            // 
            this.cmd_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Delete.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Delete.ForeColor = System.Drawing.Color.Black;
            this.cmd_Delete.Location = new System.Drawing.Point(618, 309);
            this.cmd_Delete.Name = "cmd_Delete";
            this.cmd_Delete.Size = new System.Drawing.Size(85, 33);
            this.cmd_Delete.TabIndex = 23;
            this.cmd_Delete.Text = "Xóa";
            this.cmd_Delete.UseVisualStyleBackColor = false;
            // 
            // cmd_Update
            // 
            this.cmd_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Update.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Update.ForeColor = System.Drawing.Color.Black;
            this.cmd_Update.Location = new System.Drawing.Point(464, 309);
            this.cmd_Update.Name = "cmd_Update";
            this.cmd_Update.Size = new System.Drawing.Size(85, 33);
            this.cmd_Update.TabIndex = 22;
            this.cmd_Update.Text = "Sửa";
            this.cmd_Update.UseVisualStyleBackColor = false;
            // 
            // cmd_Add
            // 
            this.cmd_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Add.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Add.ForeColor = System.Drawing.Color.Black;
            this.cmd_Add.Location = new System.Drawing.Point(340, 309);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(85, 33);
            this.cmd_Add.TabIndex = 21;
            this.cmd_Add.Text = "Thêm";
            this.cmd_Add.UseVisualStyleBackColor = false;
            // 
            // dg_Show
            // 
            this.dg_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dg_Show.Location = new System.Drawing.Point(28, 371);
            this.dg_Show.Name = "dg_Show";
            this.dg_Show.RowTemplate.Height = 24;
            this.dg_Show.Size = new System.Drawing.Size(1245, 225);
            this.dg_Show.TabIndex = 20;
            // 
            // cbo_IDBranch
            // 
            this.cbo_IDBranch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_IDBranch.FormattingEnabled = true;
            this.cbo_IDBranch.Location = new System.Drawing.Point(589, 216);
            this.cbo_IDBranch.Name = "cbo_IDBranch";
            this.cbo_IDBranch.Size = new System.Drawing.Size(273, 21);
            this.cbo_IDBranch.TabIndex = 19;
            // 
            // txt_FullName
            // 
            this.txt_FullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_FullName.Location = new System.Drawing.Point(589, 190);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(273, 20);
            this.txt_FullName.TabIndex = 18;
            // 
            // txt_IDStaff
            // 
            this.txt_IDStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_IDStaff.Location = new System.Drawing.Point(589, 164);
            this.txt_IDStaff.Name = "txt_IDStaff";
            this.txt_IDStaff.Size = new System.Drawing.Size(273, 20);
            this.txt_IDStaff.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(422, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đơn Vị Công Tác";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(422, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(422, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(28, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1245, 74);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quản Lý Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(589, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tìm Kiếm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(942, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FillWeight = 80.76583F;
            this.Column1.HeaderText = "Đăng Nhập";
            this.Column1.Name = "Column1";
            this.Column1.Width = 68;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.FillWeight = 111.7826F;
            this.Column2.HeaderText = "Hệ Thống";
            this.Column2.Name = "Column2";
            this.Column2.Width = 61;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.FillWeight = 90.20702F;
            this.Column3.HeaderText = "Quản Lý";
            this.Column3.Name = "Column3";
            this.Column3.Width = 53;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.FillWeight = 79.77518F;
            this.Column4.HeaderText = "Thống Kê";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.FillWeight = 67.46934F;
            this.Column5.HeaderText = "Truy Vấn";
            this.Column5.Name = "Column5";
            this.Column5.Width = 56;
            // 
            // frm_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
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
            this.Name = "frm_Staff";
            this.Text = "frm_Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Exit;
        private System.Windows.Forms.Button cmd_Save;
        private System.Windows.Forms.Button cmd_Delete;
        private System.Windows.Forms.Button cmd_Update;
        private System.Windows.Forms.Button cmd_Add;
        private System.Windows.Forms.DataGridView dg_Show;
        private System.Windows.Forms.ComboBox cbo_IDBranch;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.TextBox txt_IDStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}