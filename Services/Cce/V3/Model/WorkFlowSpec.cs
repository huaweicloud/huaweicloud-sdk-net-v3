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
    public class WorkFlowSpec 
    {

        /// <summary>
        /// 集群ID，资源唯一标识，创建成功后自动生成，填写无效
        /// </summary>
        [JsonProperty("clusterID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterID { get; set; }

        /// <summary>
        /// 本次集群升级的当前版本 
        /// </summary>
        [JsonProperty("clusterVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// 本次集群升级的目标版本 
        /// </summary>
        [JsonProperty("targetVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkFlowSpec {\n");
            sb.Append("  clusterID: ").Append(ClusterID).Append("\n");
            sb.Append("  clusterVersion: ").Append(ClusterVersion).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkFlowSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkFlowSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterID == input.ClusterID ||
                    (this.ClusterID != null &&
                    this.ClusterID.Equals(input.ClusterID))
                ) && 
                (
                    this.ClusterVersion == input.ClusterVersion ||
                    (this.ClusterVersion != null &&
                    this.ClusterVersion.Equals(input.ClusterVersion))
                ) && 
                (
                    this.TargetVersion == input.TargetVersion ||
                    (this.TargetVersion != null &&
                    this.TargetVersion.Equals(input.TargetVersion))
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
                if (this.ClusterID != null)
                    hashCode = hashCode * 59 + this.ClusterID.GetHashCode();
                if (this.ClusterVersion != null)
                    hashCode = hashCode * 59 + this.ClusterVersion.GetHashCode();
                if (this.TargetVersion != null)
                    hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
