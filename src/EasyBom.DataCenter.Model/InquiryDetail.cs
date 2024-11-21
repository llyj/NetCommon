using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class InquiryDetail
    {
        /// <summary>
        /// 询盘Id
        /// </summary>
        [JsonPropertyName("InquiryId")]
        public int InquiryId { get; set; }

        /// <summary>
        /// 询盘时间
        /// </summary>
        [JsonPropertyName("InquiryTime")]
        [Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset InquiryTime { get; set; }

        /// <summary>
        /// 询盘单号
        /// </summary>
        [JsonPropertyName("InquiryNumber")]
        [Required(AllowEmptyStrings = true)]
        public string InquiryNumber { get; set; }

        /// <summary>
        /// 是否作废
        /// </summary>
        [JsonPropertyName("CancellationStatus")]
        [Required(AllowEmptyStrings = true)]
        public string CancellationStatus { get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [JsonPropertyName("SourceChannel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [JsonPropertyName("CustomerID")]
        public int CustomerID { get; set; }

        /// <summary>
        /// 客户等级
        /// </summary>
        [JsonPropertyName("CustomerLevel")]
        public string CustomerLevel { get; set; }

        /// <summary>
        /// 国家/地区
        /// </summary>
        [JsonPropertyName("Country")]
        [Required(AllowEmptyStrings = true)]
        public string Country { get; set; }

        /// <summary>
        /// 邮箱状态
        /// </summary>
        [JsonPropertyName("EmailDomain")]
        public string EmailDomain { get; set; }

        /// <summary>
        /// 查价状态
        /// </summary>
        [JsonPropertyName("PricingStatus")]
        [Required(AllowEmptyStrings = true)]
        public string PricingStatus { get; set; }

        /// <summary>
        /// 售后状态
        /// </summary>
        [JsonPropertyName("SalesStatus")]
        [Required(AllowEmptyStrings = true)]
        public string SalesStatus { get; set; }

        /// <summary>
        /// 需求型号
        /// </summary>
        [JsonPropertyName("RequiredModel")]
        [Required(AllowEmptyStrings = true)]
        public string RequiredModel { get; set; }

        /// <summary>
        /// 需求品牌
        /// </summary>
        [JsonPropertyName("RequiredBrand")]
        public string RequiredBrand { get; set; }

        /// <summary>
        /// 需求年份
        /// </summary>
        [JsonPropertyName("RequiredYear")]
        public string RequiredYear { get; set; }

        /// <summary>
        /// 需求封装
        /// </summary>
        [JsonPropertyName("RequiredPackage")]
        public string RequiredPackage { get; set; }

        /// <summary>
        /// 需求数量
        /// </summary>
        [JsonPropertyName("RequiredQuantity")]
        public int? RequiredQuantity { get; set; }

        /// <summary>
        /// 需求交期
        /// </summary>
        [JsonPropertyName("RequiredDate")]
        public string RequiredDate { get; set; }

        /// <summary>
        /// 报价型号
        /// </summary>
        [JsonPropertyName("QuotedModel")]
        public string QuotedModel { get; set; }

        /// <summary>
        /// 报价品牌
        /// </summary>
        [JsonPropertyName("QuotedBrand")]
        public string QuotedBrand { get; set; }

        /// <summary>
        /// 报价年份
        /// </summary>
        [JsonPropertyName("QuotedYear")]
        public string QuotedYear { get; set; }

        /// <summary>
        /// 报价封装
        /// </summary>
        [JsonPropertyName("QuotedPackage")]
        public string QuotedPackage { get; set; }

        /// <summary>
        /// 交期
        /// </summary>
        [JsonPropertyName("DeliveryDate")]
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 报价数量
        /// </summary>
        [JsonPropertyName("QuotedQuantity")]
        public int? QuotedQuantity { get; set; }

    }
}