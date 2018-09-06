namespace _2017_SIVC_QLFS
{
    partial class frm_ValuationCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ValuationCertificate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IDprofile = new System.Windows.Forms.TextBox();
            this.txt_VCNumber = new System.Windows.Forms.TextBox();
            this.txt_Customer = new System.Windows.Forms.TextBox();
            this.cbo_IDBranch = new System.Windows.Forms.ComboBox();
            this.cbo_IDType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ContractNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_DateVC = new System.Windows.Forms.DateTimePicker();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.cmd_Update = new System.Windows.Forms.Button();
            this.cmd_Delete = new System.Windows.Forms.Button();
            this.cmd_Save = new System.Windows.Forms.Button();
            this.cmd_Exit = new System.Windows.Forms.Button();
            this.dg_Show = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1691, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Số Chứng Thư";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hồ sơ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số VC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Ra Chứng Thư";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn Vị Thực Hiện";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Loại Tài Sản";
            // 
            // txt_IDprofile
            // 
            this.txt_IDprofile.Enabled = false;
            this.txt_IDprofile.Location = new System.Drawing.Point(713, 128);
            this.txt_IDprofile.Name = "txt_IDprofile";
            this.txt_IDprofile.Size = new System.Drawing.Size(293, 29);
            this.txt_IDprofile.TabIndex = 11;
            this.txt_IDprofile.TextChanged += new System.EventHandler(this.txt_IDprofile_TextChanged);
            // 
            // txt_VCNumber
            // 
            this.txt_VCNumber.Location = new System.Drawing.Point(178, 47);
            this.txt_VCNumber.Name = "txt_VCNumber";
            this.txt_VCNumber.Size = new System.Drawing.Size(293, 29);
            this.txt_VCNumber.TabIndex = 12;
            // 
            // txt_Customer
            // 
            this.txt_Customer.Location = new System.Drawing.Point(178, 84);
            this.txt_Customer.Name = "txt_Customer";
            this.txt_Customer.Size = new System.Drawing.Size(293, 29);
            this.txt_Customer.TabIndex = 13;
            // 
            // cbo_IDBranch
            // 
            this.cbo_IDBranch.FormattingEnabled = true;
            this.cbo_IDBranch.Location = new System.Drawing.Point(767, 55);
            this.cbo_IDBranch.Name = "cbo_IDBranch";
            this.cbo_IDBranch.Size = new System.Drawing.Size(239, 29);
            this.cbo_IDBranch.TabIndex = 16;
            // 
            // cbo_IDType
            // 
            this.cbo_IDType.FormattingEnabled = true;
            this.cbo_IDType.Location = new System.Drawing.Point(767, 91);
            this.cbo_IDType.Name = "cbo_IDType";
            this.cbo_IDType.Size = new System.Drawing.Size(239, 29);
            this.cbo_IDType.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txt_ContractNumber);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtp_DateVC);
            this.groupBox2.Controls.Add(this.cbo_IDType);
            this.groupBox2.Controls.Add(this.cbo_IDBranch);
            this.groupBox2.Controls.Add(this.txt_Customer);
            this.groupBox2.Controls.Add(this.txt_VCNumber);
            this.groupBox2.Controls.Add(this.txt_IDprofile);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(52, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 244);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // txt_ContractNumber
            // 
            this.txt_ContractNumber.Location = new System.Drawing.Point(181, 161);
            this.txt_ContractNumber.Name = "txt_ContractNumber";
            this.txt_ContractNumber.Size = new System.Drawing.Size(289, 29);
            this.txt_ContractNumber.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Số Hợp Đồng";
            // 
            // dtp_DateVC
            // 
            this.dtp_DateVC.CustomFormat = "dd/MM/yyyy";
            this.dtp_DateVC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateVC.Location = new System.Drawing.Point(238, 122);
            this.dtp_DateVC.Name = "dtp_DateVC";
            this.dtp_DateVC.Size = new System.Drawing.Size(233, 29);
            this.dtp_DateVC.TabIndex = 21;
            // 
            // cmd_Add
            // 
            this.cmd_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Add.BackColor = System.Drawing.Color.LightSlateGray;
            this.cmd_Add.ForeColor = System.Drawing.Color.Blue;
            this.cmd_Add.Location = new System.Drawing.Point(225, 336);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(114, 32);
            this.cmd_Add.TabIndex = 22;
            this.cmd_Add.Text = "Thêm";
            this.cmd_Add.UseVisualStyleBackColor = false;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // cmd_Update
            // 
            this.cmd_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Update.BackColor = System.Drawing.Color.LightSlateGray;
            this.cmd_Update.ForeColor = System.Drawing.Color.Blue;
            this.cmd_Update.Location = new System.Drawing.Point(366, 336);
            this.cmd_Update.Name = "cmd_Update";
            this.cmd_Update.Size = new System.Drawing.Size(114, 32);
            this.cmd_Update.TabIndex = 23;
            this.cmd_Update.Text = "Sửa";
            this.cmd_Update.UseVisualStyleBackColor = false;
            this.cmd_Update.Click += new System.EventHandler(this.cmd_Update_Click);
            // 
            // cmd_Delete
            // 
            this.cmd_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Delete.BackColor = System.Drawing.Color.LightSlateGray;
            this.cmd_Delete.ForeColor = System.Drawing.Color.Blue;
            this.cmd_Delete.Location = new System.Drawing.Point(509, 336);
            this.cmd_Delete.Name = "cmd_Delete";
            this.cmd_Delete.Size = new System.Drawing.Size(114, 32);
            this.cmd_Delete.TabIndex = 24;
            this.cmd_Delete.Text = "Xóa";
            this.cmd_Delete.UseVisualStyleBackColor = false;
            this.cmd_Delete.Click += new System.EventHandler(this.cmd_Delete_Click);
            // 
            // cmd_Save
            // 
            this.cmd_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Save.BackColor = System.Drawing.Color.LightSlateGray;
            this.cmd_Save.ForeColor = System.Drawing.Color.Blue;
            this.cmd_Save.Location = new System.Drawing.Point(664, 336);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(114, 32);
            this.cmd_Save.TabIndex = 25;
            this.cmd_Save.Text = "Lưu";
            this.cmd_Save.UseVisualStyleBackColor = false;
            this.cmd_Save.Click += new System.EventHandler(this.cmd_Save_Click);
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Exit.BackColor = System.Drawing.Color.LightSlateGray;
            this.cmd_Exit.ForeColor = System.Drawing.Color.Blue;
            this.cmd_Exit.Location = new System.Drawing.Point(795, 336);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(114, 32);
            this.cmd_Exit.TabIndex = 26;
            this.cmd_Exit.Text = "Thoát";
            this.cmd_Exit.UseVisualStyleBackColor = false;
            this.cmd_Exit.Click += new System.EventHandler(this.cmd_Exit_Click);
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
            this.dg_Show.Location = new System.Drawing.Point(3, 374);
            this.dg_Show.Name = "dg_Show";
            this.dg_Show.RowTemplate.Height = 24;
            this.dg_Show.Size = new System.Drawing.Size(1132, 282);
            this.dg_Show.TabIndex = 27;
            this.dg_Show.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Show_RowEnter);
            // 
            // frm_ValuationCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1137, 668);
            this.ControlBox = false;
            this.Controls.Add(this.dg_Show);
            this.Controls.Add(this.cmd_Exit);
            this.Controls.Add(this.cmd_Save);
            this.Controls.Add(this.cmd_Delete);
            this.Controls.Add(this.cmd_Update);
            this.Controls.Add(this.cmd_Add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_ValuationCertificate";
            this.Text = "Quản Lý Số Chứng Thư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ValuationCertificate_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_IDprofile;
        private System.Windows.Forms.TextBox txt_VCNumber;
        private System.Windows.Forms.TextBox txt_Customer;
        private System.Windows.Forms.ComboBox cbo_IDBranch;
        private System.Windows.Forms.ComboBox cbo_IDType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmd_Add;
        private System.Windows.Forms.Button cmd_Update;
        private System.Windows.Forms.Button cmd_Delete;
        private System.Windows.Forms.Button cmd_Save;
        private System.Windows.Forms.Button cmd_Exit;
        private System.Windows.Forms.DataGridView dg_Show;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_DateVC;
        private System.Windows.Forms.TextBox txt_ContractNumber;
    }
}