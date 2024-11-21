using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 其他商品实体
    /// </summary>
    public class OtherInclude
    {
        /// <summary>
        /// 产品列表
        /// </summary>
        [JsonPropertyName("Products")]
        public List<Products> Products { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [JsonPropertyName("Keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// 产品数量
        /// </summary>
        [JsonPropertyName("ProductCount")]
        public int? ProductCount { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

    }
}