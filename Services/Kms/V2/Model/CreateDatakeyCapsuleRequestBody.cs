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
    public class CreateDatakeyCapsuleRequestBody 
    {
        /// <summary>
        /// **参数解释：** 待创建的数据密钥长度 **约束限制：** 256或者128二选一 **取值范围：** - 128 - 256 **默认取值：** 不涉及
        /// </summary>
        /// <value>**参数解释：** 待创建的数据密钥长度 **约束限制：** 256或者128二选一 **取值范围：** - 128 - 256 **默认取值：** 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<DatakeyLengthEnum>))]
        public class DatakeyLengthEnum
        {
            /// <summary>
            /// Enum AES_256 for value: AES_256
            /// </summary>
            public static readonly DatakeyLengthEnum AES_256 = new DatakeyLengthEnum("AES_256");

            /// <summary>
            /// Enum SM4 for value: SM4
            /// </summary>
            public static readonly DatakeyLengthEnum SM4 = new DatakeyLengthEnum("SM4");

            private static readonly Dictionary<string, DatakeyLengthEnum> StaticFields =
            new Dictionary<string, DatakeyLengthEnum>()
            {
                { "AES_256", AES_256 },
                { "SM4", SM4 },
            };

            private string _value;

            public DatakeyLengthEnum()
            {

            }

            public DatakeyLengthEnum(string value)
            {
                _value = value;
            }

            public static DatakeyLengthEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as DatakeyLengthEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DatakeyLengthEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DatakeyLengthEnum a, DatakeyLengthEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DatakeyLengthEnum a, DatakeyLengthEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 密钥ID **约束限制：** UUID格式，满足正则表达式^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$ **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// **参数解释：** 待创建的数据密钥长度 **约束限制：** 256或者128二选一 **取值范围：** - 128 - 256 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("datakey_length", NullValueHandling = NullValueHandling.Ignore)]
        public DatakeyLengthEnum DatakeyLength { get; set; }
        /// <summary>
        /// **参数解释：** 公钥信息，使用RSAES_OAEP_SHA_256算法加密；如果传递了public_key，KMS会使用该公钥对明文数据密钥进行加密，并返回加密后的数据密钥 **约束限制：** 仅支持RSA公钥 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }

        /// <summary>
        /// **参数解释：** 密钥策略ID和内联的密钥策略二选一 **约束限制：** 仅支持RSA公钥 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// **参数解释：** 密钥策略ID和内联的密钥策略二选一 **约束限制：** 仅支持RSA公钥 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("key_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDatakeyCapsuleRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  datakeyLength: ").Append(DatakeyLength).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  keyPolicy: ").Append(KeyPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDatakeyCapsuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDatakeyCapsuleRequestBody input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.DatakeyLength != input.DatakeyLength) return false;
            if (this.PublicKey != input.PublicKey || (this.PublicKey != null && !this.PublicKey.Equals(input.PublicKey))) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.KeyPolicy != input.KeyPolicy || (this.KeyPolicy != null && !this.KeyPolicy.Equals(input.KeyPolicy))) return false;

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
                hashCode = hashCode * 59 + this.DatakeyLength.GetHashCode();
                if (this.PublicKey != null) hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.PolicyId != null) hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.KeyPolicy != null) hashCode = hashCode * 59 + this.KeyPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
