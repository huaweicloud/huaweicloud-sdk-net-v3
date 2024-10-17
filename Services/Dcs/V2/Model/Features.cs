using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Features 
    {

        /// <summary>
        /// 是否支持acl - true：是 - false：否 
        /// </summary>
        [JsonProperty("support_acl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportAcl { get; set; }

        /// <summary>
        /// 实例是否支持客户端ip透传 - true：是 - false：否 
        /// </summary>
        [JsonProperty("support_transparent_client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportTransparentClientIp { get; set; }

        /// <summary>
        /// 是否支持SSL - true：是 - false：否 
        /// </summary>
        [JsonProperty("support_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportSsl { get; set; }

        /// <summary>
        /// 是否支持审计日志 - true: 是 - false: 否 
        /// </summary>
        [JsonProperty("support_audit_log", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportAuditLog { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Features {\n");
            sb.Append("  supportAcl: ").Append(SupportAcl).Append("\n");
            sb.Append("  supportTransparentClientIp: ").Append(SupportTransparentClientIp).Append("\n");
            sb.Append("  supportSsl: ").Append(SupportSsl).Append("\n");
            sb.Append("  supportAuditLog: ").Append(SupportAuditLog).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Features);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Features input)
        {
            if (input == null) return false;
            if (this.SupportAcl != input.SupportAcl || (this.SupportAcl != null && !this.SupportAcl.Equals(input.SupportAcl))) return false;
            if (this.SupportTransparentClientIp != input.SupportTransparentClientIp || (this.SupportTransparentClientIp != null && !this.SupportTransparentClientIp.Equals(input.SupportTransparentClientIp))) return false;
            if (this.SupportSsl != input.SupportSsl || (this.SupportSsl != null && !this.SupportSsl.Equals(input.SupportSsl))) return false;
            if (this.SupportAuditLog != input.SupportAuditLog || (this.SupportAuditLog != null && !this.SupportAuditLog.Equals(input.SupportAuditLog))) return false;

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
                if (this.SupportAcl != null) hashCode = hashCode * 59 + this.SupportAcl.GetHashCode();
                if (this.SupportTransparentClientIp != null) hashCode = hashCode * 59 + this.SupportTransparentClientIp.GetHashCode();
                if (this.SupportSsl != null) hashCode = hashCode * 59 + this.SupportSsl.GetHashCode();
                if (this.SupportAuditLog != null) hashCode = hashCode * 59 + this.SupportAuditLog.GetHashCode();
                return hashCode;
            }
        }
    }
}
