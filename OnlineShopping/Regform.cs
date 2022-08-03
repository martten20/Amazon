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
    public partial class form2 : Form
    {
        ShopService.WebService1SoapClient admin_ser = new ShopService.WebService1SoapClient();
        public form2()
        {
            InitializeComponent();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {

                int id = 0;

                try
                {
                    admin_ser.register(email.Text, password.Text, Name.Text, address.Text, area.Text, int.Parse(Mobile.Text));                   
                    id = admin_ser.GetCart_ID(email.Text);
                    CustomerFun cf = new CustomerFun(email.Text, id);
                    cf.Show();
                    this.Close();

                }
                catch (Exception t)
                {
                    MessageBox.Show("Email Already Exists", "OnlineShopping");
                }

        }

        private void form2_Load(object sender, EventArgs e)
        {

        }
    }
}
