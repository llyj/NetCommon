using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 价格库存请求实体
    /// </summary>
    public class PriceStockRepModel
    {
        /// <summary>
        /// 压缩数据
        /// </summary>
        [JsonPropertyName("Data")]
        [Required(AllowEmptyStrings = true)]
        public string Data { get; set; }

        [JsonPropertyName("CrawlSource")]
        public string CrawlSource { get; set; }

    }
}