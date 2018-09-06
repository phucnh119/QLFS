namespace _2017_SIVC_QLFS
{
    partial class frm_Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Role));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IDRole = new System.Windows.Forms.TextBox();
            this.txt_Permission = new System.Windows.Forms.TextBox();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.cmd_Update = new System.Windows.Forms.Button();
            this.cmd_Delete = new System.Windows.Forms.Button();
            this.cmd_Save = new System.Windows.Forms.Button();
            this.cmd_Exit = new System.Windows.Forms.Button();
            this.dg_Show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(989, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Quyền Truy Cập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(172, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Truy Cập";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(174, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quyền Hạn";
            // 
            // txt_IDRole
            // 
            this.txt_IDRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_IDRole.Location = new System.Drawing.Point(320, 161);
            this.txt_IDRole.Name = "txt_IDRole";
            this.txt_IDRole.Size = new System.Drawing.Size(372, 29);
            this.txt_IDRole.TabIndex = 3;
            // 
            // txt_Permission
            // 
            this.txt_Permission.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Permission.Location = new System.Drawing.Point(320, 211);
            this.txt_Permission.Name = "txt_Permission";
            this.txt_Permission.Size = new System.Drawing.Size(372, 29);
            this.txt_Permission.TabIndex = 4;
            // 
            // cmd_Add
            // 
            this.cmd_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Add.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Add.ForeColor = System.Drawing.Color.Black;
            this.cmd_Add.Location = new System.Drawing.Point(222, 268);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(109, 36);
            this.cmd_Add.TabIndex = 5;
            this.cmd_Add.Text = "Thêm";
            this.cmd_Add.UseVisualStyleBackColor = false;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // cmd_Update
            // 
            this.cmd_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Update.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Update.ForeColor = System.Drawing.Color.Black;
            this.cmd_Update.Location = new System.Drawing.Point(337, 268);
            this.cmd_Update.Name = "cmd_Update";
            this.cmd_Update.Size = new System.Drawing.Size(109, 36);
            this.cmd_Update.TabIndex = 6;
            this.cmd_Update.Text = "Sửa";
            this.cmd_Update.UseVisualStyleBackColor = false;
            this.cmd_Update.Click += new System.EventHandler(this.cmd_Update_Click);
            // 
            // cmd_Delete
            // 
            this.cmd_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Delete.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Delete.ForeColor = System.Drawing.Color.Black;
            this.cmd_Delete.Location = new System.Drawing.Point(452, 268);
            this.cmd_Delete.Name = "cmd_Delete";
            this.cmd_Delete.Size = new System.Drawing.Size(109, 36);
            this.cmd_Delete.TabIndex = 7;
            this.cmd_Delete.Text = "Xóa";
            this.cmd_Delete.UseVisualStyleBackColor = false;
            this.cmd_Delete.Click += new System.EventHandler(this.cmd_Delete_Click);
            // 
            // cmd_Save
            // 
            this.cmd_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Save.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Save.ForeColor = System.Drawing.Color.Black;
            this.cmd_Save.Location = new System.Drawing.Point(567, 268);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(109, 36);
            this.cmd_Save.TabIndex = 8;
            this.cmd_Save.Text = "Lưu";
            this.cmd_Save.UseVisualStyleBackColor = false;
            this.cmd_Save.Click += new System.EventHandler(this.cmd_Save_Click);
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Exit.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Exit.ForeColor = System.Drawing.Color.Black;
            this.cmd_Exit.Location = new System.Drawing.Point(682, 268);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(109, 36);
            this.cmd_Exit.TabIndex = 9;
            this.cmd_Exit.Text = "Thoát";
            this.cmd_Exit.UseVisualStyleBackColor = false;
            this.cmd_Exit.Click += new System.EventHandler(this.cmd_Exit_Click);
            // 
            // dg_Show
            // 
            this.dg_Show.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dg_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Show.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Show.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dg_Show.Location = new System.Drawing.Point(35, 325);
            this.dg_Show.Name = "dg_Show";
            this.dg_Show.RowTemplate.Height = 24;
            this.dg_Show.Size = new System.Drawing.Size(929, 172);
            this.dg_Show.TabIndex = 10;
            this.dg_Show.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Show_RowEnter);
            // 
            // frm_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1013, 558);
            this.ControlBox = false;
            this.Controls.Add(this.dg_Show);
            this.Controls.Add(this.cmd_Exit);
            this.Controls.Add(this.cmd_Save);
            this.Controls.Add(this.cmd_Delete);
            this.Controls.Add(this.cmd_Update);
            this.Controls.Add(this.cmd_Add);
            this.Controls.Add(this.txt_Permission);
            this.Controls.Add(this.txt_IDRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Role";
            this.Text = "Quản Lý Quyền Truy Cập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IDRole;
        private System.Windows.Forms.TextBox txt_Permission;
        private System.Windows.Forms.Button cmd_Add;
        private System.Windows.Forms.Button cmd_Update;
        private System.Windows.Forms.Button cmd_Delete;
        private System.Windows.Forms.Button cmd_Save;
        private System.Windows.Forms.Button cmd_Exit;
        private System.Windows.Forms.DataGridView dg_Show;
    }
}