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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        databaseConnection dc = new databaseConnection();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void btnLogin_Click(object sender, EventArgs e)
        {
            object[] result = dc.readDB($"select username from adminTable where username ='{txtUsername.Text}' and pwd ='{txtPwd.Text}'", 1);
            if (result[0] != null)
            {
                global.username = txtUsername.Text;

                if (result[0].ToString() == "boss")
                {
                    global.role = result[0].ToString();
                }
                else
                {
                    global.role = "emp";
                }
                mainForm mm = new mainForm();
                Login ll = new Login();
                mm.ShowDialog();               
                this.Hide();
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "boss";
            
        }
    }
}
