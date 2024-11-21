using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 二级分类实体
    /// </summary>
    public class Info_CategoryResp
    {
        /// <summary>
        /// 分类名
        /// </summary>
        [JsonPropertyName("Category")]
        public string Category { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Number")]
        public long? Number { get; set; }

    }
}