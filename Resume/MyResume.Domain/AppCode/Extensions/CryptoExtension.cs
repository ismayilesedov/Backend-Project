﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyResume.Domain.AppCode.Extensions
{
    public static partial class Extension
    {
        const string saltKey = "!P513codeacademy";
        public static string ToMD5(this string value)
        {
            byte[] buffer = Encoding.UTF8.GetBytes($"{saltKey}{value}MyResume.Domain.AppCode");

            var provider = MD5.Create();

            return string.Join("", provider.ComputeHash(buffer).Select(s => s.ToString("x2")));
        }
      

        public static string Encrypt(this string value, string key, bool appliedUrlEncode = false)
        {
            try
            {
                using (var provider = new TripleDESCryptoServiceProvider())
                using (var md5 = new MD5CryptoServiceProvider())
                {
                    var keyBuffer = md5.ComputeHash(Encoding.UTF8.GetBytes($"#{key}!"));
                    var ivBuffer = md5.ComputeHash(Encoding.UTF8.GetBytes($"@{key}$"));

                    var transform = provider.CreateEncryptor(keyBuffer, ivBuffer);

                    using (var ms = new MemoryStream())
                    using (var cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                    {
                        var valueBuffer = Encoding.UTF8.GetBytes(value);

                        cs.Write(valueBuffer, 0, valueBuffer.Length);
                        cs.FlushFinalBlock();

                        ms.Position = 0;
                        var result = new byte[ms.Length];

                        ms.Read(result, 0, result.Length);

                        if (appliedUrlEncode)
                        {
                            return HttpUtility.UrlEncode(Convert.ToBase64String(result));
                        }

                        return Convert.ToBase64String(result);
                    }
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static string Decrypt(this string value, string key)
        {
            try
            {
                using (var provider = new TripleDESCryptoServiceProvider())
                using (var md5 = new MD5CryptoServiceProvider())
                {
                    var keyBuffer = md5.ComputeHash(Encoding.UTF8.GetBytes($"#{key}!"));
                    var ivBuffer = md5.ComputeHash(Encoding.UTF8.GetBytes($"@{key}$"));

                    var transform = provider.CreateDecryptor(keyBuffer, ivBuffer);

                    using (var ms = new MemoryStream())
                    using (var cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                    {
                        byte[] valueBuffer = Convert.FromBase64String(value);

                        cs.Write(valueBuffer, 0, valueBuffer.Length);
                        cs.FlushFinalBlock();

                        ms.Position = 0;
                        var result = new byte[ms.Length];

                        ms.Read(result, 0, result.Length);

                        return Encoding.UTF8.GetString(result);
                    }
                }
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
