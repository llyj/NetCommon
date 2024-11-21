using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 通用数据请求参数类
    /// </summary>
    public class DetailsParameter
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

        /// <summary>
        /// 控制数量
        /// </summary>
        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

    }
}