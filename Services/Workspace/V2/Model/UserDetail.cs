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
    public class UserDetail 
    {
        /// <summary>
        /// 激活类型，默认为用户激活。 * USER_ACTIVATE： 用户激活 * ADMIN_ACTIVATE： 管理员激活
        /// </summary>
        /// <value>激活类型，默认为用户激活。 * USER_ACTIVATE： 用户激活 * ADMIN_ACTIVATE： 管理员激活</value>
        [JsonConverter(typeof(EnumClassConverter<ActiveTypeEnum>))]
        public class ActiveTypeEnum
        {
            /// <summary>
            /// Enum ADMIN_ACTIVATE for value: ADMIN_ACTIVATE
            /// </summary>
            public static readonly ActiveTypeEnum ADMIN_ACTIVATE = new ActiveTypeEnum("ADMIN_ACTIVATE");

            /// <summary>
            /// Enum USER_ACTIVATE for value: USER_ACTIVATE
            /// </summary>
            public static readonly ActiveTypeEnum USER_ACTIVATE = new ActiveTypeEnum("USER_ACTIVATE");

            private static readonly Dictionary<string, ActiveTypeEnum> StaticFields =
            new Dictionary<string, ActiveTypeEnum>()
            {
                { "ADMIN_ACTIVATE", ADMIN_ACTIVATE },
                { "USER_ACTIVATE", USER_ACTIVATE },
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
        /// 用户id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 桌面用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

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
        /// 用户sid。
        /// </summary>
        [JsonProperty("object_sid", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectSid { get; set; }

        /// <summary>
        /// 登录名(windows以前版本)。
        /// </summary>
        [JsonProperty("sam_account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SamAccountName { get; set; }

        /// <summary>
        /// 用户登录名。
        /// </summary>
        [JsonProperty("user_principal_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// 全名。
        /// </summary>
        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        /// <summary>
        /// 用户在域树上的唯一位置。
        /// </summary>
        [JsonProperty("distinguished_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// 账号类型(0：用户；1：用户组)。
        /// </summary>
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountType { get; set; }

        /// <summary>
        /// UTC时间毫秒数对应的字符，格式为：yyyy-MM-ddTHH:mm:ss.SSSZ。
        /// </summary>
        [JsonProperty("when_created", NullValueHandling = NullValueHandling.Ignore)]
        public string WhenCreated { get; set; }

        /// <summary>
        /// 账号有效期最后一天对应的UTC时间，以毫秒为单位。
        /// </summary>
        [JsonProperty("account_expires", NullValueHandling = NullValueHandling.Ignore)]
        public long? AccountExpires { get; set; }

        /// <summary>
        /// 是否是预创建的用户，true表示是预创建用户，false表示不是预创建用户。
        /// </summary>
        [JsonProperty("is_pre_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPreUser { get; set; }

        /// <summary>
        /// 账户是否过期，true表示过期，false表示未过期。
        /// </summary>
        [JsonProperty("user_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserExpired { get; set; }

        /// <summary>
        /// 账户是否被锁定，true表示被锁定，false表示未锁定。
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; }

        /// <summary>
        /// 是否允许修改密码，true表示允许修改密码，false表示不允许。
        /// </summary>
        [JsonProperty("enable_change_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableChangePassword { get; set; }

        /// <summary>
        /// 密码是否永不过期，true表示密码永不过期，false表示密码会过期。
        /// </summary>
        [JsonProperty("password_never_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PasswordNeverExpired { get; set; }

        /// <summary>
        /// 下次登录是否需要重置密码，true表示需要重置密码，false表示不需要。
        /// </summary>
        [JsonProperty("next_login_change_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NextLoginChangePassword { get; set; }

        /// <summary>
        /// 账户是否禁用，true表示被禁用，false表示未禁用。
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 加入的组列表。
        /// </summary>
        [JsonProperty("group_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GroupNames { get; set; }

        /// <summary>
        /// 用户是否订阅协同，true表示已订阅，false表示未订阅。
        /// </summary>
        [JsonProperty("share_space_subscription", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShareSpaceSubscription { get; set; }

        /// <summary>
        /// 用户已绑定协同桌面数。
        /// </summary>
        [JsonProperty("share_space_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShareSpaceDesktops { get; set; }

        /// <summary>
        /// 用户绑定桌面云总数。
        /// </summary>
        [JsonProperty("total_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDesktops { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserDetail {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  userPhone: ").Append(UserPhone).Append("\n");
            sb.Append("  activeType: ").Append(ActiveType).Append("\n");
            sb.Append("  objectSid: ").Append(ObjectSid).Append("\n");
            sb.Append("  samAccountName: ").Append(SamAccountName).Append("\n");
            sb.Append("  userPrincipalName: ").Append(UserPrincipalName).Append("\n");
            sb.Append("  fullName: ").Append(FullName).Append("\n");
            sb.Append("  distinguishedName: ").Append(DistinguishedName).Append("\n");
            sb.Append("  accountType: ").Append(AccountType).Append("\n");
            sb.Append("  whenCreated: ").Append(WhenCreated).Append("\n");
            sb.Append("  accountExpires: ").Append(AccountExpires).Append("\n");
            sb.Append("  isPreUser: ").Append(IsPreUser).Append("\n");
            sb.Append("  userExpired: ").Append(UserExpired).Append("\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("  enableChangePassword: ").Append(EnableChangePassword).Append("\n");
            sb.Append("  passwordNeverExpired: ").Append(PasswordNeverExpired).Append("\n");
            sb.Append("  nextLoginChangePassword: ").Append(NextLoginChangePassword).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  groupNames: ").Append(GroupNames).Append("\n");
            sb.Append("  shareSpaceSubscription: ").Append(ShareSpaceSubscription).Append("\n");
            sb.Append("  shareSpaceDesktops: ").Append(ShareSpaceDesktops).Append("\n");
            sb.Append("  totalDesktops: ").Append(TotalDesktops).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserDetail input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.UserEmail != input.UserEmail || (this.UserEmail != null && !this.UserEmail.Equals(input.UserEmail))) return false;
            if (this.UserPhone != input.UserPhone || (this.UserPhone != null && !this.UserPhone.Equals(input.UserPhone))) return false;
            if (this.ActiveType != input.ActiveType) return false;
            if (this.ObjectSid != input.ObjectSid || (this.ObjectSid != null && !this.ObjectSid.Equals(input.ObjectSid))) return false;
            if (this.SamAccountName != input.SamAccountName || (this.SamAccountName != null && !this.SamAccountName.Equals(input.SamAccountName))) return false;
            if (this.UserPrincipalName != input.UserPrincipalName || (this.UserPrincipalName != null && !this.UserPrincipalName.Equals(input.UserPrincipalName))) return false;
            if (this.FullName != input.FullName || (this.FullName != null && !this.FullName.Equals(input.FullName))) return false;
            if (this.DistinguishedName != input.DistinguishedName || (this.DistinguishedName != null && !this.DistinguishedName.Equals(input.DistinguishedName))) return false;
            if (this.AccountType != input.AccountType || (this.AccountType != null && !this.AccountType.Equals(input.AccountType))) return false;
            if (this.WhenCreated != input.WhenCreated || (this.WhenCreated != null && !this.WhenCreated.Equals(input.WhenCreated))) return false;
            if (this.AccountExpires != input.AccountExpires || (this.AccountExpires != null && !this.AccountExpires.Equals(input.AccountExpires))) return false;
            if (this.IsPreUser != input.IsPreUser || (this.IsPreUser != null && !this.IsPreUser.Equals(input.IsPreUser))) return false;
            if (this.UserExpired != input.UserExpired || (this.UserExpired != null && !this.UserExpired.Equals(input.UserExpired))) return false;
            if (this.Locked != input.Locked || (this.Locked != null && !this.Locked.Equals(input.Locked))) return false;
            if (this.EnableChangePassword != input.EnableChangePassword || (this.EnableChangePassword != null && !this.EnableChangePassword.Equals(input.EnableChangePassword))) return false;
            if (this.PasswordNeverExpired != input.PasswordNeverExpired || (this.PasswordNeverExpired != null && !this.PasswordNeverExpired.Equals(input.PasswordNeverExpired))) return false;
            if (this.NextLoginChangePassword != input.NextLoginChangePassword || (this.NextLoginChangePassword != null && !this.NextLoginChangePassword.Equals(input.NextLoginChangePassword))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;
            if (this.GroupNames != input.GroupNames || (this.GroupNames != null && input.GroupNames != null && !this.GroupNames.SequenceEqual(input.GroupNames))) return false;
            if (this.ShareSpaceSubscription != input.ShareSpaceSubscription || (this.ShareSpaceSubscription != null && !this.ShareSpaceSubscription.Equals(input.ShareSpaceSubscription))) return false;
            if (this.ShareSpaceDesktops != input.ShareSpaceDesktops || (this.ShareSpaceDesktops != null && !this.ShareSpaceDesktops.Equals(input.ShareSpaceDesktops))) return false;
            if (this.TotalDesktops != input.TotalDesktops || (this.TotalDesktops != null && !this.TotalDesktops.Equals(input.TotalDesktops))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserEmail != null) hashCode = hashCode * 59 + this.UserEmail.GetHashCode();
                if (this.UserPhone != null) hashCode = hashCode * 59 + this.UserPhone.GetHashCode();
                hashCode = hashCode * 59 + this.ActiveType.GetHashCode();
                if (this.ObjectSid != null) hashCode = hashCode * 59 + this.ObjectSid.GetHashCode();
                if (this.SamAccountName != null) hashCode = hashCode * 59 + this.SamAccountName.GetHashCode();
                if (this.UserPrincipalName != null) hashCode = hashCode * 59 + this.UserPrincipalName.GetHashCode();
                if (this.FullName != null) hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.DistinguishedName != null) hashCode = hashCode * 59 + this.DistinguishedName.GetHashCode();
                if (this.AccountType != null) hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.WhenCreated != null) hashCode = hashCode * 59 + this.WhenCreated.GetHashCode();
                if (this.AccountExpires != null) hashCode = hashCode * 59 + this.AccountExpires.GetHashCode();
                if (this.IsPreUser != null) hashCode = hashCode * 59 + this.IsPreUser.GetHashCode();
                if (this.UserExpired != null) hashCode = hashCode * 59 + this.UserExpired.GetHashCode();
                if (this.Locked != null) hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.EnableChangePassword != null) hashCode = hashCode * 59 + this.EnableChangePassword.GetHashCode();
                if (this.PasswordNeverExpired != null) hashCode = hashCode * 59 + this.PasswordNeverExpired.GetHashCode();
                if (this.NextLoginChangePassword != null) hashCode = hashCode * 59 + this.NextLoginChangePassword.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.GroupNames != null) hashCode = hashCode * 59 + this.GroupNames.GetHashCode();
                if (this.ShareSpaceSubscription != null) hashCode = hashCode * 59 + this.ShareSpaceSubscription.GetHashCode();
                if (this.ShareSpaceDesktops != null) hashCode = hashCode * 59 + this.ShareSpaceDesktops.GetHashCode();
                if (this.TotalDesktops != null) hashCode = hashCode * 59 + this.TotalDesktops.GetHashCode();
                return hashCode;
            }
        }
    }
}
