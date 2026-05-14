using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ReEncryptResponse : SdkResponse
    {

        /// <summary>
        /// 重新加密时使用的密钥ID
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 加密原密文时使用的密钥ID
        /// </summary>
        [JsonProperty("source_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceKeyId { get; set; }

        /// <summary>
        /// 原密文加密时使用的加密算法
        /// </summary>
        [JsonProperty("source_encryption_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceEncryptionAlgorithm { get; set; }

        /// <summary>
        /// 重新加密时使用的加密算法
        /// </summary>
        [JsonProperty("destination_encryption_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationEncryptionAlgorithm { get; set; }

        /// <summary>
        /// 重新加密后的密文
        /// </summary>
        [JsonProperty("cipher_text", NullValueHandling = NullValueHandling.Ignore)]
        public string CipherText { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReEncryptResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  sourceKeyId: ").Append(SourceKeyId).Append("\n");
            sb.Append("  sourceEncryptionAlgorithm: ").Append(SourceEncryptionAlgorithm).Append("\n");
            sb.Append("  destinationEncryptionAlgorithm: ").Append(DestinationEncryptionAlgorithm).Append("\n");
            sb.Append("  cipherText: ").Append(CipherText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReEncryptResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReEncryptResponse input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.SourceKeyId != input.SourceKeyId || (this.SourceKeyId != null && !this.SourceKeyId.Equals(input.SourceKeyId))) return false;
            if (this.SourceEncryptionAlgorithm != input.SourceEncryptionAlgorithm || (this.SourceEncryptionAlgorithm != null && !this.SourceEncryptionAlgorithm.Equals(input.SourceEncryptionAlgorithm))) return false;
            if (this.DestinationEncryptionAlgorithm != input.DestinationEncryptionAlgorithm || (this.DestinationEncryptionAlgorithm != null && !this.DestinationEncryptionAlgorithm.Equals(input.DestinationEncryptionAlgorithm))) return false;
            if (this.CipherText != input.CipherText || (this.CipherText != null && !this.CipherText.Equals(input.CipherText))) return false;

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
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.SourceKeyId != null) hashCode = hashCode * 59 + this.SourceKeyId.GetHashCode();
                if (this.SourceEncryptionAlgorithm != null) hashCode = hashCode * 59 + this.SourceEncryptionAlgorithm.GetHashCode();
                if (this.DestinationEncryptionAlgorithm != null) hashCode = hashCode * 59 + this.DestinationEncryptionAlgorithm.GetHashCode();
                if (this.CipherText != null) hashCode = hashCode * 59 + this.CipherText.GetHashCode();
                return hashCode;
            }
        }
    }
}
