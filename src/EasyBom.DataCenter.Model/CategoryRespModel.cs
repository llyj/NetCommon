using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 分类选型响应实体
    /// </summary>
    public class CategoryRespModel
    {
        /// <summary>
        /// 分类选型列表
        /// </summary>
        [JsonPropertyName("CategoryResps")]
        public List<CategoryResp> CategoryResps { get; set; }

    }
}