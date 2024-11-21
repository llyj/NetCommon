using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Store_Inquiry_Detail
    {
        /// <summary>
        /// 询盘id
        /// </summary>
        [JsonPropertyName("InquiryId")]
        public int InquiryId { get; set; }

        /// <summary>
        /// 询盘月份
        /// </summary>
        [JsonPropertyName("InquiryMonth")]
        [Required(AllowEmptyStrings = true)]
        public string InquiryMonth { get; set; }

        /// <summary>
        /// 询盘时间
        /// </summary>
        [JsonPropertyName("InquiryTime")]
        [Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset InquiryTime { get; set; }

        /// <summary>
        /// 客户是否首次询盘
        /// </summary>
        [JsonPropertyName("FirstInquiry")]
        public string FirstInquiry { get; set; }

        /// <summary>
        /// 询盘单号
        /// </summary>
        [JsonPropertyName("InquiryNumber")]
        [Required(AllowEmptyStrings = true)]
        public string InquiryNumber { get; set; }

        /// <summary>
        /// 询盘站点
        /// </summary>
        [JsonPropertyName("InquiryWebsite")]
        public string InquiryWebsite { get; set; }

        /// <summary>
        /// 询盘来源
        /// </summary>
        [JsonPropertyName("InquirySource")]
        public string InquirySource { get; set; }

        /// <summary>
        /// 是否作废
        /// </summary>
        [JsonPropertyName("CancellationStatus")]
        public string CancellationStatus { get; set; }

        /// <summary>
        /// 询价来源渠道
        /// </summary>
        [JsonPropertyName("SourceChannel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [JsonPropertyName("ChannelType")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 客户编码
        /// </summary>
        [JsonPropertyName("CustomerCode")]
        public string CustomerCode { get; set; }

        /// <summary>
        /// 客户等级
        /// </summary>
        [JsonPropertyName("CustomerLevel")]
        public string CustomerLevel { get; set; }

        /// <summary>
        /// 国家/地区
        /// </summary>
        [JsonPropertyName("Country")]
        public string Country { get; set; }

        /// <summary>
        /// 是否公共邮箱
        /// </summary>
        [JsonPropertyName("PublicEmail")]
        public string PublicEmail { get; set; }

        /// <summary>
        /// 查价状态
        /// </summary>
        [JsonPropertyName("PricingStatus")]
        [Required(AllowEmptyStrings = true)]
        public string PricingStatus { get; set; }

        /// <summary>
        /// 销售状态
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
        /// 品牌
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
        /// 目标价
        /// </summary>
        [JsonPropertyName("TargetPrice")]
        public double? TargetPrice { get; set; }

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

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonPropertyName("OrderState")]
        public string OrderState { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("OrderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单时间
        /// </summary>
        [JsonPropertyName("OrderTime")]
        public System.DateTimeOffset? OrderTime { get; set; }

        /// <summary>
        /// 售价（人民币-含税价）
        /// </summary>
        [JsonPropertyName("SalePrice")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 付款时间（询盘第一次付款）
        /// </summary>
        [JsonPropertyName("PayTime")]
        public System.DateTimeOffset? PayTime { get; set; }

        /// <summary>
        /// 出库时间（询盘第一次发货）
        /// </summary>
        [JsonPropertyName("DeliveryTime")]
        public System.DateTimeOffset? DeliveryTime { get; set; }

        /// <summary>
        /// 是否付款
        /// </summary>
        [JsonPropertyName("Ispay")]
        public string Ispay { get; set; }

        /// <summary>
        /// 是否出货
        /// </summary>
        [JsonPropertyName("IsOutbound")]
        public string IsOutbound { get; set; }

        /// <summary>
        /// 出库金额（人民币）
        /// </summary>
        [JsonPropertyName("OutboundPrice")]
        public double? OutboundPrice { get; set; }

        /// <summary>
        /// 行业应用
        /// </summary>
        [JsonPropertyName("IndustryApplication")]
        public string IndustryApplication { get; set; }

        /// <summary>
        /// 一级分类
        /// </summary>
        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

        /// <summary>
        /// 二级分类
        /// </summary>
        [JsonPropertyName("Category")]
        public string Category { get; set; }

    }
}