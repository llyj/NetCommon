using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 父子分类
    /// </summary>
    public class FatherSonCategory
    {
        /// <summary>
        /// 父分类名
        /// </summary>
        [JsonPropertyName("ParentCategoryName")]
        public string ParentCategoryName { get; set; }

        /// <summary>
        /// 子分类名
        /// </summary>
        [JsonPropertyName("CategoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 自定义名称
        /// </summary>
        [JsonPropertyName("CustomName")]
        public string CustomName { get; set; }

        /// <summary>
        /// 自定义名称
        /// </summary>
        [JsonPropertyName("SEOTitle")]
        public string SEOTitle { get; set; }

        /// <summary>
        /// 子标准分类名
        /// </summary>
        [JsonPropertyName("StandCategory")]
        public string StandCategory { get; set; }

        /// <summary>
        /// 父标准分类名
        /// </summary>
        [JsonPropertyName("ParentStandCategory")]
        public string ParentStandCategory { get; set; }

        /// <summary>
        /// 父自定义名称
        /// </summary>
        [JsonPropertyName("ParentCustomName")]
        public string ParentCustomName { get; set; }

        /// <summary>
        /// 父级自定义名称
        /// </summary>
        [JsonPropertyName("ParentSEOTitle")]
        public string ParentSEOTitle { get; set; }

    }
}