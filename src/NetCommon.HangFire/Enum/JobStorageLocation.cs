using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.HangFire.Enum
{
    /// <summary>
    /// 任务存储位置
    /// </summary>
    public enum JobStorageLocation
    {
        /// <summary>
        /// SqlServer
        /// </summary>
        [Description("SqlServer")]
        SqlServer = 1,

        /// <summary>
        /// MySQL
        /// </summary>
        [Description("MySQL")]
        MySQL = 2,

        /// <summary>
        /// Redis
        /// </summary>
        [Description("Redis")]
        Redis = 3
    }
}