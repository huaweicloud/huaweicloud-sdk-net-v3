using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplyHistory 
    {

        /// <summary>
        /// **参数解释**：  参数组ID。  **约束限制**：  不涉及。  **取值范围**：  只能由英文字母、数字组成，长度为36个字符。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }

        /// <summary>
        /// **参数解释**：  参数组的名称。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("target_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetName { get; set; }

        /// <summary>
        /// **参数解释**：  应用结果。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("apply_result", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyResult { get; set; }

        /// <summary>
        /// **参数解释**：  应用日期。  格式为yyyy-mm-dd Thh:mm:ssZ。  其中，T指定某个时间的开始；Z指示 UTC 时间。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("applied_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AppliedAt { get; set; }

        /// <summary>
        /// **参数解释**：  错误码。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyHistory {\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("  targetName: ").Append(TargetName).Append("\n");
            sb.Append("  applyResult: ").Append(ApplyResult).Append("\n");
            sb.Append("  appliedAt: ").Append(AppliedAt).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyHistory);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyHistory input)
        {
            if (input == null) return false;
            if (this.TargetId != input.TargetId || (this.TargetId != null && !this.TargetId.Equals(input.TargetId))) return false;
            if (this.TargetName != input.TargetName || (this.TargetName != null && !this.TargetName.Equals(input.TargetName))) return false;
            if (this.ApplyResult != input.ApplyResult || (this.ApplyResult != null && !this.ApplyResult.Equals(input.ApplyResult))) return false;
            if (this.AppliedAt != input.AppliedAt || (this.AppliedAt != null && !this.AppliedAt.Equals(input.AppliedAt))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;

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
                if (this.TargetId != null) hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                if (this.TargetName != null) hashCode = hashCode * 59 + this.TargetName.GetHashCode();
                if (this.ApplyResult != null) hashCode = hashCode * 59 + this.ApplyResult.GetHashCode();
                if (this.AppliedAt != null) hashCode = hashCode * 59 + this.AppliedAt.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
