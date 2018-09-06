using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace _2017_SIVC_QLFS
{
    public partial class frm_Detal : Form
    {
        cls_Connection con = new cls_Connection();

        public frm_Detal()
        {
            InitializeComponent();
        }

        public void cleardata()
        {
            System.IO.File.Delete(@"C:\Windows\Temp\-1.pdf");
        }

        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            cleardata();
            this.Close();
        }

        private void frm_Detal_Load(object sender, EventArgs e)
        {
            txt_Criteria.Focus();
        }

        private void cmd_Show_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select FilePath from ValuationCertificate where Date_VC like '" + dtp_Date.Text.Substring(6) + "-" + dtp_Date.Text.Substring(3, 2) + "%' and VC_Number = N'" + txt_Criteria.Text + "'";
                string localPath = @"C:\Windows\Temp\";

                FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create(con.getDataValue(sql));
                requestFileDownload.Credentials = new NetworkCredential("administrator", "Tdgsivc2017@#");
                requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;

                FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();

                Stream responseStream = responseFileDownload.GetResponseStream();
                FileStream writeStream = new FileStream(localPath + con.getDataValue(sql).LastIndexOf("\\") + ".pdf", FileMode.Create);

                int Length = 2048;
                Byte[] buffer = new Byte[Length];
                int bytesRead = responseStream.Read(buffer, 0, Length);

                while (bytesRead > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                    bytesRead = responseStream.Read(buffer, 0, Length);
                }

                responseStream.Close();
                writeStream.Close();

                requestFileDownload = null;
                responseFileDownload = null;
                axAcro_Show.src = localPath + con.getDataValue(sql).LastIndexOf("\\" + 1) + ".pdf";
            }
            catch
            {
                MessageBox.Show("Không có chứng thư này", "Thông Báo");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
