using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinForm
{
    class Check
    {
        public static SqlConnection createconn()
        {
            string coonStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=productjxc;User ID=sa;Password=bcat;Persist Security Info=True;";
            SqlConnection coon = new SqlConnection(coonStr);
            return coon;

        }

        public static DataTable gettable(string sql)
        {
            SqlConnection conn = createconn();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool adminSql(string sql)
        {
            SqlConnection conn = createconn();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (conn.State!=ConnectionState.Open)
            {
                conn.Open();
            }
            if (cmd.ExecuteNonQuery()>0)
            {
                return true;
            } 
            else
            {
                return false;
            }
            conn.Close();
        }

        public static bool checkUser(string AdminName, string AdminPwd)
        {
            string sql = "select AdminPwd from Store where AdminName='" + AdminName + "'";
            DataTable dt =gettable(sql);

            
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("管理员ID输入错误，数据表中查无此人请重试！", "提示");
                return false;
            }
            else
            {
                if (AdminPwd == dt.Rows[0]["AdminPwd"].ToString().Trim())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("密码错误，请重试！", "提示");
                    return false;
                }
            }

           
/*
            if (AdminPwd == dt.Rows[0]["AdminPwd"].ToString().Trim())
            {
                return true;
            }
            else
            {
                return false;
            }
            */
        }
    }
}
