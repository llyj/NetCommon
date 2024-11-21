using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_AllManufacturers
    {
        /// <summary>
        /// 热门厂商
        /// </summary>
        [JsonPropertyName("Info_PopularManufacturers")]
        public List<Info_PopularManufacturers> Info_PopularManufacturers { get; set; }

        /// <summary>
        /// 全部厂商
        /// </summary>
        [JsonPropertyName("Info_Mfgs")]
        public List<Info_Mfgs> Info_Mfgs { get; set; }

    }
}