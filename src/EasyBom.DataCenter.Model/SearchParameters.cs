using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SearchParameters
    {
        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("Page")]
        public int? Page { get; set; }

        /// <summary>
        /// 查询字段
        /// </summary>
        [JsonPropertyName("KeyWord")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 是否有库存 无分销商价格列表可不传
        /// </summary>
        [JsonPropertyName("IsStockNum")]
        public bool? IsStockNum { get; set; }

        /// <summary>
        /// 是否精准
        /// </summary>
        [JsonPropertyName("IsPrecise")]
        public bool? IsPrecise { get; set; }

        /// <summary>
        /// 是否需要展示可替换
        /// </summary>
        [JsonPropertyName("IsReplaceable")]
        public bool? IsReplaceable { get; set; }

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
        /// 筛选属性列表
        /// </summary>
        [JsonPropertyName("Attributes")]
        public List<AttributeRequestModel> Attributes { get; set; }

        /// <summary>
        /// 权重分值
        /// </summary>
        [JsonPropertyName("Factor")]
        public double? Factor { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonPropertyName("Country")]
        public string Country { get; set; }

        /// <summary>
        /// 分销商ID
        /// </summary>
        [JsonPropertyName("DistributorID")]
        public List<int> DistributorID { get; set; }

        /// <summary>
        /// 是否允许分类为未定义
        /// </summary>
        [JsonPropertyName("IsCategoryUndefined")]
        public bool? IsCategoryUndefined { get; set; }

    }
}