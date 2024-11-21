﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 属性表格属性列表
    /// </summary>
    public class QueryAttributeModel
    {
        /// <summary>
        /// 属性名
        /// </summary>
        [JsonPropertyName("AttributeName")]
        public string AttributeName { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonPropertyName("AttributeValue")]
        public string AttributeValue { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [JsonPropertyName("Sort")]
        public int? Sort { get; set; }

        /// <summary>
        /// 类型ID
        /// </summary>
        [JsonPropertyName("TypeID")]
        public int? TypeID { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonPropertyName("TypeName")]
        public string TypeName { get; set; }

    }
}