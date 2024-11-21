using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 产品请求类
    /// </summary>
    public class ProductRequst
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }
    }
}