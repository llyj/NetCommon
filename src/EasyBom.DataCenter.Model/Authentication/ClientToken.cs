using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBom.DataCenter.Model
{
    public class ClientToken
    {
        /// <summary>
        /// Token
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        /// 刷新Token
        /// </summary>
        public string refresh_token { get; set; }

        /// <summary>
        /// Token类型
        /// </summary>
        public string token_type { get; set; } = "bearer";

        /// <summary>
        /// Token过期时间（s）默认为：5分钟
        /// </summary>
        public long expires_in { get; set; } = 5 * 60;
    }
}