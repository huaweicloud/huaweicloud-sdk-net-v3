using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UnsupportedAuditInfoResponse 
    {

        /// <summary>
        /// 审计信息
        /// </summary>
        [JsonProperty("audit_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<UnsupportedAuditInfo> AuditInfos { get; set; }

        /// <summary>
        /// 支持的版本
        /// </summary>
        [JsonProperty("support_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnsupportedAuditInfoResponse {\n");
            sb.Append("  auditInfos: ").Append(AuditInfos).Append("\n");
            sb.Append("  supportVersion: ").Append(SupportVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnsupportedAuditInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnsupportedAuditInfoResponse input)
        {
            if (input == null) return false;
            if (this.AuditInfos != input.AuditInfos || (this.AuditInfos != null && input.AuditInfos != null && !this.AuditInfos.SequenceEqual(input.AuditInfos))) return false;
            if (this.SupportVersion != input.SupportVersion || (this.SupportVersion != null && !this.SupportVersion.Equals(input.SupportVersion))) return false;

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
                if (this.AuditInfos != null) hashCode = hashCode * 59 + this.AuditInfos.GetHashCode();
                if (this.SupportVersion != null) hashCode = hashCode * 59 + this.SupportVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
