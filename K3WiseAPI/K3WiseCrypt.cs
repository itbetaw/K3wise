using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise
{
    /// <summary>
    /// K3WISE加密解密
    /// </summary>
    public class K3WiseCrypt
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Encrypt(string key, string data)
        {
            string retVal = string.Empty;
            byte[] rgbKey = System.Text.Encoding.UTF8.GetBytes(key);
            byte[] rgbIV = System.Text.Encoding.UTF8.GetBytes(key);
            byte[] source = System.Text.Encoding.UTF8.GetBytes(data);
            byte[] dealCrypt = null;
            //加密方式--DES
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            //填充模式--PKCS7
            provider.Padding = PaddingMode.PKCS7;
            //运算模式--ECB
            provider.Mode = CipherMode.ECB;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, provider.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write))
                {
                    cs.Write(source, 0, source.Length);
                    cs.FlushFinalBlock();
                }
                dealCrypt = ms.ToArray();
            }
            retVal = Convert.ToBase64String(dealCrypt);
            return retVal;
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Decrypt(string key, string data)
        {
            string retVal = string.Empty;
            byte[] rgbKey = System.Text.Encoding.UTF8.GetBytes(key);
            byte[] rgbIV = System.Text.Encoding.UTF8.GetBytes(key);
            byte[] encryptSource = Convert.FromBase64String(data);
            byte[] source = null;
            //解压
            source = encryptSource;
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            provider.Padding = PaddingMode.PKCS7;
            provider.Mode = CipherMode.ECB;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, provider.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write))
                {
                    cs.Write(source, 0, source.Length);
                    cs.FlushFinalBlock();
                }
                retVal = Encoding.UTF8.GetString(ms.ToArray());
            }
            return retVal;
        }
    }
}
