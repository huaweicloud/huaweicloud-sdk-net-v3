using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ApprovalApproverInfoDto 
    {

        /// <summary>
        /// **参数解释：** 需要更新的审核人ID列表 数字以英文逗号分隔 111,222 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("approver_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ApproverIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApprovalApproverInfoDto {\n");
            sb.Append("  approverIds: ").Append(ApproverIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApprovalApproverInfoDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApprovalApproverInfoDto input)
        {
            if (input == null) return false;
            if (this.ApproverIds != input.ApproverIds || (this.ApproverIds != null && !this.ApproverIds.Equals(input.ApproverIds))) return false;

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
                if (this.ApproverIds != null) hashCode = hashCode * 59 + this.ApproverIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
