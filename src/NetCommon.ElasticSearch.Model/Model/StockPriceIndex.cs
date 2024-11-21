using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.ElasticSearch.Model
{
    /// <summary>
    /// 预处理平台产品价格 ??
    /// (不是库存价格 ??)
    /// </summary>
    public class StockPriceIndex : AbstractPrice
    {
        public string ID_Distributor { get; set; }

        public string Distributor { get; set; }

        public string PartNo { get; set; }

        public string MFG { get; set; }
        public int? MFGID { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}