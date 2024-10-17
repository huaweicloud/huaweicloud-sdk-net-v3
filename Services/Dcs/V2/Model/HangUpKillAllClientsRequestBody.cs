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
    public class HangUpKillAllClientsRequestBody 
    {

        /// <summary>
        /// 指定要kill全部会话的节点ID，kill_all_nodes为false时必填
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// true：Kill实例全部节点的会话 false: kill指定节点的全部会话
        /// </summary>
        [JsonProperty("kill_all_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? KillAllNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HangUpKillAllClientsRequestBody {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  killAllNodes: ").Append(KillAllNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HangUpKillAllClientsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HangUpKillAllClientsRequestBody input)
        {
            if (input == null) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.KillAllNodes != input.KillAllNodes || (this.KillAllNodes != null && !this.KillAllNodes.Equals(input.KillAllNodes))) return false;

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
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.KillAllNodes != null) hashCode = hashCode * 59 + this.KillAllNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
