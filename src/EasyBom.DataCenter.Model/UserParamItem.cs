using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class UserParamItem
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [JsonPropertyName("CompanyId")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// 邮箱类别
        /// </summary>
        [JsonPropertyName("EmailType")]
        public string EmailType { get; set; }

        /// <summary>
        /// 用户来源
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
        /// 用户创建时间
        /// </summary>
        [JsonPropertyName("UserCreateTime")]
        public System.DateTimeOffset? UserCreateTime { get; set; }

        /// <summary>
        /// 额外备注
        /// </summary>
        [JsonPropertyName("Message")]
        public string Message { get; set; }

    }
}