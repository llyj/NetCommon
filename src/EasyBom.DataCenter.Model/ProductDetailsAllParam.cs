using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ProductDetailsAllParam
    {
        [JsonPropertyName("DetailsParameters")]
        public DetailsParameters DetailsParameters { get; set; }

        /// <summary>
        /// 相关产品
        /// </summary>
        [JsonPropertyName("RelatedProductCount")]
        [Range(0, 20)]
        public int? RelatedProductCount { get; set; }

        /// <summary>
        /// 联想产品
        /// </summary>
        [JsonPropertyName("AssociateProductCount")]
        [Range(0, 20)]
        public int? AssociateProductCount { get; set; }

        /// <summary>
        /// 人气热门产品数量
        /// </summary>
        [JsonPropertyName("PopProductCount")]
        [Range(0, 50)]
        public int? PopProductCount { get; set; }

    }
}