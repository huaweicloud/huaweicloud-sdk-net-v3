using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetAuditlogPolicyRequestBody 
    {

        /// <summary>
        /// 审计日志保存天数，取值范围0，7~732。 - 取值0，表示关闭审计日志策略。 - 取值7~732，表示开启审计日志策略，并设置审计日志保存天数为该值。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }

        /// <summary>
        /// 仅关闭审计日志策略时有效。 - true（默认），表示关闭审计日志策略的同时，保留历史审计日志。 - false，表示关闭审计日志策略的同时，删除已有的历史审计日志。
        /// </summary>
        [JsonProperty("reserve_auditlogs", NullValueHandling = NullValueHandling.Ignore)]
        public string ReserveAuditlogs { get; set; }

        /// <summary>
        /// 仅打开审计日志策略时有效，并且为空时，默认全部。审计范围。请输入数据库或集合名称，多个库或集合请用英文逗号分隔。若名称中有英文逗号，请在逗号前添加“$”符号，用以区分分隔符。
        /// </summary>
        [JsonProperty("audit_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditScope { get; set; }

        /// <summary>
        /// 仅打开审计日志策略时有效，并且为空时，默认全部。审计类型。支持insert，delete，update，query等。
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
            sb.Append("  auditScope: ").Append(AuditScope).Append("\n");
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
                    this.AuditScope == input.AuditScope ||
                    (this.AuditScope != null &&
                    this.AuditScope.Equals(input.AuditScope))
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
                if (this.AuditScope != null)
                    hashCode = hashCode * 59 + this.AuditScope.GetHashCode();
                if (this.AuditTypes != null)
                    hashCode = hashCode * 59 + this.AuditTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
