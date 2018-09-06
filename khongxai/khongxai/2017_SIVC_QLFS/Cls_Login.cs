using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;

namespace _2017_SIVC_QLFS
{
    class Cls_Login
    {
        //Biến toàn cục
        public static string User;
        public static string Branch;
        public static string Role;

        public bool CheckAdmin(string UserName, string PassWord)
        {
            cls_Connection connect = new cls_Connection();
            string sql = "SELECT AccountStaff.Acount, AccountStaff.PassWord FROM AccountStaff" +
                         " WHERE (ID_Role = N'sa') AND (AccountStaff.Acount = N'" + UserName + "') AND (AccountStaff.PassWord = N'" + PassWord + "')";
            connect.Connection();
            if (connect.getDataReader(sql).Read())
            {
                connect.Disconnection();
                return true;
            }
            else
            {
                connect.Disconnection();
                return false;
            }
        }

        public bool CheckUpload(string UserName, string PassWord)
        {
            cls_Connection connect = new cls_Connection();
            string sql = "SELECT AccountStaff.Acount, AccountStaff.PassWord FROM AccountStaff" +
                         " WHERE (ID_Role = N'ul') AND (AccountStaff.Acount = N'" + UserName + "') AND (AccountStaff.PassWord = N'" + PassWord + "')";
            connect.Connection();
            if (connect.getDataReader(sql).Read())
            {
                connect.Disconnection();
                return true;
            }
            else
            {
                connect.Disconnection();
                return false;
            }
        }

        public bool CheckUser(string UserName, string PassWord)
        {
            cls_Connection connect = new cls_Connection();
            string sql = "SELECT AccountStaff.Acount, AccountStaff.PassWord FROM AccountStaff" +
                         " WHERE (ID_Role = N'us') AND (AccountStaff.Acount = N'" + UserName + "') AND (AccountStaff.PassWord = N'" + PassWord + "')";
            connect.Connection();
            if (connect.getDataReader(sql).Read())
            {
                connect.Disconnection();
                return true;
            }
            else
            {
                connect.Disconnection();
                return false;
            }
        }
        public void GetValueSystem(string UserName, string PassWord)
        {
            string sql = "SELECT ac.ID_Role, st.ID_Branch,ac.Acount, ac.PassWord FROM AccountStaff ac " +
                            "Join Staff st on st.ID_Staff = ac.ID_Staff WHERE ac.Acount = '" + UserName + "'  AND ac.PassWord = '" + PassWord + "'";
            SqlConnection connet = cls_Connection.con;
            connet.Open();
            // Tạo một đối tượng Command.
            SqlCommand cmd = new SqlCommand();

            // Liên hợp Command với Connection.
            cmd.Connection = connet;
            cmd.CommandText = sql;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Role = reader.GetString(0);
                        Branch = reader.GetString(1);
                        User = reader.GetString(2);
                    }
                }
            }
            connet.Close();
        }
    }
}
