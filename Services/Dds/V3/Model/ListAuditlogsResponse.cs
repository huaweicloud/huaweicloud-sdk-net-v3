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
    /// Response Object
    /// </summary>
    public class ListAuditlogsResponse : SdkResponse
    {

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 审计日志具体信息。
        /// </summary>
        [JsonProperty("audit_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListAuditlogsResult> AuditLogs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAuditlogsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  auditLogs: ").Append(AuditLogs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAuditlogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAuditlogsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.AuditLogs == input.AuditLogs ||
                    this.AuditLogs != null &&
                    input.AuditLogs != null &&
                    this.AuditLogs.SequenceEqual(input.AuditLogs)
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.AuditLogs != null)
                    hashCode = hashCode * 59 + this.AuditLogs.GetHashCode();
                return hashCode;
            }
        }
    }
}
