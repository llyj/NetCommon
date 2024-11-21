using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.ElasticSearch.Model
{
    public class IPStatisticsIndex
    {
        public string Date_IP { get; set; }

        public string IP { get; set; }

        public DateTime? CreateTime { get; set; }
        public int? Count { get; set; }
    }
}