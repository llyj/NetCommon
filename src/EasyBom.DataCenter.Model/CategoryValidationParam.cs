using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class CategoryValidationParam
    {
        /// <summary>
        /// 标准化名称
        /// </summary>
        [JsonPropertyName("StandCategory")]
        public string StandCategory { get; set; }

    }
}