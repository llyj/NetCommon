using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 父级分类
    /// </summary>
    public class Info_ParentCategory
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 分类名
        /// </summary>
        [JsonPropertyName("CategoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 自定义分类名
        /// </summary>
        [JsonPropertyName("CustomName")]
        public string CustomName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Number")]
        public long? Number { get; set; }

        /// <summary>
        /// 分类描述
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// SEO标题
        /// </summary>
        [JsonPropertyName("SEOTitle")]
        public string SEOTitle { get; set; }

        /// <summary>
        /// 内容描述
        /// </summary>
        [JsonPropertyName("ContentDescription")]
        public string ContentDescription { get; set; }

    }
}