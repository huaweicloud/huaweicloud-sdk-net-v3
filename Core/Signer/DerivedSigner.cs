using System;
using System.Text;
using System.Globalization;
using System.Security.Cryptography;
using System.IO;

namespace HuaweiCloud.SDK.Core
{
    public class DerivedSigner : Signer
    {
        const string V11HmacSha256 = "V11-HMAC-SHA256";

        public void Sign(HttpRequest request, string regionId, string derivedAuthServiceName)
        {
            if (string.IsNullOrEmpty(regionId))
            {
                throw new ArgumentException("regionId in credential is required when using derived auth");
            }
            if (string.IsNullOrEmpty(derivedAuthServiceName))
            {
                throw new ArgumentException("derivedAuthServiceName in credential is required when using derived auth");
            }
            // Add X-Sdk-Date
            var time = request.Headers.GetValues(HeaderXDate);
            DateTime t;
            if (time == null)
            {
                t = DateTime.Now;
                request.Headers.Add(HeaderXDate, t.ToUniversalTime().ToString(BasicDateFormat));
            }
            else
            {
                t = DateTime.ParseExact(time[0], BasicDateFormat, CultureInfo.CurrentCulture);
            }

            // Add Host header
            var host = request.Url.Host;
            if (request.Headers.GetValues(HeaderHost) != null)
            {
                host = request.Headers.GetValues(HeaderHost)?[0];
            }
            request.Headers.Set("host", host);

            // Create the string to sign
            var canonicalRequest = ConstructCanonicalRequest(request);
            string timeStamp = t.ToUniversalTime().ToString(BasicDateFormat);
            string info = timeStamp.Substring(0, 8) + "/" + regionId + "/" + derivedAuthServiceName;
            string stringToSign = StringToSign(canonicalRequest, timeStamp, info);

            // Calculate the signature
            var signedHeaders = ProcessSignedHeaders(request);
            string derivationKey = Hkdf.GetDerKeySha(Key, Secret, info);
            string signatureString = SignStringToSign(stringToSign, Encoding.UTF8.GetBytes(derivationKey));
            var authValue = $"{V11HmacSha256} Credential={Key}/{info}, SignedHeaders={string.Join(";", signedHeaders)}, Signature={signatureString}";
            request.Headers.Set(HeaderAuthorization, authValue);
        }

        string StringToSign(string canonicalRequest, string timeStamp, string info)
        {
            SHA256 sha256 = new SHA256Managed();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(canonicalRequest));
            sha256.Clear();
            return $"{V11HmacSha256}\n" +
                   $"{timeStamp}\n" +
                   $"{info}\n" +
                   $"{ToHexString(bytes)}";
        }

        static class Hkdf
        {
            private const string HmacSha1 = "HMACSHA1";

            private const string HmacSha256 = "HMACSHA256";

            private static readonly int DERIVATION_KEY_LENGTH = 32;

            private static readonly string HMAC_ALGORITHM = HmacSha256;

            private static readonly int AlgorithmHashLength = GetHashLen(HMAC_ALGORITHM);

            private static readonly int ExpandCeil = (int)Math.Ceiling(DERIVATION_KEY_LENGTH / (double)AlgorithmHashLength);

            public static string GetDerKeySha(string ak, string sk, string info)
            {
                if (string.IsNullOrEmpty(ak) || string.IsNullOrEmpty(sk))
                {
                    return null;
                }

                try
                {
                    byte[] tmpKey = Extract(ak, sk);
                    byte[] derSecretKey = Expend(tmpKey, Encoding.UTF8.GetBytes(info));
                    if (derSecretKey != null)
                    {
                        return ToHexString(derSecretKey);
                    }
                }
                catch (Exception exception)
                {
                    throw new ArgumentException("Failed to derive AK " + $"{ak}" + " with info " + $"{info}" + " .\n" + $"{exception.Message}");
                }
                return null;
            }

            private static byte[] Expend(byte[] prk, byte[] info)
            {
                HMAC hMacSha = HMAC.Create(HMAC_ALGORITHM);
                if (hMacSha == null)
                {
                    throw new ArgumentException("unknown in HMAC algorithm");
                }
                hMacSha.Key = prk;

                byte[] rawResult;
                if (ExpandCeil == 1)
                {
                    rawResult = ExpandFirst(info, hMacSha);
                }
                else
                {
                    rawResult = new byte[0];
                    byte[] temp = new byte[0];
                    for (int i = 1; i <= ExpandCeil; ++i)
                    {
                        temp = ExpandOnce(info, hMacSha, temp, i);
                        MemoryStream combineBytes = new MemoryStream();
                        combineBytes.Write(rawResult, 0, rawResult.Length);
                        combineBytes.Write(temp, 0, temp.Length);
                        rawResult = combineBytes.ToArray();
                    }
                }

                byte[] ret = null;
                if (DERIVATION_KEY_LENGTH <= rawResult.Length)
                {
                    ret = new byte[DERIVATION_KEY_LENGTH];
                    Array.Copy(rawResult, 0, ret, 0, Math.Min(DERIVATION_KEY_LENGTH, rawResult.Length));
                }
                return ret;
            }

            private static byte[] Extract(string ak, string sk)
            {
                HMAC hMacSha = HMAC.Create(HMAC_ALGORITHM);
                if (hMacSha == null)
                {
                    throw new ArgumentException("unknown in HMAC algorithm");
                }
                var akBytes = Encoding.UTF8.GetBytes(ak);
                var skBytes = Encoding.UTF8.GetBytes(sk);
                hMacSha.Key = akBytes;

                return hMacSha.ComputeHash(skBytes);
            }

            private static byte[] ExpandFirst(byte[] info, HMAC mac)
            {
                byte[] result = new byte[info.Length + 1];
                Array.Copy(info, 0, result, 0, info.Length);
                result[info.Length] = 0x01;
                return mac.ComputeHash(result);
            }

            private static byte[] ExpandOnce(byte[] info, HMAC mac, byte[] preTemp, int i)
            {
                MemoryStream hashBytes = new MemoryStream();
                hashBytes.Write(preTemp, 0, preTemp.Length);
                hashBytes.Write(info, 0, info.Length);
                hashBytes.WriteByte((byte)i);
                return mac.ComputeHash(hashBytes.ToArray());
            }

            private static string ToHexstring(byte[] data)
            {
                string hex = string.Empty;
                foreach (var b in data)
                {
                    hex += b.ToString("x2");
                }
                return hex;
            }

            private static int GetHashLen(string hmacAlgorithm)
            {
                switch (hmacAlgorithm)
                {
                    case HmacSha1:
                        return 20;
                    case HmacSha256:
                    default:
                        return 32;
                }
            }
        }
    }
}
