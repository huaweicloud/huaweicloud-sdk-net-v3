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
    /// 
    /// </summary>
    public class PutMfaDeviceManagementForDirectoryReqBody 
    {
        /// <summary>
        /// 允许用户自行管理MFA的行为
        /// </summary>
        /// <value>允许用户自行管理MFA的行为</value>
        [JsonConverter(typeof(EnumClassConverter<UserPermissionEnum>))]
        public class UserPermissionEnum
        {
            /// <summary>
            /// Enum READ_ACTIONS for value: READ_ACTIONS
            /// </summary>
            public static readonly UserPermissionEnum READ_ACTIONS = new UserPermissionEnum("READ_ACTIONS");

            /// <summary>
            /// Enum ALL_ACTIONS for value: ALL_ACTIONS
            /// </summary>
            public static readonly UserPermissionEnum ALL_ACTIONS = new UserPermissionEnum("ALL_ACTIONS");

            private static readonly Dictionary<string, UserPermissionEnum> StaticFields =
            new Dictionary<string, UserPermissionEnum>()
            {
                { "READ_ACTIONS", READ_ACTIONS },
                { "ALL_ACTIONS", ALL_ACTIONS },
            };

            private string _value;

            public UserPermissionEnum()
            {

            }

            public UserPermissionEnum(string value)
            {
                _value = value;
            }

            public static UserPermissionEnum FromValue(string value)
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

                if (this.Equals(obj as UserPermissionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UserPermissionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UserPermissionEnum a, UserPermissionEnum b)
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

            public static bool operator !=(UserPermissionEnum a, UserPermissionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 关联到IAM身份中心实例的身份源的全局唯一标识符（ID）。
        /// </summary>
        [JsonProperty("identity_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// 允许用户自行管理MFA的行为
        /// </summary>
        [JsonProperty("user_permission", NullValueHandling = NullValueHandling.Ignore)]
        public UserPermissionEnum UserPermission { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutMfaDeviceManagementForDirectoryReqBody {\n");
            sb.Append("  identityStoreId: ").Append(IdentityStoreId).Append("\n");
            sb.Append("  userPermission: ").Append(UserPermission).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PutMfaDeviceManagementForDirectoryReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PutMfaDeviceManagementForDirectoryReqBody input)
        {
            if (input == null) return false;
            if (this.IdentityStoreId != input.IdentityStoreId || (this.IdentityStoreId != null && !this.IdentityStoreId.Equals(input.IdentityStoreId))) return false;
            if (this.UserPermission != input.UserPermission) return false;

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
                if (this.IdentityStoreId != null) hashCode = hashCode * 59 + this.IdentityStoreId.GetHashCode();
                hashCode = hashCode * 59 + this.UserPermission.GetHashCode();
                return hashCode;
            }
        }
    }
}
