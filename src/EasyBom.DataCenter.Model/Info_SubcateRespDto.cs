using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_SubcateRespDto
    {
        /// <summary>
        /// 子分类产品列表
        /// </summary>
        [JsonPropertyName("Info_SubcateProducts")]
        public List<Info_SubcateProductModel> Info_SubcateProducts { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("TotalPage")]
        public long? TotalPage { get; set; }

        /// <summary>
        /// 列表总数
        /// </summary>
        [JsonPropertyName("TotalResult")]
        public long? TotalResult { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

    }
}