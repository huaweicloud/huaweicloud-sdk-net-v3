using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 创建ACL账号
    /// </summary>
    public class CreateAclAccountRequestBody 
    {
        /// <summary>
        /// 账号权限
        /// </summary>
        /// <value>账号权限</value>
        [JsonConverter(typeof(EnumClassConverter<AccountRoleEnum>))]
        public class AccountRoleEnum
        {
            /// <summary>
            /// Enum READ for value: read
            /// </summary>
            public static readonly AccountRoleEnum READ = new AccountRoleEnum("read");

            /// <summary>
            /// Enum WRITE for value: write
            /// </summary>
            public static readonly AccountRoleEnum WRITE = new AccountRoleEnum("write");

            private static readonly Dictionary<string, AccountRoleEnum> StaticFields =
            new Dictionary<string, AccountRoleEnum>()
            {
                { "read", READ },
                { "write", WRITE },
            };

            private string _value;

            public AccountRoleEnum()
            {

            }

            public AccountRoleEnum(string value)
            {
                _value = value;
            }

            public static AccountRoleEnum FromValue(string value)
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

                if (this.Equals(obj as AccountRoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccountRoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccountRoleEnum a, AccountRoleEnum b)
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

            public static bool operator !=(AccountRoleEnum a, AccountRoleEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 账号名称 - 以字母开头。 - 内容由字母、数字、中划线、下划线组成。 - 长度范围[1~64]个字符。 
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 账号权限
        /// </summary>
        [JsonProperty("account_role", NullValueHandling = NullValueHandling.Ignore)]
        public AccountRoleEnum AccountRole { get; set; }
        /// <summary>
        /// 账号密码 - 输入长度为8到64位的字符串。 - 不能包含正序逆序用户名。 - 必须包含如下四种字符中的三种组合（不允许包含冒号）：   - 小写字母   - 大写字母   - 数字   - 特殊字符包括（&#x60;~!@#$%^&amp;*()-_&#x3D;+\\|{},&lt;.&gt;/?） 
        /// </summary>
        [JsonProperty("account_password", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// 账号描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAclAccountRequestBody {\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  accountRole: ").Append(AccountRole).Append("\n");
            sb.Append("  accountPassword: ").Append(AccountPassword).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAclAccountRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAclAccountRequestBody input)
        {
            if (input == null) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.AccountRole != input.AccountRole) return false;
            if (this.AccountPassword != input.AccountPassword || (this.AccountPassword != null && !this.AccountPassword.Equals(input.AccountPassword))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                hashCode = hashCode * 59 + this.AccountRole.GetHashCode();
                if (this.AccountPassword != null) hashCode = hashCode * 59 + this.AccountPassword.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
