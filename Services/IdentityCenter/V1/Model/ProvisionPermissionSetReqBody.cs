using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// ProvisionPermissionSet的请求体
    /// </summary>
    public class ProvisionPermissionSetReqBody 
    {
        /// <summary>
        /// 创建绑定的实体类型
        /// </summary>
        /// <value>创建绑定的实体类型</value>
        [JsonConverter(typeof(EnumClassConverter<TargetTypeEnum>))]
        public class TargetTypeEnum
        {
            /// <summary>
            /// Enum ACCOUNT for value: ACCOUNT
            /// </summary>
            public static readonly TargetTypeEnum ACCOUNT = new TargetTypeEnum("ACCOUNT");

            /// <summary>
            /// Enum ALL_PROVISIONED_ACCOUNTS for value: ALL_PROVISIONED_ACCOUNTS
            /// </summary>
            public static readonly TargetTypeEnum ALL_PROVISIONED_ACCOUNTS = new TargetTypeEnum("ALL_PROVISIONED_ACCOUNTS");

            private static readonly Dictionary<string, TargetTypeEnum> StaticFields =
            new Dictionary<string, TargetTypeEnum>()
            {
                { "ACCOUNT", ACCOUNT },
                { "ALL_PROVISIONED_ACCOUNTS", ALL_PROVISIONED_ACCOUNTS },
            };

            private string _value;

            public TargetTypeEnum()
            {

            }

            public TargetTypeEnum(string value)
            {
                _value = value;
            }

            public static TargetTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TargetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TargetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TargetTypeEnum a, TargetTypeEnum b)
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

            public static bool operator !=(TargetTypeEnum a, TargetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 账号ID
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }

        /// <summary>
        /// 创建绑定的实体类型
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public TargetTypeEnum TargetType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProvisionPermissionSetReqBody {\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProvisionPermissionSetReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProvisionPermissionSetReqBody input)
        {
            if (input == null) return false;
            if (this.TargetId != input.TargetId || (this.TargetId != null && !this.TargetId.Equals(input.TargetId))) return false;
            if (this.TargetType != input.TargetType) return false;

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
                if (this.TargetId != null) hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                return hashCode;
            }
        }
    }
}
