using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SubmitFaqParam
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
        [Required(AllowEmptyStrings = true)]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 问答实体
        /// </summary>
        [JsonPropertyName("FaqModels")]
        public FaqModels FaqModels { get; set; }

        /// <summary>
        /// 审核/上架状态
        /// </summary>
        [JsonPropertyName("AuditStatus")]
        public bool? AuditStatus { get; set; }

    }
}