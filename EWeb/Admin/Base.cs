using System;

/// <summary>
///PageBase 的摘要说明
/// </summary>
namespace EWeb.Admin
{

    public class Base : System.Web.UI.Page
    {
        protected const int _pagesize = 20;

        protected override void OnLoad(EventArgs e)
        {
            if (!IsPostBack)
            {
      
            }


            //Model.ModEmployee emp = (Model.ModEmployee)Session[Tools.SessionUtil.SessionKey];
            //if (emp == null)
            //{
            //    Response.Redirect("/login.aspx");
            //}
            base.OnLoad(e);
        }
    }
}

