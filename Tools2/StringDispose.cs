using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Tools
{
    /// <summary>
    /// 字符操作
    /// author ywx
    /// </summary>
    public class StringDispose
    {
        /// <summary>
        /// 判断数字
        /// </summary>
        /// <param name="checkStr"></param>
        /// <returns></returns>
        public static bool IsNumber(string checkStr)
        {
            if (string.IsNullOrEmpty(checkStr)) { return false; }
            return Regex.IsMatch(checkStr, @"^\d+$");
        }

        /// <summary>
        /// 判断vale中是否含有keywords字符
        /// </summary>
        /// <param name="value">字符串</param>
        /// <param name="keywords">查询字符</param>
        /// <returns></returns>
        public static bool ContainsArray(string value, params string[] keywords)
        {
            return value.ContainsArray(keywords);
        }

        /// <summary>
        /// 判断时间(长型)
        /// </summary>
        /// <param name="checkStr"></param>
        /// <returns></returns>
        private static Regex RegExcel = new Regex(@"^(.xls|xlsx)$");
        public static bool IsExcel(string inputexcel)
        {
            Match m = RegExcel.Match(inputexcel);
            return m.Success;
        }
        /// <summary>
        /// 判断是不是excel
        /// </summary>
        /// <param name="checkStr"></param>
        /// <returns></returns>
        private static Regex RegDate = new Regex(@"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d$");
        public static bool IsDate(string inputdate)
        {
            Match m = RegDate.Match(inputdate);
            return m.Success;
        }
        /// <summary>
        /// 判断时间(短型)
        /// </summary>
        /// <param name="checkStr"></param>
        /// <returns></returns>
        private static Regex RegDate2 = new Regex(@"^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2})$");
        public static bool IsShortDate(string inputdate)
        {
            Match m = RegDate2.Match(inputdate);
            return m.Success;
        }
        /// <summary>
        /// 是否是浮点数
        /// </summary>
        /// <param name="inputData">输入字符串</param>
        /// <returns></returns>
        private static Regex RegDecimal = new Regex("[0-9]*\\.?[0-9]*");
        public static bool IsDecimal(string inputData)
        {

            Match m = RegDecimal.Match(inputData);
            return m.Success;
        }
        /// <summary>
        /// 请求字符串类型
        /// </summary>
        /// <param name="requestStr">请求的Request值</param>
        /// <returns>返回字符串，null则返回""</returns>
        public static string RequestString(string requestStr)
        {
            if (string.IsNullOrEmpty(requestStr))
            {
                return "";
            }
            else
            {
                return requestStr;
            }
        }

        /// <summary>
        /// 获取request 数字类型值
        /// </summary>
        /// <param name="requestStr">获取request值</param>
        /// <returns>返回数字类型,空则返回0</returns>
        public static int RequestInt(string requestStr)
        {
            if (Tools.StringDispose.IsNumber(requestStr))
            {
                return Int32.Parse(requestStr);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// string型转换为bool型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool StrToBool(object expression, bool defValue)
        {
            if (expression != null)
                return StrToBool(expression, defValue);
           

            return defValue;
        }

        /// <summary>
        /// string型转换为bool型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool StrToBool(string expression, bool defValue)
        {
            if (expression != null)
            {
                if (string.Compare(expression, "true", true) == 0)
                    return true;
                else if (string.Compare(expression, "false", true) == 0)
                    return false;
            }
            return defValue;
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int ObjectToInt(object expression)
        {
            return ObjectToInt(expression, 0);
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int ObjectToInt(object expression, int defValue)
        {
            if (expression != null)
                return StrToInt(expression.ToString(), defValue);

            return defValue;
        }

        /// <summary>
        /// 将对象转换为Int32类型,转换失败返回0
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <returns>转换后的int类型结果</returns>
        public static int StrToInt(string str)
        {
            return StrToInt(str, 0);
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int StrToInt(string str, int defValue)
        {
            if (string.IsNullOrEmpty(str) || str.Trim().Length >= 11 || !Regex.IsMatch(str.Trim(), @"^([-]|[0-9])[0-9]*(\.\w*)?$"))
                return defValue;

            int rv;
            if (Int32.TryParse(str, out rv))
                return rv;

            return Convert.ToInt32(StrToFloat(str, defValue));
        }

        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static float StrToFloat(object strValue, float defValue)
        {
            if ((strValue == null))
                return defValue;

            return StrToFloat(strValue.ToString(), defValue);
        }

        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static float ObjectToFloat(object strValue, float defValue)
        {
            if ((strValue == null))
                return defValue;

            return StrToFloat(strValue.ToString(), defValue);
        }

        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static float ObjectToFloat(object strValue)
        {
            return ObjectToFloat(strValue.ToString(), 0);
        }

        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <returns>转换后的int类型结果</returns>
        public static float StrToFloat(object strValue)
        {
            if ((strValue == null))
                return 0;

            return StrToFloat(strValue.ToString(), 0);
        }

        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static float StrToFloat(string strValue, float defValue)
        {
            if ((strValue == null) || (strValue.Length > 10))
                return defValue;

            float intValue = defValue;
            if (strValue != null)
            {
                bool IsFloat = Regex.IsMatch(strValue, @"^([-]|[0-9])[0-9]*(\.\w*)?$");
                if (IsFloat)
                    float.TryParse(strValue, out intValue);
            }
            return intValue;
        }

        /// <summary>
        /// 将对象转换为日期时间类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static DateTime StrToDateTime(string str, DateTime defValue)
        {
            if (!string.IsNullOrEmpty(str))
            {
                DateTime dateTime;
                if (DateTime.TryParse(str, out dateTime))
                    return dateTime;
            }
            return defValue;
        }

        /// <summary>
        /// 将对象转换为日期时间类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <returns>转换后的int类型结果</returns>
        public static DateTime StrToDateTime(string str)
        {
            return StrToDateTime(str, DateTime.Now);
        }

        /// <summary>
        /// 将对象转换为日期时间类型
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <returns>转换后的int类型结果</returns>
        public static DateTime ObjectToDateTime(object obj)
        {
            return StrToDateTime(obj.ToString());
        }

        /// <summary>
        /// 将对象转换为日期时间类型
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static DateTime ObjectToDateTime(object obj, DateTime defValue)
        {
            return StrToDateTime(obj.ToString(), defValue);
        }
    

        #region 文件处理
        /// <summary>
        /// 获得一个16位时间随机数
        /// </summary>
        /// <returns>返回随机数</returns>
        public static string GetDataRandom()
        {

            string strData = System.DateTime.Now.Year.ToString() +
            System.DateTime.Now.Month.ToString() +
            System.DateTime.Now.Day.ToString() +
            System.DateTime.Now.Hour.ToString() +
            System.DateTime.Now.Minute.ToString() +
            System.DateTime.Now.Second.ToString() +
            System.DateTime.Now.Millisecond.ToString();

            //Random r = new Random();
            //strData = strData + r.Next(1000);
            return strData;
        }


        public static string GetFileSize(float filesize)
        {
            float filesizeFloat = filesize / 1024;
            if (filesizeFloat < 1024)
            {
                return Math.Ceiling(filesizeFloat) + "K";
            }
            else
            {
                filesizeFloat = filesizeFloat / 1024;
                return Math.Round(filesizeFloat, 2) + "M";
            }

        }

        #endregion

     

        /// <summary>
        /// 截取字符串长度
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="length">长度</param>
        /// <param name="showtype">0普通返回 其他+...</param>
        /// <returns></returns>
        public static string SetStrLength(string str, int length, int showtype)
        {
            if (length <= str.Length)
            {

                str = str.Substring(0, length);

                if (showtype == 0)
                {
                    return str;
                }
                return str + "...";
            }

            return str;

        }

        /// <summary>
        /// 获得当前天和星期几
        /// </summary>
        /// <returns></returns>
        public static string GetDataWeek()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Today.ToLongDateString() + "&nbsp");
            switch (DateTime.Today.DayOfWeek.ToString())
            {
                case "Monday":
                    sb.Append("星期一");
                    break;
                case "Tuesday":
                    sb.Append("星期二");
                    break;
                case "Wednesday":
                    sb.Append("星期三");
                    break;
                case "Thursday":
                    sb.Append("星期四");
                    break;
                case "Friday":
                    sb.Append("星期五");
                    break;
                case "Saturday":
                    sb.Append("星期六");
                    break;
                case "Sunday":
                    sb.Append("星期日");
                    break;

            }


            return sb.ToString();
        }



        /// <summary>
        /// 删除html标记
        /// </summary>
        /// <returns></returns>
        public static string RemoveHTML(string HtmlCode)
        {
            string MatchVale = HtmlCode;
            MatchVale = new Regex("<br>", RegexOptions.IgnoreCase).Replace(MatchVale, "\n");
            foreach (Match s in Regex.Matches(HtmlCode, "<[^{><}]*>")) { MatchVale = MatchVale.Replace(s.Value, ""); }//"(<[^{><}]*>)"//@"<[\s\S-! ]*?>"//"<.+?>"//<(.*)>.*<\/\1>|<(.*) \/>//<[^>]+>//<(.|\n)+?>
            MatchVale = new Regex("\n", RegexOptions.IgnoreCase).Replace(MatchVale, "<br>");
            return MatchVale;
        }
        /// <summary>
        /// 删除所有html标记
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string RemoveAllHTML(string content)
        {
            string pattern = "<[^>]*>";
            return Regex.Replace(content, pattern, string.Empty, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 过滤HTML标记
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveHTMLB(string str)
        {
            Regex regex = new Regex(@"\<(.*?)\>", RegexOptions.IgnoreCase);
            return regex.Replace(str, "").Replace("&nbsp;", "").Replace("\n", "").Replace("\r", "");
        }


    }
}
