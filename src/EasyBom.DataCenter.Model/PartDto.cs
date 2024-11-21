using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class PartDto
    {
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Package")]
        public string Package { get; set; }

    }
}