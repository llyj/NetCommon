using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 价格响应实体
    /// </summary>
    public class PriceResponseDto
    {
        /// <summary>
        /// 库存价格ID
        /// </summary>
        [JsonPropertyName("SID")]
        public long? SID { get; set; }

        /// <summary>
        /// 价格列表
        /// </summary>
        [JsonPropertyName("Prices")]
        public List<Prices> Prices { get; set; }

    }
}