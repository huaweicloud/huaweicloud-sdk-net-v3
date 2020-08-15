using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DecryptDataRequestBody 
    {

        /// <summary>
        /// 被加密数据密文。取值为加密数据结果中的cipher_text的值，满足正则匹配“^[0-9a-zA-Z+/&#x3D;]{188,5648}$”。
        /// </summary>
        [JsonProperty("cipher_text", NullValueHandling = NullValueHandling.Ignore)]
        public string CipherText { get; set; }

        /// <summary>
        /// 一系列key-value键值对，用于记录资源上下文信息，用于保护数据的完整性，不应包含敏感信息，最大长度为8192。 当在加密时指定了该参数时，解密密文时，需要传入相同的参数，才能正确的解密。 例如：{\&quot;Key1\&quot;:\&quot;Value1\&quot;,\&quot;Key2\&quot;:\&quot;Value2\&quot;}
        /// </summary>
        [JsonProperty("encryption_context", NullValueHandling = NullValueHandling.Ignore)]
        public Object EncryptionContext { get; set; }

        /// <summary>
        /// 请求消息序列号，36字节序列号。 例如：919c82d4-8046-4722-9094-35c3c6524cff
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecryptDataRequestBody {\n");
            sb.Append("  cipherText: ").Append(CipherText).Append("\n");
            sb.Append("  encryptionContext: ").Append(EncryptionContext).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DecryptDataRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DecryptDataRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CipherText == input.CipherText ||
                    (this.CipherText != null &&
                    this.CipherText.Equals(input.CipherText))
                ) && 
                (
                    this.EncryptionContext == input.EncryptionContext ||
                    (this.EncryptionContext != null &&
                    this.EncryptionContext.Equals(input.EncryptionContext))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CipherText != null)
                    hashCode = hashCode * 59 + this.CipherText.GetHashCode();
                if (this.EncryptionContext != null)
                    hashCode = hashCode * 59 + this.EncryptionContext.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
