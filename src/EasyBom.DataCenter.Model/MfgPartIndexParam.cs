using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 产品索引参数类
    /// </summary>
    public class MfgPartIndexParam
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 索引
        /// </summary>
        [JsonPropertyName("Index")]
        [Required(AllowEmptyStrings = true)]
        [StringLength(1)]
        [RegularExpression(@"[a-z0-9A-Z#]+")]
        public string Index { get; set; }

        /// <summary>
        /// 倍数
        /// </summary>
        [JsonPropertyName("Type")]
        public int? Type { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("PageIndex")]
        public int? PageIndex { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("PageSize")]
        public int? PageSize { get; set; }

    }
}