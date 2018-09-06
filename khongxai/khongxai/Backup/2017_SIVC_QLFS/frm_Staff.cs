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
    public partial class frm_Staff : Form
    {
        cls_Connection con = new cls_Connection();
        bool check = true;

        public frm_Staff()
        {
            InitializeComponent();
        }

        private void frm_Staff_Load(object sender, EventArgs e)
        {
            loadcbox();
            StatusControl(true);
            LoadData();
        }

        public void cleardata()
        {
            txt_IDStaff.Clear();
            txt_FullName.Clear();
            txt_IDStaff.Focus();
        }

        public void StatusControl(bool Status)
        {
            cmd_Add.Enabled = Status;
            cmd_Delete.Enabled = Status;
            cmd_Update.Enabled = Status;
            cmd_Exit.Enabled = Status;
            cmd_Save.Enabled = !Status;
            txt_IDStaff.Enabled = !Status;
            txt_FullName.Enabled = !Status;
            cbo_IDBranch.Enabled = !Status;
        }
        public void LoadData()
        {
            string sql = "select ID_Staff,FullName,BranchName from Staff St Join Branch br On St.ID_Branch=br.ID_Branch;";
            dg_Show.DataSource = con.getDataTable(sql);
        }
        public void loadcbox()
        {
            string sql = "select * from Branch";
            cbo_IDBranch.DataSource = con.getDataTable(sql);
            cbo_IDBranch.DisplayMember = "BranchName";
            cbo_IDBranch.ValueMember = "ID_Branch";
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
                txt_IDStaff.Text = row.Cells[0].Value.ToString();
                txt_FullName.Text = row.Cells[1].Value.ToString();
                cbo_IDBranch.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            StatusControl(false);
            cleardata();
        }

        private void cmd_Update_Click(object sender, EventArgs e)
        {
            StatusControl(false);
            txt_IDStaff.Enabled = false;
            check = false;
        }

        private void cmd_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa không?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from Staff where ID_Staff='" + txt_IDStaff.Text + "'";
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
                sql = "insert into Staff values(N'" + txt_IDStaff.Text + "',N'" + txt_FullName.Text + "',N'" + cbo_IDBranch.SelectedValue.ToString() + "')";
            }
            else
            {
                sql = "update Staff set FullName =N'" + txt_FullName.Text + "',ID_Branch=N'" + cbo_IDBranch.SelectedValue.ToString() + "' where ID_Staff='" + txt_IDStaff.Text + "'";
            }
            con.ExecuteNonQuery(sql);
            LoadData();
            StatusControl(true);
            check = true;
        }
    }
}
