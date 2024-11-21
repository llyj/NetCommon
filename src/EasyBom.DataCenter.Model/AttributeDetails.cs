using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 属性列表
    /// </summary>
    public class AttributeDetails
    {
        /// <summary>
        /// 属性名
        /// </summary>
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonPropertyName("Values")]
        public List<string> Values { get; set; }

    }
}