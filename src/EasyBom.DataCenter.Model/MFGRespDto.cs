using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class MFGRespDto
    {
        /// <summary>
        /// 品牌选型列表
        /// </summary>
        [JsonPropertyName("MFGs")]
        public List<MFGResp> MFGs { get; set; }

    }
}