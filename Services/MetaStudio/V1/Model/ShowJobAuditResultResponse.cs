using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowJobAuditResultResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("system_audit_result", NullValueHandling = NullValueHandling.Ignore)]
        public AuditResultSystemAuditResult SystemAuditResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("admin_audit_result", NullValueHandling = NullValueHandling.Ignore)]
        public AuditResultAdminAuditResult AdminAuditResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobAuditResultResponse {\n");
            sb.Append("  systemAuditResult: ").Append(SystemAuditResult).Append("\n");
            sb.Append("  adminAuditResult: ").Append(AdminAuditResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobAuditResultResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobAuditResultResponse input)
        {
            if (input == null) return false;
            if (this.SystemAuditResult != input.SystemAuditResult || (this.SystemAuditResult != null && !this.SystemAuditResult.Equals(input.SystemAuditResult))) return false;
            if (this.AdminAuditResult != input.AdminAuditResult || (this.AdminAuditResult != null && !this.AdminAuditResult.Equals(input.AdminAuditResult))) return false;

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
                if (this.SystemAuditResult != null) hashCode = hashCode * 59 + this.SystemAuditResult.GetHashCode();
                if (this.AdminAuditResult != null) hashCode = hashCode * 59 + this.AdminAuditResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
