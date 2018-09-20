using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Sử dụng cấu trúc try catch để viết*/
            /*đọc file excel lên datagrid view*/

            /*Thông báo khi đã đọc hoàn thành file excel
             * Nếu có lỗi trong quá trình đọc thì thông báo lỗi đó là gì*/

            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DtSet;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\phucnh\Desktop\dbfix1.xls';Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "Net-informations.com");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                dataGridView1.DataSource = DtSet.Tables[0];
                MyConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*sử dụng try catch để viết*/
            /*Thực hiện câu lệnh connect đến sql server
             * Chạy vòng lặp for
             *Thực hiện câu truy vấn Update theo điều sau: Update tên bảng set FilePath = cột trên datagridview where IDProfile = IDProfile trên datagirdview
             * Thông báo khi đã hoàn tất
             * Báo lỗi*/
        }
    }
}
