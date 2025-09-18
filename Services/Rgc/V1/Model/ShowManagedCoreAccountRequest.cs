using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowManagedCoreAccountRequest 
    {
        /// <summary>
        /// 纳管账号类型。类型包括LOGGING，SECURITY和PRIMARY。
        /// </summary>
        /// <value>纳管账号类型。类型包括LOGGING，SECURITY和PRIMARY。</value>
        [JsonConverter(typeof(EnumClassConverter<AccountTypeEnum>))]
        public class AccountTypeEnum
        {
            /// <summary>
            /// Enum LOGGING for value: LOGGING
            /// </summary>
            public static readonly AccountTypeEnum LOGGING = new AccountTypeEnum("LOGGING");

            /// <summary>
            /// Enum SECURITY for value: SECURITY
            /// </summary>
            public static readonly AccountTypeEnum SECURITY = new AccountTypeEnum("SECURITY");

            /// <summary>
            /// Enum PRIMARY for value: PRIMARY
            /// </summary>
            public static readonly AccountTypeEnum PRIMARY = new AccountTypeEnum("PRIMARY");

            private static readonly Dictionary<string, AccountTypeEnum> StaticFields =
            new Dictionary<string, AccountTypeEnum>()
            {
                { "LOGGING", LOGGING },
                { "SECURITY", SECURITY },
                { "PRIMARY", PRIMARY },
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
        /// 纳管账号类型。类型包括LOGGING，SECURITY和PRIMARY。
        /// </summary>
        [SDKProperty("account_type", IsQuery = true)]
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccountTypeEnum AccountType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowManagedCoreAccountRequest {\n");
            sb.Append("  accountType: ").Append(AccountType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowManagedCoreAccountRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowManagedCoreAccountRequest input)
        {
            if (input == null) return false;
            if (this.AccountType != input.AccountType) return false;

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
                hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                return hashCode;
            }
        }
    }
}
