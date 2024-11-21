using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class PullProductIndexRespModel
    {
        /// <summary>
        /// 当前最后一位PID
        /// </summary>
        [JsonPropertyName("LastId")]
        public int? LastId { get; set; }

        /// <summary>
        /// 拉取产品索引列表
        /// </summary>
        [JsonPropertyName("PullProductIndexList")]
        public List<PullProductIndexModel> PullProductIndexList { get; set; }

    }
}