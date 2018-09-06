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
    public partial class frm_Role : Form
    {
        cls_Connection con = new cls_Connection();
        bool check = true;

        public frm_Role()
        {
            InitializeComponent();
        }

        public void cleardata()
        {
            txt_IDRole.Clear();
            txt_Permission.Clear();
            txt_IDRole.Focus();
        }

        public void StatusControl(bool Status)
        {
            cmd_Add.Enabled = Status;
            cmd_Delete.Enabled = Status;
            cmd_Update.Enabled = Status;
            cmd_Exit.Enabled = Status;
            cmd_Save.Enabled = !Status;
            txt_IDRole.Enabled = !Status;
            txt_Permission.Enabled = !Status;
        }
        public void LoadData()
        {
            string sql = "SELECT * FROM Role";
            dg_Show.DataSource = con.getDataTable(sql);
        }
        private void frm_Role_Load(object sender, EventArgs e)
        {
            StatusControl(true);
            LoadData();
        }

        private void dg_Show_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // lấy dữ liệu vào textbox
                DataGridViewRow row = new DataGridViewRow();
                row = dg_Show.Rows[e.RowIndex];
                txt_IDRole.Text = row.Cells[0].Value.ToString();
                txt_Permission.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            StatusControl(false);
            cleardata();
        }

        private void cmd_Update_Click(object sender, EventArgs e)
        {
            StatusControl(false);
            txt_IDRole.Enabled = false;
            check = false;
        }

        private void cmd_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa không?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from Role where ID_Role='" + txt_IDRole.Text + "'";
                con.ExecuteNonQuery(sql);
                LoadData();
            }
        }

        private void cmd_Save_Click(object sender, EventArgs e)
        {
            string sql;
            // xét nút thêm 
            if (check == true)
            {
                sql = "insert into Role values(N'" + txt_IDRole.Text + "',N'" + txt_Permission.Text + "')";
            }
            else
            {
                sql = "update Role set Permission =N'" + txt_Permission.Text + "' where ID_Role='" + txt_IDRole.Text + "'";
            }
            con.ExecuteNonQuery(sql);
            LoadData();
            StatusControl(true);
            check = true;
        }
    }
}
