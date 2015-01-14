/********************************************************************************
** ���ߣ� ywx
** ��ʼʱ�䣺 2013/08/03
** �޸��ˣ���
** ������Requests������
**********************************************************************************/
using System;
using System.Web;


namespace Tools
{
    /// <summary>
    /// Requests������
    /// </summary>
    public class Request2 {
    

        /// <summary>
        /// ���մ�ֵ
        /// </summary>
        /// <param name="VarName">��������</param>
        /// <returns>������Ӧ��ֵ</returns>
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
