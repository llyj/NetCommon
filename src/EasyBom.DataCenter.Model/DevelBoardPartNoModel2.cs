using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 开发板关联型号
    /// </summary>
    public class DevelBoardPartNoModel2
    {
        /// <summary>
        /// 关联型号ID
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Package")]
        public string Package { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [JsonPropertyName("PicUrl")]
        public string PicUrl { get; set; }

        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

        [JsonPropertyName("Category")]
        public string Category { get; set; }

    }
}