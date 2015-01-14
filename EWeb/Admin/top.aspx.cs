using System;

namespace EWeb.Admin
{
    public partial class top : Base
    {
        public Model.ModEmployee sessionEmp = new Model.ModEmployee();
        protected void Page_Load(object sender, EventArgs e)
        {
            //sessionEmp = (Model.ModEmployee)Session[Tools.SessionUtil.SessionKey];
        }
    }
}