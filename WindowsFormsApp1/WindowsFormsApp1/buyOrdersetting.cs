using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class buyOrdersetting : Form
    {
        databaseConnection dc = new databaseConnection();

        SqlConnectionStringBuilder scsb;
        string connectionString = "";
        string buyOrderid = "";
        public buyOrdersetting()
        {
            InitializeComponent();
        }

        private string flag;
        public string Flag
        {
            get { return flag; }
            set { flag = value; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buyOrdersetting_Load(object sender, EventArgs e)
        {
            string[] cut = this.flag.Split('&');
            if (cut[0] == "insert")
            {
                this.Text = "新增";
            }
            if (cut[0] == "update")
            {
                string ID = cut[1];
                this.Text = "修改";
                scsb = new SqlConnectionStringBuilder();
                scsb.DataSource = @".";
                scsb.InitialCatalog = "XX";
                scsb.IntegratedSecurity = true;
                connectionString = scsb.ToString();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string strSQL = "select cargo , unitprice,amount from buyDetail where buyOrderid=@id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@id", ID);
                SqlDataReader reader = cmd.ExecuteReader();                
                dateTimePicker1.Value = Convert.ToDateTime(cut[2]);
                maskedTextBox1.Text = cut[3];
                txtTotalMoney.Text = cut[4];
                txtVendor.Text = cut[5];
                ArrayList result1 = new ArrayList();
                while (reader.Read())
                {
                    for (int i = 0; i < 3; i++)
                    {
                        result1.Add(reader[i]);
                    }
                }
                reader.Close();
                con.Close();
                if (result1.Count != 0)
                {
                    object[] a = (object[])result1.ToArray();
                    object[] result = (object[])a.ToArray();
                    if (result[0] != null)
                    {
                        for (int i = 0; i < result.Length; i = i + 3)
                        {
                            string[] val = { "", "", "" };
                            val[0] = result[i].ToString();
                            val[1] = result[i + 1].ToString();
                            val[2] = result[i + 2].ToString();
                            dGV.Rows.Add(val);
                        }
                    }
                }
                else
                {
                    object[] a = new object[10];
                    a[0] = null;                    
                }              
            }
        }       

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Text == "新增")
                {//寫入採購單上部分
                    dc.writeDB($"insert into buyOrder(date,time,totalMoney,vendor)values('{dateTimePicker1.Value.ToString("yyyy/MM/dd")}','{maskedTextBox1.Text}','{txtTotalMoney.Text}',N'{txtVendor.Text}')");

                    string sql = "";
                    for (int i = 0; i < dGV.Rows.Count - 1; i++)
                    {
                        string cargo = dGV.Rows[i].Cells[0].Value.ToString();
                        string unitPrice = dGV.Rows[i].Cells[1].Value.ToString();
                        string amount = dGV.Rows[i].Cells[2].Value.ToString();
                        string price = ((Convert.ToDecimal(unitPrice)) * (Convert.ToDecimal(amount))).ToString();
                        sql += $"insert into buyDetail(buyOrderid,cargo,unitPrice,amount,price)values((select top 1 id from buyorder order by id desc),N'{cargo}','{unitPrice}','{amount}','{price}')";
                    }
                    dc.writeDB(sql);

                    MessageBox.Show("成功");

                    DialogResult = DialogResult.OK;

                    this.Close();
                }

                if (this.Text == "修改")
                {//Error converting data type varchar to bigint.'
                    dc.writeDB($"update buyOrder set date='{dateTimePicker1.Value.ToString("yyyy/MM/dd")}',time='{maskedTextBox1.Text}',totalMoney='{txtTotalMoney.Text}',vendor=N'{txtVendor.Text}'where id='{buyOrderid}'");
                    //修改進貨單上部分

                    //*******比新增多這句
                    dc.writeDB($"delete from buyDetail where buyOrderid = '{buyOrderid}'");
                    //*******

                    string sql = "";
                    for (int i = 0; i < dGV.Rows.Count - 1; i++)
                    {
                        string cargo = dGV.Rows[i].Cells[0].Value.ToString();
                        string unitPrice = dGV.Rows[i].Cells[1].Value.ToString();
                        string amount = dGV.Rows[i].Cells[2].Value.ToString();
                        string price = ((Convert.ToDecimal(unitPrice)) * (Convert.ToDecimal(amount))).ToString();
                        sql += $"insert into buyDetail(buyOrderid,cargo,unitPrice,amount,price)values('{buyOrderid}',N'{cargo}','{unitPrice}','{amount}','{price}')";
                    }
                    dc.writeDB(sql);

                    MessageBox.Show("成功");

                    DialogResult = DialogResult.OK;

                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("請輸入時間");
            }

        }

       
              

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.Text == "新增")
                {//寫入採購單上部分
                    dc.writeDB($"insert into buyOrder(date,time,totalMoney,vendor)values('{dateTimePicker1.Value.ToString("yyyy/MM/dd")}','{maskedTextBox1.Text}','{txtTotalMoney.Text}',N'{txtVendor.Text}')");

                    string sql = "";
                    for (int i = 0; i < dGV.Rows.Count - 1; i++)
                    {
                        string cargo = dGV.Rows[i].Cells[0].Value.ToString();
                        string unitPrice = dGV.Rows[i].Cells[1].Value.ToString();
                        string amount = dGV.Rows[i].Cells[2].Value.ToString();
                        string price = ((Convert.ToDecimal(unitPrice)) * (Convert.ToDecimal(amount))).ToString();
                        sql += $"insert into buyDetail(buyOrderid,cargo,unitPrice,amount,price)values((select top 1 id from buyorder order by id desc),N'{cargo}','{unitPrice}','{amount}','{price}')";
                    }
                    dc.writeDB(sql);

                    MessageBox.Show("成功");

                    DialogResult = DialogResult.OK;

                    this.Close();
                }

                if (this.Text == "修改")
                {//Error converting data type varchar to bigint.'
                    dc.writeDB($"update buyOrder set date='{dateTimePicker1.Value.ToString("yyyy/MM/dd")}',time='{maskedTextBox1.Text}',totalMoney='{txtTotalMoney.Text}',vendor=N'{txtVendor.Text}'where id='{buyOrderid}'");
                    //修改進貨單上部分

                    //*******比新增多這句
                    dc.writeDB($"delete from buyDetail where buyOrderid = '{buyOrderid}'");
                    //*******

                    string sql = "";
                    for (int i = 0; i < dGV.Rows.Count - 1; i++)
                    {
                        string cargo = dGV.Rows[i].Cells[0].Value.ToString();
                        string unitPrice = dGV.Rows[i].Cells[1].Value.ToString();
                        string amount = dGV.Rows[i].Cells[2].Value.ToString();
                        string price = ((Convert.ToDecimal(unitPrice)) * (Convert.ToDecimal(amount))).ToString();
                        sql += $"insert into buyDetail(buyOrderid,cargo,unitPrice,amount,price)values('{buyOrderid}',N'{cargo}','{unitPrice}','{amount}','{price}')";
                    }
                    dc.writeDB(sql);

                    MessageBox.Show("成功");

                    DialogResult = DialogResult.OK;

                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("請輸入時間");
            }

        }

        private void dGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal sum = 0;

            for (int i = 0; i < dGV.Rows.Count - 1; i++)
            {
                try
                {
                    sum += (Convert.ToDecimal(dGV.Rows[i].Cells[1].Value) * (Convert.ToDecimal(dGV.Rows[i].Cells[2].Value)));
                }
                catch { }
            }

            txtTotalMoney.Text = sum.ToString();
        }
    }
}
