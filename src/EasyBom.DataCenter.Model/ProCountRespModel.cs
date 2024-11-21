using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 产品总条数响应实体
    /// </summary>
    public class ProCountRespModel
    {
        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("TotalCount")]
        public long? TotalCount { get; set; }

    }
}