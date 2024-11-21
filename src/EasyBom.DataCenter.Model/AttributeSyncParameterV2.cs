using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AttributeSyncParameterV2
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
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("MFGID")]
        public List<int> MFGID { get; set; }

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
        /// 分销商ID
        /// </summary>
        [JsonPropertyName("DistributorIDs")]
        public List<int> DistributorIDs { get; set; }

        /// <summary>
        /// 属性名
        /// </summary>
        [JsonPropertyName("AttrName")]
        public string AttrName { get; set; }

        /// <summary>
        /// 聚合ID
        /// </summary>
        [JsonPropertyName("AggregationID")]
        public int? AggregationID { get; set; }

        /// <summary>
        /// 分销商详情页ID
        /// </summary>
        [JsonPropertyName("PageFiltrDistId")]
        public int? PageFiltrDistId { get; set; }

        /// <summary>
        /// isRoHS
        /// </summary>
        [JsonPropertyName("IsRoHS")]
        public bool? IsRoHS { get; set; }

    }
}