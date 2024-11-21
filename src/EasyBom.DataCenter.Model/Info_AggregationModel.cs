using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_AggregationModel
    {
        /// <summary>
        /// 自定义名称
        /// </summary>
        [JsonPropertyName("CustomName")]
        public string CustomName { get; set; }

        /// <summary>
        /// 聚合名称
        /// </summary>
        [JsonPropertyName("AggregationName")]
        public string AggregationName { get; set; }

        /// <summary>
        /// SEO标题
        /// </summary>
        [JsonPropertyName("SEOTitle")]
        public string SEOTitle { get; set; }

    }
}