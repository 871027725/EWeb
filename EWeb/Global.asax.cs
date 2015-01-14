using System;
using Tools.LogHelper;
namespace EWeb
{
    public class Global : System.Web.HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
           // System.Web.HttpResponse httpResponse = System.Web.HttpContext.Current.Response;
           // httpResponse.AddHeader("Cache-Control", "no-cache");
            LoggerManage.getInstance().error(this.GetType(),"系统开始启动,清空所有无效数据库链接");
        }

        void Application_End(object sender, EventArgs e)
        {
            LoggerManage.getInstance().info(this.GetType(), "系统停止运行");
        }

        void Application_Error(object sender, EventArgs e)
        {
            LoggerManage.getInstance().info(this.GetType(), "系统错误!");
        }

        void Session_Start(object sender, EventArgs e)
        {
         
        }

        void Session_End(object sender, EventArgs e)
        {
            // 在会话结束时运行的代码。 
            // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为
            // InProc 时，才会引发 Session_End 事件。如果会话模式设置为 StateServer 
            // 或 SQLServer，则不会引发该事件。

        }

    }
}
