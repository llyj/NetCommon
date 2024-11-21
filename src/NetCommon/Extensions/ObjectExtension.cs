using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.Extensions
{
    public static class ObjectExtension
    {
        public static int ToInt(this object value)
        {
            return value.ToInt(0);
        }

        public static int ToInt(this object? value, int defaultValue)
        {
            int result = defaultValue;

            if (value == null || value == DBNull.Value)
                return result;

            if (value is Enum)
                return (int)value;

            int.TryParse(value.ToString(), out result);
            return result;
        }

        /// <summary>
        /// 转十进制数值型，不能转返回设定默认值
        /// </summary>
        /// <param name="value">字符</param>
        /// <returns>十进制数值型</returns>
        public static decimal ToDecimal(this object value)
        {
            return ToDecimal(value, 0);
        }

        /// <summary>
        /// 字符转十进制数值型，不能转返回设定默认值
        /// </summary>
        /// <param name="value">字符</param>
        /// <param name="defaultValue">不能转返回的值</param>
        /// <returns>十进制数值型</returns>
        public static decimal ToDecimal(this object value, decimal defaultValue)
        {
            if (value != null && value != DBNull.Value)
            {
                decimal.TryParse(value.ToString(), out defaultValue);
            }
            return defaultValue;
        }

        /// <summary>
        /// 对象转时间
        /// </summary>
        /// <param name="time">字符串日期</param>
        public static DateTime ToDateTime(this object time)
        {
            return ToDateTime(time, new DateTime());
        }

        /// <summary>
        /// 对象转时间
        /// </summary>
        /// <param name="time">字符串日期</param>
        /// <param name="defaultValue">默认值</param>
        public static DateTime ToDateTime(this object time, DateTime defaultValue)
        {
            if (time != null && time != DBNull.Value && time.ToString() != "")
            {
                DateTime.TryParse(time.ToString(), out defaultValue);
            }
            else
            {
                defaultValue = new DateTime(1900, 01, 01, 00, 00, 00);
            }
            return defaultValue;
        }
    }
}