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
    /// 
    /// </summary>
    public class SetAuditlogPolicyRequestBody 
    {

        /// <summary>
        /// 审计日志保存天数，取值范围0~732。0表示关闭审计日志策略。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// 仅关闭审计日志策略时有效。  - true（默认），表示关闭审计日志策略的同时，延迟删除已有的历史审计日志。 - false，表示关闭审计日志策略的同时，删除已有的历史审计日志。
        /// </summary>
        [JsonProperty("reserve_auditlogs", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReserveAuditlogs { get; set; }

        /// <summary>
        /// 审计记录的操作类型，动态范围。空表示不过滤任何操作类型。
        /// </summary>
        [JsonProperty("audit_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AuditTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetAuditlogPolicyRequestBody {\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("  reserveAuditlogs: ").Append(ReserveAuditlogs).Append("\n");
            sb.Append("  auditTypes: ").Append(AuditTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetAuditlogPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetAuditlogPolicyRequestBody input)
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
                    this.ReserveAuditlogs == input.ReserveAuditlogs ||
                    (this.ReserveAuditlogs != null &&
                    this.ReserveAuditlogs.Equals(input.ReserveAuditlogs))
                ) && 
                (
                    this.AuditTypes == input.AuditTypes ||
                    this.AuditTypes != null &&
                    input.AuditTypes != null &&
                    this.AuditTypes.SequenceEqual(input.AuditTypes)
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
                if (this.ReserveAuditlogs != null)
                    hashCode = hashCode * 59 + this.ReserveAuditlogs.GetHashCode();
                if (this.AuditTypes != null)
                    hashCode = hashCode * 59 + this.AuditTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
