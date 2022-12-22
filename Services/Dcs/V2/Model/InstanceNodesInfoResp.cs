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
    /// 实例信息响应体
    /// </summary>
    public class InstanceNodesInfoResp 
    {

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 当前实例节点总数
        /// </summary>
        [JsonProperty("node_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// 节点详情。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodesInfoResp> Nodes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceNodesInfoResp {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  nodeCount: ").Append(NodeCount).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceNodesInfoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceNodesInfoResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.NodeCount == input.NodeCount ||
                    (this.NodeCount != null &&
                    this.NodeCount.Equals(input.NodeCount))
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    input.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.NodeCount != null)
                    hashCode = hashCode * 59 + this.NodeCount.GetHashCode();
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
