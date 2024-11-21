using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 聚合实体
    /// </summary>
    public class CategoryAggregationModel
    {
        /// <summary>
        /// 一级聚合列表
        /// </summary>
        [JsonPropertyName("CategoryAggregationList")]
        public List<CategoryAggregationList> CategoryAggregationList { get; set; }

    }
}