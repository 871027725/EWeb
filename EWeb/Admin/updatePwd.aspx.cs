//using System;

//namespace EWeb.Admin
//{
//    public partial class updatePwd : Base
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }

//        protected void btnSave_Click(object sender, EventArgs e)
//        {
//            string pwd = txtPwd.Value;
//            string newPwd = txtNewPwd.Value;
//            string confirmNewPwd = txtConfirmPwd.Value;
//            if (string.IsNullOrEmpty(newPwd))
//            {
//                Tools.MyJScript.AlertWindow(this, "请输入新密码!");
//                return;
//            }
//            if (string.IsNullOrEmpty(confirmNewPwd))
//            {
//                Tools.MyJScript.AlertWindow(this, "请输入确认密码!");
//                return;
//            }
//            if (!newPwd.Equals(confirmNewPwd))
//            {
//                Tools.MyJScript.AlertWindow(this, "新密码与确认密码不一致!");
//                return;
//            }
//            Model.ModEmployee emp = (Model.ModEmployee)Session[Tools.SessionUtil.SessionKey];
//            if (emp != null)
//            {
//                if (!Tools.DESEncrypt.Decrypt(emp.Password).Equals(pwd))
//                {
//                    Tools.MyJScript.AlertWindow(this, "原始密码不正确!");
//                    return;
//                }
//                emp.Password = Tools.DESEncrypt.Encrypt(newPwd);
//                if (!Bll.BllEmployee.getInstance(Tools.DateBaseUtil.WWW).Update(emp))
//                {
//                    Tools.MyJScript.AlertWindow(this, "修改密码失败!");
//                    return;
//                }
//                else
//                {
//                    Tools.MyJScript.AlertWindow(this, Tools.MyJScript.UpdateSuccess);
//                    return;
//                }
//            }
//            else {
//                Tools.MyJScript.AlertWindowAndRedirect(this, Tools.MyJScript.Failure,"/login.aspx");
//            }
//        }
//    }
//}