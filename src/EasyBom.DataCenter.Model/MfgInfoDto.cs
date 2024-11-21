using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class MfgInfoDto
    {
        [JsonPropertyName("MfgID")]
        public int? MfgID { get; set; }

        [JsonPropertyName("MfgName")]
        public string MfgName { get; set; }

        [JsonPropertyName("Alias")]
        public string Alias { get; set; }

    }
}