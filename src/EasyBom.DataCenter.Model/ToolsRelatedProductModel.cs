using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ToolsRelatedProductModel
    {
        /// <summary>
        /// 相关商品列表
        /// </summary>
        [JsonPropertyName("RelatedProductInfos")]
        public List<RelatedProductInfo> RelatedProductInfos { get; set; }

        /// <summary>
        /// 相关商品URL
        /// </summary>
        [JsonPropertyName("RelatedPartUrlModels")]
        public List<RelatedPartUrlModel> RelatedPartUrlModels { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

    }
}