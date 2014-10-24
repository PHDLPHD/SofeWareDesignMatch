using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SDM.Code.Helper
{
    /// <summary>
    /// FTP帮助类
    /// </summary>
    public class FTPHelper
    {
        /// <summary>
        /// 文件位置
        /// </summary>
        private static string path;
        /// <summary>
        /// Uri
        /// </summary>
        private static string uri;
        /// <summary>
        /// 上传FTP文件
        /// </summary>
        /// <param name="filePath">上传文件位置</param>
        /// <param name="fileName">文件</param>
        /// <param name="ftpServerIP">FTP服务器IP</param>
        /// <param name="ftpUserID">FTP用户名</param>
        /// <param name="ftpPassword">FTP密码</param>
        /// <returns>true为上传成功,false为上传失败</returns>
        public static bool UpLoadFTP(string filePath, string fileName, string ftpServerIP, string ftpUserID, string ftpPassword)
        {
            path = filePath + "\\" + fileName;
            FileInfo fileInf = new FileInfo(path);
            uri = "ftp://" + ftpServerIP + "/" + fileInf.Name;
            FtpWebRequest fwr = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
            try
            {
                fwr.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                fwr.KeepAlive = false;
                fwr.Method = WebRequestMethods.Ftp.UploadFile;
                fwr.UseBinary = true;
                fwr.ContentLength = fileInf.Length;
                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentlen;
                FileStream fs = fileInf.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                Stream stm = fwr.GetRequestStream();
                contentlen = fs.Read(buff, 0, buffLength);
                while (contentlen != 0)
                {
                    stm.Write(buff, 0, contentlen);
                    contentlen = fs.Read(buff, 0, buffLength);
                }
                stm.Close();
                fs.Close();
                return true;
            }
            catch(Exception e)
            {
                fwr.Abort();
                return false;
            }
        }
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="filePath">保存文件路径</param>
        /// <param name="fileName">文件名</param>
        /// <param name="ftpServerIP">FTP服务器IP</param>
        /// <param name="ftpUserID">FTP用户ID</param>
        /// <param name="ftpPassword">密码</param>
        /// <returns>true为下载成功,false为下载失败</returns>
        public static bool DownloadFtp(string filePath,string fileName,string ftpServerIP,string ftpUserID,string ftpPassword)
        {
            FtpWebRequest fwr;
            try
            {
                path=filePath + "\\" + fileName;
                FileStream fs = new FileStream(path, FileMode.Create);
                uri = "ftp://" + ftpServerIP + "/" + fileName;
                fwr = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                fwr.Method = WebRequestMethods.Ftp.DownloadFile;
                fwr.UseBinary = true;
                fwr.KeepAlive = false;
                fwr.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)fwr.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer=new byte[bufferSize];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while(readCount>0)
                {
                    fs.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, readCount);
                }
                ftpStream.Close();
                fs.Close();
                response.Close();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
