using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 获取厂商下分类参数实体
    /// </summary>
    public class MfgCategoryParam
    {
        /// <summary>
        /// 厂商ID
        /// </summary>
        [JsonPropertyName("MfgID")]
        public int? MfgID { get; set; }

    }
}