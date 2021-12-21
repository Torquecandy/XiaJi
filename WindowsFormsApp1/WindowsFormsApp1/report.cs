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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        databaseConnection dc = new databaseConnection();
        private void report_Load(object sender, EventArgs e)
        {
            dc.setCB("select distinct cargo as good from sellTable", "good", cboxCargo);

            dc.setCB("select distinct state as good from sellTable", "good", cboxType);
        }

        private void setDGV()
        {
            string sqlWhere = "";

            string sqlDate = "1=1";//代表永遠正確的SQL語句
            if (chkdate.Checked == true)
            {
                sqlDate = $"date >='{dateTimePicker1.Value.ToString("yyyy / MM / dd")}' and date <= '{dateTimePicker2.Value.ToString("yyyy / MM / dd")}'";
            }
            string sqlCargo = "1=1";
            if (chkCargo.Checked == true)
            {
                sqlCargo = $"cargo = N'{cboxCargo.Text}'";
            }
            string sqlType = "1=1";
            if (chkType.Checked == true)
            {
                sqlType = $"state = N'{cboxType.Text}'";
            }
            string sqlMoring = "1=1";
            if (chkMoring.Checked == true)
            {
                sqlMoring = $"time between '09:00' and '15:00'";
            }
            string sqlEvening = "1=1";
            if (chkEvening.Checked == true)
            {
                sqlEvening = $"time between '16:00' and '20:00'";
            }

            sqlWhere = sqlDate + " and " + sqlCargo + " and " + sqlType + " and " + sqlMoring + " and " + sqlEvening;

            dc.setDGV($"select cargo as 商品, amount as 數量, unitprice as 單價, price as 總價,state as 售出方式," +
                $" Convert(nvarchar(50),date,111)as 日期, Convert(nvarchar(50),time,108)as 時間 from sellTable where " + sqlWhere, dGV);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            setDGV();
        }               
              

        private void btnGB_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlWhere = "";

                string sqlDate = "1=1";//代表永遠正確的SQL語句
                if (chkdate.Checked == true)
                {
                    sqlDate = $"date >='{dateTimePicker1.Value.ToString("yyyy / MM / dd")}' and date <= '{dateTimePicker2.Value.ToString("yyyy / MM / dd")}'";
                }
                string sqlCargo = "1=1";
                if (chkCargo.Checked == true)
                {
                    sqlCargo = $"cargo = N'{cboxCargo.Text}'";
                }

                string sqlOperator = "1=1";
                if (chkType.Checked == true)
                {
                    sqlCargo = $"state = N'{cboxType.Text}'";
                }
                string sqlMoring = "1=1";
                if (chkMoring.Checked == true)
                {
                    sqlMoring = $"time between '09:00' and '15:00'";
                }
                string sqlEvening = "1=1";
                if (chkEvening.Checked == true)
                {
                    sqlEvening = $"time between '16:00' and '20:00'";
                }

                sqlWhere = sqlDate + " and " + sqlCargo + " and " + sqlOperator+ " and " + sqlMoring+" and "+ sqlEvening;

                string sqlSelect = "";
                string sqlGroupBy = "";
                if (chkGBdate.Checked == true)
                {
                    sqlSelect += ",Convert(nvarchar(50),date,111)as 日期";
                    sqlGroupBy += ",Convert(nvarchar(50),date,111)";
                }
                if (chkGBCargo.Checked == true)
                {
                    sqlSelect += ",cargo as 商品";
                    sqlGroupBy += ",cargo";
                }
                if (chkGBType.Checked == true)
                {
                    sqlSelect += ",state as 售出方式";
                    sqlGroupBy += ",state";
                }
                

                sqlSelect = sqlSelect.Substring(1, sqlSelect.Length - 1);
                sqlGroupBy = sqlGroupBy.Substring(1, sqlGroupBy.Length - 1);


                dc.setDGV($"select {sqlSelect} ,sum(amount)as 數量,sum(price) as 總售價 from sellTable where " + sqlWhere + " group by " + sqlGroupBy, dGV);
            }
            catch
            {
                MessageBox.Show("至少勾選一樣條件");
            }
        }
    }
}
