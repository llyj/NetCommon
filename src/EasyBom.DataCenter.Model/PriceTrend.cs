using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 价格走势
    /// </summary>
    public class PriceTrend
    {
        /// <summary>
        /// 价格
        /// </summary>
        [JsonPropertyName("price")]
        public List<double> Price { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("labels")]
        public List<long> Labels { get; set; }

    }
}