using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_ParentCategoryRespModel
    {
        /// <summary>
        /// 父级分类产品列表
        /// </summary>
        [JsonPropertyName("ParentCategroyProducts")]
        public List<ParentCategroyProducts> ParentCategroyProducts { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("TotalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("TotalPage")]
        public int? TotalPage { get; set; }

    }
}