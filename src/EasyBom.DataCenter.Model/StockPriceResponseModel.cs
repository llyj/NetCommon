using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 价格库存响应实体
    /// </summary>
    public class StockPriceResponseModel
    {
        /// <summary>
        /// 最后一位ID
        /// </summary>
        [JsonPropertyName("LastID")]
        public int? LastID { get; set; }

        /// <summary>
        /// 库存价格列表
        /// </summary>
        [JsonPropertyName("StockPriceArray")]
        public List<StockPriceModel> StockPriceArray { get; set; }

    }
}