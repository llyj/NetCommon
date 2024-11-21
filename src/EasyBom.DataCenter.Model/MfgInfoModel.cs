using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class MfgInfoModel
    {
        /// <summary>
        /// 厂商ID
        /// </summary>
        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        /// <summary>
        /// 厂商名称
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

    }
}