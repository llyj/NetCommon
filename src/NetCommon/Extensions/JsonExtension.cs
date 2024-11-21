using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using NetCommon.JsonConverters;

namespace NetCommon.Extensions
{
    /// <summary>
    /// Json扩展类
    /// </summary>
    public static class JsonExtension
    {
        public static JsonSerializerOptions DefaultJsonSerializerOptions => new JsonSerializerOptions()
        {
            AllowTrailingCommas = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, // 忽略null值的属性
            PropertyNameCaseInsensitive = true, //忽略大小写
            //PropertyNamingPolicy = JsonNamingPolicy.CamelCase, // 驼峰式
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping, // 序列化中文时的编码问题
            Converters = { new DateTimeConverter(), new NullableDateTimeConverter() }
            //Converters.Add(new DateTimeConverter()),
            //Converters.Add(new NullableDateTimeConverter()),
        };

        /// <summary>
        /// object to json
        /// </summary>
        /// <param name=obj></param>
        /// <returns></returns>
        public static string ToJson(this object obj)
        {
            if (obj == null)
                return string.Empty;

            try
            {
                var res = JsonSerializer.Serialize(obj, DefaultJsonSerializerOptions);
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// json to entity
        /// </summary>
        /// <typeparam name=T></typeparam>
        /// <param name=json></param>
        /// <returns></returns>
        public static T ToEntity<T>(this string json)
        {
            if (string.IsNullOrEmpty(json))
                return default(T);

            try
            {
                var res = JsonSerializer.Deserialize<T>(json, DefaultJsonSerializerOptions);
                return res;
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}