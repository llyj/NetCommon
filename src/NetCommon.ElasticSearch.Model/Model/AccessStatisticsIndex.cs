using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.ElasticSearch.Model
{
    public class AccessStatisticsIndex
    {
        public string Date_IP_UserAgent { get; set; }
        public string IP { get; set; }

        /// <summary>
        /// IP前三段
        /// </summary>
        public string Date_IPSegment { get; set; }

        public string UserAgent { get; set; }
        public int? Count { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}