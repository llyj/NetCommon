using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class UtmelProductIndexParam
    {
        /// <summary>
        /// 起始主键ID
        /// </summary>
        [JsonPropertyName("LastPID")]
        public int LastPID { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

    }
}