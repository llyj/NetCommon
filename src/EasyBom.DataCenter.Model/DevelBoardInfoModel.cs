using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 开发板基本信息
    /// </summary>
    public class DevelBoardInfoModel
    {
        /// <summary>
        /// 开发板ID
        /// </summary>
        [JsonPropertyName("KID")]
        public int? KID { get; set; }

        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 开发板名称
        /// </summary>
        [JsonPropertyName("DevelName")]
        public string DevelName { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 短描述
        /// </summary>
        [JsonPropertyName("ShortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// 开发板图片链接
        /// </summary>
        [JsonPropertyName("PicUrl")]
        public string PicUrl { get; set; }

    }
}