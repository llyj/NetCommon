using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NetCommon.Util
{
    /// <summary>
    /// 加密类
    /// </summary>
    public static class EncrypUtil
    {
        /// <summary>
        /// 字符串MD5加密
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string MD5Crypto(string input)
        {
            // 将字符串编码为字节数组
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // 初始化MD5加密提供者
            using (MD5 md5Hash = MD5.Create())
            {
                // 计算输入字符串的哈希值
                byte[] data = md5Hash.ComputeHash(inputBytes);

                // 创建StringBuilder以收集字节并创建字符串
                StringBuilder sBuilder = new StringBuilder();

                // 遍历哈希值的每个字节并格式化为十六进制字符串
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // 返回十六进制字符串
                return sBuilder.ToString();
            }
        }
    }
}