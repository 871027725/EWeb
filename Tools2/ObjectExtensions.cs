/********************************************************************************
** 作者： ywx
** 创始时间： 2011-3-15
** 修改人：无
** 描述：ObjectExtensions扩展
**********************************************************************************/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tools {
    public static class ObjectExtensions {

        public static int ToInt(this object strValue, int defValue) { int def = 0; int.TryParse(strValue.ToString(), out def); return def == 0 ? defValue : def; }
		public static byte ToTinyInt(this object strValue, byte defValue) { byte def = 0;  byte.TryParse(strValue.ToString(), out def); return def == 0 ? defValue : def; }
		public static short ToSmallInt(this object strValue, short defValue) { short def = 0;  short.TryParse(strValue.ToString(), out def); return def == 0 ? defValue : def; }
		public static decimal ToDecimal(this object strValue, decimal defValue) { decimal def = 0;  decimal.TryParse(strValue.ToString(), out def); return def == 0 ? defValue : def; }
		public static float ToFloat(this object strValue, float defValue) { float def = 0;  float.TryParse(strValue.ToString(), out def); return def == 0 ? defValue : def; }
		public static Int64 ToBigInt(this object strValue, Int64 defValue) { Int64 def = 0;  Int64.TryParse(strValue.ToString(), out def); return def == 0 ? defValue : def; }
		public static decimal ToMoney(this object strValue, decimal defValue) { decimal def = 0;  decimal.TryParse(strValue.ToString(), out def); return def == 0 ? defValue : def; }
        public static int ToInteger(this object strValue, int defValue) { int def = 0; int.TryParse(strValue.ToString(), out def); return def == 0 ? defValue : def; }
        public static bool ToBool(this object Expression, bool defValue) {
            if (Expression != null) {
                if (string.Compare(Expression.ToString(), "true", true) == 0) return true;
                if (string.Compare(Expression.ToString(), "false", true) == 0) return false;
                if (string.Compare(Expression.ToString(), "1", true) == 0) return true;
                if (string.Compare(Expression.ToString(), "0", true) == 0) return false;
            }
            return defValue;
        }
        public static int ToInt(this object strValue) { return strValue.ToInt(0); }
        public static byte ToTinyInt(this object strValue) { return strValue.ToTinyInt(0); }
        public static short ToSmallInt(this object strValue) { return strValue.ToSmallInt(0); }
        public static decimal ToDecimal(this object strValue) { return strValue.ToDecimal(0); }
        public static float ToFloat(this object strValue) { return strValue.ToFloat(0); }
        public static Int64 ToBigInt(this object strValue) { return strValue.ToBigInt(0); }
        public static decimal ToMoney(this object strValue) { return strValue.ToMoney(0); }
        public static int ToInteger(this object strValue) { return strValue.ToInteger(0); }
        public static bool ToBool(this object strValue) { return strValue.ToBool(false); }


         /// <summary>
        /// 输出图片空值处理 默认图片路径 如： /images/nopic.jpg
        /// </summary>
        /// <returns>返回处理图片路径</returns>
        public static string defpic(this object strValue)
        {
            return defpic(strValue, "/images/nopic.jpg");
        }
        /// <summary>
        /// 输出图片空值处理
        /// </summary>
        /// <param name="strValue">对象</param>
        /// <param name="defValue">默认图片路径 如： /images/nopic.jpg </param>
        /// <returns>返回处理图片路径</returns>
        public static string defpic(this object strValue, string defValue)
        {
            if (strValue.ToString().Length > 1)
            {
                return strValue.ToString();
            }
            else {
                return defValue;
            }
        }

       
    }


    public static class StringExtensions
    {

        static public bool IsNullEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
        static public string IsNullEmpty(this string str, string defaultValue)
        {
            return str.IsNullEmpty() ? defaultValue : str;
        }

        public static bool ContainsArray(this string value, params string[] keywords)
        {
            return keywords.All((s) => value.Contains(s));
        }

        public static bool IsMatch(this string str, string op)
        {
            if (str.Equals(String.Empty) || str == null) return false;
            Regex re = new Regex(op, RegexOptions.IgnoreCase);
            return re.IsMatch(str);
        }
        public static bool IsIP(this string input)
        {
            return input.IsMatch(@"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$"); //@"^(([01]?[\d]{1,2})|(2[0-4][\d])|(25[0-5]))(\.(([01]?[\d]{1,2})|(2[0-4][\d])|(25[0-5]))){3}$";
        }

        public static string FormatWith(this string str, params object[] args)
        {
            return string.Format(str, args);
        }
        public static string FormatWith(this string text, object arg0)
        {
            return string.Format(text, arg0);
        }
        public static string FormatWith(this string text, object arg0, object arg1)
        {
            return string.Format(text, arg0, arg1);
        }
        public static string FormatWith(this string text, object arg0, object arg1, object arg2)
        {
            return string.Format(text, arg0, arg1, arg2);
        }
        public static string FormatWith(this string text, IFormatProvider provider, params object[] args)
        {
            return string.Format(provider, text, args);
        }

        public static TimeSpan GetTimeSpan(this DateTime startTime, DateTime endTime)
        {
            return endTime - startTime;
        }

        public static DateTime ToDateTime(this string DateTimeStr)
        {
            return DateTime.Parse(DateTimeStr);
        }
        public static string ToDateTime(this string fDateTime, string formatStr)
        {
            DateTime s = Convert.ToDateTime(fDateTime);
            return s.ToString(formatStr);
        }
        public static DateTime ToDateTime(this string DateTimeStr, DateTime defDate)
        {
            DateTime.TryParse(DateTimeStr, out defDate);
            return defDate;
        }
        public static DateTime? ToDateTime(this string DateTimeStr, DateTime? defDate)
        {
            DateTime dt = DateTime.Now;
            DateTime dt2 = dt;
            DateTime.TryParse(DateTimeStr, out dt);
            if (dt == dt2) return defDate;
            return dt;
        }
        public static bool IsDate(this string DateStr)
        {
            try { DateTime _dt = DateTime.Parse(DateStr); return true; }
            catch { return false; }
        }

    }
}

