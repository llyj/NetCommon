using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AttributesRespV2
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        /// <summary>
        /// 属性中文名
        /// </summary>
        [JsonPropertyName("NameChinese")]
        public string NameChinese { get; set; }

        /// <summary>
        /// 属性数量
        /// </summary>
        [JsonPropertyName("Number")]
        public long? Number { get; set; }

    }
}