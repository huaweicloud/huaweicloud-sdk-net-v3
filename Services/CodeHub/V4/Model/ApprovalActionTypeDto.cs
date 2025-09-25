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
    public class ApprovalActionTypeDto 
    {

        /// <summary>
        /// **参数解释：** 审核/检视操作动作 - approve，审核通过 - reject，审核拒绝 - complete，检视通过 - reset，重置审核/检视结果
        /// </summary>
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionType { get; set; }

        /// <summary>
        /// **参数解释：** 审核备注 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("approver_comment", NullValueHandling = NullValueHandling.Ignore)]
        public string ApproverComment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApprovalActionTypeDto {\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("  approverComment: ").Append(ApproverComment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApprovalActionTypeDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApprovalActionTypeDto input)
        {
            if (input == null) return false;
            if (this.ActionType != input.ActionType || (this.ActionType != null && !this.ActionType.Equals(input.ActionType))) return false;
            if (this.ApproverComment != input.ApproverComment || (this.ApproverComment != null && !this.ApproverComment.Equals(input.ApproverComment))) return false;

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
                if (this.ActionType != null) hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.ApproverComment != null) hashCode = hashCode * 59 + this.ApproverComment.GetHashCode();
                return hashCode;
            }
        }
    }
}
