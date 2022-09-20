using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public class Encryptions
    {
        public string GetMD5X(string inputStr)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //先将字符串转换成字节数组
            byte[] buffer = Encoding.Default.GetBytes(inputStr);
            byte[] Md5Buffer = md5.ComputeHash(buffer);
            //将字节数组转换成字符串
            string str = "";
            for (int i = 0; i < Md5Buffer.Length; i++)
            {
                str += Md5Buffer[i].ToString("x");
            }
            return str;
        }

        public string GetMD5X2(string inputStr)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //先将字符串转换成字节数组
            byte[] buffer = Encoding.Default.GetBytes(inputStr);
            byte[] Md5Buffer = md5.ComputeHash(buffer);
            //将字节数组转换成字符串
            string str = "";
            for (int i = 0; i < Md5Buffer.Length; i++)
            {
                str += Md5Buffer[i].ToString("x2");
            }
            return str;
        }


        public string DESEncrypt(string originalValue, string key, string iv)
        {
            using (DESCryptoServiceProvider sa
                = new DESCryptoServiceProvider { Key = Encoding.UTF8.GetBytes(key), IV = Encoding.UTF8.GetBytes(iv) })
            {
                using (ICryptoTransform ct = sa.CreateEncryptor())
                {
                    byte[] by = Encoding.UTF8.GetBytes(originalValue);
                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                        {
                            cs.Write(by, 0, by.Length);
                            cs.FlushFinalBlock();
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }

                }


            }
        }

        public string DESDecrypt(string encryptedValue, string key, string iv)
        {
            using (DESCryptoServiceProvider sa = new DESCryptoServiceProvider
            { Key = Encoding.UTF8.GetBytes(key), IV = Encoding.UTF8.GetBytes(iv) })
            {
                using (ICryptoTransform ct = sa.CreateDecryptor())
                {
                    byte[] byt = Convert.FromBase64String(encryptedValue);

                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                        {
                            cs.Write(byt, 0, byt.Length);
                            cs.FlushFinalBlock();
                        }
                        return Encoding.UTF8.GetString(ms.ToArray());
                    }
                }
            }
        }
    }
}
