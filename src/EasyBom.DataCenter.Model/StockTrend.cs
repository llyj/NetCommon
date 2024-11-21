using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 库存走势
    /// </summary>
    public class StockTrend
    {
        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("stock")]
        public List<int> Stock { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("labels")]
        public List<long> Labels { get; set; }

    }
}