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
    public partial class frm_AccountStaff : Form
    {
        cls_Connection con = new cls_Connection();
        bool check = true;

        public frm_AccountStaff()
        {
            InitializeComponent();
        }

        public void cleardata()
        {
            txt_Account.Clear();
            txt_Password.Clear();
            txt_Account.Focus();
        }

        public void StatusControl(bool Status)
        {
            cmd_Add.Enabled = Status;
            cmd_Delete.Enabled = Status;
            cmd_Update.Enabled = Status;
            cmd_Exit.Enabled = Status;
            cmd_Save.Enabled = !Status;
            txt_Account.Enabled = !Status;
            txt_Password.Enabled = !Status;
        }
        public void loadcbox()
        {
            string sql = "select * from Staff";
            cbo_FullName.DataSource = con.getDataTable(sql);
            cbo_FullName.DisplayMember = "FullName";
            cbo_FullName.ValueMember = "ID_Staff";
            sql = "SELECT * FROM Role";
            cbo_Permission.DataSource = con.getDataTable(sql);
            cbo_Permission.DisplayMember = "Permission";
            cbo_Permission.ValueMember = "ID_Role";
        }

        public void LoadData()
        {
            string sql = "SELECT AccountStaff.Acount,AccountStaff.PassWord,Staff.FullName, Role.Permission FROM Staff INNER JOIN AccountStaff ON Staff.ID_Staff = AccountStaff.ID_Staff INNER JOIN Role ON AccountStaff.ID_Role = Role.ID_Role";
            dg_Show.DataSource = con.getDataTable(sql);
        }

        private void frm_AccountStaff_Load(object sender, EventArgs e)
        {
            loadcbox();
            LoadData();
            StatusControl(true);
        }

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            StatusControl(false);
            cleardata();
        }

        private void cmd_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa không?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from AccountStaff where Acount='" + txt_Account.Text + "'";
                con.ExecuteNonQuery(sql);
                LoadData();
            }
        }

        private void cmd_Update_Click(object sender, EventArgs e)
        {
            StatusControl(false);
            txt_Account.Enabled = false;
            check = false;
        }

        private void cmd_Save_Click(object sender, EventArgs e)
        {
            string sql;
            // xét nút thêm 
            if (check == true)
            {
                sql = "insert into AccountStaff values(N'" + txt_Account.Text + "',N'" + txt_Password.Text + "',N'" + cbo_FullName.SelectedValue.ToString() + "',N'" + cbo_Permission.SelectedValue.ToString() + "')";
            }
            else
            {
                sql = "update AccountStaff set PassWord =N'" + txt_Password.Text + "',ID_Staff=N'" + cbo_FullName.SelectedValue.ToString() + "',ID_Role=N'" + cbo_Permission.SelectedValue.ToString() + "' where Acount='" + txt_Account.Text + "'";
            }
            con.ExecuteNonQuery(sql);
            LoadData();
            StatusControl(true);
            check = true;
        }

        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_Show_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // lấy dữ liệu vào textbox
                DataGridViewRow row = new DataGridViewRow();
                row = dg_Show.Rows[e.RowIndex];
                txt_Account.Text = row.Cells[0].Value.ToString();
                txt_Password.Text = row.Cells[1].Value.ToString();
                cbo_FullName.Text = row.Cells[2].Value.ToString();
                cbo_Permission.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
