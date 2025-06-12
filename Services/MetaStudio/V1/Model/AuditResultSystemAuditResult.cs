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
    /// 系统审核结果。
    /// </summary>
    public class AuditResultSystemAuditResult 
    {

        /// <summary>
        /// 操作时间。
        /// </summary>
        [JsonProperty("audit_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AuditTime { get; set; }

        /// <summary>
        /// 错误列表。
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuditResultSystemAuditResultErrors> Errors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditResultSystemAuditResult {\n");
            sb.Append("  auditTime: ").Append(AuditTime).Append("\n");
            sb.Append("  errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditResultSystemAuditResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditResultSystemAuditResult input)
        {
            if (input == null) return false;
            if (this.AuditTime != input.AuditTime || (this.AuditTime != null && !this.AuditTime.Equals(input.AuditTime))) return false;
            if (this.Errors != input.Errors || (this.Errors != null && input.Errors != null && !this.Errors.SequenceEqual(input.Errors))) return false;

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
                if (this.AuditTime != null) hashCode = hashCode * 59 + this.AuditTime.GetHashCode();
                if (this.Errors != null) hashCode = hashCode * 59 + this.Errors.GetHashCode();
                return hashCode;
            }
        }
    }
}
