using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_CateRespModel
    {
        /// <summary>
        /// 产品列表
        /// </summary>
        [JsonPropertyName("Products")]
        public List<Info_Products> Products { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("TotalPage")]
        public long? TotalPage { get; set; }

        /// <summary>
        /// 列表总数
        /// </summary>
        [JsonPropertyName("TotalResult")]
        public long? TotalResult { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

    }
}