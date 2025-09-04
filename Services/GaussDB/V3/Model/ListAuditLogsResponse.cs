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
    public class ListAuditLogsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  记录列表。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("audit_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuditLogDetail> AuditLogs { get; set; }

        /// <summary>
        /// **参数解释**：  总记录数。  **取值范围**：  不小于0。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAuditLogsResponse {\n");
            sb.Append("  auditLogs: ").Append(AuditLogs).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAuditLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAuditLogsResponse input)
        {
            if (input == null) return false;
            if (this.AuditLogs != input.AuditLogs || (this.AuditLogs != null && input.AuditLogs != null && !this.AuditLogs.SequenceEqual(input.AuditLogs))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.AuditLogs != null) hashCode = hashCode * 59 + this.AuditLogs.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
