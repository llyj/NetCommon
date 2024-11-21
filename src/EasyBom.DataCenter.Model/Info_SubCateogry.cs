using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_SubCateogry
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
        /// 自定义名
        /// </summary>
        [JsonPropertyName("CustomName")]
        public string CustomName { get; set; }

        /// <summary>
        /// 父级分类ID
        /// </summary>
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

        /// <summary>
        /// 父级分类名
        /// </summary>
        [JsonPropertyName("ParentCategoryName")]
        public string ParentCategoryName { get; set; }

        /// <summary>
        /// 父级自定义名
        /// </summary>
        [JsonPropertyName("ParentCustomName")]
        public string ParentCustomName { get; set; }

        /// <summary>
        /// 父级SEOTitle
        /// </summary>
        [JsonPropertyName("ParentSEOTitle")]
        public string ParentSEOTitle { get; set; }

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
        /// 是否重复
        /// </summary>
        [JsonPropertyName("IsRepeat")]
        public bool? IsRepeat { get; set; }

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