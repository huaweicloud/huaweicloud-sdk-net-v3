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
    public class Grants 
    {
        /// <summary>
        /// 授权类型。 有效值：“user”，“domain”。
        /// </summary>
        /// <value>授权类型。 有效值：“user”，“domain”。</value>
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
        /// 密钥ID。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 授权ID，64字节。
        /// </summary>
        [JsonProperty("grant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GrantId { get; set; }

        /// <summary>
        /// 被授权用户ID，1~64字节，满足正则匹配“^[a-zA-Z0-9]{1，64}$”。 例如：0d0466b00d0466b00d0466b00d0466b0
        /// </summary>
        [JsonProperty("grantee_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string GranteePrincipal { get; set; }

        /// <summary>
        /// 授权类型。 有效值：“user”，“domain”。
        /// </summary>
        [JsonProperty("grantee_principal_type", NullValueHandling = NullValueHandling.Ignore)]
        public GranteePrincipalTypeEnum GranteePrincipalType { get; set; }
        /// <summary>
        /// 授权允许的操作列表。 有效的值：“create-datakey”，“create-datakey-without-plaintext”，“encrypt-datakey”，“decrypt-datakey”，“describe-key”，“create-grant”，“retire-grant”，“encrypt-data”，“decrypt-data”。 有效值不能仅为“create-grant”。
        /// </summary>
        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Operations { get; set; }

        /// <summary>
        /// 创建授权用户ID，1~64字节，满足正则匹配“^[a-zA-Z0-9]{1，64}$”。 例如：0d0466b00d0466b00d0466b00d0466b0
        /// </summary>
        [JsonProperty("issuing_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuingPrincipal { get; set; }

        /// <summary>
        /// 创建时间，时间戳，即从1970年1月1日至该时间的总秒数。 例如：1497341531000
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationDate { get; set; }

        /// <summary>
        /// 授权名字，取值1到255字符，满足正则匹配“^[a-zA-Z0-9:/_-]{1,255}$”。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 可退役授权的用户ID，1~64字节，满足正则匹配“^[a-zA-Z0-9]{1，64}$”。 例如：0d0466b00d0466b00d0466b00d0466b0
        /// </summary>
        [JsonProperty("retiring_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string RetiringPrincipal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Grants {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  grantId: ").Append(GrantId).Append("\n");
            sb.Append("  granteePrincipal: ").Append(GranteePrincipal).Append("\n");
            sb.Append("  granteePrincipalType: ").Append(GranteePrincipalType).Append("\n");
            sb.Append("  operations: ").Append(Operations).Append("\n");
            sb.Append("  issuingPrincipal: ").Append(IssuingPrincipal).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  retiringPrincipal: ").Append(RetiringPrincipal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Grants);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Grants input)
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
                    this.GrantId == input.GrantId ||
                    (this.GrantId != null &&
                    this.GrantId.Equals(input.GrantId))
                ) && 
                (
                    this.GranteePrincipal == input.GranteePrincipal ||
                    (this.GranteePrincipal != null &&
                    this.GranteePrincipal.Equals(input.GranteePrincipal))
                ) && 
                (
                    this.GranteePrincipalType == input.GranteePrincipalType ||
                    (this.GranteePrincipalType != null &&
                    this.GranteePrincipalType.Equals(input.GranteePrincipalType))
                ) && 
                (
                    this.Operations == input.Operations ||
                    this.Operations != null &&
                    input.Operations != null &&
                    this.Operations.SequenceEqual(input.Operations)
                ) && 
                (
                    this.IssuingPrincipal == input.IssuingPrincipal ||
                    (this.IssuingPrincipal != null &&
                    this.IssuingPrincipal.Equals(input.IssuingPrincipal))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
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
                if (this.GrantId != null)
                    hashCode = hashCode * 59 + this.GrantId.GetHashCode();
                if (this.GranteePrincipal != null)
                    hashCode = hashCode * 59 + this.GranteePrincipal.GetHashCode();
                if (this.GranteePrincipalType != null)
                    hashCode = hashCode * 59 + this.GranteePrincipalType.GetHashCode();
                if (this.Operations != null)
                    hashCode = hashCode * 59 + this.Operations.GetHashCode();
                if (this.IssuingPrincipal != null)
                    hashCode = hashCode * 59 + this.IssuingPrincipal.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RetiringPrincipal != null)
                    hashCode = hashCode * 59 + this.RetiringPrincipal.GetHashCode();
                return hashCode;
            }
        }
    }
}
