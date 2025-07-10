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
    /// 账户详细信息。
    /// </summary>
    public class AccountInfo 
    {

        /// <summary>
        /// 账户，账户的格式必须为:账户(组)的形式。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 域名(用户组必填，不填时使用默认值 local.com)。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccountTypeEnum AccountType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("platform_type", NullValueHandling = NullValueHandling.Ignore)]
        public PlatformTypeEnum PlatformType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountInfo {\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  accountType: ").Append(AccountType).Append("\n");
            sb.Append("  platformType: ").Append(PlatformType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccountInfo input)
        {
            if (input == null) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.AccountType != input.AccountType) return false;
            if (this.PlatformType != input.PlatformType) return false;

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
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                hashCode = hashCode * 59 + this.PlatformType.GetHashCode();
                return hashCode;
            }
        }
    }
}
