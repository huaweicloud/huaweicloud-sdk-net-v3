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
    /// 纳管账号基本信息。
    /// </summary>
    public class AccountBaselineRsp 
    {
        /// <summary>
        /// 纳管账号类型。类型包括LOGGING，SECURITY。
        /// </summary>
        /// <value>纳管账号类型。类型包括LOGGING，SECURITY。</value>
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

            private static readonly Dictionary<string, AccountTypeEnum> StaticFields =
            new Dictionary<string, AccountTypeEnum>()
            {
                { "LOGGING", LOGGING },
                { "SECURITY", SECURITY },
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

            public static bool operator !=(AccountTypeEnum a, AccountTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 纳管账号名称。
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 纳管账号的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 纳管账号类型。类型包括LOGGING，SECURITY。
        /// </summary>
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccountTypeEnum AccountType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountBaselineRsp {\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  accountType: ").Append(AccountType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountBaselineRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccountBaselineRsp input)
        {
            if (input == null) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
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
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                return hashCode;
            }
        }
    }
}
