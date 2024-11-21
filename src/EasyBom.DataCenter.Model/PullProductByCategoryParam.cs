using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class PullProductByCategoryParam
    {
        /// <summary>
        /// 最后PID
        /// </summary>
        [JsonPropertyName("LastPid")]
        public int? LastPid { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 拉取数量
        /// </summary>
        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

    }
}