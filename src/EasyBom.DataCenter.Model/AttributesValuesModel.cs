using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 属性值实体
    /// </summary>
    public class AttributesValuesModel
    {
        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Number")]
        public long? Number { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonPropertyName("Value")]
        public string Value { get; set; }

        /// <summary>
        /// 中文属性值
        /// </summary>
        [JsonPropertyName("ChineseValue")]
        public string ChineseValue { get; set; }

    }
}