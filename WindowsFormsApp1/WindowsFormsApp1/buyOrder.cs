using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class buyOrder : Form
    {
        
        public buyOrder()
        {
            InitializeComponent();
        }
        databaseConnection dc = new databaseConnection();
        SqlConnectionStringBuilder scsb;
        string connectionString = "";

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {            
            buyOrdersetting bo = new buyOrdersetting();
            bo.Flag = "insert";

            if (bo.ShowDialog() == DialogResult.OK)
            {
                setDDD();
            }
        }

        private void buyOrder_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "XX";
            scsb.IntegratedSecurity = true;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\ADO.net夏記\WindowsFormsApp1\WindowsFormsApp1\XiaJi.mdf;Integrated Security=True";


            setDDD();
        }
        private void setDDD()
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string strSQL = "select id, date as 日期,time as 時間,totalMoney as 總金額,vendor as 廠商 from buyOrder order by date desc,time desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvOrder.DataSource = dt;
            }
            reader.Close();
            con.Close();
            

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string strSQLL = "select id,buyOrderid,cargo as 商品,unitPrice as 單價,amount as 數量,price as 總價 from buyDetail where buyOrderid='0'";
            SqlCommand cmdd = new SqlCommand(strSQLL, conn);
            SqlDataReader readerr = cmdd.ExecuteReader();

            if (readerr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(readerr);
                dgvDetail.DataSource = dt;
            }
            readerr.Close();
            conn.Close();

           
            dgvOrder.ClearSelection();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {//透過ID去找到要刪除的資料列
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string sql = "delete from buyOrder where id =@ID"+" "+"delete from buyDetail where buyOrderid =@ID"; 
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", dgvOrder[0, dgvOrder.CurrentCell.RowIndex].Value.ToString());
                cmd.ExecuteNonQuery();//用於insert update delete
                con.Close();            
                MessageBox.Show("刪除成功");
                setDDD();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {//透過ID去更新資料列
            if (dgvOrder.SelectedRows.Count > 0)
            {
                string id = dgvOrder[0, dgvOrder.CurrentCell.RowIndex].Value.ToString();
                string date = dgvOrder[1, dgvOrder.CurrentCell.RowIndex].Value.ToString();
                string time = dgvOrder[2, dgvOrder.CurrentCell.RowIndex].Value.ToString();
                string totalMoney = dgvOrder[3, dgvOrder.CurrentCell.RowIndex].Value.ToString();
                string vendor = dgvOrder[4, dgvOrder.CurrentCell.RowIndex].Value.ToString();
                buyOrdersetting bos = new buyOrdersetting();
                bos.Flag = "update" + "&" + id + "&" + date + "&" + time + "&" + totalMoney + "&" + vendor;
                if (bos.ShowDialog() == DialogResult.OK)
                {
                    setDDD();
                }
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "select id,buyOrderid,cargo as 商品,unitPrice as 單價,amount as 數量,price as 總價 from buyDetail where buyOrderid=@ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", dgvOrder[0, dgvOrder.CurrentCell.RowIndex].Value.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvDetail.DataSource = dt;
            con.Close();

            dgvDetail.Columns[0].Visible = false;
            dgvDetail.Columns[1].Visible = false;
        }
    }
    }

