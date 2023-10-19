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
    /// 
    /// </summary>
    public class AclAccountRoleModifyBody 
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

            public static bool operator !=(AccountRoleEnum a, AccountRoleEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 账号权限
        /// </summary>
        [JsonProperty("account_role", NullValueHandling = NullValueHandling.Ignore)]
        public AccountRoleEnum AccountRole { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AclAccountRoleModifyBody {\n");
            sb.Append("  accountRole: ").Append(AccountRole).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AclAccountRoleModifyBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AclAccountRoleModifyBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountRole == input.AccountRole ||
                    (this.AccountRole != null &&
                    this.AccountRole.Equals(input.AccountRole))
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
                if (this.AccountRole != null)
                    hashCode = hashCode * 59 + this.AccountRole.GetHashCode();
                return hashCode;
            }
        }
    }
}
