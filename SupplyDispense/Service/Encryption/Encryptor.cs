using System;
using System.Linq;
using System.Security.Cryptography;

namespace SupplyDispense.Service.Encryption
{
    public static class Encryptor
    {
        public static string Encrypt(string pass)
        {
            return GetHash(CreateBufferf(pass));
        }

        private static byte[] CreateBufferf(string pass)
        {
            return pass.ToCharArray()
                .SelectMany(BitConverter.GetBytes)
                .ToArray();
        }

        private static string GetHash(byte[] buffer)
        {
            return BitConverter
                .ToString(new SHA1CryptoServiceProvider().ComputeHash(buffer))
                .Replace("-", "");
        }
    }
}