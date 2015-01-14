//using System;
//using System.Data;

//namespace EWeb.Admin.employee
//{
//    public partial class list : Base
//    {
//        private Dal.DalEmployee employeeService = Dal.DalEmployee.getInstance();
//        public DataTable dt = new DataTable();
//        public string username = string.Empty;
//        string whereSql = "";
//        private int _pageindex = 1;
//        private int allpage;
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            _pageindex = Tools.Request2.GetInt("page", 1);
//            username = Tools.Request2.Get("username");
//            if (!string.IsNullOrEmpty(username))
//            {
//                whereSql = " username like '%" + Bll.BaseBll.CheckSqlValueByLike(username) + "%'";
//            }
//            using (dt = Bll.BaseBll.getInstance(Tools.DateBaseUtil.WWW).GetPageList1("employee", "*", whereSql, "eid", 0, true, _pagesize, _pageindex, ref allpage).Tables[0])
//            {
//                if (dt.Rows.Count > 0)
//                {
//                    AspNetPager1.RecordCount = allpage;
//                    AspNetPager1.PageSize = _pagesize;
//                    AspNetPager1.CurrentPageIndex = _pageindex;
//                }
//            }
//        }

//        protected void btnDel_Click(object sender, EventArgs e)
//        {
//            string id = Request.Form["checkboxid"]!=null?Request.Form["checkboxid"].ToString():"";
//            if (string.IsNullOrEmpty(id)) {
//                Tools.MyJScript.AlertWindow(this, Tools.MyJScript.DelFailure);
//            }
//            try
//            {
//                if (employeeService.DeleteByBatch(id))
//                {
//                    Tools.MyJScript.AlertWindowAndRedirect(this, Tools.MyJScript.DeleSuccess, "list.aspx");
//                }
//                else {
//                    Tools.MyJScript.AlertWindow(this, Tools.MyJScript.Failure);
//                }
//            }
//            catch (Exception ex) {
//                Tools.Msg.WriterError("保存失败,程序异常,============ " + ex.Message);
//                Tools.MyJScript.AlertWindow(this, Tools.MyJScript.DelFailure);
//            }
//        }

//        public string GetName(string pwd) {
//            return Tools.DESEncrypt.Decrypt(pwd);
//        }
//    }
//}