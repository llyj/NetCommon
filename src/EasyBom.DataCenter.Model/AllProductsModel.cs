using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AllProductsModel
    {
        /// <summary>
        /// 一级聚合导航
        /// </summary>
        [JsonPropertyName("CategoryAggregationList")]
        public List<CategoryAggregationList> CategoryAggregationList { get; set; }

        /// <summary>
        /// 聚合分类列表
        /// </summary>
        [JsonPropertyName("AllProductAggregationsLists")]
        public List<AllProductAggregationsList> AllProductAggregationsLists { get; set; }

    }
}