using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 添加用户信息
    /// </summary>
    public class AddUserInfoModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [JsonPropertyName("Email")]
        [Required(AllowEmptyStrings = true)]
        public string Email { get; set; }

        [JsonPropertyName("Password")]
        [Required(AllowEmptyStrings = true)]
        public string Password { get; set; }

        /// <summary>
        /// 行业
        /// </summary>
        [JsonPropertyName("Industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 职业
        /// </summary>
        [JsonPropertyName("JobFunction")]
        public string JobFunction { get; set; }

        [JsonPropertyName("CID")]
        public string CID { get; set; }

    }
}