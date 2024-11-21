using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_CategoryAgg
    {
        /// <summary>
        /// 聚合ID
        /// </summary>
        [JsonPropertyName("AggregationID")]
        public int? AggregationID { get; set; }

        /// <summary>
        /// 聚合名
        /// </summary>
        [JsonPropertyName("AggregationName")]
        public string AggregationName { get; set; }

        /// <summary>
        /// 自定义聚合名
        /// </summary>
        [JsonPropertyName("CustomName")]
        public string CustomName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Number")]
        public long? Number { get; set; }

        /// <summary>
        /// 聚合描述
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// SEO标题
        /// </summary>
        [JsonPropertyName("SEOTitle")]
        public string SEOTitle { get; set; }

        /// <summary>
        /// SEO关键字
        /// </summary>
        [JsonPropertyName("SEOKeyword")]
        public string SEOKeyword { get; set; }

        /// <summary>
        /// SEO描述
        /// </summary>
        [JsonPropertyName("SEODescription")]
        public string SEODescription { get; set; }

        /// <summary>
        /// 内容描述
        /// </summary>
        [JsonPropertyName("ContentDescription")]
        public string ContentDescription { get; set; }

    }
}