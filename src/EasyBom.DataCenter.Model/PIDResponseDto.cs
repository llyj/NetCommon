using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class PIDResponseDto
    {
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        [JsonPropertyName("MID")]
        public int? MID { get; set; }

    }
}