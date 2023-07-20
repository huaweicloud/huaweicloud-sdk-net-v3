using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AomMappingRuleInfo 
    {

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }

        /// <summary>
        /// 日志流前缀
        /// </summary>
        [JsonProperty("deployments_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploymentsPrefix { get; set; }

        /// <summary>
        /// 工作负载
        /// </summary>
        [JsonProperty("deployments", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Deployments { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 容器名称
        /// </summary>
        [JsonProperty("container_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerName { get; set; }

        /// <summary>
        /// 接入规则详情
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<AomMappingfilesInfo> Files { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AomMappingRuleInfo {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  clusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  deploymentsPrefix: ").Append(DeploymentsPrefix).Append("\n");
            sb.Append("  deployments: ").Append(Deployments).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  containerName: ").Append(ContainerName).Append("\n");
            sb.Append("  files: ").Append(Files).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AomMappingRuleInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AomMappingRuleInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.DeploymentsPrefix == input.DeploymentsPrefix ||
                    (this.DeploymentsPrefix != null &&
                    this.DeploymentsPrefix.Equals(input.DeploymentsPrefix))
                ) && 
                (
                    this.Deployments == input.Deployments ||
                    this.Deployments != null &&
                    input.Deployments != null &&
                    this.Deployments.SequenceEqual(input.Deployments)
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.ContainerName == input.ContainerName ||
                    (this.ContainerName != null &&
                    this.ContainerName.Equals(input.ContainerName))
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    input.Files != null &&
                    this.Files.SequenceEqual(input.Files)
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.DeploymentsPrefix != null)
                    hashCode = hashCode * 59 + this.DeploymentsPrefix.GetHashCode();
                if (this.Deployments != null)
                    hashCode = hashCode * 59 + this.Deployments.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ContainerName != null)
                    hashCode = hashCode * 59 + this.ContainerName.GetHashCode();
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                return hashCode;
            }
        }
    }
}
