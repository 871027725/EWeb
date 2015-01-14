using System;
using System.Web;
using System.Text;
using log4net;
namespace Tools
{
    /// <summary>
    /// 输出消息类
    /// </summary>
    public class Msg
    {
        #region Write
        /// <summary>
        /// 输出消息
        /// </summary>
        /// <param name="msg">消息内容</param>
        public static void Write(string msg) { HttpContext.Current.Response.Write(msg); }
        public static void Write(string format, params object[] args) { HttpContext.Current.Response.Output.Write(format, args); }
        public static void Write(object msg) { Write(msg.ToString()); }

        public static void WriteEnd(string msg) { Msg.Write(msg); Msg.End(); }
        public static void WriteEnd(string format, params object[] args) { Msg.Write(format, args); Msg.End(); }
        public static void WriteEnd(object msg) { WriteEnd(msg.ToString()); }

        /// <summary>
        /// 输出消息到HtmlGenericControl控件
        /// </summary>
        /// <param name="Control">HtmlGenericControl控件</param>
        /// <param name="msg">消息内容</param>
        /// <param name="isAdd">是否累记</param>
        public static void Write(System.Web.UI.HtmlControls.HtmlGenericControl Control, string msg, bool isAdd)
        {
            if (isAdd) Control.InnerHtml += msg; else Control.InnerHtml = msg;
        }
        #endregion

        #region End
        /// <summary>
        /// 终止页面的运行
        /// </summary>
        public static void End() { HttpContext.Current.Response.End(); }
        #endregion

        public static void Redirect(string url) { HttpContext.Current.Response.Redirect(url); }

        private static ILog log = LogManager.GetLogger("Logging");

        public static void WriterInfo(string msg){
            if (log.IsInfoEnabled) {
                log.Info(msg);
            }
        }
        public static void WriterError(string msg)
        {
            if (log.IsInfoEnabled) {
                log.Info(msg);
            }
        }
    }
}