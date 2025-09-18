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
    /// 解除与用户或组绑定的所有账号授权关联的请求体
    /// </summary>
    public class DisassociateProfileReqBody 
    {
        /// <summary>
        /// 解除绑定的实体类型，可为用户或者用户组
        /// </summary>
        /// <value>解除绑定的实体类型，可为用户或者用户组</value>
        [JsonConverter(typeof(EnumClassConverter<AccessorTypeEnum>))]
        public class AccessorTypeEnum
        {
            /// <summary>
            /// Enum GROUP for value: GROUP
            /// </summary>
            public static readonly AccessorTypeEnum GROUP = new AccessorTypeEnum("GROUP");

            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            public static readonly AccessorTypeEnum USER = new AccessorTypeEnum("USER");

            private static readonly Dictionary<string, AccessorTypeEnum> StaticFields =
            new Dictionary<string, AccessorTypeEnum>()
            {
                { "GROUP", GROUP },
                { "USER", USER },
            };

            private string _value;

            public AccessorTypeEnum()
            {

            }

            public AccessorTypeEnum(string value)
            {
                _value = value;
            }

            public static AccessorTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AccessorTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccessorTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccessorTypeEnum a, AccessorTypeEnum b)
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

            public static bool operator !=(AccessorTypeEnum a, AccessorTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户或用户组的唯一标识ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 解除绑定的实体类型，可为用户或者用户组
        /// </summary>
        [JsonProperty("accessor_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccessorTypeEnum AccessorType { get; set; }
        /// <summary>
        /// 关联到IAM身份中心实例的身份源的全局唯一标识符（ID）。
        /// </summary>
        [JsonProperty("identity_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateProfileReqBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  accessorType: ").Append(AccessorType).Append("\n");
            sb.Append("  identityStoreId: ").Append(IdentityStoreId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateProfileReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateProfileReqBody input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.AccessorType != input.AccessorType) return false;
            if (this.IdentityStoreId != input.IdentityStoreId || (this.IdentityStoreId != null && !this.IdentityStoreId.Equals(input.IdentityStoreId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.AccessorType.GetHashCode();
                if (this.IdentityStoreId != null) hashCode = hashCode * 59 + this.IdentityStoreId.GetHashCode();
                return hashCode;
            }
        }
    }
}
