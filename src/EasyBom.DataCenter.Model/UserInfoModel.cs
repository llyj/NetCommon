using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 用户信息实体
    /// </summary>
    public class UserInfoModel
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("UserID")]
        public int? UserID { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonPropertyName("Email")]
        public string Email { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [JsonPropertyName("CompanyID")]
        public System.Guid? CompanyID { get; set; }

        [JsonPropertyName("CompanyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 分销商ID
        /// </summary>
        [JsonPropertyName("DistributorID")]
        public int? DistributorID { get; set; }

        /// <summary>
        /// 公司码
        /// </summary>
        [JsonPropertyName("Code")]
        public string Code { get; set; }

        /// <summary>
        /// 公司状态
        /// </summary>
        [JsonPropertyName("CompanyStatus")]
        public int? CompanyStatus { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        [JsonPropertyName("IsActivate")]
        public bool? IsActivate { get; set; }

        /// <summary>
        /// 是否跳转
        /// </summary>
        [JsonPropertyName("IsJump")]
        public bool? IsJump { get; set; }

    }
}