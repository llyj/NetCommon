using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 新增订阅实体
    /// </summary>
    public class AddSubscribeModel
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonPropertyName("Email")]
        [Required(AllowEmptyStrings = true)]
        public string Email { get; set; }

    }
}