using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class CrawlingRecordGoogleParam
    {
        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("Page")]
        public int? Page { get; set; }

        [JsonPropertyName("Urls")]
        public List<string> Urls { get; set; }

    }
}