using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UCSStatusViolation 
    {

        /// <summary>
        /// 进行审计的集群ID
        /// </summary>
        [JsonProperty("clusterID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterID { get; set; }

        /// <summary>
        /// 审计时间
        /// </summary>
        [JsonProperty("auditTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditTimestamp { get; set; }

        /// <summary>
        /// 违规状态列表
        /// </summary>
        [JsonProperty("clusterViolations", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusViolation> ClusterViolations { get; set; }

        /// <summary>
        /// 拦截事件列表
        /// </summary>
        [JsonProperty("clusterEvents", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusEvent> ClusterEvents { get; set; }

        /// <summary>
        /// 告警事件列表
        /// </summary>
        [JsonProperty("warnEvents", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusEvent> WarnEvents { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UCSStatusViolation {\n");
            sb.Append("  clusterID: ").Append(ClusterID).Append("\n");
            sb.Append("  auditTimestamp: ").Append(AuditTimestamp).Append("\n");
            sb.Append("  clusterViolations: ").Append(ClusterViolations).Append("\n");
            sb.Append("  clusterEvents: ").Append(ClusterEvents).Append("\n");
            sb.Append("  warnEvents: ").Append(WarnEvents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UCSStatusViolation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UCSStatusViolation input)
        {
            if (input == null) return false;
            if (this.ClusterID != input.ClusterID || (this.ClusterID != null && !this.ClusterID.Equals(input.ClusterID))) return false;
            if (this.AuditTimestamp != input.AuditTimestamp || (this.AuditTimestamp != null && !this.AuditTimestamp.Equals(input.AuditTimestamp))) return false;
            if (this.ClusterViolations != input.ClusterViolations || (this.ClusterViolations != null && input.ClusterViolations != null && !this.ClusterViolations.SequenceEqual(input.ClusterViolations))) return false;
            if (this.ClusterEvents != input.ClusterEvents || (this.ClusterEvents != null && input.ClusterEvents != null && !this.ClusterEvents.SequenceEqual(input.ClusterEvents))) return false;
            if (this.WarnEvents != input.WarnEvents || (this.WarnEvents != null && input.WarnEvents != null && !this.WarnEvents.SequenceEqual(input.WarnEvents))) return false;

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
                if (this.ClusterID != null) hashCode = hashCode * 59 + this.ClusterID.GetHashCode();
                if (this.AuditTimestamp != null) hashCode = hashCode * 59 + this.AuditTimestamp.GetHashCode();
                if (this.ClusterViolations != null) hashCode = hashCode * 59 + this.ClusterViolations.GetHashCode();
                if (this.ClusterEvents != null) hashCode = hashCode * 59 + this.ClusterEvents.GetHashCode();
                if (this.WarnEvents != null) hashCode = hashCode * 59 + this.WarnEvents.GetHashCode();
                return hashCode;
            }
        }
    }
}
