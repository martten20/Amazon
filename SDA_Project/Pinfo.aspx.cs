using System;
using System.Collections.Generic;
using System.Linq;

namespace SDAProject
{
    public partial class Pinfo : System.Web.UI.Page
    {
        int id;
        ShopService.WebService1SoapClient admin_ser = new ShopService.WebService1SoapClient();
        List<string> itm = new List<string>();
        string email = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString.Get("id"));
            email = admin_ser.getemail_from_cart_id(id);
            itm = admin_ser.personal_info(email);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = itm.ElementAt(0);
            TextBox2.Text = itm.ElementAt(1);
            TextBox3.Text = itm.ElementAt(2);


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            admin_ser.update_personal_info(email, TextBox1.Text.ToString(), TextBox2.Text.ToString(), int.Parse(TextBox3.Text.ToString()));
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?id=" + id);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("MyCart.aspx?id=" + id);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactAsPage.aspx?id=" + id);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}