using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 前缀型号联想查询请求实体
    /// </summary>
    public class AssociateParameter
    {
        /// <summary>
        /// 联想关键字
        /// </summary>
        [JsonPropertyName("PrePartNo")]
        [Required(AllowEmptyStrings = true)]
        public string PrePartNo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

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