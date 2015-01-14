/********************************************************************************
** 作者： ywx
** 创始时间： 2013/08/03
** 修改人：无
** 描述：Requests操作类
**********************************************************************************/
using System;
using System.Web;


namespace Tools
{
    /// <summary>
    /// Requests操作类
    /// </summary>
    public class Request2 {
    

        /// <summary>
        /// 接收传值
        /// </summary>
        /// <param name="VarName">参数名称</param>
        /// <returns>参数对应的值</returns>
        static public String Get(String VarName)
        {
            string varValue = "";
            if (HttpContext.Current.Request[VarName]!=null) 
                varValue = HttpContext.Current.Request[VarName].ToString();
            return varValue;
        }

        /// <summary>
        /// GetInt
        /// </summary>
        /// <param name="varName"></param>
        /// <param name="defValue"></param>
        /// <returns></returns>
        static public int GetInt(string varName, int defValue) { return Get(varName).ToInt(defValue); }
      
    }
}
