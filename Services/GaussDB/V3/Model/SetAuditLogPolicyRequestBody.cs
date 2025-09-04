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
    /// 
    /// </summary>
    public class SetAuditLogPolicyRequestBody 
    {

        /// <summary>
        /// **参数解释**：  审计日志保存天数，0表示关闭审计日志策略。  **约束限制**：  不涉及。  **取值范围**：  0~732。  **默认取值**：  7。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// **参数解释**：  仅关闭审计日志策略时有效。 - true（默认），表示关闭审计日志策略的同时，保留历史审计日志。 - false，表示关闭审计日志策略的同时，删除已有的历史审计日志。  **约束限制**：  不涉及。  **取值范围**：  true|false。  **默认取值**：  true。
        /// </summary>
        [JsonProperty("reserve_audit_logs", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReserveAuditLogs { get; set; }

        /// <summary>
        /// **参数解释**：  审计记录的操作类型，动态范围。空表示不过滤任何操作类型。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("audit_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AuditTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetAuditLogPolicyRequestBody {\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("  reserveAuditLogs: ").Append(ReserveAuditLogs).Append("\n");
            sb.Append("  auditTypes: ").Append(AuditTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetAuditLogPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetAuditLogPolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.KeepDays != input.KeepDays || (this.KeepDays != null && !this.KeepDays.Equals(input.KeepDays))) return false;
            if (this.ReserveAuditLogs != input.ReserveAuditLogs || (this.ReserveAuditLogs != null && !this.ReserveAuditLogs.Equals(input.ReserveAuditLogs))) return false;
            if (this.AuditTypes != input.AuditTypes || (this.AuditTypes != null && input.AuditTypes != null && !this.AuditTypes.SequenceEqual(input.AuditTypes))) return false;

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
                if (this.ReserveAuditLogs != null) hashCode = hashCode * 59 + this.ReserveAuditLogs.GetHashCode();
                if (this.AuditTypes != null) hashCode = hashCode * 59 + this.AuditTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
