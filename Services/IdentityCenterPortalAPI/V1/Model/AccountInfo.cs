using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterPortalAPI.V1.Model
{
    /// <summary>
    /// Provides information about your account.
    /// </summary>
    public class AccountInfo 
    {

        /// <summary>
        /// 分配给用户的账号的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 分配给用户的账号的名称
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 分配给用户的账号的电子邮箱地址
        /// </summary>
        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountInfo {\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  emailAddress: ").Append(EmailAddress).Append("\n");
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
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.EmailAddress != input.EmailAddress || (this.EmailAddress != null && !this.EmailAddress.Equals(input.EmailAddress))) return false;

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
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.EmailAddress != null) hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
