﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;

namespace NetCommon.Swagger
{
    /// <summary>
    /// Swagger 配置
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// token
        /// </summary>
        public string? AccessToken { get; set; }

        /// <summary>
        /// 接口项目名
        /// </summary>
        public string? WebApiProjectName { get; set; }

        /// <summary>
        /// 实体项目名
        /// </summary>
        public string? EntityProjectName { get; set; }
    }
}