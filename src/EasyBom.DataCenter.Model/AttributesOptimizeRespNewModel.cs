using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// uteml新属性选型响应实体
    /// </summary>
    public class AttributesOptimizeRespNewModel
    {
        [JsonPropertyName("AttributesName")]
        public List<AttributesListModel> AttributesName { get; set; }

    }
}