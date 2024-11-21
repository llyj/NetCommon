using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetCommon.Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// 判断是否NULL或空字符
        /// </summary>
        /// <returns></returns>
        public static bool IsEmptyVal(this string str)
        {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// 判断字符串是否相同(不区分大小写)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool EqualsNoCase(this string str, string point)
        {
            return str.Equals(point, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 移除字符, 多个字符逗号隔开
        /// </summary>
        /// <param name="str"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string Remove(this string str, params string[] args)
        {
            if (str.IsEmptyVal())
                return str;

            foreach (string arg in args)
            {
                str = str.Replace(arg, "", StringComparison.OrdinalIgnoreCase);
            }
            return str;
        }

        /// <summary>
        /// 移除特殊字符
        /// </summary>
        /// <returns></returns>
        public static string RemoveSpecialCharacter(this string str)
        {
            if (!str.IsEmptyVal())
                return string.Empty;

            str = Regex.Replace(str, @"[\-\+\*%'\\'/#@<>&$\=\:,\(\)\*\[\]\.]", "").ToLower();

            byte[] space = new byte[] { 0xc2, 0xa0 };
            string UTFSpace = Encoding.GetEncoding("UTF-8").GetString(space);
            return str.Replace(UTFSpace, "").Replace(" ", "");
        }

        /// <summary>
        /// 字符串转时间
        /// </summary>
        /// <param name="time">字符串日期</param>
        public static DateTime ToDateTime(this string time)
        {
            return ToDateTime(time, new DateTime());
        }

        /// <summary>
        /// 字符串转时间
        /// </summary>
        /// <param name="time">字符串日期</param>
        /// <param name="defaultValue">默认值</param>
        public static DateTime ToDateTime(this string time, DateTime defaultValue)
        {
            if (!string.IsNullOrEmpty(time))
            {
                DateTime.TryParse(time, out defaultValue);
            }
            return defaultValue;
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <param name="ignoreCase"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this string str, bool ignoreCase = true) where T : struct
        {
            var parseResult = Enum.TryParse<T>(str, ignoreCase, out var result);
            return parseResult ? result : default(T);
        }
    }
}