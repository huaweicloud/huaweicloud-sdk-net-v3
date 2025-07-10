using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EditUserReq 
    {
        /// <summary>
        /// 激活类型，默认为用户激活。 * USER_ACTIVATE： 用户激活 * ADMIN_ACTIVATE： 管理员激活
        /// </summary>
        /// <value>激活类型，默认为用户激活。 * USER_ACTIVATE： 用户激活 * ADMIN_ACTIVATE： 管理员激活</value>
        [JsonConverter(typeof(EnumClassConverter<ActiveTypeEnum>))]
        public class ActiveTypeEnum
        {
            /// <summary>
            /// Enum USER_ACTIVATE for value: USER_ACTIVATE
            /// </summary>
            public static readonly ActiveTypeEnum USER_ACTIVATE = new ActiveTypeEnum("USER_ACTIVATE");

            /// <summary>
            /// Enum ADMIN_ACTIVATE for value: ADMIN_ACTIVATE
            /// </summary>
            public static readonly ActiveTypeEnum ADMIN_ACTIVATE = new ActiveTypeEnum("ADMIN_ACTIVATE");

            private static readonly Dictionary<string, ActiveTypeEnum> StaticFields =
            new Dictionary<string, ActiveTypeEnum>()
            {
                { "USER_ACTIVATE", USER_ACTIVATE },
                { "ADMIN_ACTIVATE", ADMIN_ACTIVATE },
            };

            private string _value;

            public ActiveTypeEnum()
            {

            }

            public ActiveTypeEnum(string value)
            {
                _value = value;
            }

            public static ActiveTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ActiveTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActiveTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActiveTypeEnum a, ActiveTypeEnum b)
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

            public static bool operator !=(ActiveTypeEnum a, ActiveTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 用户邮箱。
        /// </summary>
        [JsonProperty("user_email", NullValueHandling = NullValueHandling.Ignore)]
        public string UserEmail { get; set; }

        /// <summary>
        /// 手机号。
        /// </summary>
        [JsonProperty("user_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPhone { get; set; }

        /// <summary>
        /// 激活类型，默认为用户激活。 * USER_ACTIVATE： 用户激活 * ADMIN_ACTIVATE： 管理员激活
        /// </summary>
        [JsonProperty("active_type", NullValueHandling = NullValueHandling.Ignore)]
        public ActiveTypeEnum ActiveType { get; set; }
        /// <summary>
        /// 账户过期时间，0表示永远不过期。
        /// </summary>
        [JsonProperty("account_expires", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountExpires { get; set; }

        /// <summary>
        /// 是否允许修改密码，true表示允许，false表示不允许。
        /// </summary>
        [JsonProperty("enable_change_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableChangePassword { get; set; }

        /// <summary>
        /// 下次登录是否需要重置密码，true表示需要重置密码，false表示不需要。
        /// </summary>
        [JsonProperty("next_login_change_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NextLoginChangePassword { get; set; }

        /// <summary>
        /// 密码是否永不过期，true表示密码永不过期，false表示密码会过期。
        /// </summary>
        [JsonProperty("password_never_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PasswordNeverExpired { get; set; }

        /// <summary>
        /// 账户是否禁用，true表示被禁用，false表示未禁用。
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 用户信息映射，包含用户的服务等级、操作模式和类型。
        /// </summary>
        [JsonProperty("user_info_map", NullValueHandling = NullValueHandling.Ignore)]
        public string UserInfoMap { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditUserReq {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  userEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  userPhone: ").Append(UserPhone).Append("\n");
            sb.Append("  activeType: ").Append(ActiveType).Append("\n");
            sb.Append("  accountExpires: ").Append(AccountExpires).Append("\n");
            sb.Append("  enableChangePassword: ").Append(EnableChangePassword).Append("\n");
            sb.Append("  nextLoginChangePassword: ").Append(NextLoginChangePassword).Append("\n");
            sb.Append("  passwordNeverExpired: ").Append(PasswordNeverExpired).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  userInfoMap: ").Append(UserInfoMap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EditUserReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EditUserReq input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.UserEmail != input.UserEmail || (this.UserEmail != null && !this.UserEmail.Equals(input.UserEmail))) return false;
            if (this.UserPhone != input.UserPhone || (this.UserPhone != null && !this.UserPhone.Equals(input.UserPhone))) return false;
            if (this.ActiveType != input.ActiveType) return false;
            if (this.AccountExpires != input.AccountExpires || (this.AccountExpires != null && !this.AccountExpires.Equals(input.AccountExpires))) return false;
            if (this.EnableChangePassword != input.EnableChangePassword || (this.EnableChangePassword != null && !this.EnableChangePassword.Equals(input.EnableChangePassword))) return false;
            if (this.NextLoginChangePassword != input.NextLoginChangePassword || (this.NextLoginChangePassword != null && !this.NextLoginChangePassword.Equals(input.NextLoginChangePassword))) return false;
            if (this.PasswordNeverExpired != input.PasswordNeverExpired || (this.PasswordNeverExpired != null && !this.PasswordNeverExpired.Equals(input.PasswordNeverExpired))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;
            if (this.UserInfoMap != input.UserInfoMap || (this.UserInfoMap != null && !this.UserInfoMap.Equals(input.UserInfoMap))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UserEmail != null) hashCode = hashCode * 59 + this.UserEmail.GetHashCode();
                if (this.UserPhone != null) hashCode = hashCode * 59 + this.UserPhone.GetHashCode();
                hashCode = hashCode * 59 + this.ActiveType.GetHashCode();
                if (this.AccountExpires != null) hashCode = hashCode * 59 + this.AccountExpires.GetHashCode();
                if (this.EnableChangePassword != null) hashCode = hashCode * 59 + this.EnableChangePassword.GetHashCode();
                if (this.NextLoginChangePassword != null) hashCode = hashCode * 59 + this.NextLoginChangePassword.GetHashCode();
                if (this.PasswordNeverExpired != null) hashCode = hashCode * 59 + this.PasswordNeverExpired.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.UserInfoMap != null) hashCode = hashCode * 59 + this.UserInfoMap.GetHashCode();
                return hashCode;
            }
        }
    }
}
