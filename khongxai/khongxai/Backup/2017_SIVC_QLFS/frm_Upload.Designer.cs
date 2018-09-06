namespace _2017_SIVC_QLFS
{
    partial class frm_Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Upload));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.cbo_IDProfile = new System.Windows.Forms.ComboBox();
            this.txt_Linkfile = new System.Windows.Forms.TextBox();
            this.cmd_Linkfile = new System.Windows.Forms.Button();
            this.cmd_UpLoad = new System.Windows.Forms.Button();
            this.cmd_Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.OFD_ChooseFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1037, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "UpLoad File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời Gian";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số VC";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_Date.CustomFormat = "dd/MM/yyyy";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(360, 288);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(362, 29);
            this.dtp_Date.TabIndex = 5;
            this.dtp_Date.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            // 
            // cbo_IDProfile
            // 
            this.cbo_IDProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_IDProfile.FormattingEnabled = true;
            this.cbo_IDProfile.Location = new System.Drawing.Point(360, 342);
            this.cbo_IDProfile.Margin = new System.Windows.Forms.Padding(5);
            this.cbo_IDProfile.Name = "cbo_IDProfile";
            this.cbo_IDProfile.Size = new System.Drawing.Size(361, 29);
            this.cbo_IDProfile.TabIndex = 6;
            this.cbo_IDProfile.SelectedIndexChanged += new System.EventHandler(this.cbo_IDProfile_SelectedIndexChanged);
            // 
            // txt_Linkfile
            // 
            this.txt_Linkfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Linkfile.Location = new System.Drawing.Point(360, 398);
            this.txt_Linkfile.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Linkfile.Name = "txt_Linkfile";
            this.txt_Linkfile.Size = new System.Drawing.Size(361, 29);
            this.txt_Linkfile.TabIndex = 8;
            // 
            // cmd_Linkfile
            // 
            this.cmd_Linkfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Linkfile.BackColor = System.Drawing.Color.LightSlateGray;
            this.cmd_Linkfile.ForeColor = System.Drawing.Color.Black;
            this.cmd_Linkfile.Location = new System.Drawing.Point(741, 392);
            this.cmd_Linkfile.Margin = new System.Windows.Forms.Padding(5);
            this.cmd_Linkfile.Name = "cmd_Linkfile";
            this.cmd_Linkfile.Size = new System.Drawing.Size(88, 44);
            this.cmd_Linkfile.TabIndex = 9;
            this.cmd_Linkfile.Text = "...";
            this.cmd_Linkfile.UseVisualStyleBackColor = false;
            this.cmd_Linkfile.Click += new System.EventHandler(this.cmd_Linkfile_Click);
            // 
            // cmd_UpLoad
            // 
            this.cmd_UpLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_UpLoad.BackColor = System.Drawing.Color.LightSlateGray;
            this.cmd_UpLoad.ForeColor = System.Drawing.Color.Blue;
            this.cmd_UpLoad.Location = new System.Drawing.Point(362, 449);
            this.cmd_UpLoad.Margin = new System.Windows.Forms.Padding(5);
            this.cmd_UpLoad.Name = "cmd_UpLoad";
            this.cmd_UpLoad.Size = new System.Drawing.Size(137, 45);
            this.cmd_UpLoad.TabIndex = 10;
            this.cmd_UpLoad.Text = "Upload";
            this.cmd_UpLoad.UseVisualStyleBackColor = false;
            this.cmd_UpLoad.Click += new System.EventHandler(this.cmd_UpLoad_Click);
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Exit.BackColor = System.Drawing.Color.LightSlateGray;
            this.cmd_Exit.ForeColor = System.Drawing.Color.Blue;
            this.cmd_Exit.Location = new System.Drawing.Point(584, 449);
            this.cmd_Exit.Margin = new System.Windows.Forms.Padding(5);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(137, 45);
            this.cmd_Exit.TabIndex = 11;
            this.cmd_Exit.Text = "Thoát";
            this.cmd_Exit.UseVisualStyleBackColor = false;
            this.cmd_Exit.Click += new System.EventHandler(this.cmd_Exit_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 401);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Chọn File";
            // 
            // OFD_ChooseFile
            // 
            this.OFD_ChooseFile.FileName = "openFileDialog1";
            // 
            // frm_Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1065, 829);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmd_Exit);
            this.Controls.Add(this.cmd_UpLoad);
            this.Controls.Add(this.cmd_Linkfile);
            this.Controls.Add(this.txt_Linkfile);
            this.Controls.Add(this.cbo_IDProfile);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Upload";
            this.Text = "UpLoad File";
            this.Load += new System.EventHandler(this.frm_Upload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.ComboBox cbo_IDProfile;
        private System.Windows.Forms.TextBox txt_Linkfile;
        private System.Windows.Forms.Button cmd_Linkfile;
        private System.Windows.Forms.Button cmd_UpLoad;
        private System.Windows.Forms.Button cmd_Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog OFD_ChooseFile;
    }
}