using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ToolModel
    {
        /// <summary>
        /// 工具名称
        /// </summary>
        [JsonPropertyName("ToolsName")]
        public string ToolsName { get; set; }

        /// <summary>
        /// 标准工具名称
        /// </summary>
        [JsonPropertyName("StandToolName")]
        public string StandToolName { get; set; }

        /// <summary>
        /// 图标路径
        /// </summary>
        [JsonPropertyName("IconPath")]
        public string IconPath { get; set; }

    }
}