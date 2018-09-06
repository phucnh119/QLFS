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
    public partial class frm_ValuationCertificate : Form
    {
        cls_Connection con = new cls_Connection();
        bool check = true;
        public string branch = Cls_Login.Branch;
        public frm_ValuationCertificate()
        {
            InitializeComponent();
        }

        public void cleardata()
        {
            txt_IDprofile.Clear();
            txt_VCNumber.Clear();
            txt_ContractNumber.Clear();
            txt_Customer.Clear();
            txt_IDprofile.Focus();
        }

        public void StatusControl(bool Status)
        {
            cmd_Add.Enabled = Status;
            cmd_Delete.Enabled = Status;
            cmd_Update.Enabled = Status;
            cmd_Exit.Enabled = Status;
            cmd_Save.Enabled = !Status;
            txt_IDprofile.Enabled = !Status;
            txt_VCNumber.Enabled = !Status;
            txt_ContractNumber.Enabled = !Status;
            txt_Customer.Enabled = !Status;
            cbo_IDBranch.Enabled = !Status;
            cbo_IDType.Enabled = !Status;
        }

        public void LoadData()
        {
            string sql = "";
            if (branch.Equals("HS"))
            {
                sql = "SELECT ValuationCertificate.ID_Profile, ValuationCertificate.VC_Number, ValuationCertificate.Customer, ValuationCertificate.Date_VC, " +
                         "ValuationCertificate.ContractNumber, Branch.BranchName, PropertyType.Property " +
                         "FROM ValuationCertificate INNER JOIN " +
                         "Branch ON ValuationCertificate.ID_Branch = Branch.ID_Branch INNER JOIN " +
                         "PropertyType ON ValuationCertificate.ID_Type = PropertyType.ID_Type";
            }
            else
            {
                sql = "SELECT ValuationCertificate.ID_Profile, ValuationCertificate.VC_Number, ValuationCertificate.Customer, ValuationCertificate.Date_VC, " +
                         "ValuationCertificate.ContractNumber, Branch.BranchName, PropertyType.Property " +
                         "FROM ValuationCertificate INNER JOIN " +
                         "Branch ON ValuationCertificate.ID_Branch = Branch.ID_Branch INNER JOIN " +
                         "PropertyType ON ValuationCertificate.ID_Type = PropertyType.ID_Type " +
                         "Where Branch.ID_Branch = '" + branch + "'";
            }
            dg_Show.DataSource = con.getDataTable(sql);
        }

        public void Loadcbo()
        {
            string sql = "";
            if (branch.Equals("HS"))
                sql = "SELECT BranchName, ID_Branch FROM Branch";
            else
                sql = "SELECT BranchName, ID_Branch FROM Branch Where ID_Branch = '" + branch + "'";
            cbo_IDBranch.DataSource = con.getDataTable(sql);
            cbo_IDBranch.DisplayMember = "BranchName";
            cbo_IDBranch.ValueMember = "ID_Branch";
            sql = "SELECT * FROM PropertyType";
            cbo_IDType.DataSource = con.getDataTable(sql);
            cbo_IDType.DisplayMember = "Property";
            cbo_IDType.ValueMember = "ID_Type";
        }

        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ValuationCertificate_Load(object sender, EventArgs e)
        {
            Loadcbo();
            StatusControl(true);
            LoadData();
            txt_IDprofile.Enabled = false;
        }

        private void dg_Show_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // lấy dữ liệu vào textbox
                DataGridViewRow row = new DataGridViewRow();
                row = dg_Show.Rows[e.RowIndex];
                txt_IDprofile.Text = row.Cells[0].Value.ToString();
                txt_VCNumber.Text = row.Cells[1].Value.ToString();
                txt_Customer.Text = row.Cells[2].Value.ToString();
                txt_ContractNumber.Text = row.Cells[4].Value.ToString();
                cbo_IDBranch.Text = row.Cells[5].Value.ToString();
                cbo_IDType.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            StatusControl(false);
            cleardata();
            getday();
            txt_IDprofile.Enabled = false;
        }

        private void cmd_Update_Click(object sender, EventArgs e)
        {
            StatusControl(false);
            check = false;
            txt_IDprofile.Enabled=false;
        }

        private void cmd_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa không?", "Thông Báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from ValuationCertificate where ID_Profile='" + txt_IDprofile.Text + "'";
                con.ExecuteNonQuery(sql);
                LoadData();
            }
        }
        public void getday()
        {
            txt_IDprofile.Text = cbo_IDBranch.SelectedValue.ToString() + System.DateTime.Now.GetHashCode().ToString();
            
        }
        private void cmd_Save_Click(object sender, EventArgs e)
        {
            //getday();
            string sql;
            DateTime getdate = dtp_DateVC.Value;
            if (check == true)
            {
                sql = "INSERT INTO ValuationCertificate (ID_Profile, VC_Number, Customer, Date_VC, ContractNumber, ID_Branch, ID_Type) " +
                      "VALUES (N'" + txt_IDprofile.Text + "', N'" + txt_VCNumber.Text + "', N'" + txt_Customer.Text + "','" + String.Format("{0:yyyy-MM-dd}", getdate) + "', N'" + txt_ContractNumber.Text + "', N'" + cbo_IDBranch.SelectedValue.ToString() + "', N'" + cbo_IDType.SelectedValue.ToString() +"')";
            }
            else
            {
                sql = "UPDATE ValuationCertificate " +
                      "SET VC_Number = N'" + txt_VCNumber.Text +"', Customer = N'" + txt_Customer.Text + "', Date_VC = '" + String.Format("{0:yyyy-MM-dd}", getdate) + "', ContractNumber = N'" + txt_ContractNumber.Text + "', ID_Branch = N'" + cbo_IDBranch.SelectedValue.ToString() + "', ID_Type = N'" +  cbo_IDType.SelectedValue.ToString() + "' " +
                      "WHERE (ID_Profile = N'" + txt_IDprofile.Text + "')";
            }
            con.ExecuteNonQuery(sql);
            LoadData();
            StatusControl(true);
            check = true;
        }

        private void txt_IDprofile_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void cbo_IDBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            getday();
        }




    }
}
