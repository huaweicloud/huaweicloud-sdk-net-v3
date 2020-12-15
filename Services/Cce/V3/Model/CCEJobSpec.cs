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
    public class CCEJobSpec 
    {

        /// <summary>
        /// 作业所在的集群的ID。
        /// </summary>
        [JsonProperty("clusterUID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterUID { get; set; }

        /// <summary>
        /// 扩展参数。
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExtendParam { get; set; }

        /// <summary>
        /// 作业操作的资源ID。
        /// </summary>
        [JsonProperty("resourceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceID { get; set; }

        /// <summary>
        /// 作业操作的资源名称。
        /// </summary>
        [JsonProperty("resourceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 子作业的列表。  - 包含了所有子作业的详细信息 - 在创建集群、节点等场景下，通常会由多个子作业共同组成创建作业，在子作业都完成后，作业才会完成 
        /// </summary>
        [JsonProperty("subJobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CCEJob> SubJobs { get; set; }

        /// <summary>
        /// 作业的类型，例：“CreateCluster”- 创建集群。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CCEJobSpec {\n");
            sb.Append("  clusterUID: ").Append(ClusterUID).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("  resourceID: ").Append(ResourceID).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  subJobs: ").Append(SubJobs).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CCEJobSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CCEJobSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterUID == input.ClusterUID ||
                    (this.ClusterUID != null &&
                    this.ClusterUID.Equals(input.ClusterUID))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    this.ExtendParam != null &&
                    input.ExtendParam != null &&
                    this.ExtendParam.SequenceEqual(input.ExtendParam)
                ) && 
                (
                    this.ResourceID == input.ResourceID ||
                    (this.ResourceID != null &&
                    this.ResourceID.Equals(input.ResourceID))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.SubJobs == input.SubJobs ||
                    this.SubJobs != null &&
                    input.SubJobs != null &&
                    this.SubJobs.SequenceEqual(input.SubJobs)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ClusterUID != null)
                    hashCode = hashCode * 59 + this.ClusterUID.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                if (this.ResourceID != null)
                    hashCode = hashCode * 59 + this.ResourceID.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.SubJobs != null)
                    hashCode = hashCode * 59 + this.SubJobs.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
