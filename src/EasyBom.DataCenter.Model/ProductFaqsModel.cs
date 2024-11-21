using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 产品问答实体
    /// </summary>
    public class ProductFaqsModel
    {
        /// <summary>
        /// 问题
        /// </summary>
        [JsonPropertyName("Question")]
        public string Question { get; set; }

        /// <summary>
        /// 回答
        /// </summary>
        [JsonPropertyName("Answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [JsonPropertyName("Link")]
        public string Link { get; set; }

    }
}