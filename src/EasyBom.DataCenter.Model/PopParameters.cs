using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 人气商品请求实体
    /// </summary>
    public class PopParameters
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryIDs")]
        public List<int> CategoryIDs { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("MFGIDs")]
        public List<int> MFGIDs { get; set; }

        /// <summary>
        /// 产品数量
        /// </summary>
        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("Page")]
        public int? Page { get; set; }

    }
}