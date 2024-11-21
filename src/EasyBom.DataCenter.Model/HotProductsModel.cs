using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 热门商品响应实体
    /// </summary>
    public class HotProductsModel
    {
        /// <summary>
        /// 热门商品列表
        /// </summary>
        [JsonPropertyName("HotProducts")]
        public List<HotProductsDto> HotProducts { get; set; }

        /// <summary>
        /// 图片后缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

        /// <summary>
        /// 产品总数
        /// </summary>
        [JsonPropertyName("TotalCount")]
        public long? TotalCount { get; set; }

    }
}