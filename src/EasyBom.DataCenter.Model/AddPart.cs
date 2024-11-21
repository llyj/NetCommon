using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AddPart
    {
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

        /// <summary>
        /// 附件路径
        /// </summary>
        [JsonPropertyName("Datasheet_Url")]
        public string Datasheet_Url { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        [JsonPropertyName("Image_Url")]
        public string Image_Url { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        [JsonPropertyName("Attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        [JsonPropertyName("Category")]
        public string Category { get; set; }

    }
}