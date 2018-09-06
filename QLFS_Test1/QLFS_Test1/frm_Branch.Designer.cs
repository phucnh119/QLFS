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
            this.dg_Show = new System.Windows.Forms.DataGridView();
            this.cmd_Exit = new System.Windows.Forms.Button();
            this.cmd_Save = new System.Windows.Forms.Button();
            this.cmd_Delete = new System.Windows.Forms.Button();
            this.cmd_Update = new System.Windows.Forms.Button();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.txt_BranchName = new System.Windows.Forms.TextBox();
            this.txt_ID_Branch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1098, 71);
            this.label1.TabIndex = 26;
            this.label1.Text = "Quản Lý Chi Nhánh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dg_Show
            // 
            this.dg_Show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Show.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Show.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dg_Show.Location = new System.Drawing.Point(12, 314);
            this.dg_Show.Name = "dg_Show";
            this.dg_Show.RowTemplate.Height = 24;
            this.dg_Show.Size = new System.Drawing.Size(1269, 285);
            this.dg_Show.TabIndex = 25;
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Exit.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Exit.ForeColor = System.Drawing.Color.Black;
            this.cmd_Exit.Location = new System.Drawing.Point(819, 268);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(97, 40);
            this.cmd_Exit.TabIndex = 24;
            this.cmd_Exit.Text = "Thoát";
            this.cmd_Exit.UseVisualStyleBackColor = false;
            this.cmd_Exit.Click += new System.EventHandler(this.cmd_Exit_Click);
            // 
            // cmd_Save
            // 
            this.cmd_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Save.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Save.ForeColor = System.Drawing.Color.Black;
            this.cmd_Save.Location = new System.Drawing.Point(705, 268);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(97, 40);
            this.cmd_Save.TabIndex = 23;
            this.cmd_Save.Text = "Lưu";
            this.cmd_Save.UseVisualStyleBackColor = false;
            this.cmd_Save.Click += new System.EventHandler(this.cmd_Save_Click);
            // 
            // cmd_Delete
            // 
            this.cmd_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Delete.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Delete.ForeColor = System.Drawing.Color.Black;
            this.cmd_Delete.Location = new System.Drawing.Point(595, 268);
            this.cmd_Delete.Name = "cmd_Delete";
            this.cmd_Delete.Size = new System.Drawing.Size(97, 40);
            this.cmd_Delete.TabIndex = 22;
            this.cmd_Delete.Text = "Xóa";
            this.cmd_Delete.UseVisualStyleBackColor = false;
            this.cmd_Delete.Click += new System.EventHandler(this.cmd_Delete_Click);
            // 
            // cmd_Update
            // 
            this.cmd_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Update.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Update.ForeColor = System.Drawing.Color.Black;
            this.cmd_Update.Location = new System.Drawing.Point(483, 268);
            this.cmd_Update.Name = "cmd_Update";
            this.cmd_Update.Size = new System.Drawing.Size(97, 40);
            this.cmd_Update.TabIndex = 21;
            this.cmd_Update.Text = "Sửa";
            this.cmd_Update.UseVisualStyleBackColor = false;
            this.cmd_Update.Click += new System.EventHandler(this.cmd_Update_Click);
            // 
            // cmd_Add
            // 
            this.cmd_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Add.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Add.ForeColor = System.Drawing.Color.Black;
            this.cmd_Add.Location = new System.Drawing.Point(377, 268);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(97, 40);
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
            this.label4.Location = new System.Drawing.Point(122, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Đường Dẫn Lưu File";
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
            this.label3.Location = new System.Drawing.Point(122, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
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
            this.label2.Location = new System.Drawing.Point(122, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Chi Nhánh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_path
            // 
            this.txt_path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_path.Location = new System.Drawing.Point(345, 207);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(814, 20);
            this.txt_path.TabIndex = 16;
            this.txt_path.TextChanged += new System.EventHandler(this.txt_path_TextChanged);
            // 
            // txt_BranchName
            // 
            this.txt_BranchName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BranchName.Location = new System.Drawing.Point(345, 159);
            this.txt_BranchName.Name = "txt_BranchName";
            this.txt_BranchName.Size = new System.Drawing.Size(814, 20);
            this.txt_BranchName.TabIndex = 15;
            this.txt_BranchName.TextChanged += new System.EventHandler(this.txt_BranchName_TextChanged);
            // 
            // txt_ID_Branch
            // 
            this.txt_ID_Branch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID_Branch.Location = new System.Drawing.Point(345, 111);
            this.txt_ID_Branch.Name = "txt_ID_Branch";
            this.txt_ID_Branch.Size = new System.Drawing.Size(814, 20);
            this.txt_ID_Branch.TabIndex = 14;
            this.txt_ID_Branch.TextChanged += new System.EventHandler(this.txt_ID_Branch_TextChanged);
            // 
            // frm_Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Show);
            this.Controls.Add(this.cmd_Exit);
            this.Controls.Add(this.cmd_Save);
            this.Controls.Add(this.cmd_Delete);
            this.Controls.Add(this.cmd_Update);
            this.Controls.Add(this.cmd_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.txt_BranchName);
            this.Controls.Add(this.txt_ID_Branch);
            this.Name = "frm_Branch";
            this.Text = "frm_Branch";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_Show;
        private System.Windows.Forms.Button cmd_Exit;
        private System.Windows.Forms.Button cmd_Save;
        private System.Windows.Forms.Button cmd_Delete;
        private System.Windows.Forms.Button cmd_Update;
        private System.Windows.Forms.Button cmd_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.TextBox txt_BranchName;
        private System.Windows.Forms.TextBox txt_ID_Branch;
    }
}