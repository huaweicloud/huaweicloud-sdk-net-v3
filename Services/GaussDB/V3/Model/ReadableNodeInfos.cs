using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 可读节点信息。
    /// </summary>
    public class ReadableNodeInfos 
    {

        /// <summary>
        /// 可读节点IP。
        /// </summary>
        [JsonProperty("data_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DataIp { get; set; }

        /// <summary>
        /// 可读节点ID。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 可读节点名称。
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReadableNodeInfos {\n");
            sb.Append("  dataIp: ").Append(DataIp).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReadableNodeInfos);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReadableNodeInfos input)
        {
            if (input == null) return false;
            if (this.DataIp != input.DataIp || (this.DataIp != null && !this.DataIp.Equals(input.DataIp))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.NodeName != input.NodeName || (this.NodeName != null && !this.NodeName.Equals(input.NodeName))) return false;

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
                if (this.DataIp != null) hashCode = hashCode * 59 + this.DataIp.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NodeName != null) hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
