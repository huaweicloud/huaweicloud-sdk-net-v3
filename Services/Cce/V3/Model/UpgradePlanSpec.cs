using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpgradePlanSpec 
    {

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("clusterID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterID { get; set; }

        /// <summary>
        /// 当前集群版本
        /// </summary>
        [JsonProperty("clusterVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// 本次集群升级的目标版本
        /// </summary>
        [JsonProperty("targetVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 自动升级计划的最早时间（UTC时间），需要早于notBeforeDeadline
        /// </summary>
        [JsonProperty("notBefore", NullValueHandling = NullValueHandling.Ignore)]
        public string NotBefore { get; set; }

        /// <summary>
        /// 自动升级计划的最晚时间（UTC时间）
        /// </summary>
        [JsonProperty("notAfter", NullValueHandling = NullValueHandling.Ignore)]
        public string NotAfter { get; set; }

        /// <summary>
        /// 自动升级计划开始的截止时间（UTC时间）
        /// </summary>
        [JsonProperty("notBeforeDeadline", NullValueHandling = NullValueHandling.Ignore)]
        public string NotBeforeDeadline { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradePlanSpec {\n");
            sb.Append("  clusterID: ").Append(ClusterID).Append("\n");
            sb.Append("  clusterVersion: ").Append(ClusterVersion).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  notBefore: ").Append(NotBefore).Append("\n");
            sb.Append("  notAfter: ").Append(NotAfter).Append("\n");
            sb.Append("  notBeforeDeadline: ").Append(NotBeforeDeadline).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradePlanSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradePlanSpec input)
        {
            if (input == null) return false;
            if (this.ClusterID != input.ClusterID || (this.ClusterID != null && !this.ClusterID.Equals(input.ClusterID))) return false;
            if (this.ClusterVersion != input.ClusterVersion || (this.ClusterVersion != null && !this.ClusterVersion.Equals(input.ClusterVersion))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.NotBefore != input.NotBefore || (this.NotBefore != null && !this.NotBefore.Equals(input.NotBefore))) return false;
            if (this.NotAfter != input.NotAfter || (this.NotAfter != null && !this.NotAfter.Equals(input.NotAfter))) return false;
            if (this.NotBeforeDeadline != input.NotBeforeDeadline || (this.NotBeforeDeadline != null && !this.NotBeforeDeadline.Equals(input.NotBeforeDeadline))) return false;

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
                if (this.ClusterVersion != null) hashCode = hashCode * 59 + this.ClusterVersion.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.NotBefore != null) hashCode = hashCode * 59 + this.NotBefore.GetHashCode();
                if (this.NotAfter != null) hashCode = hashCode * 59 + this.NotAfter.GetHashCode();
                if (this.NotBeforeDeadline != null) hashCode = hashCode * 59 + this.NotBeforeDeadline.GetHashCode();
                return hashCode;
            }
        }
    }
}
