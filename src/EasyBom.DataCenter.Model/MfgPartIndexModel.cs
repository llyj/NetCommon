using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 产品索引返回实体
    /// </summary>
    public class MfgPartIndexModel
    {
        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("TotalPage")]
        public int? TotalPage { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("TotalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 索引列表
        /// </summary>
        [JsonPropertyName("CategoryProductIndexLists")]
        public List<CategoryProductIndexList> CategoryProductIndexLists { get; set; }

        /// <summary>
        /// 产品索引集合
        /// </summary>
        [JsonPropertyName("MfgPartIndexLists")]
        public List<MfgPartIndexList> MfgPartIndexLists { get; set; }

    }
}