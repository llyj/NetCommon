using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AttributeRequestModel
    {
        /// <summary>
        /// 属性名
        /// </summary>
        [JsonPropertyName("AttributeName")]
        public string AttributeName { get; set; }

        /// <summary>
        /// 属性值列表
        /// </summary>
        [JsonPropertyName("AttributeValues")]
        public List<string> AttributeValues { get; set; }

    }
}