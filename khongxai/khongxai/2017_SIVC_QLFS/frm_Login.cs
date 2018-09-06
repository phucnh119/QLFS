using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2017_SIVC_QLFS
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_Login_Click(object sender, EventArgs e)
        {
                Cls_Login loginadmin = new Cls_Login();
                if (loginadmin.CheckAdmin(txt_User.Text, txt_PassWord.Text) == true)
                {
                    frm_Main frm = (frm_Main)this.MdiParent;
                    loginadmin.GetValueSystem(txt_User.Text, txt_PassWord.Text);
                    this.Close();
                    frm.MenuAdmin();
                }
                else if (loginadmin.CheckUpload(txt_User.Text, txt_PassWord.Text) == true)
                {
                    frm_Main frm = (frm_Main)this.MdiParent;
                    loginadmin.GetValueSystem(txt_User.Text, txt_PassWord.Text);
                    this.Close();
                    frm.MenuUpload();
                }
                else if (loginadmin.CheckUser(txt_User.Text, txt_PassWord.Text) == true)
                {
                    frm_Main frm = (frm_Main)this.MdiParent;
                    loginadmin.GetValueSystem(txt_User.Text, txt_PassWord.Text);
                    this.Close();
                    frm.MenuUser();
                }
                else
                {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng", "Thông Báo");
                }
        }
    }
}
