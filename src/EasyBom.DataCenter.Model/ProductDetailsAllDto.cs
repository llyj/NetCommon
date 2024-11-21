using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ProductDetailsAllDto
    {
        [JsonPropertyName("DatailsDto")]
        public DatailsModel DatailsDto { get; set; }

        [JsonPropertyName("RelatedProductDto")]
        public RelatedProductModelV2 RelatedProductDto { get; set; }

        [JsonPropertyName("OtherIncludeDto")]
        public OtherIncludeV2 OtherIncludeDto { get; set; }

        [JsonPropertyName("ReplacementDto")]
        public Replacements ReplacementDto { get; set; }

        [JsonPropertyName("PopProducts")]
        public List<PopProductsDto> PopProducts { get; set; }

        /// <summary>
        /// 重定向Model
        /// </summary>
        [JsonPropertyName("RedirectProductModel")]
        public RedirectProductModel RedirectProductModel { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

    }
}