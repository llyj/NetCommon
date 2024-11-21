using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class UploadPIDParam
    {
        /// <summary>
        /// PID列表
        /// </summary>
        [JsonPropertyName("PIDs")]
        public List<int> PIDs { get; set; }

    }
}