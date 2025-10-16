using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAuditLogResponse : SdkResponse
    {

        /// <summary>
        /// 日志总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 日志列表
        /// </summary>
        [JsonProperty("audit_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowAuditLogResponseBodyAuditRecords> AuditRecords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAuditLogResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  auditRecords: ").Append(AuditRecords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAuditLogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuditLogResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.AuditRecords != input.AuditRecords || (this.AuditRecords != null && input.AuditRecords != null && !this.AuditRecords.SequenceEqual(input.AuditRecords))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.AuditRecords != null) hashCode = hashCode * 59 + this.AuditRecords.GetHashCode();
                return hashCode;
            }
        }
    }
}
