using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 相关商品实体[替代10个，热门搜索20个]
    /// </summary>
    public class RelatedProductModel
    {
        /// <summary>
        /// 替代零件，10个
        /// </summary>
        [JsonPropertyName("RelatedProductInfos")]
        public List<RelatedProductInfo> RelatedProductInfos { get; set; }

        /// <summary>
        /// 热门搜索，随机20个
        /// </summary>
        [JsonPropertyName("RelatedPartUrlModels")]
        public List<RelatedPartUrlModel> RelatedPartUrlModels { get; set; }

        /// <summary>
        /// 零件别名列表
        /// </summary>
        [JsonPropertyName("AlternatePartNos")]
        public List<string> AlternatePartNos { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

    }
}