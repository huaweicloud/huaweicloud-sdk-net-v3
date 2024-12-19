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
    public class ChangeNodesStartStopStatusBody 
    {

        /// <summary>
        /// 实例需要启停的节点ID列表。未配置该参数时，默认启停实例全部节点。
        /// </summary>
        [JsonProperty("node_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// 对实例节点的操作：  start：开启节点  stop：关闭节点 
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeNodesStartStopStatusBody {\n");
            sb.Append("  nodeIds: ").Append(NodeIds).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeNodesStartStopStatusBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeNodesStartStopStatusBody input)
        {
            if (input == null) return false;
            if (this.NodeIds != input.NodeIds || (this.NodeIds != null && input.NodeIds != null && !this.NodeIds.SequenceEqual(input.NodeIds))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;

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
                if (this.NodeIds != null) hashCode = hashCode * 59 + this.NodeIds.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                return hashCode;
            }
        }
    }
}
