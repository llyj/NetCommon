using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class PullProductByCategoryList
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 厂商ID
        /// </summary>
        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        /// <summary>
        /// 一级分类名称
        /// </summary>
        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

        /// <summary>
        /// 一级分类ID
        /// </summary>
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

        /// <summary>
        /// 二级分类名称
        /// </summary>
        [JsonPropertyName("Category")]
        public string Category { get; set; }

        /// <summary>
        /// 二级分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 属性列表
        /// </summary>
        [JsonPropertyName("Attributes")]
        public List<AttributesModel> Attributes { get; set; }

    }
}