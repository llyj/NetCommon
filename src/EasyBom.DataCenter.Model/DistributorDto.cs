using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class DistributorDto
    {
        /// <summary>
        /// 分销商id
        /// </summary>
        [JsonPropertyName("DistributorID")]
        public int? DistributorID { get; set; }

        /// <summary>
        /// 分销商名称
        /// </summary>
        [JsonPropertyName("DistributorName")]
        public string DistributorName { get; set; }

        /// <summary>
        /// 国家名称
        /// </summary>
        [JsonPropertyName("CountryName")]
        public string CountryName { get; set; }

        /// <summary>
        /// 分销商等级id
        /// </summary>
        [JsonPropertyName("DistributorGradeID")]
        public int? DistributorGradeID { get; set; }

        /// <summary>
        /// 分销商等级
        /// </summary>
        [JsonPropertyName("DistributorGrade")]
        public string DistributorGrade { get; set; }

        /// <summary>
        /// 分销商logo
        /// </summary>
        [JsonPropertyName("DistributorLogoUrl")]
        public string DistributorLogoUrl { get; set; }

        /// <summary>
        /// 分销商官方地址
        /// </summary>
        [JsonPropertyName("DistributorUrl")]
        public string DistributorUrl { get; set; }

        /// <summary>
        /// 是否是授权分销商
        /// </summary>
        [JsonPropertyName("ISAuthorizeddealer")]
        public bool? ISAuthorizeddealer { get; set; }

    }
}