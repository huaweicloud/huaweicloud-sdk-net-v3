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
    /// Response Object
    /// </summary>
    public class ListAccountsResponse : SdkResponse
    {

        /// <summary>
        /// 满足查询条件的账号对象列表
        /// </summary>
        [JsonProperty("account_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountInfo> AccountList { get; set; }

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
            sb.Append("class ListAccountsResponse {\n");
            sb.Append("  accountList: ").Append(AccountList).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccountsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccountsResponse input)
        {
            if (input == null) return false;
            if (this.AccountList != input.AccountList || (this.AccountList != null && input.AccountList != null && !this.AccountList.SequenceEqual(input.AccountList))) return false;
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
                if (this.AccountList != null) hashCode = hashCode * 59 + this.AccountList.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
