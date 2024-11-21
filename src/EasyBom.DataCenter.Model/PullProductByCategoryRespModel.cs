using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class PullProductByCategoryRespModel
    {
        /// <summary>
        /// 最后PID
        /// </summary>
        [JsonPropertyName("LastPid")]
        public int? LastPid { get; set; }

        /// <summary>
        /// 产品列表
        /// </summary>
        [JsonPropertyName("PullProductByCategoryLists")]
        public List<PullProductByCategoryList> PullProductByCategoryLists { get; set; }

    }
}