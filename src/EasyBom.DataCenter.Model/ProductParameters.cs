using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 产品属性
    /// </summary>
    public class ProductParameters
    {
        /// <summary>
        /// 产品ID和型号参数
        /// </summary>
        [JsonPropertyName("ParametersPidPartNos")]
        public List<ParametersPidPartNos> ParametersPidPartNos { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

    }
}