using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ToolMenus
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [JsonPropertyName("ID")]
        public int? ID { get; set; }

        /// <summary>
        /// 工具名称
        /// </summary>
        [JsonPropertyName("ToolsName")]
        public string ToolsName { get; set; }

        /// <summary>
        /// 工具类型
        /// </summary>
        [JsonPropertyName("ToolsType")]
        public string ToolsType { get; set; }

        /// <summary>
        /// 标准工具名称
        /// </summary>
        [JsonPropertyName("StandToolName")]
        public string StandToolName { get; set; }

        /// <summary>
        /// 工具图标
        /// </summary>
        [JsonPropertyName("IconPath")]
        public string IconPath { get; set; }

    }
}