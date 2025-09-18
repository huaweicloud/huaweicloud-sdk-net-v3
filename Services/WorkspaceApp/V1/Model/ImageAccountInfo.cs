using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 用户详细信息。
    /// </summary>
    public class ImageAccountInfo 
    {
        /// <summary>
        /// 用户类型： * &#x60;USER&#x60; - 用户 * &#x60;USER_GROUP&#x60; - 用户组
        /// </summary>
        /// <value>用户类型： * &#x60;USER&#x60; - 用户 * &#x60;USER_GROUP&#x60; - 用户组</value>
        [JsonConverter(typeof(EnumClassConverter<AccountTypeEnum>))]
        public class AccountTypeEnum
        {
            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            public static readonly AccountTypeEnum USER = new AccountTypeEnum("USER");

            /// <summary>
            /// Enum USER_GROUP for value: USER_GROUP
            /// </summary>
            public static readonly AccountTypeEnum USER_GROUP = new AccountTypeEnum("USER_GROUP");

            private static readonly Dictionary<string, AccountTypeEnum> StaticFields =
            new Dictionary<string, AccountTypeEnum>()
            {
                { "USER", USER },
                { "USER_GROUP", USER_GROUP },
            };

            private string _value;

            public AccountTypeEnum()
            {

            }

            public AccountTypeEnum(string value)
            {
                _value = value;
            }

            public static AccountTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AccountTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccountTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccountTypeEnum a, AccountTypeEnum b)
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

            public static bool operator !=(AccountTypeEnum a, AccountTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户(组)。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 用户类型： * &#x60;USER&#x60; - 用户 * &#x60;USER_GROUP&#x60; - 用户组
        /// </summary>
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccountTypeEnum AccountType { get; set; }
        /// <summary>
        /// 域名城。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageAccountInfo {\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  accountType: ").Append(AccountType).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageAccountInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageAccountInfo input)
        {
            if (input == null) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.AccountType != input.AccountType) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;

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
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                return hashCode;
            }
        }
    }
}
