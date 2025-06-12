using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 直播平台授权信息
    /// </summary>
    public class PlatformAuthorizationInfo 
    {
        /// <summary>
        /// 授权状态。 * AUTHORIZED: 已授权 * UNAUTHORIZED: 未授权
        /// </summary>
        /// <value>授权状态。 * AUTHORIZED: 已授权 * UNAUTHORIZED: 未授权</value>
        [JsonConverter(typeof(EnumClassConverter<AuthorizeStateEnum>))]
        public class AuthorizeStateEnum
        {
            /// <summary>
            /// Enum AUTHORIZED for value: AUTHORIZED
            /// </summary>
            public static readonly AuthorizeStateEnum AUTHORIZED = new AuthorizeStateEnum("AUTHORIZED");

            /// <summary>
            /// Enum UNAUTHORIZED for value: UNAUTHORIZED
            /// </summary>
            public static readonly AuthorizeStateEnum UNAUTHORIZED = new AuthorizeStateEnum("UNAUTHORIZED");

            private static readonly Dictionary<string, AuthorizeStateEnum> StaticFields =
            new Dictionary<string, AuthorizeStateEnum>()
            {
                { "AUTHORIZED", AUTHORIZED },
                { "UNAUTHORIZED", UNAUTHORIZED },
            };

            private string _value;

            public AuthorizeStateEnum()
            {

            }

            public AuthorizeStateEnum(string value)
            {
                _value = value;
            }

            public static AuthorizeStateEnum FromValue(string value)
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

                if (this.Equals(obj as AuthorizeStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AuthorizeStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AuthorizeStateEnum a, AuthorizeStateEnum b)
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

            public static bool operator !=(AuthorizeStateEnum a, AuthorizeStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 授权状态。 * AUTHORIZED: 已授权 * UNAUTHORIZED: 未授权
        /// </summary>
        [JsonProperty("authorize_state", NullValueHandling = NullValueHandling.Ignore)]
        public AuthorizeStateEnum AuthorizeState { get; set; }
        /// <summary>
        /// 授权时间
        /// </summary>
        [JsonProperty("authorized_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizedTime { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 授权账号信息。 美团平台对应：opBizCode
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlatformAuthorizationInfo {\n");
            sb.Append("  authorizeState: ").Append(AuthorizeState).Append("\n");
            sb.Append("  authorizedTime: ").Append(AuthorizedTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlatformAuthorizationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PlatformAuthorizationInfo input)
        {
            if (input == null) return false;
            if (this.AuthorizeState != input.AuthorizeState) return false;
            if (this.AuthorizedTime != input.AuthorizedTime || (this.AuthorizedTime != null && !this.AuthorizedTime.Equals(input.AuthorizedTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;

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
                hashCode = hashCode * 59 + this.AuthorizeState.GetHashCode();
                if (this.AuthorizedTime != null) hashCode = hashCode * 59 + this.AuthorizedTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                return hashCode;
            }
        }
    }
}
