using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 品牌选型响应实体
    /// </summary>
    public class MFGRespModel
    {
        /// <summary>
        /// 品牌选型列表
        /// </summary>
        [JsonPropertyName("MFGs")]
        public List<MFGResp> MFGs { get; set; }

    }
}