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
    public class ListAccountAssignmentDeletionStatusResponse : SdkResponse
    {

        /// <summary>
        /// 操作状态列表
        /// </summary>
        [JsonProperty("account_assignments_deletion_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountAssignmentOperationStatusMetadataDto> AccountAssignmentsDeletionStatus { get; set; }

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
            sb.Append("class ListAccountAssignmentDeletionStatusResponse {\n");
            sb.Append("  accountAssignmentsDeletionStatus: ").Append(AccountAssignmentsDeletionStatus).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccountAssignmentDeletionStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccountAssignmentDeletionStatusResponse input)
        {
            if (input == null) return false;
            if (this.AccountAssignmentsDeletionStatus != input.AccountAssignmentsDeletionStatus || (this.AccountAssignmentsDeletionStatus != null && input.AccountAssignmentsDeletionStatus != null && !this.AccountAssignmentsDeletionStatus.SequenceEqual(input.AccountAssignmentsDeletionStatus))) return false;
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
                if (this.AccountAssignmentsDeletionStatus != null) hashCode = hashCode * 59 + this.AccountAssignmentsDeletionStatus.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
