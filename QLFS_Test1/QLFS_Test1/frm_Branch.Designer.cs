namespace QLFS_Test1
{
    partial class frm_Branch
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
            this.cmd_Exit = new System.Windows.Forms.Button();
            this.cmd_Save = new System.Windows.Forms.Button();
            this.cmd_Delete = new System.Windows.Forms.Button();
            this.cmd_Update = new System.Windows.Forms.Button();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PathScan = new System.Windows.Forms.TextBox();
            this.txt_BranchName = new System.Windows.Forms.TextBox();
            this.txt_IDBranch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PathRar = new System.Windows.Forms.TextBox();
            this.dg_show = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 104);
            this.label1.TabIndex = 26;
            this.label1.Text = "Quản Lý Chi Nhánh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Exit.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Exit.ForeColor = System.Drawing.Color.Black;
            this.cmd_Exit.Location = new System.Drawing.Point(576, 313);
            this.cmd_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(94, 32);
            this.cmd_Exit.TabIndex = 24;
            this.cmd_Exit.Text = "Thoát";
            this.cmd_Exit.UseVisualStyleBackColor = false;
            this.cmd_Exit.Click += new System.EventHandler(this.cmd_Exit_Click);
            // 
            // cmd_Save
            // 
            this.cmd_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Save.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Save.ForeColor = System.Drawing.Color.Black;
            this.cmd_Save.Location = new System.Drawing.Point(474, 313);
            this.cmd_Save.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(94, 32);
            this.cmd_Save.TabIndex = 23;
            this.cmd_Save.Text = "Lưu";
            this.cmd_Save.UseVisualStyleBackColor = false;
            this.cmd_Save.Click += new System.EventHandler(this.cmd_Save_Click);
            // 
            // cmd_Delete
            // 
            this.cmd_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Delete.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Delete.ForeColor = System.Drawing.Color.Black;
            this.cmd_Delete.Location = new System.Drawing.Point(372, 313);
            this.cmd_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_Delete.Name = "cmd_Delete";
            this.cmd_Delete.Size = new System.Drawing.Size(94, 32);
            this.cmd_Delete.TabIndex = 22;
            this.cmd_Delete.Text = "Xóa";
            this.cmd_Delete.UseVisualStyleBackColor = false;
            this.cmd_Delete.Click += new System.EventHandler(this.cmd_Delete_Click);
            // 
            // cmd_Update
            // 
            this.cmd_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Update.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Update.ForeColor = System.Drawing.Color.Black;
            this.cmd_Update.Location = new System.Drawing.Point(270, 313);
            this.cmd_Update.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_Update.Name = "cmd_Update";
            this.cmd_Update.Size = new System.Drawing.Size(94, 32);
            this.cmd_Update.TabIndex = 21;
            this.cmd_Update.Text = "Sửa";
            this.cmd_Update.UseVisualStyleBackColor = false;
            this.cmd_Update.Click += new System.EventHandler(this.cmd_Update_Click);
            // 
            // cmd_Add
            // 
            this.cmd_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_Add.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Add.ForeColor = System.Drawing.Color.Black;
            this.cmd_Add.Location = new System.Drawing.Point(168, 313);
            this.cmd_Add.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(94, 32);
            this.cmd_Add.TabIndex = 20;
            this.cmd_Add.Text = "Thêm";
            this.cmd_Add.UseVisualStyleBackColor = false;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Đường Dẫn File Scan";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Chi Nhánh";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Chi Nhánh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_PathScan
            // 
            this.txt_PathScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PathScan.Location = new System.Drawing.Point(181, 212);
            this.txt_PathScan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PathScan.Name = "txt_PathScan";
            this.txt_PathScan.Size = new System.Drawing.Size(473, 26);
            this.txt_PathScan.TabIndex = 16;
            this.txt_PathScan.TextChanged += new System.EventHandler(this.txt_path_TextChanged);
            // 
            // txt_BranchName
            // 
            this.txt_BranchName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BranchName.Location = new System.Drawing.Point(181, 178);
            this.txt_BranchName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BranchName.Name = "txt_BranchName";
            this.txt_BranchName.Size = new System.Drawing.Size(473, 26);
            this.txt_BranchName.TabIndex = 15;
            this.txt_BranchName.TextChanged += new System.EventHandler(this.txt_BranchName_TextChanged);
            // 
            // txt_IDBranch
            // 
            this.txt_IDBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IDBranch.Location = new System.Drawing.Point(181, 144);
            this.txt_IDBranch.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IDBranch.Name = "txt_IDBranch";
            this.txt_IDBranch.Size = new System.Drawing.Size(473, 26);
            this.txt_IDBranch.TabIndex = 14;
            this.txt_IDBranch.TextChanged += new System.EventHandler(this.txt_ID_Branch_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Đường Dẫn File Nén";
            // 
            // txt_PathRar
            // 
            this.txt_PathRar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PathRar.Location = new System.Drawing.Point(181, 246);
            this.txt_PathRar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PathRar.Name = "txt_PathRar";
            this.txt_PathRar.Size = new System.Drawing.Size(473, 26);
            this.txt_PathRar.TabIndex = 28;
            // 
            // dg_show
            // 
            this.dg_show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_show.Location = new System.Drawing.Point(13, 352);
            this.dg_show.Name = "dg_show";
            this.dg_show.Size = new System.Drawing.Size(811, 377);
            this.dg_show.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tìm kiếm";
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.Location = new System.Drawing.Point(181, 280);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(473, 26);
            this.txt_Search.TabIndex = 31;
            // 
            // frm_Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 741);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dg_show);
            this.Controls.Add(this.txt_PathRar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_Exit);
            this.Controls.Add(this.cmd_Save);
            this.Controls.Add(this.cmd_Delete);
            this.Controls.Add(this.cmd_Update);
            this.Controls.Add(this.cmd_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PathScan);
            this.Controls.Add(this.txt_BranchName);
            this.Controls.Add(this.txt_IDBranch);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Branch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn vị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dg_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_Exit;
        private System.Windows.Forms.Button cmd_Save;
        private System.Windows.Forms.Button cmd_Delete;
        private System.Windows.Forms.Button cmd_Update;
        private System.Windows.Forms.Button cmd_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PathScan;
        private System.Windows.Forms.TextBox txt_BranchName;
        private System.Windows.Forms.TextBox txt_IDBranch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PathRar;
        private System.Windows.Forms.DataGridView dg_show;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Search;
    }
}