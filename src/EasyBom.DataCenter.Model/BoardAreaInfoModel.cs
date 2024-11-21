using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class BoardAreaInfoModel
    {
        /// <summary>
        /// 应用领域ID
        /// </summary>
        [JsonPropertyName("AreaID")]
        public int? AreaID { get; set; }

        /// <summary>
        /// 应用领域
        /// </summary>
        [JsonPropertyName("ApplicationArea")]
        public string ApplicationArea { get; set; }

    }
}