using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SearchFaqRespModel
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [JsonPropertyName("ID")]
        public int? ID { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 审核/上架状态
        /// </summary>
        [JsonPropertyName("AuditStatus")]
        public bool? AuditStatus { get; set; }

        /// <summary>
        /// 是否是我的
        /// </summary>
        [JsonPropertyName("IsMine")]
        public bool? IsMine { get; set; }

        /// <summary>
        /// 问答
        /// </summary>
        [JsonPropertyName("FaqModels")]
        public FaqModels FaqModels { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("UpdateTime")]
        public System.DateTimeOffset? UpdateTime { get; set; }

    }
}