using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
/*new*/
namespace _2017_SIVC_QLFS
{
    public partial class frm_Upload : Form
    {
        cls_Connection con = new cls_Connection();
        cls_CheckUnicode ChkUnicode = new cls_CheckUnicode();
        //public void cleardata()
        //{
        //    cbo_IDProfile.clea();

        //}

        public frm_Upload()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            DateTime getdate = dtp_Date.Value;
            string sql = "SELECT ID_Profile, VC_Number FROM ValuationCertificate WHERE (Date_VC = '" + String.Format("{0:yyyy-MM-dd}", getdate) + "')";
            cbo_IDProfile.DataSource = con.getDataTable(sql);
            cbo_IDProfile.DisplayMember = "VC_Number";
            cbo_IDProfile.ValueMember = "ID_Profile";

        }

        

        private void cmd_Linkfile_Click(object sender, EventArgs e)
        {
            if (OFD_ChooseFile.ShowDialog() == DialogResult.OK)
            {
                txt_Linkfile.Text = OFD_ChooseFile.FileName.Substring(OFD_ChooseFile.FileName.LastIndexOf("\\") + 1);
            }
        }

        private void frm_Upload_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            // hàm xóa dữ liệu khi hiện thị ngày chưa có dữ liệu
            cbo_IDProfile.DisplayMember = "";
            cbo_IDProfile.ValueMember = "";
            LoadData();
        }


        private void cmd_UpLoad_Click(object sender, EventArgs e)
        {
            //thang -> lấy giá trị chuỗi ở vị trí thứ 6 , 4 kí tự ....
            string thang ="Nam "+dtp_Date.Text.Substring(6,4) + "/Thang " + dtp_Date.Text.Substring(3,2)+"/";
            //MessageBox.Show("Tháng là: "+ thang);
            if (ChkUnicode.CheckFileName(txt_Linkfile.Text) == true)
            {
                string sql = "SELECT Branch.Path FROM ValuationCertificate INNER JOIN Branch ON ValuationCertificate.ID_Branch = Branch.ID_Branch WHERE (ValuationCertificate.ID_Profile = N'" + cbo_IDProfile.SelectedValue.ToString() + "')";
                string linkfile = con.getDataValue(sql) + thang + txt_Linkfile.Text;
                FtpWebRequest ftpReq = (FtpWebRequest)WebRequest.Create(linkfile);
                sql = "UPDATE ValuationCertificate SET FilePath ='" + linkfile + "' WHERE (ID_Profile = N'" + cbo_IDProfile.SelectedValue.ToString() + "')";
                con.ExecuteNonQuery(sql);
                ftpReq.UseBinary = true;
                ftpReq.Method = WebRequestMethods.Ftp.UploadFile;
                ftpReq.Credentials = new NetworkCredential("administrator", "Tdgsivc2017@#");

                byte[] b = File.ReadAllBytes(OFD_ChooseFile.FileName);
                ftpReq.ContentLength = b.Length;
                using (Stream s = ftpReq.GetRequestStream())
                {
                    s.Write(b, 0, b.Length);
                }

                FtpWebResponse ftpResp = (FtpWebResponse)ftpReq.GetResponse();

                if (ftpResp != null)
                {
                    if (ftpResp.StatusDescription.StartsWith("226"))
                    {
                        MessageBox.Show("Upload thành công ^^!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không đặt tên File bằng Tiếng Việt có dấu. Vui lòng đặt lại tên File. Chúc bạn may mắn lần sau!", "Thông Báo");
            }
        }

        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbo_IDProfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
