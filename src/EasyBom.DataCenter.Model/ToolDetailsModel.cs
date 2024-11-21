using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ToolDetailsModel
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
        /// 标准工具名称
        /// </summary>
        [JsonPropertyName("StandToolName")]
        public string StandToolName { get; set; }

        /// <summary>
        /// 工具类型
        /// </summary>
        [JsonPropertyName("ToolsType")]
        public string ToolsType { get; set; }

        /// <summary>
        /// 工具描述
        /// </summary>
        [JsonPropertyName("ToolsDescription")]
        public string ToolsDescription { get; set; }

        /// <summary>
        /// 图标路径
        /// </summary>
        [JsonPropertyName("IconPath")]
        public string IconPath { get; set; }

        /// <summary>
        /// 功能代码
        /// </summary>
        [JsonPropertyName("FunctionCode")]
        public string FunctionCode { get; set; }

        /// <summary>
        /// 样式代码
        /// </summary>
        [JsonPropertyName("StyleCode")]
        public string StyleCode { get; set; }

        /// <summary>
        /// 样式代码
        /// </summary>
        [JsonPropertyName("Code")]
        public string Code { get; set; }

        /// <summary>
        /// 关联分类
        /// </summary>
        [JsonPropertyName("Categorys")]
        public List<ToolLinkCategoryModel> Categorys { get; set; }

        /// <summary>
        /// 相关工具列表
        /// </summary>
        [JsonPropertyName("RelatedToolsModels")]
        public List<RelatedToolsModel> RelatedToolsModels { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonPropertyName("Contents")]
        public string Contents { get; set; }

    }
}