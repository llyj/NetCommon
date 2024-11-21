using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 可替换产品
    /// </summary>
    public class Replacements
    {
        /// <summary>
        /// 产品列表
        /// </summary>
        [JsonPropertyName("ReplaceProducts")]
        public List<ReplaceProducts> ReplaceProducts { get; set; }

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

        /// <summary>
        /// 属性列表
        /// </summary>
        [JsonPropertyName("Attributes")]
        public List<AttributeDetails> Attributes { get; set; }

    }
}