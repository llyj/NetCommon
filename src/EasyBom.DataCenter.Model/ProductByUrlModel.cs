using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ProductByUrlModel
    {
        /// <summary>
        /// 主键 自增列 产品ID
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 制造商型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 制造商
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

    }
}