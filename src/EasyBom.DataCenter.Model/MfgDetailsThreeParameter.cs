using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 品牌详情参数（3.0）
    /// </summary>
    public class MfgDetailsThreeParameter
    {
        /// <summary>
        /// 标准化品牌
        /// </summary>
        [JsonPropertyName("StandMfg")]
        [Required(AllowEmptyStrings = true)]
        public string StandMfg { get; set; }

        [JsonPropertyName("SeriesLimit")]
        public int? SeriesLimit { get; set; }

        [JsonPropertyName("RelatedProductLimit")]
        public int? RelatedProductLimit { get; set; }

        [JsonPropertyName("LatestProductLimit")]
        public int? LatestProductLimit { get; set; }

        [JsonPropertyName("AutDistributorLimit")]
        public int? AutDistributorLimit { get; set; }

    }
}