using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 资源文件实体
    /// </summary>
    public class ResFileModel
    {
        /// <summary>
        /// PDF类型名
        /// </summary>
        [JsonPropertyName("TypeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// 资源文件列表
        /// </summary>
        [JsonPropertyName("ResFiles")]
        public List<ResFileDto> ResFiles { get; set; }

    }
}