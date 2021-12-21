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
    public partial class profit : Form
    {
        public profit()
        {
            InitializeComponent();
        }
        databaseConnection dc = new databaseConnection();
        Dictionary<string, decimal> dic = new Dictionary<string, decimal>();       
        private void profit_Load(object sender, EventArgs e)
        {
            object[] resultSell = dc.readDB("select Convert(nvarchar(7),date,120)as 月份, isnull(sum(price),0)as 營業額 from sellTable group by Convert(nvarchar(7),date,120)", 2);
            if (resultSell[0] != null)
            {
                for (int i = 0; i < resultSell.Length; i = i + 2)
                {
                    string key = resultSell[i].ToString();
                    decimal value = Convert.ToDecimal(resultSell[i + 1]);                   

                    if (dic.ContainsKey(key) == false)
                    {
                        dic.Add(key, value);
                    }
                    else
                    {
                        dic[key] = dic[key] + value;
                    }
                }
            }

            object[] resultBuy = dc.readDB("select Convert(nvarchar(7),date,120)as 月份, isnull(sum(price),0)as 成本  from buyDetail,buyOrder where buyOrder.Id = buyDetail.buyOrderId  group by cargo,Convert(nvarchar(7),date,120)", 2);
            if (resultBuy[0] != null)
            {
                for (int i = 0; i < resultBuy.Length; i = i + 2)
                {
                    string key = resultBuy[i].ToString() ;
                    decimal value = Convert.ToDecimal(resultBuy[i + 1]);
                    
                    if (dic.ContainsKey(key) == false)
                    {
                        dic.Add(key, 0 - value);
                    }
                    else
                    {
                        dic[key] = dic[key] - value;
                    }
                }
            }
            foreach (var ii in dic)
            {
                string key = ii.Key.ToString();
                string value = ii.Value.ToString();            
                dataGridView1.Rows.Add(key, value);
            }
        }
    }
}
