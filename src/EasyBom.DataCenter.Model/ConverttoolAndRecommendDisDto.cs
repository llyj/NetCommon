using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ConverttoolAndRecommendDisDto
    {
        /// <summary>
        /// 换算工具集合
        /// </summary>
        [JsonPropertyName("ConversionTools")]
        public List<ToolModel> ConversionTools { get; set; }

        /// <summary>
        /// 分销商集合
        /// </summary>
        [JsonPropertyName("Distributors")]
        public List<DistributorDto> Distributors { get; set; }

    }
}