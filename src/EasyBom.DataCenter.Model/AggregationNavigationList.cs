using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AggregationNavigationList
    {
        /// <summary>
        /// 产品数量
        /// </summary>
        [JsonPropertyName("Number")]
        public long? Number { get; set; }

        /// <summary>
        /// 聚合名称
        /// </summary>
        [JsonPropertyName("CategoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 自定义名称
        /// </summary>
        [JsonPropertyName("CustomName")]
        public string CustomName { get; set; }

        /// <summary>
        /// SEO标题
        /// </summary>
        [JsonPropertyName("SEOTitle")]
        public string SEOTitle { get; set; }

        /// <summary>
        /// 是否为聚合
        /// </summary>
        [JsonPropertyName("IsAggregation")]
        public bool? IsAggregation { get; set; }

        /// <summary>
        /// 二级分类和聚合列表
        /// </summary>
        [JsonPropertyName("SubCategoryNavigationLists")]
        public List<SubCategoryNavigationList> SubCategoryNavigationLists { get; set; }

    }
}