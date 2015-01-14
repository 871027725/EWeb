//using System;
//using System.Data;

//namespace EWeb.Admin.employee
//{
//    public partial class edit : System.Web.UI.Page
//    {
//        public int eid = 0;   //账号ID
//        public Model.ModEmployee modEmp = new Model.ModEmployee();
//        Bll.BllEmployee employeeService = Bll.BllEmployee.getInstance(Tools.DateBaseUtil.WWW);
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            if (!IsPostBack)
//            {
//                try
//                {
//                    eid = Tools.Request2.GetInt("eid",0);
//                    if ( eid > 0 )
//                    {
//                        modEmp = employeeService.GetModel(eid);
//                        if (modEmp != null) {
//                            txtUserName.Value = modEmp.Username;
//                            txtPassword.Value = Tools.DESEncrypt.Decrypt(modEmp.Password);
//                            txtEid.Value = modEmp.Eid.ToString();
//                        } 
//                    }
//                }
//                catch (Exception)
//                {
//                    eid = 0;
//                }
//            }
//        }

//        /// <summary>
//        /// 添加账号
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        protected void empBtn_Click(object sender, EventArgs e)
//        {
//            string username = txtUserName.Value;
//            string password = txtPassword.Value;
//            int eid = Convert.ToInt32(txtEid.Value);
//            Model.ModEmployee emps = new Model.ModEmployee();
//            string whereSql = "";
//            if (eid > 0)
//            {
//                emps = employeeService.GetModel(eid);
//                if (emps == null)
//                {
//                    emps = new Model.ModEmployee();
//                }
//                whereSql = " username = '" + username + "' and eid != " + eid;
//            }
//            else
//            {
//                whereSql = " username = '" + username + "'";
//            }

//            DataTable dt = Bll.BaseBll.getInstance(Tools.DateBaseUtil.WWW).GetSelectList(1, "*", "employee", whereSql, "");
//            if (dt != null && dt.Rows.Count > 0)
//            {
//                Tools.MyJScript.AlertWindow(this, "账号已经存在");
//            }
//            try
//            {
//                emps.Username = Bll.BaseBll.CheckSqlValue(username);
//                emps.Password = Bll.BaseBll.CheckSqlValue(Tools.DESEncrypt.Encrypt(password));
//                employeeService.saveOrUpdate(emps);
//                Tools.MyJScript.AlertWindowAndRedirect(this, Tools.MyJScript.SaveSuccess, "list.aspx");
//            }
//            catch (Exception ex)
//            {
//                Tools.Msg.WriterError("保存失败,程序异常,============ " + ex.Message);
//                Tools.MyJScript.AlertWindow(this, Tools.MyJScript.Failure);
//            }
//        }
//    }
//}