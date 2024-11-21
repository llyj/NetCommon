using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ProductByMFGAndCategoryParam
    {
        [JsonPropertyName("MFGIDs")]
        public List<int> MFGIDs { get; set; }

        [JsonPropertyName("ParentIDs")]
        public List<int> ParentIDs { get; set; }

        [JsonPropertyName("CategoryIDs")]
        public List<int> CategoryIDs { get; set; }

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

    }
}