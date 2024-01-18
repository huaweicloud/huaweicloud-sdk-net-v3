using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAuditlogPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 审计日志保存天数，取值范围0~732。0表示关闭审计日志策略。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// 审计记录的操作类型，动态范围。空表示不过滤任何操作类型。
        /// </summary>
        [JsonProperty("audit_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AuditTypes { get; set; }

        /// <summary>
        /// 审计记录的所有操作类型。
        /// </summary>
        [JsonProperty("all_audit_log_action", NullValueHandling = NullValueHandling.Ignore)]
        public string AllAuditLogAction { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAuditlogPolicyResponse {\n");
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
            return this.Equals(input as ShowAuditlogPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuditlogPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeepDays == input.KeepDays ||
                    (this.KeepDays != null &&
                    this.KeepDays.Equals(input.KeepDays))
                ) && 
                (
                    this.AuditTypes == input.AuditTypes ||
                    this.AuditTypes != null &&
                    input.AuditTypes != null &&
                    this.AuditTypes.SequenceEqual(input.AuditTypes)
                ) && 
                (
                    this.AllAuditLogAction == input.AllAuditLogAction ||
                    (this.AllAuditLogAction != null &&
                    this.AllAuditLogAction.Equals(input.AllAuditLogAction))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.KeepDays != null)
                    hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                if (this.AuditTypes != null)
                    hashCode = hashCode * 59 + this.AuditTypes.GetHashCode();
                if (this.AllAuditLogAction != null)
                    hashCode = hashCode * 59 + this.AllAuditLogAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
