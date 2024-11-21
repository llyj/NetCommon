using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 全部分类列表
    /// </summary>
    public class Info_AllCategory
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 自定义分类
        /// </summary>
        [JsonPropertyName("CustomName")]
        public string CustomName { get; set; }

        /// <summary>
        /// 标准化分类
        /// </summary>
        [JsonPropertyName("StandCategory")]
        public string StandCategory { get; set; }

        /// <summary>
        /// 分类名
        /// </summary>
        [JsonPropertyName("CategoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 是否展示
        /// </summary>
        [JsonPropertyName("IsShow")]
        public bool? IsShow { get; set; }

        /// <summary>
        /// 子分类
        /// </summary>
        [JsonPropertyName("Info_ChildCategories")]
        public List<Info_ChildCategory> Info_ChildCategories { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("TotalCount")]
        public long? TotalCount { get; set; }

        /// <summary>
        /// SEO标题
        /// </summary>
        [JsonPropertyName("SEOTitle")]
        public string SEOTitle { get; set; }

    }
}