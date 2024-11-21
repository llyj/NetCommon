using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 人气商品实体
    /// </summary>
    public class PopularPartsModel
    {
        /// <summary>
        /// 人气商品列表
        /// </summary>
        [JsonPropertyName("PopularPartsLists")]
        public List<PopularPartsList> PopularPartsLists { get; set; }

    }
}