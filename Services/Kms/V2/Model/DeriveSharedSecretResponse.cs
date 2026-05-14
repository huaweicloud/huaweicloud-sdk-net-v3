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
    public class DeriveSharedSecretResponse : SdkResponse
    {

        /// <summary>
        /// 密钥ID
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 密钥协商算法
        /// </summary>
        [JsonProperty("key_agreement_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyAgreementAlgorithm { get; set; }

        /// <summary>
        /// 由KMS私钥和您的对端公钥协商出的密钥，Base64格式，如果响应体包含了ciphertext_recipient，则不会包含shared_secret
        /// </summary>
        [JsonProperty("shared_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string SharedSecret { get; set; }

        /// <summary>
        /// KMS私钥和您的对端公钥协商出的密钥经过擎天证明文档加密后的密文，密文仅能被机密环境中的私钥解密，指定擎天证明文档后，才会响应ciphertext_recipient，否则通过shared_secret响应明文的共享密钥
        /// </summary>
        [JsonProperty("ciphertext_recipient", NullValueHandling = NullValueHandling.Ignore)]
        public string CiphertextRecipient { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeriveSharedSecretResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  keyAgreementAlgorithm: ").Append(KeyAgreementAlgorithm).Append("\n");
            sb.Append("  sharedSecret: ").Append(SharedSecret).Append("\n");
            sb.Append("  ciphertextRecipient: ").Append(CiphertextRecipient).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeriveSharedSecretResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeriveSharedSecretResponse input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.KeyAgreementAlgorithm != input.KeyAgreementAlgorithm || (this.KeyAgreementAlgorithm != null && !this.KeyAgreementAlgorithm.Equals(input.KeyAgreementAlgorithm))) return false;
            if (this.SharedSecret != input.SharedSecret || (this.SharedSecret != null && !this.SharedSecret.Equals(input.SharedSecret))) return false;
            if (this.CiphertextRecipient != input.CiphertextRecipient || (this.CiphertextRecipient != null && !this.CiphertextRecipient.Equals(input.CiphertextRecipient))) return false;

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
                if (this.KeyAgreementAlgorithm != null) hashCode = hashCode * 59 + this.KeyAgreementAlgorithm.GetHashCode();
                if (this.SharedSecret != null) hashCode = hashCode * 59 + this.SharedSecret.GetHashCode();
                if (this.CiphertextRecipient != null) hashCode = hashCode * 59 + this.CiphertextRecipient.GetHashCode();
                return hashCode;
            }
        }
    }
}
