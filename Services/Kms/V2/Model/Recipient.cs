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
    /// 擎天机密计算请求体
    /// </summary>
    public class Recipient 
    {

        /// <summary>
        /// 擎天机密计算证明文档
        /// </summary>
        [JsonProperty("attestation_document", NullValueHandling = NullValueHandling.Ignore)]
        public string AttestationDocument { get; set; }

        /// <summary>
        /// 指定加密算法，仅支持RSAES_OAEP_SHA_256
        /// </summary>
        [JsonProperty("key_encryption_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyEncryptionAlgorithm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Recipient {\n");
            sb.Append("  attestationDocument: ").Append(AttestationDocument).Append("\n");
            sb.Append("  keyEncryptionAlgorithm: ").Append(KeyEncryptionAlgorithm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Recipient);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Recipient input)
        {
            if (input == null) return false;
            if (this.AttestationDocument != input.AttestationDocument || (this.AttestationDocument != null && !this.AttestationDocument.Equals(input.AttestationDocument))) return false;
            if (this.KeyEncryptionAlgorithm != input.KeyEncryptionAlgorithm || (this.KeyEncryptionAlgorithm != null && !this.KeyEncryptionAlgorithm.Equals(input.KeyEncryptionAlgorithm))) return false;

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
                if (this.AttestationDocument != null) hashCode = hashCode * 59 + this.AttestationDocument.GetHashCode();
                if (this.KeyEncryptionAlgorithm != null) hashCode = hashCode * 59 + this.KeyEncryptionAlgorithm.GetHashCode();
                return hashCode;
            }
        }
    }
}
