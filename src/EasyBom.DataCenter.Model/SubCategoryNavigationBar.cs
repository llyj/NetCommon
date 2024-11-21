using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SubCategoryNavigationBar
    {
        /// <summary>
        /// 一级聚合名
        /// </summary>
        [JsonPropertyName("AggregationName")]
        public string AggregationName { get; set; }

        /// <summary>
        /// 一级聚合名(自定义)
        /// </summary>
        [JsonPropertyName("CustomAggregationName")]
        public string CustomAggregationName { get; set; }

        /// <summary>
        /// 一级聚合名(SEO标题)
        /// </summary>
        [JsonPropertyName("AggregationSEOTitle")]
        public string AggregationSEOTitle { get; set; }

        /// <summary>
        /// 一级分类名
        /// </summary>
        [JsonPropertyName("CategoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 一级分类名(自定义)
        /// </summary>
        [JsonPropertyName("CustomCategoryName")]
        public string CustomCategoryName { get; set; }

        /// <summary>
        /// 一级分类名(SEO标题)
        /// </summary>
        [JsonPropertyName("SEOTitle")]
        public string SEOTitle { get; set; }

        /// <summary>
        /// 二级聚合名
        /// </summary>
        [JsonPropertyName("SubAggregationName")]
        public string SubAggregationName { get; set; }

        /// <summary>
        /// 二级聚合名(自定义)
        /// </summary>
        [JsonPropertyName("CustomSubAggregationName")]
        public string CustomSubAggregationName { get; set; }

        /// <summary>
        /// 二级聚合名(SEO标题)
        /// </summary>
        [JsonPropertyName("SubAggregationSEOTitle")]
        public string SubAggregationSEOTitle { get; set; }

    }
}