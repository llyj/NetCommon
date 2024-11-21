using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class DevelBoardDetailsModel2
    {
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 开发板名称
        /// </summary>
        [JsonPropertyName("DevelName")]
        public string DevelName { get; set; }

        /// <summary>
        /// 厂商名称
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        [JsonPropertyName("AttributeDetails")]
        public List<AttributeList> AttributeDetails { get; set; }

        /// <summary>
        /// PDF列表
        /// </summary>
        [JsonPropertyName("PdfList")]
        public List<DevelBoardPdf> PdfList { get; set; }

        /// <summary>
        /// 关联型号列表
        /// </summary>
        [JsonPropertyName("PartNoList")]
        public List<DevelBoardPartNoModel2> PartNoList { get; set; }

    }
}