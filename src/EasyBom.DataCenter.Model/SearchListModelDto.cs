using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 搜索列表实体
    /// </summary>
    public class SearchListModelDto
    {
        /// <summary>
        /// 搜索列表
        /// </summary>
        [JsonPropertyName("SearchListDtos")]
        public List<SearchListDtoModel> SearchListDtos { get; set; }

        /// <summary>
        /// 可替换商品
        /// </summary>
        [JsonPropertyName("ProReplacementModel")]
        public List<ProReplacementModel> ProReplacementModel { get; set; }

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