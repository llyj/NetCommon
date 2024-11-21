using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class RedirectProductModel
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 制造商型号 dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("PartNo")]
        public string PartNo { get; set; }

        /// <summary>
        /// 制造商
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

    }
}