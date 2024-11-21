using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.Extensions
{
    public static class EnumExtension
    {
        /// <summary>
        /// 获取枚举注释
        /// </summary>
        /// <param name=value></param>
        /// <returns></returns>
        public static string Description(this Enum value)
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? ((DescriptionAttribute)attributes[0]).Description : null;
        }

        /// <summary>
        /// 通过注释获取枚举值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int EnumIntValue<T>(this string str, int defaultValue = -1)
        {
            if (str.IsEmptyVal())
                return defaultValue;

            var dic = EnumToDictionary<T>();

            foreach (var item in dic)
            {
                if (str.EqualsNoCase(item.Value))
                    return item.Key;
            }
            return defaultValue;
        }

        /// <summary>
        /// 枚举转字典
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Dictionary<int, string> EnumToDictionary<T>()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            if (!typeof(T).IsEnum)
            {
                return dic;
            }
            string desc = string.Empty;
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                var attrs = item.GetType().GetField(item.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                {
                    DescriptionAttribute descAttr = attrs[0] as DescriptionAttribute;
                    desc = descAttr.Description;
                }
                dic.Add(Convert.ToInt32(item), desc);
            }
            return dic;
        }
    }
}