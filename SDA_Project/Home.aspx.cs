using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace SDAProject
{
    public partial class Home : System.Web.UI.Page
    {
        ShopService.WebService1SoapClient admin_ser = new ShopService.WebService1SoapClient();
        List<System.Web.UI.HtmlControls.HtmlGenericControl> List_comp;
        int ID_USER;
        int count;


        void ref_cart()
        {
            var itms = admin_ser.show_items();

            List_comp = new List<System.Web.UI.HtmlControls.HtmlGenericControl>();

            for (int i = 0; i < itms.Length; i++)
            {

                System.Web.UI.HtmlControls.HtmlGenericControl Div_Card_bk = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                System.Web.UI.HtmlControls.HtmlGenericControl Card_Name = new System.Web.UI.HtmlControls.HtmlGenericControl("H1");
                System.Web.UI.HtmlControls.HtmlGenericControl price_card = new System.Web.UI.HtmlControls.HtmlGenericControl("H1");
                System.Web.UI.HtmlControls.HtmlGenericControl Disc_card = new System.Web.UI.HtmlControls.HtmlGenericControl("H1");
              
                Image img = new Image();
                img.Attributes.Add("class", "img");
                img.ImageUrl = itms[i][3];

                Div_Card_bk.Attributes.Add("class", "card");
               
                Button button_card = new Button();
                button_card.Click += new EventHandler(button_Click);
                button_card.CssClass = "button_card";
                button_card.ID = itms[i][0];
                button_card.Text = "Add To Cart";
                
                Card_Name.InnerText = itms[i][0];
                price_card.Attributes.Add("class", "price");
                Card_Name.Attributes.Add("class", "CardName");
                Disc_card.Attributes.Add("class", "CardName");
                Disc_card.InnerText = itms[i][1];
                price_card.InnerText = itms[i][2] + "EG";


                Div_Card_bk.Controls.Add(img);
                Div_Card_bk.Controls.Add(Card_Name);
                Div_Card_bk.Controls.Add(price_card);
                Div_Card_bk.Controls.Add(Disc_card);
                Div_Card_bk.Controls.Add(button_card);
                
                List_comp.Add(Div_Card_bk);

            }


            for (int i = 0; i < itms.Length; i++)
                div_card.Controls.Add(List_comp.ElementAt(i));
            count = itms.Length;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ID_USER = int.Parse(Request.QueryString.Get("id"));
            ref_cart();
        }

        protected void button_Click(object sender, EventArgs e)
        {

            Button Selected_Button = sender as Button;


            int Q = admin_ser.Getquantity(ID_USER, Selected_Button.ID);

            Console.WriteLine(Q);

            if (Q == 0)
            {
                admin_ser.Insert_Into_Cart(ID_USER, Selected_Button.ID, 1);
                

            }

            else
            {
                admin_ser.Update_Item_quantity(ID_USER.ToString(), Q + 1, Selected_Button.ID);
            }







        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyCart.aspx?id=" + ID_USER);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                for (int i = 0; i < count; i++)
                {
                    if (div_card.Controls[i].Controls[4].ID != TextBox1.Text)
                        div_card.Controls[i].Visible = false;
                    if (div_card.Controls[i].Controls[4].ID == TextBox1.Text)
                        div_card.Controls[i].Visible = true;
                }
            }
            else
            {
                Server.TransferRequest(Request.Url.AbsolutePath, false);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pinfo.aspx?id=" + ID_USER);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactAsPage.aspx?id=" + ID_USER);
        }
    }
}