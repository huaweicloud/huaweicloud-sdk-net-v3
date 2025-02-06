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
    public class DescribeAccountAssignmentDeletionStatusResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("account_assignment_deletion_status", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAssignmentOperationStatusDto AccountAssignmentDeletionStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribeAccountAssignmentDeletionStatusResponse {\n");
            sb.Append("  accountAssignmentDeletionStatus: ").Append(AccountAssignmentDeletionStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DescribeAccountAssignmentDeletionStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DescribeAccountAssignmentDeletionStatusResponse input)
        {
            if (input == null) return false;
            if (this.AccountAssignmentDeletionStatus != input.AccountAssignmentDeletionStatus || (this.AccountAssignmentDeletionStatus != null && !this.AccountAssignmentDeletionStatus.Equals(input.AccountAssignmentDeletionStatus))) return false;

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
                if (this.AccountAssignmentDeletionStatus != null) hashCode = hashCode * 59 + this.AccountAssignmentDeletionStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
