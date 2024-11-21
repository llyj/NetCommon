using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class RelatedParameter
    {
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

    }
}