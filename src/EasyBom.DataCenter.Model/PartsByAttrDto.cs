using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class PartsByAttrDto
    {
        [JsonPropertyName("Parts")]
        public List<PartDto> Parts { get; set; }

        [JsonPropertyName("Pdfs")]
        public List<PdfDto> Pdfs { get; set; }

    }
}