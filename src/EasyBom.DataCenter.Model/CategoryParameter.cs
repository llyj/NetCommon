using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 获取分类面包屑请求实体
    /// </summary>
    public class CategoryParameter
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

    }
}