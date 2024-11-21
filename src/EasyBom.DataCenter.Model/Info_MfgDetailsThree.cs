using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_MfgDetailsThree
    {
        /// <summary>
        /// 品牌详情
        /// </summary>
        [JsonPropertyName("MfgDetails")]
        public MfgDetailsThree MfgDetails { get; set; }

        /// <summary>
        /// 品牌历程
        /// </summary>
        [JsonPropertyName("BusinessHistorys")]
        public List<Info_BusinessHistory> BusinessHistorys { get; set; }

        /// <summary>
        /// 产品类别
        /// </summary>
        [JsonPropertyName("ProductCategories")]
        public List<MfgCategorys> ProductCategories { get; set; }

        /// <summary>
        /// 品牌相关产品
        /// </summary>
        [JsonPropertyName("Info_BrandRelateds")]
        public List<InfoProducts> Info_BrandRelateds { get; set; }

        /// <summary>
        /// 子品牌列表
        /// </summary>
        [JsonPropertyName("SubMfgList")]
        public List<string> SubMfgList { get; set; }

        /// <summary>
        /// 品牌相关系列
        /// </summary>
        [JsonPropertyName("SeriesList")]
        public List<SeriesModelDetails> SeriesList { get; set; }

        /// <summary>
        /// 品牌最新产品
        /// </summary>
        [JsonPropertyName("Info_LatestProducts")]
        public List<InfoProducts> Info_LatestProducts { get; set; }

        /// <summary>
        /// 分销商集合
        /// </summary>
        [JsonPropertyName("DistributorsList")]
        public List<DistributorDto> DistributorsList { get; set; }

    }
}