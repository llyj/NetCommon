using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 图表数据实体
    /// </summary>
    public class ChartDataModel
    {
        /// <summary>
        /// 库存图表
        /// </summary>
        [JsonPropertyName("StockTrend")]
        public StockTrend StockTrend { get; set; }

        /// <summary>
        /// 价格图表
        /// </summary>
        [JsonPropertyName("PriceTrend")]
        public PriceTrend PriceTrend { get; set; }

        /// <summary>
        /// 地域热度
        /// </summary>
        [JsonPropertyName("AreaHots")]
        public List<AreaHot> AreaHots { get; set; }

    }
}