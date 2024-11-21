using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class GetDevelBoardDatailParameter
    {
        /// <summary>
        /// 开发板ID
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 开发板名称
        /// </summary>
        [JsonPropertyName("DevelName")]
        [Required(AllowEmptyStrings = true)]
        public string DevelName { get; set; }

        /// <summary>
        /// 开发板厂商
        /// </summary>
        [JsonPropertyName("MFG")]
        [Required(AllowEmptyStrings = true)]
        public string MFG { get; set; }

    }
}