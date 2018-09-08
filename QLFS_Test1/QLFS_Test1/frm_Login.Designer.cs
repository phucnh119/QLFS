namespace QLFS_Test1
{
    partial class frm_Login
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
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.cmd_Login = new System.Windows.Forms.Button();
            this.cmd_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập hệ thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(111, 118);
            this.txt_User.Margin = new System.Windows.Forms.Padding(4);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(532, 26);
            this.txt_User.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(111, 152);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(532, 26);
            this.txt_Password.TabIndex = 4;
            // 
            // cmd_Login
            // 
            this.cmd_Login.Location = new System.Drawing.Point(198, 202);
            this.cmd_Login.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_Login.Name = "cmd_Login";
            this.cmd_Login.Size = new System.Drawing.Size(112, 34);
            this.cmd_Login.TabIndex = 5;
            this.cmd_Login.Text = "Đăng nhập";
            this.cmd_Login.UseVisualStyleBackColor = true;
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Location = new System.Drawing.Point(351, 202);
            this.cmd_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(112, 34);
            this.cmd_Exit.TabIndex = 6;
            this.cmd_Exit.Text = "Thoát";
            this.cmd_Exit.UseVisualStyleBackColor = true;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 268);
            this.Controls.Add(this.cmd_Exit);
            this.Controls.Add(this.cmd_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button cmd_Login;
        private System.Windows.Forms.Button cmd_Exit;
    }
}