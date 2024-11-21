using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class LnquiryParamItem
    {
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [JsonPropertyName("InquiryDetailId")]
        public int? InquiryDetailId { get; set; }

        /// <summary>
        /// 询盘ID
        /// </summary>
        [JsonPropertyName("InquiryId")]
        public int? InquiryId { get; set; }

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
        /// 活动ID
        /// </summary>
        [JsonPropertyName("ActivityId")]
        public int? ActivityId { get; set; }

        /// <summary>
        /// 零件名
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 产商名
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 产品库存
        /// </summary>
        [JsonPropertyName("PartNoNum")]
        public int? PartNoNum { get; set; }

        /// <summary>
        /// 询盘时间
        /// </summary>
        [JsonPropertyName("InquiryTime")]
        public System.DateTimeOffset? InquiryTime { get; set; }

        /// <summary>
        /// 是否有货
        /// </summary>
        [JsonPropertyName("IsStock")]
        public bool? IsStock { get; set; }

        /// <summary>
        /// 来源设备类型
        /// </summary>
        [JsonPropertyName("Facility")]
        public string Facility { get; set; }

        /// <summary>
        /// 询盘来源
        /// </summary>
        [JsonPropertyName("InquirySource")]
        public string InquirySource { get; set; }

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
        /// 额外备注
        /// </summary>
        [JsonPropertyName("Message")]
        public string Message { get; set; }

    }
}