using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 对比实体
    /// </summary>
    public class ComparisonModel
    {
        /// <summary>
        /// 对比产品
        /// </summary>
        [JsonPropertyName("ComparisonPros")]
        public List<ComparisonPro> ComparisonPros { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

        /// <summary>
        /// 属性名
        /// </summary>
        [JsonPropertyName("AttributeNames")]
        public List<string> AttributeNames { get; set; }

    }
}