using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        databaseConnection dc = new databaseConnection();

        int count = 0;        
        int price = 0;
        int sum = 0;
        
        public void AddDGV(string Fname, int num)
        {
            if (txtFname.Text == Fname || txtFname.Text == "")
            {
                count += 1;
                txtFname.Text = Fname;
                txtFcount.Text = count.ToString();
                txtFsum.Text = (count * num).ToString();
                price = num;
                
            }
            else
            {
                MessageBox.Show("請先加入上一個品項");
            }
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            if (global.role == "emp")
            {
                btnProfit.Visible = false;
                btnOrder.Visible = false;
                
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            buyOrder bb = new buyOrder();            
            bb.ShowDialog();
            

        }  

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ll = new Login();
            ll.Show();
        }   
    
      
           

        private void plusMeat_Click_1(object sender, EventArgs e)
        {
            AddDGV("加肉", 20);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtFname.Text != "")
            {
                dGV.Rows.Add(new object[] { txtFname.Text, price, count, count * price });
                price = 0;
                count = 0;

                txtFname.Text = "";
                txtFcount.Text = "";
                txtFsum.Text = "";                
            }
            else
            {
                MessageBox.Show("沒有品項");
            }

        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            buyOrder bb = new buyOrder();
            bb.ShowDialog();
        }

        private void XiangChangR_Click_1(object sender, EventArgs e)
        {
            AddDGV("香腸飯", 75);
        }

        private void ShaoRouR_Click_1(object sender, EventArgs e)
        {
            AddDGV("燒肉飯", 90);
        }

        private void ShaoRou_Click_1(object sender, EventArgs e)
        {
            AddDGV("單點燒肉", 60);
        }

        private void ShaoYaR_Click_1(object sender, EventArgs e)
        {
            AddDGV("燒鴨飯", 90);
        }

        private void ChaShaoR_Click_1(object sender, EventArgs e)
        {
            AddDGV("叉燒飯", 85);
        }

        private void plusR_Click_1(object sender, EventArgs e)
        {
            AddDGV("加飯", 10);
        }

        private void ZhaPai_Click_1(object sender, EventArgs e)
        {
            AddDGV("單點炸腿排", 55);
        }

        private void UMeiTang_Click_1(object sender, EventArgs e)
        {
            AddDGV("桂花烏梅湯", 50);
        }

        private void ZhaPaiR_Click_1(object sender, EventArgs e)
        {
            AddDGV("炸腿排飯", 85);
        }

        private void fullDuck_Click_1(object sender, EventArgs e)
        {
            AddDGV("燒鴨整隻", 800);
        }

        private void ChaoShao_Click_1(object sender, EventArgs e)
        {
            AddDGV("單點叉燒", 55);
        }

        private void CaiR_Click_1(object sender, EventArgs e)
        {
            AddDGV("菜飯", 50);
        }

        private void halfDuck_Click_1(object sender, EventArgs e)
        {
            AddDGV("燒鴨半隻", 450);
        }

        private void YouJi_Click_1(object sender, EventArgs e)
        {
            AddDGV("單點油雞", 50);
        }

        private void ZhouPaiR_Click_1(object sender, EventArgs e)
        {
            AddDGV("招牌飯", 110);
        }

        private void YouJiR_Click_1(object sender, EventArgs e)
        {
            AddDGV("油雞飯", 85);
        }

        private void Duckhead_Click_1(object sender, EventArgs e)
        {
            AddDGV("鴨脖子/頭", 30);
        }

        private void PaiGu_Click_1(object sender, EventArgs e)
        {
            AddDGV("單點排骨", 50);
        }

        private void SanBaoR_Click_1(object sender, EventArgs e)
        {
            AddDGV("三寶飯", 100);
        }

        private void PaiGuR_Click_1(object sender, EventArgs e)
        {
            AddDGV("排骨飯", 80);
        }

        private void ShaoYa_Click_1(object sender, EventArgs e)
        {
            AddDGV("單點燒鴨", 60);
        }

        private void XiangChang_Click_1(object sender, EventArgs e)
        {
            AddDGV("單點香腸", 45);
        }

        private void ShuangPingR_Click_1(object sender, EventArgs e)
        {
            AddDGV("雙拼飯", 100);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            price = 0;
            count = 0;

            txtFname.Text = "";
            txtFcount.Text = "";
            txtFsum.Text = "";
        }

        private void btnClearDGV_Click_1(object sender, EventArgs e)
        {
            dGV.Rows.Clear();
            txtTotal.Text = "";
            sum = 0;
        }

        private void btnTotalMoney_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dGV.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dGV.Rows[i].Cells[3].Value);
            }
            txtTotal.Text = sum.ToString();
        }

        private void btnDelivery_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                for (int i = 0; i < dGV.Rows.Count; i++)
                {
                    string cargo = dGV.Rows[i].Cells[0].Value.ToString();
                    string unitprice = dGV.Rows[i].Cells[1].Value.ToString();
                    string amount = dGV.Rows[i].Cells[2].Value.ToString();
                    string price = ((Convert.ToDecimal(unitprice)) * (Convert.ToDecimal(amount))).ToString();
                    sql += $"insert into sellTable(cargo,unitPrice,amount,price,date,time,state) values(N'{cargo}','{unitprice}','{amount}','{price}','{DateTime.Now.ToString("yyyy/MM/dd")}','{DateTime.Now.ToString("HH:mm:ss")}',N'外送')";
                    sum += Convert.ToInt32(dGV.Rows[i].Cells[3].Value);
                }

                dc.writeDB(sql);
                dGV.Rows.Clear();
                sum = 0;
                txtTotal.Text = "";

            }
            catch
            {
                MessageBox.Show("沒有品項");
            }
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                for (int i = 0; i < dGV.Rows.Count; i++)
                {
                    string cargo = dGV.Rows[i].Cells[0].Value.ToString();
                    string unitprice = dGV.Rows[i].Cells[1].Value.ToString();
                    string amount = dGV.Rows[i].Cells[2].Value.ToString();
                    string price = ((Convert.ToDecimal(unitprice)) * (Convert.ToDecimal(amount))).ToString();
                    sql += $"insert into sellTable(cargo,unitPrice,amount,price,date,time,state) " +
                        $"values(N'{cargo}','{unitprice}','{amount}','{price}'," +
                        $"'{DateTime.Now.ToString("yyyy/MM/dd")}','{DateTime.Now.ToString("HH:mm:ss")}',N'內用')";
                    sum += Convert.ToInt32(dGV.Rows[i].Cells[3].Value);
                }

                dc.writeDB(sql);
                dGV.Rows.Clear();
                sum = 0;
                txtTotal.Text = "";

            }
            catch
            {
                MessageBox.Show("沒有品項");
            }
        }

      

      

        private void btnProfit_Click_1(object sender, EventArgs e)
        {
            profit pp = new profit();
            pp.Show();
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            report rr = new report();
            rr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDGV("公務員飯", 80);
        }

        private void btnWaiDai_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                for (int i = 0; i < dGV.Rows.Count; i++)
                {
                    string cargo = dGV.Rows[i].Cells[0].Value.ToString();
                    string unitprice = dGV.Rows[i].Cells[1].Value.ToString();
                    string amount = dGV.Rows[i].Cells[2].Value.ToString();
                    string price = ((Convert.ToDecimal(unitprice)) * (Convert.ToDecimal(amount))).ToString();
                    sql += $"insert into sellTable(cargo,unitPrice,amount,price,date,time,state) values(N'{cargo}','{unitprice}','{amount}','{price}','{DateTime.Now.ToString("yyyy/MM/dd")}','{DateTime.Now.ToString("HH:mm:ss")}',N'外帶')";
                    sum += Convert.ToInt32(dGV.Rows[i].Cells[3].Value);
                }

                dc.writeDB(sql);
                dGV.Rows.Clear();
                sum = 0;
                txtTotal.Text = "";

            }
            catch
            {
                MessageBox.Show("沒有品項");
            }
        }

        private void btnDuckLeg_Click(object sender, EventArgs e)
        {
            AddDGV("鴨腿飯", 120);
        }

        private void btnDL_Click(object sender, EventArgs e)
        {
            AddDGV("鴨腿", 90);
        }

        private void dGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dGV.SelectedRows)
            {
                dGV.Rows.RemoveAt(row.Index);
            }
        }
    }
}
