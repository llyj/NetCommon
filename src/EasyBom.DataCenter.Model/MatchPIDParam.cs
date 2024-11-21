using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class MatchPIDParam
    {
        /// <summary>
        /// 大于0表示匹配上映射品牌 大于0则查产品表，小于等于0查es
        /// </summary>
        [JsonPropertyName("MfgID")]
        public int? MfgID { get; set; }

        [JsonPropertyName("Mfg")]
        [Required(AllowEmptyStrings = true)]
        public string Mfg { get; set; }

        [JsonPropertyName("MfgPartNo")]
        [Required(AllowEmptyStrings = true)]
        public string MfgPartNo { get; set; }

    }
}