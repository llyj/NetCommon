using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class RedirectMfgModel
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        /// <summary>
        /// 制造商
        /// </summary>
        [JsonPropertyName("MfgName")]
        public string MfgName { get; set; }

        /// <summary>
        /// 标准名
        /// </summary>
        [JsonPropertyName("EnName")]
        public string EnName { get; set; }

    }
}