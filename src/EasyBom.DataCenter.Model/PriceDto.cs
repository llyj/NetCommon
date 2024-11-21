using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 价格参数
    /// </summary>
    public class PriceDto
    {
        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 截至时间
        /// </summary>
        [JsonPropertyName("Deadline")]
        [Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Deadline { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonPropertyName("StartingTime")]
        [Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset StartingTime { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonPropertyName("PIDs")]
        public List<string> PIDs { get; set; }

        /// <summary>
        /// 分销商价格库存ID
        /// </summary>
        [JsonPropertyName("SID")]
        public long SID { get; set; }

        /// <summary>
        /// 分销商列表
        /// </summary>
        [JsonPropertyName("Distributors")]
        public List<string> Distributors { get; set; }

        /// <summary>
        /// 型号列表
        /// </summary>
        [JsonPropertyName("MFGPartNos")]
        public List<string> MFGPartNos { get; set; }

    }
}