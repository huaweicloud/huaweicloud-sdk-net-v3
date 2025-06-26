using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAuditLogsResponse : SdkResponse
    {

        /// <summary>
        /// 审计日志列表
        /// </summary>
        [JsonProperty("audit_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuditLog> AuditLogs { get; set; }

        /// <summary>
        /// 审计日志总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAuditLogsResponse {\n");
            sb.Append("  auditLogs: ").Append(AuditLogs).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
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
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
