using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class CrawlingRecordGPTModel
    {
        [JsonPropertyName("crawlingRecordGPTs")]
        public List<CrawlingRecordGPT> CrawlingRecordGPTs { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("TotalPage")]
        public long? TotalPage { get; set; }

        /// <summary>
        /// 列表总数
        /// </summary>
        [JsonPropertyName("TotalResult")]
        public long? TotalResult { get; set; }

    }
}