using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 评审配置
    /// </summary>
    public class ProcessInstanceResponseResultReviewConfig 
    {

        /// <summary>
        /// 审批类型
        /// </summary>
        [JsonProperty("approval_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovalType { get; set; }

        /// <summary>
        /// 审批进度
        /// </summary>
        [JsonProperty("ratio_value", NullValueHandling = NullValueHandling.Ignore)]
        public string RatioValue { get; set; }

        /// <summary>
        /// 是否跳过决策
        /// </summary>
        [JsonProperty("skip_decisioning", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SkipDecisioning { get; set; }

        /// <summary>
        /// 决策角色
        /// </summary>
        [JsonProperty("approval_roles", NullValueHandling = NullValueHandling.Ignore)]
        public string ApprovalRoles { get; set; }

        /// <summary>
        /// 审批角色
        /// </summary>
        [JsonProperty("review_roles", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewRoles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessInstanceResponseResultReviewConfig {\n");
            sb.Append("  approvalType: ").Append(ApprovalType).Append("\n");
            sb.Append("  ratioValue: ").Append(RatioValue).Append("\n");
            sb.Append("  skipDecisioning: ").Append(SkipDecisioning).Append("\n");
            sb.Append("  approvalRoles: ").Append(ApprovalRoles).Append("\n");
            sb.Append("  reviewRoles: ").Append(ReviewRoles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProcessInstanceResponseResultReviewConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProcessInstanceResponseResultReviewConfig input)
        {
            if (input == null) return false;
            if (this.ApprovalType != input.ApprovalType || (this.ApprovalType != null && !this.ApprovalType.Equals(input.ApprovalType))) return false;
            if (this.RatioValue != input.RatioValue || (this.RatioValue != null && !this.RatioValue.Equals(input.RatioValue))) return false;
            if (this.SkipDecisioning != input.SkipDecisioning || (this.SkipDecisioning != null && !this.SkipDecisioning.Equals(input.SkipDecisioning))) return false;
            if (this.ApprovalRoles != input.ApprovalRoles || (this.ApprovalRoles != null && !this.ApprovalRoles.Equals(input.ApprovalRoles))) return false;
            if (this.ReviewRoles != input.ReviewRoles || (this.ReviewRoles != null && !this.ReviewRoles.Equals(input.ReviewRoles))) return false;

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
                if (this.ApprovalType != null) hashCode = hashCode * 59 + this.ApprovalType.GetHashCode();
                if (this.RatioValue != null) hashCode = hashCode * 59 + this.RatioValue.GetHashCode();
                if (this.SkipDecisioning != null) hashCode = hashCode * 59 + this.SkipDecisioning.GetHashCode();
                if (this.ApprovalRoles != null) hashCode = hashCode * 59 + this.ApprovalRoles.GetHashCode();
                if (this.ReviewRoles != null) hashCode = hashCode * 59 + this.ReviewRoles.GetHashCode();
                return hashCode;
            }
        }
    }
}
