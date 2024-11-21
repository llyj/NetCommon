using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AllConversionToolsParam
    {
        /// <summary>
        /// 工具名称
        /// </summary>
        [JsonPropertyName("ToolName")]
        public string ToolName { get; set; }

    }
}