using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class databaseConnection
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\ADO.net夏記\WindowsFormsApp1\WindowsFormsApp1\XiaJi.mdf;Integrated Security=True";
         public void writeDB(string sqlStr)//寫入資料庫
        {//                 帶入SQL指令)↑ 
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = sqlStr;
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();//用於insert update delete
            con.Close();
        } 

        public object[] readDB(string sqlStr,int number)//讀取資料庫
        {//               (帶入SQL指令)↑          ↑返回的列數
            SqlConnection con = new SqlConnection(connectionString);
            try
            {//防止取得數據時出錯
                con.Open();
                string sql = sqlStr;
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader r = cmd.ExecuteReader();//用於select
                ArrayList result = new ArrayList();
                while (r.Read())
                {
                    for (int i = 0; i < number; i++)
                    {
                        result.Add(r[i]);
                    }
                }
                con.Close();
                if (result.Count != 0)
                {
                    object[] a = (object[])result.ToArray();
                    return a;
                }
                else
                {
                    object[] a = new object[10];
                    a[0] = null;
                    return a;
                }
            }
            catch
            {
                object[] a = new object[10];
                a[0] = null;
                return a;
            }
        }
        public void setDGV(string sql, DataGridView dgv)//DataGridView連結資料庫
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv.DataSource = dt;
            con.Close();

        }
        public void setCB(string sql, string columnsName, ComboBox ccb)//ComboBox連結資料庫
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ccb.DataSource = dt;
            ccb.ValueMember = columnsName;
            con.Close();

        }
    }
}
