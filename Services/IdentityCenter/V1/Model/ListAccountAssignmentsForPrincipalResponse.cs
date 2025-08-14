using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAccountAssignmentsForPrincipalResponse : SdkResponse
    {

        /// <summary>
        /// 满足查询条件的账号分配列表
        /// </summary>
        [JsonProperty("account_assignments", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountAssignmentDto> AccountAssignments { get; set; }

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
            sb.Append("class ListAccountAssignmentsForPrincipalResponse {\n");
            sb.Append("  accountAssignments: ").Append(AccountAssignments).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccountAssignmentsForPrincipalResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccountAssignmentsForPrincipalResponse input)
        {
            if (input == null) return false;
            if (this.AccountAssignments != input.AccountAssignments || (this.AccountAssignments != null && input.AccountAssignments != null && !this.AccountAssignments.SequenceEqual(input.AccountAssignments))) return false;
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
                if (this.AccountAssignments != null) hashCode = hashCode * 59 + this.AccountAssignments.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
