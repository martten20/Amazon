using ASPSnippets.GoogleAPI;
using System;
using System.Web.Script.Serialization;

namespace SDAProject
{

    public partial class Reg : System.Web.UI.Page
    {

        ShopService.WebService1SoapClient admin_ser = new ShopService.WebService1SoapClient();
        GoogleProfile profile;
        protected void Page_Load(object sender, EventArgs e)
        {
            GoogleConnect.ClientId = "772000048074-a47l1jp7uk5ctn81ng35pm6r1rb1nsa3.apps.googleusercontent.com";
            GoogleConnect.ClientSecret = "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";
            GoogleConnect.RedirectUri = Request.Url.AbsoluteUri.Split('?')[0];

            if (!this.IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["code"]))
                {

                    string code = Request.QueryString["code"];
                    string json = GoogleConnect.Fetch("me", code);
                    profile = new JavaScriptSerializer().Deserialize<GoogleProfile>(json);
                    int id = 0;

                    admin_ser.register(profile.Email, profile.Id, profile.Name, "Google-Account", "Google-Account", 0);
                    admin_ser.Insert_Cart(profile.Email);
                    id = admin_ser.GetCart_ID(TextBox3.Text);
                    Response.Redirect("Home.aspx?id=" + id);

                }
                if (Request.QueryString["error"] == "access_denied")
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied.')", true);
                }
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = 0;

            try
            {
                if (RequiredFieldValidator1.IsValid)
                {
                  

                    admin_ser.register(TextBox3.Text, TextBox2.Text, TextBox1.Text, TextBox4.Text, TextBox5.Text, int.Parse(TextBox6.Text));
                    admin_ser.Insert_Cart(TextBox3.Text);
                    id = admin_ser.GetCart_ID(TextBox3.Text);
                    Response.Redirect("Home.aspx?id=" + id);
                }
            }
            catch (Exception t)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied.')", true);
            }
         
        }

        protected void google_Click1(object sender, EventArgs e)
        {
            GoogleConnect.Authorize("profile", "email");
        }
    }
}