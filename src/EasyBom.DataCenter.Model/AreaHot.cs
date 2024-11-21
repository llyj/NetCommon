using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 地域热度
    /// </summary>
    public class AreaHot
    {
        /// <summary>
        /// 排行
        /// </summary>
        [JsonPropertyName("rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 热度
        /// </summary>
        [JsonPropertyName("hot")]
        public int? Hot { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("show")]
        public bool? Show { get; set; }

    }
}