using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class PdfPathParam
    {
        /// <summary>
        /// 原始pdf路径
        /// </summary>
        [JsonPropertyName("Path")]
        public string Path { get; set; }

    }
}