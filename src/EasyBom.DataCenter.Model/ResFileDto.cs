using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ResFileDto
    {
        /// <summary>
        /// 资源文件名称
        /// </summary>
        [JsonPropertyName("ResName")]
        public string ResName { get; set; }

        /// <summary>
        /// 资源文件url
        /// </summary>
        [JsonPropertyName("ResUrl")]
        public string ResUrl { get; set; }

        /// <summary>
        /// 资源文件类型
        /// </summary>
        [JsonPropertyName("ResType")]
        public string ResType { get; set; }

    }
}