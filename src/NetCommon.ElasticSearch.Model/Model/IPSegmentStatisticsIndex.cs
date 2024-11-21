using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetCommon.ElasticSearch.Model
{
    public class IPSegmentStatisticsIndex
    {
        public string Date_IPSegment { get; set; }
        /// <summary>
        /// IP段
        /// </summary>

        public string IPSegment { get; set; }

        /// <summary>
        /// 统计计数
        /// </summary>
        public int? Count { get; set; }

        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// type=0普通,type=2黑
        /// </summary>
        [JsonIgnore]
        public int? Type { get; set; }
    }
}