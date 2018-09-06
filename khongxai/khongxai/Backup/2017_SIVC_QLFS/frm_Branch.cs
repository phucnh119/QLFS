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
    public partial class frm_Branch : Form
    {
        cls_Connection con = new cls_Connection();
        bool check = true;

        public frm_Branch()
        {
            InitializeComponent();
        }

        public void cleardata()
        {
            txt_ID_Branch.Clear();
            txt_BranchName.Clear();
            txt_path.Clear();
            txt_ID_Branch.Focus();
        }

        public void StatusControl (bool Status)
        {
            cmd_Add.Enabled = Status;
            cmd_Delete.Enabled = Status;
            cmd_Update.Enabled = Status;
            cmd_Exit.Enabled = Status;
            cmd_Save.Enabled = !Status;
            txt_BranchName.Enabled = !Status;
            txt_ID_Branch.Enabled = !Status;
            txt_path.Enabled = !Status;
        }
        public void LoadData()
        {
            string sql = "SELECT * FROM Branch";
            dg_Show.DataSource=con.getDataTable(sql);
        }
        private void frm_Branch_Load(object sender, EventArgs e)
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
                txt_ID_Branch.Text = row.Cells[0].Value.ToString();
                txt_BranchName.Text = row.Cells[1].Value.ToString();
                txt_path.Text = row.Cells[2].Value.ToString();
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
            txt_ID_Branch.Enabled = false;
            check = false;
        }

        private void cmd_Save_Click(object sender, EventArgs e)
        {
            string sql;
            // xét nút thêm 
            if (check == true)
            {
                sql = "insert into Branch values(N'" + txt_ID_Branch.Text + "',N'" + txt_BranchName.Text + "',N'" + txt_path.Text +"')";
            }
            else
            {
                sql = "update Branch set BranchName =N'" + txt_BranchName.Text + "',Path=N'" + txt_path.Text + "' where ID_Branch='" + txt_ID_Branch.Text + "'";
            }
            con.ExecuteNonQuery(sql);
            LoadData();
            StatusControl(true);
            check = true;
        }

        private void cmd_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa không?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from branch where ID_Branch='" + txt_ID_Branch.Text + "'";
                con.ExecuteNonQuery(sql);
                LoadData();
            }
        }


    }
}
