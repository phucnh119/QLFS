using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class1
    {
        public static SqlConnection con;

        //Hàm kết nối
        public void Connection()
        {
            if (con == null)
            {
                string strcon = "Data Source=127.0.0.1;Initial Catalog=2017_SIVC_QLFS;Persist Security Info=True;User ID=sa;Password=123456";
                con = new SqlConnection(strcon);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //Hàm ngắt kết nối
        public void Disconnection()
        {
            if ((con != null) && (con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
        //Hàm trả DataTable
        public DataTable getDataTable(string sql)
        {
            Connection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Disconnection();
            return dt;
        }

        //Hàm thực thi ExecuteNonquery

        public void ExecuteNonQuery(string sql)
        {
            Connection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            Disconnection();
        }

        //Hàm thực thi DataReader
        public SqlDataReader getDataReader(string sql)
        {
            Connection();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        //Hàm lầy già trị trả về
        public string getDataValue(string sql)
        {
            string datavalue;
            Connection();
            SqlCommand cmd = new SqlCommand(sql, con);
            return datavalue = cmd.ExecuteScalar().ToString();
        }
    }
}
