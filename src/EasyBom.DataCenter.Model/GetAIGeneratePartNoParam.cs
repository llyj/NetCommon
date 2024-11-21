using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class GetAIGeneratePartNoParam
    {
        /// <summary>
        /// 起始日期
        /// </summary>
        [JsonPropertyName("StartDate")]
        public System.DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [JsonPropertyName("EndDate")]
        public System.DateTimeOffset? EndDate { get; set; }

        [JsonPropertyName("LastPID")]
        public int? LastPID { get; set; }

    }
}