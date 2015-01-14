using System;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Specialized;

namespace Tools
{
   public class Properties
   {

       #region 枚举方法
       public class EnumHelp
       {
           /// <summary>   
           /// 获取枚举类型的所有字段信息   
           /// </summary>   
           /// <param name="type"></param>   
           /// <returns></returns>   
           public static List<string[]> GetEnumOpt(Type type)
           {
               List<string[]> Strs = new List<string[]>();
               FieldInfo[] fields = type.GetFields();
               for (int i = 1, count = fields.Length; i < count; i++)
               {
                   FieldInfo field = fields[i];
                   string[] strEnum = new string[2];
                   strEnum[0] = ((int)Enum.Parse(type, field.Name)).ToString();
                   strEnum[1] = field.Name;
                   Strs.Add(strEnum);
               }
               return Strs;
           }
           /// <summary>
           /// 从枚举类型和它的特性读出并返回一个键值对
           /// </summary>
           /// <param name="enumType">Type,该参数的格式为typeof(需要读的枚举类型)</param>
           /// <returns>键值对</returns>
           public static NameValueCollection GetNVCFromEnumValue(Type enumType)
           {
               NameValueCollection nvc = new NameValueCollection();
               Type typeDescription = typeof(DescriptionAttribute);
               System.Reflection.FieldInfo[] fields = enumType.GetFields();
               string strText = string.Empty;
               string strValue = string.Empty;
               foreach (FieldInfo field in fields)
               {
                   if (field.FieldType.IsEnum)
                   {
                       //strValue = ((int)enumType.InvokeMember(field.Name, BindingFlags.GetField, null, null, null)).ToString();
                       strValue = field.Name;
                       object[] arr = field.GetCustomAttributes(typeDescription, true);
                       if (arr.Length > 0)
                       {
                           DescriptionAttribute aa = (DescriptionAttribute)arr[0];
                           strText = aa.Description;
                       }
                       else
                       {
                           strText = field.Name;
                       }
                       nvc.Add(strText, strValue);
                   }
               }
               return nvc;
           }


       }
       #endregion

    }
}
