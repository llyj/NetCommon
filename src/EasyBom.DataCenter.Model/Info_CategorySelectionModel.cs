using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_CategorySelectionModel
    {
        /// <summary>
        /// 属性选型
        /// </summary>
        [JsonPropertyName("AttributeSelections")]
        public List<Info_CategoryAttribute> AttributeSelections { get; set; }

        /// <summary>
        /// 属性名列表
        /// </summary>
        [JsonPropertyName("AddAttributeList")]
        public List<Info_AddAttributeList> AddAttributeList { get; set; }

    }
}