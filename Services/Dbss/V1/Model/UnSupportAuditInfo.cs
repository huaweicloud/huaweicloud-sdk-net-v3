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
    public class UnSupportAuditInfo 
    {

        /// <summary>
        /// 实例版本
        /// </summary>
        [JsonProperty("audit_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditVersion { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("server_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnSupportAuditInfo {\n");
            sb.Append("  auditVersion: ").Append(AuditVersion).Append("\n");
            sb.Append("  serverName: ").Append(ServerName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnSupportAuditInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnSupportAuditInfo input)
        {
            if (input == null) return false;
            if (this.AuditVersion != input.AuditVersion || (this.AuditVersion != null && !this.AuditVersion.Equals(input.AuditVersion))) return false;
            if (this.ServerName != input.ServerName || (this.ServerName != null && !this.ServerName.Equals(input.ServerName))) return false;

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
                if (this.AuditVersion != null) hashCode = hashCode * 59 + this.AuditVersion.GetHashCode();
                if (this.ServerName != null) hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                return hashCode;
            }
        }
    }
}
