using ASPSnippets.GoogleAPI;
using System;
using System.Web.Script.Serialization;

namespace SDAProject
{
    public class GoogleProfile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }
        public string Verified_Email { get; set; }
    }
    public partial class Login : System.Web.UI.Page
    {
        GoogleProfile profile;
        ShopService.WebService1SoapClient admin_ser = new ShopService.WebService1SoapClient();

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
                    int id;

                    if (!admin_ser.login(profile.Email, profile.Id))
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Wrong Password" + "');", true);



                    else
                    {
                        id = admin_ser.GetCart_ID(profile.Email);


                        Response.Redirect("Home.aspx?id=" + id);




                    }
                }
                if (Request.QueryString["error"] == "access_denied")
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied.')", true);
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            int id;

            if (!admin_ser.login(TextBox1.Text, TextBox2.Text.ToString()))
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Wrong Password" + "');", true);



            else
            {
                id = admin_ser.GetCart_ID(TextBox1.Text);


                Response.Redirect("Home.aspx?id=" + id);
            }

        }

        protected void google_Click1(object sender, EventArgs e)
        {


            GoogleConnect.Authorize("profile", "email");



        }
    }
}