using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 品牌下父级分类实体
    /// </summary>
    public class Info_MfgParentCategorys
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("MfgID")]
        public int? MfgID { get; set; }

        /// <summary>
        /// 品牌名
        /// </summary>
        [JsonPropertyName("MfgName")]
        public string MfgName { get; set; }

        /// <summary>
        /// 品牌图标
        /// </summary>
        [JsonPropertyName("MfgIconPath")]
        public string MfgIconPath { get; set; }

        /// <summary>
        /// 品牌地址
        /// </summary>
        [JsonPropertyName("MfgUrl")]
        public string MfgUrl { get; set; }

        /// <summary>
        /// 父级分类名
        /// </summary>
        [JsonPropertyName("ParentCategory")]
        public List<string> ParentCategory { get; set; }

    }
}