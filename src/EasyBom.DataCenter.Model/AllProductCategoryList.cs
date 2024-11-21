using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 一级分类集合
    /// </summary>
    public class AllProductCategoryList
    {
        /// <summary>
        /// 分类名称
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
        /// 是否是聚合
        /// </summary>
        [JsonPropertyName("IsAggregation")]
        public bool? IsAggregation { get; set; }

        /// <summary>
        /// 二级分类集合
        /// </summary>
        [JsonPropertyName("AllProductSubCategoryList")]
        public List<AllProductSubCategoryList> AllProductSubCategoryList { get; set; }

    }
}