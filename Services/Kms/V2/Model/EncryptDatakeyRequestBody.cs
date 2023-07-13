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
    /// 
    /// </summary>
    public class EncryptDatakeyRequestBody 
    {

        /// <summary>
        /// 密钥ID，36字节，满足正则匹配“^[0-9a-z]{8}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{12}$”。 例如：0d0466b0-e727-4d9c-b35d-f84bb474a37f。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// CMK为AES时，DEK明文和DEK明文的SHA256（32字节）；CMK为SM4时，DEK明文和DEK明文的SM3（32字节），均为16进制字符串表示。
        /// </summary>
        [JsonProperty("plain_text", NullValueHandling = NullValueHandling.Ignore)]
        public string PlainText { get; set; }

        /// <summary>
        /// DEK明文字节长度，取值范围为1~1024。 DEK明文字节长度，取值为“64”。
        /// </summary>
        [JsonProperty("datakey_plain_length", NullValueHandling = NullValueHandling.Ignore)]
        public string DatakeyPlainLength { get; set; }

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
            sb.Append("class EncryptDatakeyRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  plainText: ").Append(PlainText).Append("\n");
            sb.Append("  datakeyPlainLength: ").Append(DatakeyPlainLength).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EncryptDatakeyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EncryptDatakeyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
                ) && 
                (
                    this.PlainText == input.PlainText ||
                    (this.PlainText != null &&
                    this.PlainText.Equals(input.PlainText))
                ) && 
                (
                    this.DatakeyPlainLength == input.DatakeyPlainLength ||
                    (this.DatakeyPlainLength != null &&
                    this.DatakeyPlainLength.Equals(input.DatakeyPlainLength))
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
                if (this.KeyId != null)
                    hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.PlainText != null)
                    hashCode = hashCode * 59 + this.PlainText.GetHashCode();
                if (this.DatakeyPlainLength != null)
                    hashCode = hashCode * 59 + this.DatakeyPlainLength.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
