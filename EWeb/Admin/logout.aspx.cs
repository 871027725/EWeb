using System;
namespace EWeb.Admin
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Session.Remove(Tools.SessionUtil.SessionKey);
            Response.Redirect("/Login.aspx");
        }
    }
}