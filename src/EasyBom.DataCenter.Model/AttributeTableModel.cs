using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 属性表格
    /// </summary>
    public class AttributeTableModel
    {
        /// <summary>
        /// 列表数据
        /// </summary>
        [JsonPropertyName("AttributeTables")]
        public List<AttributeTableDto> AttributeTables { get; set; }

        /// <summary>
        /// 属性表头
        /// </summary>
        [JsonPropertyName("AttributeNames")]
        public List<string> AttributeNames { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("TotalPage")]
        public long? TotalPage { get; set; }

        /// <summary>
        /// 列表总数
        /// </summary>
        [JsonPropertyName("TotalResult")]
        public long? TotalResult { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

    }
}