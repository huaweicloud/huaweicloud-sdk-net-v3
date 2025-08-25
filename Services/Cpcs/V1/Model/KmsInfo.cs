using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class KmsInfo 
    {

        /// <summary>
        /// AES_256算法密钥数量
        /// </summary>
        [JsonProperty("aes_256", NullValueHandling = NullValueHandling.Ignore)]
        public int? Aes256 { get; set; }

        /// <summary>
        /// SM4算法密钥数量
        /// </summary>
        [JsonProperty("sm4", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sm4 { get; set; }

        /// <summary>
        /// RSA_2048算法密钥数量
        /// </summary>
        [JsonProperty("rsa_2048", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rsa2048 { get; set; }

        /// <summary>
        /// RSA_3072算法密钥数量
        /// </summary>
        [JsonProperty("rsa_3072", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rsa3072 { get; set; }

        /// <summary>
        /// RSA_4096算法密钥数量
        /// </summary>
        [JsonProperty("rsa_4096", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rsa4096 { get; set; }

        /// <summary>
        /// EC_P256算法密钥数量
        /// </summary>
        [JsonProperty("ec_p256", NullValueHandling = NullValueHandling.Ignore)]
        public int? EcP256 { get; set; }

        /// <summary>
        /// EC_P384务算法密钥数量
        /// </summary>
        [JsonProperty("ec_p384", NullValueHandling = NullValueHandling.Ignore)]
        public int? EcP384 { get; set; }

        /// <summary>
        /// SM2算法密钥数量
        /// </summary>
        [JsonProperty("sm2", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sm2 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KmsInfo {\n");
            sb.Append("  aes256: ").Append(Aes256).Append("\n");
            sb.Append("  sm4: ").Append(Sm4).Append("\n");
            sb.Append("  rsa2048: ").Append(Rsa2048).Append("\n");
            sb.Append("  rsa3072: ").Append(Rsa3072).Append("\n");
            sb.Append("  rsa4096: ").Append(Rsa4096).Append("\n");
            sb.Append("  ecP256: ").Append(EcP256).Append("\n");
            sb.Append("  ecP384: ").Append(EcP384).Append("\n");
            sb.Append("  sm2: ").Append(Sm2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KmsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KmsInfo input)
        {
            if (input == null) return false;
            if (this.Aes256 != input.Aes256 || (this.Aes256 != null && !this.Aes256.Equals(input.Aes256))) return false;
            if (this.Sm4 != input.Sm4 || (this.Sm4 != null && !this.Sm4.Equals(input.Sm4))) return false;
            if (this.Rsa2048 != input.Rsa2048 || (this.Rsa2048 != null && !this.Rsa2048.Equals(input.Rsa2048))) return false;
            if (this.Rsa3072 != input.Rsa3072 || (this.Rsa3072 != null && !this.Rsa3072.Equals(input.Rsa3072))) return false;
            if (this.Rsa4096 != input.Rsa4096 || (this.Rsa4096 != null && !this.Rsa4096.Equals(input.Rsa4096))) return false;
            if (this.EcP256 != input.EcP256 || (this.EcP256 != null && !this.EcP256.Equals(input.EcP256))) return false;
            if (this.EcP384 != input.EcP384 || (this.EcP384 != null && !this.EcP384.Equals(input.EcP384))) return false;
            if (this.Sm2 != input.Sm2 || (this.Sm2 != null && !this.Sm2.Equals(input.Sm2))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Aes256 != null) hashCode = hashCode * 59 + this.Aes256.GetHashCode();
                if (this.Sm4 != null) hashCode = hashCode * 59 + this.Sm4.GetHashCode();
                if (this.Rsa2048 != null) hashCode = hashCode * 59 + this.Rsa2048.GetHashCode();
                if (this.Rsa3072 != null) hashCode = hashCode * 59 + this.Rsa3072.GetHashCode();
                if (this.Rsa4096 != null) hashCode = hashCode * 59 + this.Rsa4096.GetHashCode();
                if (this.EcP256 != null) hashCode = hashCode * 59 + this.EcP256.GetHashCode();
                if (this.EcP384 != null) hashCode = hashCode * 59 + this.EcP384.GetHashCode();
                if (this.Sm2 != null) hashCode = hashCode * 59 + this.Sm2.GetHashCode();
                return hashCode;
            }
        }
    }
}
