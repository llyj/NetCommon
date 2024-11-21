using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class OrderParamItem
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonPropertyName("OrderId")]
        public int? OrderId { get; set; }

        /// <summary>
        /// 访客ID
        /// </summary>
        [JsonPropertyName("VisitorId")]
        public int? VisitorId { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [JsonPropertyName("CompanyId")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [JsonPropertyName("OrderTypes")]
        public string OrderTypes { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("OrderAmount")]
        public double? OrderAmount { get; set; }

        /// <summary>
        /// 来源设备类型
        /// </summary>
        [JsonPropertyName("Facility")]
        public string Facility { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [JsonPropertyName("OrderSource")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonPropertyName("ChannelSource")]
        public string ChannelSource { get; set; }

        /// <summary>
        /// 站点来源
        /// </summary>
        [JsonPropertyName("WebSource")]
        public string WebSource { get; set; }

        /// <summary>
        /// 公司归属
        /// </summary>
        [JsonPropertyName("CompanySource")]
        public string CompanySource { get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        [JsonPropertyName("PaymentTime")]
        public System.DateTimeOffset? PaymentTime { get; set; }

        /// <summary>
        /// 出库时间
        /// </summary>
        [JsonPropertyName("ShippingTime")]
        public System.DateTimeOffset? ShippingTime { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [JsonPropertyName("OrderTime")]
        public System.DateTimeOffset? OrderTime { get; set; }

        /// <summary>
        /// 额外备注
        /// </summary>
        [JsonPropertyName("Message")]
        public string Message { get; set; }

    }
}