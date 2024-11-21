using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_ProductsTempParam
    {
        /// <summary>
        /// 一级分类自定义名称
        /// </summary>
        [JsonPropertyName("ParentCustomName")]
        [Required(AllowEmptyStrings = true)]
        public string ParentCustomName { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("MFGs")]
        public List<string> MFGs { get; set; }

        /// <summary>
        /// 筛选属性列表
        /// </summary>
        [JsonPropertyName("Attributes")]
        public List<AttributeRequestModel> Attributes { get; set; }

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

    }
}