using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 品牌历程
    /// </summary>
    public class Info_BusinessHistory
    {
        /// <summary>
        /// 时间
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 买方名称
        /// </summary>
        [JsonPropertyName("buyerName")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 买方id
        /// </summary>
        [JsonPropertyName("buyerId")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 卖方名称
        /// </summary>
        [JsonPropertyName("sellerName")]
        public string SellerName { get; set; }

        /// <summary>
        /// 卖方id
        /// </summary>
        [JsonPropertyName("sellerId")]
        public string SellerId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// 离线链接
        /// </summary>
        [JsonPropertyName("offlineLink")]
        public string OfflineLink { get; set; }

        [JsonPropertyName("se_buyerId")]
        public string Se_buyerId { get; set; }

        [JsonPropertyName("se_sellerId")]
        public string Se_sellerId { get; set; }

    }
}