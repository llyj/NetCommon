using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class FaqOwnershipRespModel
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        [JsonPropertyName("Code")]
        public FaqOwnershipRespModelCode? Code { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [JsonPropertyName("Message")]
        public string Message { get; set; }

    }
}