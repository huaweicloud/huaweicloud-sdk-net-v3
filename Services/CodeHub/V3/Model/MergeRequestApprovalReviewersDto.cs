using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MergeRequestApprovalReviewersDto 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("approval_merge_request_reviewers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApprovalUserDto> ApprovalMergeRequestReviewers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestApprovalReviewersDto {\n");
            sb.Append("  approvalMergeRequestReviewers: ").Append(ApprovalMergeRequestReviewers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestApprovalReviewersDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestApprovalReviewersDto input)
        {
            if (input == null) return false;
            if (this.ApprovalMergeRequestReviewers != input.ApprovalMergeRequestReviewers || (this.ApprovalMergeRequestReviewers != null && input.ApprovalMergeRequestReviewers != null && !this.ApprovalMergeRequestReviewers.SequenceEqual(input.ApprovalMergeRequestReviewers))) return false;

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
                if (this.ApprovalMergeRequestReviewers != null) hashCode = hashCode * 59 + this.ApprovalMergeRequestReviewers.GetHashCode();
                return hashCode;
            }
        }
    }
}
