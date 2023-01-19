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
    public class CreateGrantRequestBody 
    {
        /// <summary>
        /// 授权类型。有效值：“user”，“domain”。默认值为“user”。
        /// </summary>
        /// <value>授权类型。有效值：“user”，“domain”。默认值为“user”。</value>
        [JsonConverter(typeof(EnumClassConverter<GranteePrincipalTypeEnum>))]
        public class GranteePrincipalTypeEnum
        {
            /// <summary>
            /// Enum USER for value: user
            /// </summary>
            public static readonly GranteePrincipalTypeEnum USER = new GranteePrincipalTypeEnum("user");

            /// <summary>
            /// Enum DOMAIN for value: domain
            /// </summary>
            public static readonly GranteePrincipalTypeEnum DOMAIN = new GranteePrincipalTypeEnum("domain");

            private static readonly Dictionary<string, GranteePrincipalTypeEnum> StaticFields =
            new Dictionary<string, GranteePrincipalTypeEnum>()
            {
                { "user", USER },
                { "domain", DOMAIN },
            };

            private string _value;

            public GranteePrincipalTypeEnum()
            {

            }

            public GranteePrincipalTypeEnum(string value)
            {
                _value = value;
            }

            public static GranteePrincipalTypeEnum FromValue(string value)
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

                if (this.Equals(obj as GranteePrincipalTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GranteePrincipalTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GranteePrincipalTypeEnum a, GranteePrincipalTypeEnum b)
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

            public static bool operator !=(GranteePrincipalTypeEnum a, GranteePrincipalTypeEnum b)
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
        /// 被授权用户ID，1~64字节，满足正则匹配“^[a-zA-Z0-9]{1，64}$”。 例如：0d0466b00d0466b00d0466b00d0466b0
        /// </summary>
        [JsonProperty("grantee_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string GranteePrincipal { get; set; }

        /// <summary>
        /// 授权允许的操作列表。 有效的值：“create-datakey”，“create-datakey-without-plaintext”，“encrypt-datakey”，“decrypt-datakey”，“describe-key”，“create-grant”，“retire-grant”，“encrypt-data”，“decrypt-data”。 有效值不能仅为“create-grant”。
        /// </summary>
        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Operations { get; set; }

        /// <summary>
        /// 授权名称，取值1到255字符，满足正则匹配“^[a-zA-Z0-9:/_-]{1,255}$”。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 可退役授权的用户ID，1~64字节，满足正则匹配“^[a-zA-Z0-9]{1，64}$”。 例如：0d0466b00d0466b00d0466b00d0466b0
        /// </summary>
        [JsonProperty("retiring_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string RetiringPrincipal { get; set; }

        /// <summary>
        /// 授权类型。有效值：“user”，“domain”。默认值为“user”。
        /// </summary>
        [JsonProperty("grantee_principal_type", NullValueHandling = NullValueHandling.Ignore)]
        public GranteePrincipalTypeEnum GranteePrincipalType { get; set; }
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
            sb.Append("class CreateGrantRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  granteePrincipal: ").Append(GranteePrincipal).Append("\n");
            sb.Append("  operations: ").Append(Operations).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  retiringPrincipal: ").Append(RetiringPrincipal).Append("\n");
            sb.Append("  granteePrincipalType: ").Append(GranteePrincipalType).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateGrantRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateGrantRequestBody input)
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
                    this.GranteePrincipal == input.GranteePrincipal ||
                    (this.GranteePrincipal != null &&
                    this.GranteePrincipal.Equals(input.GranteePrincipal))
                ) && 
                (
                    this.Operations == input.Operations ||
                    this.Operations != null &&
                    input.Operations != null &&
                    this.Operations.SequenceEqual(input.Operations)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RetiringPrincipal == input.RetiringPrincipal ||
                    (this.RetiringPrincipal != null &&
                    this.RetiringPrincipal.Equals(input.RetiringPrincipal))
                ) && 
                (
                    this.GranteePrincipalType == input.GranteePrincipalType ||
                    (this.GranteePrincipalType != null &&
                    this.GranteePrincipalType.Equals(input.GranteePrincipalType))
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
                if (this.GranteePrincipal != null)
                    hashCode = hashCode * 59 + this.GranteePrincipal.GetHashCode();
                if (this.Operations != null)
                    hashCode = hashCode * 59 + this.Operations.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RetiringPrincipal != null)
                    hashCode = hashCode * 59 + this.RetiringPrincipal.GetHashCode();
                if (this.GranteePrincipalType != null)
                    hashCode = hashCode * 59 + this.GranteePrincipalType.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
