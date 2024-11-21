using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// Utmel商城详情页实体
    /// </summary>
    public class DatailsModel
    {
        /// <summary>
        /// 产品信息
        /// </summary>
        [JsonPropertyName("ProductModel")]
        public ProductModel ProductModel { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

    }
}