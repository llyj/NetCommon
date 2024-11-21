using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AllManufacturersParam
    {
        /// <summary>
        /// 热门厂商数量
        /// </summary>
        [JsonPropertyName("PopularLimit")]
        public int? PopularLimit { get; set; }

    }
}