using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 参数实体
    /// </summary>
    public class Info_Parameter
    {
        /// <summary>
        /// 标准化分类名
        /// </summary>
        [JsonPropertyName("StandCategory")]
        public string StandCategory { get; set; }

    }
}