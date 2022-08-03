using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace SDAProject
{
    public partial class MyCart : System.Web.UI.Page
    {
        ShopService.WebService1SoapClient admin_ser = new ShopService.WebService1SoapClient();
        List<System.Web.UI.HtmlControls.HtmlGenericControl> listcomponent;
        List<string> item = new List<string>();
        int ID_CART;
        void Load_Cart()
        {

            item = admin_ser.view_cart(ID_CART);
            listcomponent = new List<System.Web.UI.HtmlControls.HtmlGenericControl>();
            int count = 0;
            for (int i = 0; i < item.Count(); i += 2)
            {
                System.Web.UI.HtmlControls.HtmlGenericControl card_div = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                System.Web.UI.HtmlControls.HtmlGenericControl Name_text_card = new System.Web.UI.HtmlControls.HtmlGenericControl("H1");
                System.Web.UI.HtmlControls.HtmlGenericControl price_text_card = new System.Web.UI.HtmlControls.HtmlGenericControl("H1");
                
                card_div.Attributes.Add("class", "card");
                Image img = new Image();
                img.Attributes.Add("class", "img");
                string url = admin_ser.Getpimage(item[i]);
                img.ImageUrl = url;
             
                Button card_button = new Button();

                card_button.Click += new EventHandler(button_Click);
                card_button.CssClass = "card_B";
                card_button.ID = item[i];
                card_button.Text = "Remove";
              
                Name_text_card.InnerText = item[i];
                price_text_card.InnerText = "Quantity:" + item[i + 1];
                price_text_card.Attributes.Add("class", "price");
                Name_text_card.Attributes.Add("class", "CardName");
               
                card_div.Controls.Add(img);
                card_div.Controls.Add(Name_text_card);
                card_div.Controls.Add(price_text_card);
                card_div.Controls.Add(card_button);

                listcomponent.Add(card_div);
                count++;
            }

            for (int i = 0; i < count; i++)
                div_card.Controls.Add(listcomponent.ElementAt(i));

        }


        void Load_Total()
        {
            if (listcomponent.Count != 0)
            {
                System.Web.UI.HtmlControls.HtmlGenericControl h = new System.Web.UI.HtmlControls.HtmlGenericControl("H1");
                h.Attributes.Add("class", "totalcost");
                h.InnerText = "Total Cost:: " + admin_ser.total_price(ID_CART.ToString()).ToString() + " EG";
                totalCost.Controls.Add(h);

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ID_CART = int.Parse(Request.QueryString.Get("id"));
            Load_Cart();
            Load_Total();

        }
        protected void button_Click(object sender, EventArgs e)
        {
            Button Selected_Button = sender as Button;
            int Q = admin_ser.Getquantity(ID_CART, Selected_Button.ID);

            if (Q == 1)
            {


                admin_ser.Delete_Item_from_cart(Selected_Button.ID, ID_CART);
            }

            else
            {
                admin_ser.Update_Item_quantity(ID_CART.ToString(), Q - 1, Selected_Button.ID);
            }

            Server.TransferRequest(Request.Url.AbsolutePath, false);

        }
        protected void Unnamed1_CheckedChanged(object sender, EventArgs e)
        {
            r2.Checked = false;
            TextBox5.Visible = true;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            TextBox1.Visible = true;
            divv.Visible = true;
        }

        protected void Unnamed2_CheckedChanged(object sender, EventArgs e)
        {
            r1.Checked = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            TextBox1.Visible = false;
            divv.Visible = false;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (r1.Checked == false && r2.Checked == false)
            { ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Please Choose Payment Method" + "');", true); }
            else
            {
                if (r1.Checked == true)
                    admin_ser.put_method(ID_CART, "Viza");
                else
                    admin_ser.put_method(ID_CART, "cash");

                for (int i = 0; i < item.Count(); i += 2)
                    admin_ser.Delete_Item_from_cart(item.ElementAt(i), ID_CART);
                Server.TransferRequest(Request.Url.AbsolutePath, false);

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?id=" + ID_CART);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pinfo.aspx?id=" + ID_CART);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactAsPage.aspx?id=" + ID_CART);
        }
    }
}