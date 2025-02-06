using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// 创建用户请求体
    /// </summary>
    public class CreateUserReqBody 
    {
        /// <summary>
        /// 初始化密码方式，一次性密码/邮箱
        /// </summary>
        /// <value>初始化密码方式，一次性密码/邮箱</value>
        [JsonConverter(typeof(EnumClassConverter<PasswordModeEnum>))]
        public class PasswordModeEnum
        {
            /// <summary>
            /// Enum OTP for value: OTP
            /// </summary>
            public static readonly PasswordModeEnum OTP = new PasswordModeEnum("OTP");

            /// <summary>
            /// Enum EMAIL for value: EMAIL
            /// </summary>
            public static readonly PasswordModeEnum EMAIL = new PasswordModeEnum("EMAIL");

            private static readonly Dictionary<string, PasswordModeEnum> StaticFields =
            new Dictionary<string, PasswordModeEnum>()
            {
                { "OTP", OTP },
                { "EMAIL", EMAIL },
            };

            private string _value;

            public PasswordModeEnum()
            {

            }

            public PasswordModeEnum(string value)
            {
                _value = value;
            }

            public static PasswordModeEnum FromValue(string value)
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

                if (this.Equals(obj as PasswordModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PasswordModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PasswordModeEnum a, PasswordModeEnum b)
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

            public static bool operator !=(PasswordModeEnum a, PasswordModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户的地址信息列表
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddressDto> Addresses { get; set; }

        /// <summary>
        /// 用户的显示名称
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 用户的电子邮箱信息列表
        /// </summary>
        [JsonProperty("emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<EmailDto> Emails { get; set; }

        /// <summary>
        /// 用户的地理区域或位置信息
        /// </summary>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameDto Name { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("nickname", NullValueHandling = NullValueHandling.Ignore)]
        public string Nickname { get; set; }

        /// <summary>
        /// 用户的电话号码信息列表
        /// </summary>
        [JsonProperty("phone_numbers", NullValueHandling = NullValueHandling.Ignore)]
        public List<PhoneNumberDto> PhoneNumbers { get; set; }

        /// <summary>
        /// 用户语言首选项
        /// </summary>
        [JsonProperty("preferred_language", NullValueHandling = NullValueHandling.Ignore)]
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// 与用户关联的URL
        /// </summary>
        [JsonProperty("profile_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// 用户时区
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// 用户头衔
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 用户名，用于标识用户的唯一字符串
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [JsonProperty("user_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UserType { get; set; }

        /// <summary>
        /// 初始化密码方式，一次性密码/邮箱
        /// </summary>
        [JsonProperty("password_mode", NullValueHandling = NullValueHandling.Ignore)]
        public PasswordModeEnum PasswordMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enterprise", NullValueHandling = NullValueHandling.Ignore)]
        public EnterpriseDto Enterprise { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserReqBody {\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  emails: ").Append(Emails).Append("\n");
            sb.Append("  locale: ").Append(Locale).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nickname: ").Append(Nickname).Append("\n");
            sb.Append("  phoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  preferredLanguage: ").Append(PreferredLanguage).Append("\n");
            sb.Append("  profileUrl: ").Append(ProfileUrl).Append("\n");
            sb.Append("  timezone: ").Append(Timezone).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userType: ").Append(UserType).Append("\n");
            sb.Append("  passwordMode: ").Append(PasswordMode).Append("\n");
            sb.Append("  enterprise: ").Append(Enterprise).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateUserReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateUserReqBody input)
        {
            if (input == null) return false;
            if (this.Addresses != input.Addresses || (this.Addresses != null && input.Addresses != null && !this.Addresses.SequenceEqual(input.Addresses))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Emails != input.Emails || (this.Emails != null && input.Emails != null && !this.Emails.SequenceEqual(input.Emails))) return false;
            if (this.Locale != input.Locale || (this.Locale != null && !this.Locale.Equals(input.Locale))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Nickname != input.Nickname || (this.Nickname != null && !this.Nickname.Equals(input.Nickname))) return false;
            if (this.PhoneNumbers != input.PhoneNumbers || (this.PhoneNumbers != null && input.PhoneNumbers != null && !this.PhoneNumbers.SequenceEqual(input.PhoneNumbers))) return false;
            if (this.PreferredLanguage != input.PreferredLanguage || (this.PreferredLanguage != null && !this.PreferredLanguage.Equals(input.PreferredLanguage))) return false;
            if (this.ProfileUrl != input.ProfileUrl || (this.ProfileUrl != null && !this.ProfileUrl.Equals(input.ProfileUrl))) return false;
            if (this.Timezone != input.Timezone || (this.Timezone != null && !this.Timezone.Equals(input.Timezone))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.UserType != input.UserType || (this.UserType != null && !this.UserType.Equals(input.UserType))) return false;
            if (this.PasswordMode != input.PasswordMode) return false;
            if (this.Enterprise != input.Enterprise || (this.Enterprise != null && !this.Enterprise.Equals(input.Enterprise))) return false;

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
                if (this.Addresses != null) hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Emails != null) hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.Locale != null) hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Nickname != null) hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.PhoneNumbers != null) hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.PreferredLanguage != null) hashCode = hashCode * 59 + this.PreferredLanguage.GetHashCode();
                if (this.ProfileUrl != null) hashCode = hashCode * 59 + this.ProfileUrl.GetHashCode();
                if (this.Timezone != null) hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserType != null) hashCode = hashCode * 59 + this.UserType.GetHashCode();
                hashCode = hashCode * 59 + this.PasswordMode.GetHashCode();
                if (this.Enterprise != null) hashCode = hashCode * 59 + this.Enterprise.GetHashCode();
                return hashCode;
            }
        }
    }
}
