using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 品牌实体
    /// </summary>
    public class ManufacturerModel
    {
        /// <summary>
        /// 品牌列表
        /// </summary>
        [JsonPropertyName("ManufacturerLists")]
        public List<ManufacturerList> ManufacturerLists { get; set; }

    }
}