using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Store_Order_Detail
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonPropertyName("OrderId")]
        public int? OrderId { get; set; }

        /// <summary>
        /// 下单月份
        /// </summary>
        [JsonPropertyName("OrderMonth")]
        public string OrderMonth { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [JsonPropertyName("OrderTime")]
        public System.DateTimeOffset? OrderTime { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [JsonPropertyName("OrderType")]
        public string OrderType { get; set; }

        /// <summary>
        /// 客户是否首次下单
        /// </summary>
        [JsonPropertyName("FirstOrder")]
        public string FirstOrder { get; set; }

        /// <summary>
        /// 订单站点
        /// </summary>
        [JsonPropertyName("OrderWebsite")]
        public string OrderWebsite { get; set; }

        /// <summary>
        /// 是否作废
        /// </summary>
        [JsonPropertyName("CancellationStatus")]
        public string CancellationStatus { get; set; }

        /// <summary>
        /// 来源渠道
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
        /// 型号
        /// </summary>
        [JsonPropertyName("RequiredModel")]
        public string RequiredModel { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [JsonPropertyName("RequiredBrand")]
        public string RequiredBrand { get; set; }

        /// <summary>
        /// 年份
        /// </summary>
        [JsonPropertyName("QuotedYear")]
        public string QuotedYear { get; set; }

        /// <summary>
        /// 封装
        /// </summary>
        [JsonPropertyName("QuotedPackage")]
        public string QuotedPackage { get; set; }

        /// <summary>
        /// 交期
        /// </summary>
        [JsonPropertyName("DeliveryDate")]
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 数量
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
        [JsonPropertyName("OrderNumber")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// 售价（人民币-含税价）
        /// </summary>
        [JsonPropertyName("SalePrice")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 付款时间（订单第一次付款）
        /// </summary>
        [JsonPropertyName("PayTime")]
        public System.DateTimeOffset? PayTime { get; set; }

        /// <summary>
        /// 出库时间（订单第一次发货）
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