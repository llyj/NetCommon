using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 一级分类实体
    /// </summary>
    public class ParentCategoryDto
    {
        /// <summary>
        /// 父级分类名
        /// </summary>
        [JsonPropertyName("ParentName")]
        public string ParentName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Number")]
        public long? Number { get; set; }

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
        /// 二级分类列表
        /// </summary>
        [JsonPropertyName("Info_MfgCategorys")]
        public List<SubCategoryDto> Info_MfgCategorys { get; set; }

    }
}