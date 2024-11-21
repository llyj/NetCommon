using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 二级分类响应实体
    /// </summary>
    public class Info_CategoryRespModel
    {
        /// <summary>
        /// 二级分类列表
        /// </summary>
        [JsonPropertyName("Info_CategoryResps")]
        public List<Info_CategoryResp> Info_CategoryResps { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("TotalCount")]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 父级分类
        /// </summary>
        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

    }
}