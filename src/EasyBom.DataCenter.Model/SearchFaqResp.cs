using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SearchFaqResp
    {
        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("TotalCount")]
        public long? TotalCount { get; set; }

        [JsonPropertyName("SearchFaqRespModels")]
        public List<SearchFaqRespModel> SearchFaqRespModels { get; set; }

    }
}