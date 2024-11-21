using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_CategoryAggDetail
    {
        /// <summary>
        /// 分类聚合
        /// </summary>
        [JsonPropertyName("Info_CategoryAgg")]
        public Info_CategoryAgg Info_CategoryAgg { get; set; }

        /// <summary>
        /// 分类列表
        /// </summary>
        [JsonPropertyName("Info_Categorys")]
        public List<Info_Category> Info_Categorys { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

    }
}