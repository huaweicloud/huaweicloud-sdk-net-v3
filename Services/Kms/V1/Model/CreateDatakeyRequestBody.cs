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
    public class CreateDatakeyRequestBody 
    {
        /// <summary>
        /// 指定生成的密钥bit位长度。有效值：AES_256、AES_128。  - AES_256：表示256比特的对称密钥。  - AES_128：表示128比特的对称密钥。 说明：  datakey_length和key_spec二选一。   - 若datakey_length和key_spec都为空，默认生成256bit的密钥。   - 若datakey_length和key_spec都指定了值，仅datakey_length生效。
        /// </summary>
        /// <value>指定生成的密钥bit位长度。有效值：AES_256、AES_128。  - AES_256：表示256比特的对称密钥。  - AES_128：表示128比特的对称密钥。 说明：  datakey_length和key_spec二选一。   - 若datakey_length和key_spec都为空，默认生成256bit的密钥。   - 若datakey_length和key_spec都指定了值，仅datakey_length生效。</value>
        [JsonConverter(typeof(EnumClassConverter<KeySpecEnum>))]
        public class KeySpecEnum
        {
            /// <summary>
            /// Enum AES_256 for value: AES_256
            /// </summary>
            public static readonly KeySpecEnum AES_256 = new KeySpecEnum("AES_256");

            /// <summary>
            /// Enum AES_128 for value: AES_128
            /// </summary>
            public static readonly KeySpecEnum AES_128 = new KeySpecEnum("AES_128");

            private static readonly Dictionary<string, KeySpecEnum> StaticFields =
            new Dictionary<string, KeySpecEnum>()
            {
                { "AES_256", AES_256 },
                { "AES_128", AES_128 },
            };

            private string Value;

            public KeySpecEnum(string value)
            {
                Value = value;
            }

            public static KeySpecEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as KeySpecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeySpecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(KeySpecEnum a, KeySpecEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(KeySpecEnum a, KeySpecEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 密钥ID，36字节，满足正则匹配“^[0-9a-z]{8}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{12}$”。 例如：0d0466b0-e727-4d9c-b35d-f84bb474a37f。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 一系列key-value键值对，用于记录资源上下文信息，用于保护数据的完整性，不应包含敏感信息，最大长度为8192。 当在加密时指定了该参数时，解密密文时，需要传入相同的参数，才能正确的解密。 例如：{\&quot;Key1\&quot;:\&quot;Value1\&quot;,\&quot;Key2\&quot;:\&quot;Value2\&quot;}
        /// </summary>
        [JsonProperty("encryption_context", NullValueHandling = NullValueHandling.Ignore)]
        public Object EncryptionContext { get; set; }

        /// <summary>
        /// 指定生成的密钥bit位长度。有效值：AES_256、AES_128。  - AES_256：表示256比特的对称密钥。  - AES_128：表示128比特的对称密钥。 说明：  datakey_length和key_spec二选一。   - 若datakey_length和key_spec都为空，默认生成256bit的密钥。   - 若datakey_length和key_spec都指定了值，仅datakey_length生效。
        /// </summary>
        [JsonProperty("key_spec", NullValueHandling = NullValueHandling.Ignore)]
        public KeySpecEnum KeySpec { get; set; }
        /// <summary>
        /// 密钥bit位长度。取值为8的倍数，取值范围为8~8192。 说明：  datakey_length和key_spec二选一。   - 若datakey_length和key_spec都为空，默认生成256bit的密钥。   - 若datakey_length和key_spec都指定了值，仅datakey_length生效。
        /// </summary>
        [JsonProperty("datakey_length", NullValueHandling = NullValueHandling.Ignore)]
        public string DatakeyLength { get; set; }

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
            sb.Append("class CreateDatakeyRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  encryptionContext: ").Append(EncryptionContext).Append("\n");
            sb.Append("  keySpec: ").Append(KeySpec).Append("\n");
            sb.Append("  datakeyLength: ").Append(DatakeyLength).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDatakeyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDatakeyRequestBody input)
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
                    this.EncryptionContext == input.EncryptionContext ||
                    (this.EncryptionContext != null &&
                    this.EncryptionContext.Equals(input.EncryptionContext))
                ) && 
                (
                    this.KeySpec == input.KeySpec ||
                    (this.KeySpec != null &&
                    this.KeySpec.Equals(input.KeySpec))
                ) && 
                (
                    this.DatakeyLength == input.DatakeyLength ||
                    (this.DatakeyLength != null &&
                    this.DatakeyLength.Equals(input.DatakeyLength))
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
                if (this.EncryptionContext != null)
                    hashCode = hashCode * 59 + this.EncryptionContext.GetHashCode();
                if (this.KeySpec != null)
                    hashCode = hashCode * 59 + this.KeySpec.GetHashCode();
                if (this.DatakeyLength != null)
                    hashCode = hashCode * 59 + this.DatakeyLength.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
