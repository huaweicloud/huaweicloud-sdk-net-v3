using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ApprovalReviewerInfoDto 
    {

        /// <summary>
        /// **参数解释：** 需要更新的检视人ID列表 数字以英文逗号分隔 111,222 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("reviewer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewerIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApprovalReviewerInfoDto {\n");
            sb.Append("  reviewerIds: ").Append(ReviewerIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApprovalReviewerInfoDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApprovalReviewerInfoDto input)
        {
            if (input == null) return false;
            if (this.ReviewerIds != input.ReviewerIds || (this.ReviewerIds != null && !this.ReviewerIds.Equals(input.ReviewerIds))) return false;

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
                if (this.ReviewerIds != null) hashCode = hashCode * 59 + this.ReviewerIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
