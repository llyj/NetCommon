using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_SubcategoryDetails
    {
        /// <summary>
        /// 导航栏信息
        /// </summary>
        [JsonPropertyName("SubCategoryNavigationBar")]
        public SubCategoryNavigationBar SubCategoryNavigationBar { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [JsonPropertyName("Mfgs")]
        public List<Info_AggregateMfg> Mfgs { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

        /// <summary>
        /// 子分类信息
        /// </summary>
        [JsonPropertyName("Info_SubCateogry")]
        public Info_SubCateogry Info_SubCateogry { get; set; }

        /// <summary>
        /// 聚合信息
        /// </summary>
        [JsonPropertyName("Info_AggregationModel")]
        public Info_AggregationModel Info_AggregationModel { get; set; }

    }
}