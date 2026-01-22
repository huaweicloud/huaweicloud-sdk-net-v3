using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountDto 
    {

        /// <summary>
        /// **参数解释**： 账号列表 **约束限制**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountInfo> Accounts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountDto {\n");
            sb.Append("  accounts: ").Append(Accounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccountDto input)
        {
            if (input == null) return false;
            if (this.Accounts != input.Accounts || (this.Accounts != null && input.Accounts != null && !this.Accounts.SequenceEqual(input.Accounts))) return false;

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
                if (this.Accounts != null) hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                return hashCode;
            }
        }
    }
}
