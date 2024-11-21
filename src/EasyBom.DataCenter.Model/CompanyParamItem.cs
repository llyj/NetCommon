using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class CompanyParamItem
    {
        /// <summary>
        /// 客户ID
        /// </summary>
        [JsonPropertyName("CompanyId")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// 客户类型
        /// </summary>
        [JsonPropertyName("CompanySort")]
        public string CompanySort { get; set; }

        /// <summary>
        /// 行业归属
        /// </summary>
        [JsonPropertyName("IndustryAffiliation")]
        public string IndustryAffiliation { get; set; }

        /// <summary>
        /// 主营产品
        /// </summary>
        [JsonPropertyName("MainProduct")]
        public string MainProduct { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonPropertyName("Country")]
        public string Country { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonPropertyName("Province")]
        public string Province { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("City")]
        public string City { get; set; }

        /// <summary>
        /// 企业市值/资产
        /// </summary>
        [JsonPropertyName("MarketCapitalization")]
        public int? MarketCapitalization { get; set; }

        /// <summary>
        /// 客户来源
        /// </summary>
        [JsonPropertyName("Source")]
        public string Source { get; set; }

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
        /// 客户创建时间
        /// </summary>
        [JsonPropertyName("CompanyCreateTime")]
        public System.DateTimeOffset? CompanyCreateTime { get; set; }

        /// <summary>
        /// 额外备注
        /// </summary>
        [JsonPropertyName("Message")]
        public string Message { get; set; }

    }
}