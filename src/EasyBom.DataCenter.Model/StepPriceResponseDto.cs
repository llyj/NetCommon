using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class StepPriceResponseDto
    {
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("Stock")]
        public int? Stock { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [JsonPropertyName("Price")]
        public double? Price { get; set; }

        /// <summary>
        /// 价格来源
        /// </summary>
        [JsonPropertyName("PriceSource")]
        public string PriceSource { get; set; }

        /// <summary>
        /// 阶梯价
        /// </summary>
        [JsonPropertyName("StepPrice")]
        public List<PricingModel> StepPrice { get; set; }

        /// <summary>
        /// 货币
        /// </summary>
        [JsonPropertyName("Currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonPropertyName("ExpiredDateTime")]
        public System.DateTimeOffset? ExpiredDateTime { get; set; }

        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

    }
}