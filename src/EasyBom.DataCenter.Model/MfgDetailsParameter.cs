using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 品牌详情参数
    /// </summary>
    public class MfgDetailsParameter
    {
        /// <summary>
        /// 标准化品牌
        /// </summary>
        [JsonPropertyName("StandMfg")]
        [Required(AllowEmptyStrings = true)]
        public string StandMfg { get; set; }

    }
}