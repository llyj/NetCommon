using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class GPTResultModel
    {
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        [JsonPropertyName("GPTReturnValue")]
        public string GPTReturnValue { get; set; }

    }
}