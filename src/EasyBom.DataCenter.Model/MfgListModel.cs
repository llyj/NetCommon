using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 厂商列表响应实体
    /// </summary>
    public class MfgListModel
    {
        /// <summary>
        /// 厂商列表
        /// </summary>
        [JsonPropertyName("MfgList")]
        public List<MfgListDto> MfgList { get; set; }

    }
}