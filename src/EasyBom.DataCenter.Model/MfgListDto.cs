using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 厂商列表Dto
    /// </summary>
    public class MfgListDto
    {
        /// <summary>
        /// 厂商ID
        /// </summary>
        [JsonPropertyName("MfgID")]
        public int? MfgID { get; set; }

        /// <summary>
        /// 厂商名称
        /// </summary>
        [JsonPropertyName("MfgName")]
        public string MfgName { get; set; }

    }
}