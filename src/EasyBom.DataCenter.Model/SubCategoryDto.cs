using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 二级分类实体
    /// </summary>
    public class SubCategoryDto
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 父类ID
        /// </summary>
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

        /// <summary>
        /// 标准化分类名
        /// </summary>
        [JsonPropertyName("StandCategoryName")]
        public string StandCategoryName { get; set; }

        /// <summary>
        /// 自定义分类名
        /// </summary>
        [JsonPropertyName("CustomName")]
        public string CustomName { get; set; }

        /// <summary>
        /// 分类名
        /// </summary>
        [JsonPropertyName("CategoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 父类名
        /// </summary>
        [JsonPropertyName("ParentName")]
        public string ParentName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Number")]
        public int? Number { get; set; }

        /// <summary>
        /// 是否重复
        /// </summary>
        [JsonPropertyName("IsRepeat")]
        public bool? IsRepeat { get; set; }

        /// <summary>
        /// SEO标题
        /// </summary>
        [JsonPropertyName("SEOTitle")]
        public string SEOTitle { get; set; }

    }
}