using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_ReLoadSelectionModel
    {
        /// <summary>
        /// 属性选型
        /// </summary>
        [JsonPropertyName("AttributeSelections")]
        public List<Info_CategoryAttribute> AttributeSelections { get; set; }

        /// <summary>
        /// 品牌选型
        /// </summary>
        [JsonPropertyName("MfgSelections")]
        public List<Info_MfgSelection> MfgSelections { get; set; }

    }
}