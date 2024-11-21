﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class PartNoParam
    {
        /// <summary>
        /// 型号列表
        /// </summary>
        [JsonPropertyName("PartNoList")]
        public List<string> PartNoList { get; set; }

    }
}