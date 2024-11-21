using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class OrderDetailParamItem
    {
        /// <summary>
        /// 订单明细标识ID
        /// </summary>
        [JsonPropertyName("OrderItemId")]
        public int? OrderItemId { get; set; }

        /// <summary>
        /// 订单标识
        /// </summary>
        [JsonPropertyName("OrderId")]
        public int? OrderId { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [JsonPropertyName("ActivityId")]
        public int? ActivityId { get; set; }

        /// <summary>
        /// 是否为授权产商
        /// </summary>
        [JsonPropertyName("IsAuthorization")]
        public bool? IsAuthorization { get; set; }

        /// <summary>
        /// 型号名
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 产商名
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 询盘明细ID
        /// </summary>
        [JsonPropertyName("InquiryDetailId")]
        public int? InquiryDetailId { get; set; }

        /// <summary>
        /// 是否出库
        /// </summary>
        [JsonPropertyName("OutBoundStatus")]
        public bool? OutBoundStatus { get; set; }

        /// <summary>
        /// 零件数量
        /// </summary>
        [JsonPropertyName("PartNoNum")]
        public int? PartNoNum { get; set; }

        /// <summary>
        /// 型号报价金额(型号出库金额)
        /// </summary>
        [JsonPropertyName("QuotedPrice")]
        public double? QuotedPrice { get; set; }

        /// <summary>
        /// 是否付款
        /// </summary>
        [JsonPropertyName("PaymentStatus")]
        public bool? PaymentStatus { get; set; }

        /// <summary>
        /// 是否退换货
        /// </summary>
        [JsonPropertyName("SalesReturnBarter")]
        public bool? SalesReturnBarter { get; set; }

        /// <summary>
        /// 是否退款
        /// </summary>
        [JsonPropertyName("RefundStatus")]
        public bool? RefundStatus { get; set; }

        /// <summary>
        /// 额外备注
        /// </summary>
        [JsonPropertyName("Message")]
        public string Message { get; set; }

    }
}