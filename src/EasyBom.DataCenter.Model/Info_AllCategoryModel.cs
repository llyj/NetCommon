using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 全部分类实体
    /// </summary>
    public class Info_AllCategoryModel
    {
        /// <summary>
        /// 分类列表
        /// </summary>
        [JsonPropertyName("Info_AllCategories")]
        public List<Info_AllCategory> Info_AllCategories { get; set; }

        /// <summary>
        /// 全部分类总数
        /// </summary>
        [JsonPropertyName("ResultCount")]
        public long? ResultCount { get; set; }

    }
}