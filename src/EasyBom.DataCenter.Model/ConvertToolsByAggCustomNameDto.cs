using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ConvertToolsByAggCustomNameDto
    {
        /// <summary>
        /// 聚合ID
        /// </summary>
        [JsonPropertyName("AggregationID")]
        public int? AggregationID { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 换算工具数量
        /// </summary>
        [JsonPropertyName("ConvertToolLimit")]
        public int? ConvertToolLimit { get; set; }

        /// <summary>
        /// 分销商数量
        /// </summary>
        [JsonPropertyName("DistributorLimit")]
        public int? DistributorLimit { get; set; }

    }
}