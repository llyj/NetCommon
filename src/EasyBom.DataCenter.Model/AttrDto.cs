using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AttrDto
    {
        [JsonPropertyName("AttrName")]
        public string AttrName { get; set; }

        [JsonPropertyName("AttrValue")]
        public string AttrValue { get; set; }

    }
}