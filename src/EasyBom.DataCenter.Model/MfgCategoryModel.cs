using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 厂商下分类信息返回实体
    /// </summary>
    public class MfgCategoryModel
    {
        /// <summary>
        /// 厂商ID
        /// </summary>
        [JsonPropertyName("MfgID")]
        public int? MfgID { get; set; }

        /// <summary>
        /// 一级分类列表
        /// </summary>
        [JsonPropertyName("ParentCategoryDtos")]
        public List<ParentCategoryDto> ParentCategoryDtos { get; set; }

    }
}