using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SearchFaqParam
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("Page")]
        public int? Page { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 型号 支持模糊
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 归属 该条问答是否归属于我  0查全部/1查自己的/2查公共的
        /// </summary>
        [JsonPropertyName("IsMine")]
        public int? IsMine { get; set; }

        /// <summary>
        /// 审核/上架状态 0查全部/1已审核/2未审核
        /// </summary>
        [JsonPropertyName("AuditStatus")]
        public int? AuditStatus { get; set; }

        /// <summary>
        /// 时间排序  1升序/0降序
        /// </summary>
        [JsonPropertyName("SortByTime")]
        public int? SortByTime { get; set; }

    }
}