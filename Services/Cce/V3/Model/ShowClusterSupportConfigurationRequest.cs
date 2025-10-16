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
    /// Request Object
    /// </summary>
    public class ShowClusterSupportConfigurationRequest 
    {

        /// <summary>
        /// **参数解释**： 该参数用于过滤集群架构 **约束限制**： 不涉及 **取值范围**： - ARM64: 仅获取鲲鹏集群支持的配置项  **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("clusterType", IsQuery = true)]
        [JsonProperty("clusterType", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterType { get; set; }

        /// <summary>
        /// **参数解释**： 该参数用于获取指定集群版本支持的配置项 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("clusterVersion", IsQuery = true)]
        [JsonProperty("clusterVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// **参数解释**： 该参数用于获取指定集群支持的配置项 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("clusterID", IsQuery = true)]
        [JsonProperty("clusterID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterID { get; set; }

        /// <summary>
        /// **参数解释**： 该参数用于过滤掉集群网络模型相关配置项 **约束限制**： 不涉及 **取值范围**： - eni: 过滤掉云原生网络2.0模型相关配置  **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("networkMode", IsQuery = true)]
        [JsonProperty("networkMode", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowClusterSupportConfigurationRequest {\n");
            sb.Append("  clusterType: ").Append(ClusterType).Append("\n");
            sb.Append("  clusterVersion: ").Append(ClusterVersion).Append("\n");
            sb.Append("  clusterID: ").Append(ClusterID).Append("\n");
            sb.Append("  networkMode: ").Append(NetworkMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowClusterSupportConfigurationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowClusterSupportConfigurationRequest input)
        {
            if (input == null) return false;
            if (this.ClusterType != input.ClusterType || (this.ClusterType != null && !this.ClusterType.Equals(input.ClusterType))) return false;
            if (this.ClusterVersion != input.ClusterVersion || (this.ClusterVersion != null && !this.ClusterVersion.Equals(input.ClusterVersion))) return false;
            if (this.ClusterID != input.ClusterID || (this.ClusterID != null && !this.ClusterID.Equals(input.ClusterID))) return false;
            if (this.NetworkMode != input.NetworkMode || (this.NetworkMode != null && !this.NetworkMode.Equals(input.NetworkMode))) return false;

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
                if (this.ClusterType != null) hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.ClusterVersion != null) hashCode = hashCode * 59 + this.ClusterVersion.GetHashCode();
                if (this.ClusterID != null) hashCode = hashCode * 59 + this.ClusterID.GetHashCode();
                if (this.NetworkMode != null) hashCode = hashCode * 59 + this.NetworkMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
