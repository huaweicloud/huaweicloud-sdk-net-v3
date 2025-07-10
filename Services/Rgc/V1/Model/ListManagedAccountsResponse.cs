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
    /// Response Object
    /// </summary>
    public class ListManagedAccountsResponse : SdkResponse
    {

        /// <summary>
        /// 纳管的账号信息。
        /// </summary>
        [JsonProperty("managed_accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ManagedAccount> ManagedAccounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoDto PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListManagedAccountsResponse {\n");
            sb.Append("  managedAccounts: ").Append(ManagedAccounts).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListManagedAccountsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListManagedAccountsResponse input)
        {
            if (input == null) return false;
            if (this.ManagedAccounts != input.ManagedAccounts || (this.ManagedAccounts != null && input.ManagedAccounts != null && !this.ManagedAccounts.SequenceEqual(input.ManagedAccounts))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.ManagedAccounts != null) hashCode = hashCode * 59 + this.ManagedAccounts.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
