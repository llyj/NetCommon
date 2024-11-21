using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Huaqiang_DataParam
    {
        [JsonPropertyName("Huaqiang_Datas")]
        public List<Huaqiang_DataDto> Huaqiang_Datas { get; set; }

    }
}