using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 一级分类详情实体
    /// </summary>
    public class Info_CategoryDetail
    {
        /// <summary>
        /// 品牌
        /// </summary>
        [JsonPropertyName("Mfgs")]
        public List<Info_AggregateMfg> Mfgs { get; set; }

        /// <summary>
        /// 二级分类
        /// </summary>
        [JsonPropertyName("Categories")]
        public List<Info_ChildCategory> Categories { get; set; }

        /// <summary>
        /// 二级分类和聚合列表
        /// </summary>
        [JsonPropertyName("AggregationsModels")]
        public List<Info_AggregationsModel> AggregationsModels { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

        /// <summary>
        /// 父级分类信息
        /// </summary>
        [JsonPropertyName("Info_ParentCategory")]
        public Info_ParentCategory Info_ParentCategory { get; set; }

        /// <summary>
        /// 聚合信息
        /// </summary>
        [JsonPropertyName("Info_AggregationModel")]
        public Info_AggregationModel Info_AggregationModel { get; set; }

    }
}