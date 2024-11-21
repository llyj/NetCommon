using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 品牌选型响应
    /// </summary>
    public class MFGResp
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        /// <summary>
        /// 制造商名称
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 制造商中文名
        /// </summary>
        [JsonPropertyName("ChineseMFG")]
        public string ChineseMFG { get; set; }

        /// <summary>
        /// 制造商数量
        /// </summary>
        [JsonPropertyName("MFGNumber")]
        public long? MFGNumber { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        [JsonPropertyName("MfgIconPath")]
        public string MfgIconPath { get; set; }

    }
}