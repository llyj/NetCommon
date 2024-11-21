using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ProductRunDetail
    {
        /// <summary>
        /// 型号
        /// </summary>
        [JsonPropertyName("MfgPartNo")]
        [Required(AllowEmptyStrings = true)]
        public string MfgPartNo { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [JsonPropertyName("Mfg")]
        [Required(AllowEmptyStrings = true)]
        public string Mfg { get; set; }

        /// <summary>
        /// 询价数量
        /// </summary>
        [JsonPropertyName("InquiryFrequency")]
        public int InquiryFrequency { get; set; }

        /// <summary>
        /// 复盘数量
        /// </summary>
        [JsonPropertyName("ReviewFrequency")]
        public int ReviewFrequency { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        [JsonPropertyName("Sales")]
        public int Sales { get; set; }

        /// <summary>
        /// 销售额
        /// </summary>
        [JsonPropertyName("SaleAmount")]
        public double SaleAmount { get; set; }

        /// <summary>
        /// 销售人次
        /// </summary>
        [JsonPropertyName("SaleVisitors")]
        public int SaleVisitors { get; set; }

        /// <summary>
        /// 下单次数
        /// </summary>
        [JsonPropertyName("PlaceOrderFrequency")]
        public int PlaceOrderFrequency { get; set; }

        /// <summary>
        /// 删单次数
        /// </summary>
        [JsonPropertyName("DeleteOrderFrequency")]
        public int DeleteOrderFrequency { get; set; }

        /// <summary>
        /// 收藏量
        /// </summary>
        [JsonPropertyName("CollectFrequency")]
        public int CollectFrequency { get; set; }

        /// <summary>
        /// 复购
        /// </summary>
        [JsonPropertyName("Repurchase")]
        public int Repurchase { get; set; }

        /// <summary>
        /// 加购
        /// </summary>
        [JsonPropertyName("AddCartFrequency")]
        public int AddCartFrequency { get; set; }

        [JsonPropertyName("CreateTime")]
        [Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset CreateTime { get; set; }

    }
}