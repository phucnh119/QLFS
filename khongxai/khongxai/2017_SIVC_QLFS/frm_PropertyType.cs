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
    public partial class frm_PropertyType : Form
    {
        cls_Connection con = new cls_Connection();
        bool check = true;

        public frm_PropertyType()
        {
            InitializeComponent();
        }

        public void cleardata()
        {
            txt_IDType.Clear();
            txt_Property.Clear();
            txt_IDType.Focus();
        }

        public void StatusControl(bool Status)
        {
            cmd_Add.Enabled = Status;
            cmd_Delete.Enabled = Status;
            cmd_Update.Enabled = Status;
            cmd_Exit.Enabled = Status;
            cmd_Save.Enabled = !Status;
            txt_IDType.Enabled = !Status;
            txt_Property.Enabled = !Status;
        }
        public void LoadData()
        {
            string sql = "SELECT * FROM PropertyType";
            dg_Show.DataSource = con.getDataTable(sql);
        }

        private void frm_PropertyType_Load(object sender, EventArgs e)
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
                txt_IDType.Text = row.Cells[0].Value.ToString();
                txt_Property.Text = row.Cells[1].Value.ToString();
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
            txt_IDType.Enabled = false;
            check = false;
        }

        private void cmd_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa không?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from PropertyType where ID_Type='" + txt_IDType.Text + "'";
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
                sql = "insert into PropertyType values(N'" + txt_IDType.Text + "',N'" + txt_Property.Text + "')";
            }
            else
            {
                sql = "update PropertyType set Property =N'" + txt_Property.Text + "' where ID_Type='" + txt_IDType.Text + "'";
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

    }
}
