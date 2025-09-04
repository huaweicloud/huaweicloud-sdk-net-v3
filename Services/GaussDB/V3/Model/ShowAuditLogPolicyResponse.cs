using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAuditLogPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  审计日志保存天数，0表示关闭审计日志策略。   **取值范围**：  0~732。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// **参数解释**：  审计记录的操作类型。空表示不过滤任何操作类型。  **取值范围**：  动态范围。
        /// </summary>
        [JsonProperty("audit_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AuditTypes { get; set; }

        /// <summary>
        /// **参数解释**：  审计记录的操作类型。空表示不过滤任何操作类型。  **取值范围**：  不涉及
        /// </summary>
        [JsonProperty("all_audit_log_action", NullValueHandling = NullValueHandling.Ignore)]
        public string AllAuditLogAction { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAuditLogPolicyResponse {\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("  auditTypes: ").Append(AuditTypes).Append("\n");
            sb.Append("  allAuditLogAction: ").Append(AllAuditLogAction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAuditLogPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuditLogPolicyResponse input)
        {
            if (input == null) return false;
            if (this.KeepDays != input.KeepDays || (this.KeepDays != null && !this.KeepDays.Equals(input.KeepDays))) return false;
            if (this.AuditTypes != input.AuditTypes || (this.AuditTypes != null && input.AuditTypes != null && !this.AuditTypes.SequenceEqual(input.AuditTypes))) return false;
            if (this.AllAuditLogAction != input.AllAuditLogAction || (this.AllAuditLogAction != null && !this.AllAuditLogAction.Equals(input.AllAuditLogAction))) return false;

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
                if (this.KeepDays != null) hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                if (this.AuditTypes != null) hashCode = hashCode * 59 + this.AuditTypes.GetHashCode();
                if (this.AllAuditLogAction != null) hashCode = hashCode * 59 + this.AllAuditLogAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
