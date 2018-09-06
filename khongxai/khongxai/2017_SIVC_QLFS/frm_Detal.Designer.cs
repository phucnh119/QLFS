namespace _2017_SIVC_QLFS
{
    partial class frm_Detal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Detal));
            this.label2 = new System.Windows.Forms.Label();
            this.axAcro_Show = new AxAcroPDFLib.AxAcroPDF();
            this.cmd_Exit = new System.Windows.Forms.Button();
            this.cmd_Show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Criteria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axAcro_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(674, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thời Gian";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // axAcro_Show
            // 
            this.axAcro_Show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcro_Show.Enabled = true;
            this.axAcro_Show.Location = new System.Drawing.Point(12, 112);
            this.axAcro_Show.Name = "axAcro_Show";
            this.axAcro_Show.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcro_Show.OcxState")));
            this.axAcro_Show.Size = new System.Drawing.Size(1252, 526);
            this.axAcro_Show.TabIndex = 12;
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Exit.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Exit.ForeColor = System.Drawing.Color.Black;
            this.cmd_Exit.Location = new System.Drawing.Point(1121, 70);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(69, 36);
            this.cmd_Exit.TabIndex = 11;
            this.cmd_Exit.Text = "Thoát";
            this.cmd_Exit.UseVisualStyleBackColor = false;
            this.cmd_Exit.Click += new System.EventHandler(this.cmd_Exit_Click);
            // 
            // cmd_Show
            // 
            this.cmd_Show.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Show.BackColor = System.Drawing.Color.DarkGray;
            this.cmd_Show.ForeColor = System.Drawing.Color.Black;
            this.cmd_Show.Location = new System.Drawing.Point(1032, 70);
            this.cmd_Show.Name = "cmd_Show";
            this.cmd_Show.Size = new System.Drawing.Size(69, 36);
            this.cmd_Show.TabIndex = 10;
            this.cmd_Show.Text = "Hiển Thị";
            this.cmd_Show.UseVisualStyleBackColor = false;
            this.cmd_Show.Click += new System.EventHandler(this.cmd_Show_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(69, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1138, 61);
            this.label1.TabIndex = 9;
            this.label1.Text = "Truy Vấn File Scan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_Date.CustomFormat = "dd/MM/yyyy";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(765, 80);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(134, 20);
            this.dtp_Date.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(215, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số VC hoặc Hợp Đồng";
            this.label3.UseMnemonic = false;
            // 
            // txt_Criteria
            // 
            this.txt_Criteria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Criteria.Location = new System.Drawing.Point(362, 80);
            this.txt_Criteria.Name = "txt_Criteria";
            this.txt_Criteria.Size = new System.Drawing.Size(296, 20);
            this.txt_Criteria.TabIndex = 15;
            // 
            // frm_Detal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1276, 673);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Criteria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.axAcro_Show);
            this.Controls.Add(this.cmd_Exit);
            this.Controls.Add(this.cmd_Show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_Date);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Detal";
            this.Text = "Truy xuất file scan";
            this.Load += new System.EventHandler(this.frm_Detal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcro_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private AxAcroPDFLib.AxAcroPDF axAcro_Show;
        private System.Windows.Forms.Button cmd_Exit;
        private System.Windows.Forms.Button cmd_Show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Criteria;
    }
}