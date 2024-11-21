using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 品牌选型参数实体
    /// </summary>
    public class MFGSyncParameter
    {
        /// <summary>
        /// 查询字段
        /// </summary>
        [JsonPropertyName("KeyWord")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 父级分类ID
        /// </summary>
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

        /// <summary>
        /// 是否精准
        /// </summary>
        [JsonPropertyName("IsPrecise")]
        public bool? IsPrecise { get; set; }

        /// <summary>
        /// 筛选属性列表
        /// </summary>
        [JsonPropertyName("Attributes")]
        public List<AttributeRequestModel> Attributes { get; set; }

        /// <summary>
        /// 品牌ID集合
        /// </summary>
        [JsonPropertyName("MFGIDs")]
        public List<int> MFGIDs { get; set; }

        /// <summary>
        /// 聚合ID
        /// </summary>
        [JsonPropertyName("AggregationID")]
        public int? AggregationID { get; set; }

    }
}