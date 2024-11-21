using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 联想参数实体
    /// </summary>
    public class AssociationParameter
    {
        /// <summary>
        /// 关键字
        /// </summary>
        [JsonPropertyName("Keyword")]
        [Required(AllowEmptyStrings = true)]
        public string Keyword { get; set; }

        /// <summary>
        /// 分类ID集合
        /// </summary>
        [JsonPropertyName("CategoryIDs")]
        public List<int> CategoryIDs { get; set; }

        /// <summary>
        /// 品牌ID集合
        /// </summary>
        [JsonPropertyName("MFGIDs")]
        public List<int> MFGIDs { get; set; }

    }
}