using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 人气商品
    /// </summary>
    public class PopProductsModel
    {
        /// <summary>
        /// 人气商品列表
        /// </summary>
        [JsonPropertyName("PopProducts")]
        public List<PopProductsDto> PopProducts { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

    }
}