using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AttributesListModel
    {
        /// <summary>
        /// 属性英文名
        /// </summary>
        [JsonPropertyName("NameEnglish")]
        public string NameEnglish { get; set; }

        /// <summary>
        /// 属性中文名
        /// </summary>
        [JsonPropertyName("NameChinese")]
        public string NameChinese { get; set; }

    }
}