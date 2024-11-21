using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AggregationNavigationModel
    {
        /// <summary>
        /// 一级分类列表
        /// </summary>
        [JsonPropertyName("CategoryNavigationLists")]
        public List<AggregationNavigationList> CategoryNavigationLists { get; set; }

        /// <summary>
        /// 长度-用于前端排版
        /// </summary>
        [JsonPropertyName("Length")]
        public int? Length { get; set; }

    }
}