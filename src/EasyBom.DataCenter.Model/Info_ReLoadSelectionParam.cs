﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_ReLoadSelectionParam
    {
        /// <summary>
        /// 父级分类ID
        /// </summary>
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("MFGs")]
        public List<string> MFGs { get; set; }

        /// <summary>
        /// 属性名列表
        /// </summary>
        [JsonPropertyName("AttributeNames")]
        public List<string> AttributeNames { get; set; }

        /// <summary>
        /// 筛选属性列表
        /// </summary>
        [JsonPropertyName("Attributes")]
        public List<AttributeRequestModel> Attributes { get; set; }

    }
}