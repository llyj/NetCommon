using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SearchDevelBoardParameters
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
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryIDs")]
        public List<int> CategoryIDs { get; set; }

        /// <summary>
        /// 父级分类ID
        /// </summary>
        [JsonPropertyName("ParentIDs")]
        public List<int> ParentIDs { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("MFGIDs")]
        public List<int> MFGIDs { get; set; }

        /// <summary>
        /// 领域ID
        /// </summary>
        [JsonPropertyName("AreaIDs")]
        public List<int> AreaIDs { get; set; }

    }
}