using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.ElasticSearch.Model.Config
{
    public class ElasticSearchConfig
    {
        /// <summary>
        /// 主机链接
        /// </summary>
        public string HostUrl { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>

        public string Password { get; set; }
    }
}