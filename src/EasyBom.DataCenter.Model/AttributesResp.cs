using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 属性响应实体
    /// </summary>
    public class AttributesResp
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        /// <summary>
        /// 属性数量
        /// </summary>
        [JsonPropertyName("Number")]
        public long? Number { get; set; }

        /// <summary>
        /// 属性值列表
        /// </summary>
        [JsonPropertyName("AttributesValues")]
        public List<AttributesValuesModel> AttributesValues { get; set; }

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