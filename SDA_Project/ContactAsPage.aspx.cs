using System;

namespace SDAProject
{
    public partial class ContactAsPage : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString.Get("id"));

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pinfo.aspx?id=" + id);
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("MyCart.aspx?id=" + id);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?id=" + id);
        }
    }
}