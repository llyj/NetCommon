using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class MfgPartIndexList
    {
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        [JsonPropertyName("EnName")]
        public string EnName { get; set; }

        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }

    }
}