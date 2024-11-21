using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.ElasticSearch.Model
{
    /// <summary>
    /// 整合后平台产品价格
    /// </summary>
    public class ProductPriceIndex : AbstractPrice
    {
        public string ID_Distributor { get; set; }

        public string Distributor { get; set; }

        public string PartNo { get; set; }

        public string MFG { get; set; }
        public int? MFGID { get; set; }

        public DateTime? CreateTime { get; set; }
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 拿货周期
        /// </summary>
        public string LeadTime { get; set; } = "";
    }
}