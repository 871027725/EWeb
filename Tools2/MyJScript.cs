using System.Text;
using System.Web;
using System.Web.UI;
namespace Tools
{
    public class MyJScript
    {
        public MyJScript()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        /// <summary>
        /// 没有操作权限
        /// </summary>
        public const string NOPopbem = "没有操作权限!";
        /// <summary>
        /// 审核成功
        /// </summary>
        public const string CheckSuccess = "审核成功!";
        /// <summary>
        /// 保存成功
        /// </summary>
        public const string SaveSuccess = "保存成功!";
        /// <summary>
        /// 删除成功
        /// </summary>
        public const string DeleSuccess = "删除成功";
        /// <summary>
        /// 删除失败
        /// </summary>
        public const string DelFailure = "删除失败";
        /// <summary>
        /// 更新成功
        /// </summary>
        public const string UpdateSuccess = "更新成功";
        /// <summary>
        /// 保存失败
        /// </summary>
        public const string Failure = "保存失败!";

        /// <summary>
        /// 附件删除成功
        /// </summary>
        public const string FileDelSuccess = "附件删除成功!";

        /// <summary>
        /// 附件删除失败
        /// </summary>
        public const string FileDelFailure = "附件删除失败!";

        /// <summary>
        /// 密码重置成功
        /// </summary>
        public const string SetPwdSuccess = "重置成功!";

        /// <summary>
        /// 密码重置失败
        /// </summary>
        public const string SetPwdFailure = "重置失败!";

        /// <summary>
        /// 发送成功
        /// </summary>
        public const string SendSuccess = "发送成功!";

        /// <summary>
        /// 发送失败
        /// </summary>
        public const string SendFailure = "发送失败!";


        public const string RedirectPage = "/Information.aspx";


        public static void AlertWindowAndRedirect(System.Web.UI.Page page, string str, string url)
        {

            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>alert('{0}');location.href='{1}'</script>", str, url);
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);

            }
        }

        public static void AlertWindowAndReload(Page page, string str)
        {

            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>alert('{0}');location=location;</script>", str);
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);
            }
        }


        public static void AlertAndParentRedirect(Page page, string str, string url)
        {

            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>alert('{0}');window.parent.location.href='{1}'</script>", str, url);
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);

            }
        }
        public static void AlertAndGoBack(Page page, string str)
        {

            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>alert('{0}');histroy.go(-1);</script>", str);
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);

            }
        }

        public static void AlertAndCloseParentReload(Page page, string str)
        {
            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>opener.window.location.reload();alert('{0}');window.close();</script>", str);
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);

            }
        }





        public static void AlertAndParentRedirect(Page page, string url)
        {

            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>window.parent.location.href='{0}'</script>", url);
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);

            }
        }

        public static void AlertWindow(Page page, string str)
        {
            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>alert('{0}');</script>", str);
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);

            }
        }
        public static void AlertAndCloseWindow(Page page, string str)
        {
            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>alert('{0}');window.close();</script>", str);
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);

            }
        }

        public static void CloseWindow(Page page)
        {
            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>window.close();</script>");
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);

            }
        }
        public static void FunWindow(Page page, string fun)
        {
            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>window.close();" + fun + "</script>");
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);

            }
        }
        public static void Redirect(Page page, string url)
        {

            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>window.location.href='{0}'</script>", url);
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);

            }
        }

        public static void ParentRedirect(Page page, string obj, string url, string strMs, string tourl)
        {
            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                string strScript = string.Format("<script language=javascript>alert('{1}'); parent." + obj + ".location.href='{0}';location.href='{2}';</script>", url, strMs, tourl);
                csm.RegisterStartupScript(page.GetType(), "clientScript", strScript);
            }

        }

        public static void MemberAlert(Page page, string str)
        {
            StringBuilder script = new StringBuilder();
            script.AppendLine("<script language=javascript>");
            script.Append("$().ready(function(){");
            script.Append(str);
            script.Append("});");
            script.AppendLine("</script>");

            ClientScriptManager csm = page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                csm.RegisterStartupScript(page.GetType(), "clientScript", script.ToString());
            }
        }


        #region 美化版js by ywx
        /// <summary>
        /// Alert 美化版
        /// </summary>
        /// <param name="Page">当前页: this</param>
        /// <param name="msg">提示内容</param>
        /// <param name="type">提示类型: 0 成功,1 信息,2 警告,3 错误</param>
        /// <param name="url">跳转页面</param>
        /// <returns>Alert美化版</returns>
        public static void Alert(System.Web.UI.Page Page, string msg, int type, string url)
        {
            string msg_btn = "<button class=popbtn onclick=dialogClose(); >确 定</button>";
            if (url.Length != 0) msg_btn = "<button class=popbtn onclick=window.location=\'" + url + "\' >确 定</button>";
            ClientScriptManager csm = Page.ClientScript;
            if (!csm.IsClientScriptBlockRegistered("clientScript"))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<script language=\"javascript\">\n");
                sb.Append("$(document).ready(function() {$.dialog.show({type:" + type + ", msg:\"" + msg + "\", button:\"" + msg_btn + "\" });});");
                sb.Append("\n</script>\n");
                csm.RegisterStartupScript(Page.GetType(), "RunBottomJs", sb.ToString());
            }
        }
        #endregion




    }
}
