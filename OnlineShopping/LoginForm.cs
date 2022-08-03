using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping
{
    public partial class LoginForm : Form
    {
        ShopService.WebService1SoapClient admin_ser = new ShopService.WebService1SoapClient();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void log_button_Click(object sender, EventArgs e)
        {
            int id;
             
            if (!admin_ser.login(Email_text.Text, password_text.Text))
                MessageBox.Show("Wrong", "ONLINESHOPPING");
 
            else
            {
                id = admin_ser.GetCart_ID(Email_text.Text);
                

                CustomerFun cf = new CustomerFun(Email_text.Text, id);
                cf.Show();
                this.Close();

            }

        }
    }
}
