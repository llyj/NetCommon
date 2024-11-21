﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ProductNoPidParameters
    {
        /// <summary>
        /// 品牌
        /// </summary>
        [JsonPropertyName("MFG")]
        [Required(AllowEmptyStrings = true)]
        public string MFG { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        [Required(AllowEmptyStrings = true)]
        public string MFGPartNo { get; set; }

    }
}