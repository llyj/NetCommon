using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SupplierPricePushParam
    {
        /// <summary>
        /// 型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [JsonPropertyName("StockNum")]
        public int? StockNum { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [JsonPropertyName("Price")]
        public double? Price { get; set; }

        /// <summary>
        /// 阶梯价
        /// </summary>
        [JsonPropertyName("Prices")]
        public string Prices { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Qty")]
        public int? Qty { get; set; }

        /// <summary>
        /// 库存来源
        /// </summary>
        [JsonPropertyName("StockNumSource")]
        public string StockNumSource { get; set; }

        /// <summary>
        /// 价格来源
        /// </summary>
        [JsonPropertyName("PriceSource")]
        public string PriceSource { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("Currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 供应商ID
        /// </summary>
        [JsonPropertyName("SupplierID")]
        public int? SupplierID { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonPropertyName("Updatetime")]
        public System.DateTimeOffset? Updatetime { get; set; }

    }
}