using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.Helper
{
    public class SftpHelper
    {
        private readonly SftpClient _sftpClient;

        public SftpHelper(SftpClient item)
        {
            _sftpClient = item;
            _sftpClient.Connect();
        }

        ~SftpHelper()
        {
            _sftpClient.Disconnect();
            _sftpClient.Dispose();
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="localPath">本文件路径</param>
        /// <param name="remotePath">ftp文件路径</param>
        public void UploadFile(string localPath, string remotePath)
        {
            using (var fileStream = new FileStream(localPath, FileMode.Open))
                _sftpClient.UploadFile(fileStream, remotePath);
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="remotePath">ftp文件路径</param>
        /// <param name="localPath">本文件路径</param>
        public void DownloadFile(string remotePath, string localPath)
        {
            using (var fileStream = new FileStream(localPath, FileMode.Create))
                _sftpClient.DownloadFile(remotePath, fileStream);
        }

        /// <summary>
        /// 创建文件目录
        /// </summary>
        /// <param name="remotePath"></param>
        public void CreateDirectory(string remotePath)
        {
            _sftpClient.CreateDirectory(remotePath);
        }
    }
}