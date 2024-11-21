using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class StepPriceModel
    {
        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Qty")]
        public int? Qty { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [JsonPropertyName("Price")]
        public double? Price { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        [JsonPropertyName("Discount")]
        public double? Discount { get; set; }

    }
}