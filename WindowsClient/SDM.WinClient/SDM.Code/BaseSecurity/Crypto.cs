using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SDM.Code.BaseSecurity
{
    /// <summary>
    /// 加密类
    /// </summary>
    public class Crypto
    {
        /// <summary>
        /// 密钥
        /// </summary>
        private const string Key = "qJzGEh6hESZDVJeCnFPGuxzaiB7NLQM3";

        /// <summary>
        /// 矢量，矢量可以为空 
        /// </summary>
        private const string IV = "qcDY6X+aPLw=";

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="targetValue"></param>
        /// <returns></returns>
        public static string EncryptMD5(string value)
        {
            byte[] StrRes = Encoding.Default.GetBytes(value);
            HashAlgorithm iSHA = new MD5CryptoServiceProvider();
            StrRes = iSHA.ComputeHash(StrRes);
            StringBuilder EnText = new StringBuilder();
            foreach (byte iByte in StrRes)
            {
                EnText.AppendFormat("{0:x2}", iByte);
            }
            return EnText.ToString();
        }

        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="targetValue"></param>
        /// <returns></returns>
        public static string EncryptSHA1(string value)
        {
            byte[] StrRes = Encoding.Default.GetBytes(value);
            HashAlgorithm iSHA = new SHA1CryptoServiceProvider();
            StrRes = iSHA.ComputeHash(StrRes);
            StringBuilder EnText = new StringBuilder();
            foreach (byte iByte in StrRes)
            {
                EnText.AppendFormat("{0:x2}", iByte);
            }
            return EnText.ToString();
        }

        /// <summary>
        /// DES数据加密
        /// </summary>
        /// <param name="targetValue">目标值</param>
        /// <param name="key">密钥</param>
        /// <returns>加密值</returns>
        public static string EncryptDES(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            DESCryptoServiceProvider mCSP = new DESCryptoServiceProvider();
            mCSP.Key = Convert.FromBase64String(Key);
            mCSP.IV = Convert.FromBase64String(IV);
            //指定加密的运算模式 
            mCSP.Mode = System.Security.Cryptography.CipherMode.ECB;
            //获取或设置加密算法的填充模式 
            mCSP.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            ICryptoTransform ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV);
            byte[] byt = Encoding.Default.GetBytes(value);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
            cs.Write(byt, 0, byt.Length);
            cs.FlushFinalBlock();
            cs.Close();
            return Convert.ToBase64String(ms.ToArray());
        }



        /// <summary>
        /// DES数据解密
        /// </summary>
        /// <param name="targetValue"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string DecryptDES(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            DESCryptoServiceProvider mCSP = new DESCryptoServiceProvider();
            mCSP.Key = Convert.FromBase64String(Key);
            mCSP.IV = Convert.FromBase64String(IV);
            mCSP.Mode = System.Security.Cryptography.CipherMode.ECB;
            mCSP.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            ICryptoTransform ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV);
            byte[] byt = Convert.FromBase64String(value);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
            cs.Write(byt, 0, byt.Length);
            cs.FlushFinalBlock();
            cs.Close();
            return Encoding.Default.GetString(ms.ToArray());

        }

        /// <summary>
        /// 3DES加密
        /// </summary>
        /// <param name="targetValue"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Encrypt3DES(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            TripleDESCryptoServiceProvider mCSP = new TripleDESCryptoServiceProvider();
            mCSP.Key = Convert.FromBase64String(Key);
            mCSP.IV = Convert.FromBase64String(IV);
            //指定加密的运算模式 
            mCSP.Mode = System.Security.Cryptography.CipherMode.ECB;
            //获取或设置加密算法的填充模式 
            mCSP.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            ICryptoTransform ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV);
            byte[] byt = Encoding.Default.GetBytes(value);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
            cs.Write(byt, 0, byt.Length);
            cs.FlushFinalBlock();
            cs.Close();
            return Convert.ToBase64String(ms.ToArray());
        }

        /// <summary>
        /// 3DES解密
        /// </summary>
        /// <param name="targetValue"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decrypt3DES(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            TripleDESCryptoServiceProvider mCSP = new TripleDESCryptoServiceProvider();
            mCSP.Key = Convert.FromBase64String(Key);
            mCSP.IV = Convert.FromBase64String(IV);
            mCSP.Mode = System.Security.Cryptography.CipherMode.ECB;
            mCSP.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            ICryptoTransform ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV);
            byte[] byt = Convert.FromBase64String(value);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
            cs.Write(byt, 0, byt.Length);
            cs.FlushFinalBlock();
            cs.Close();
            return Encoding.Default.GetString(ms.ToArray());
        }
    }
}
