using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AttachInternalIpRequestBody 
    {

        /// <summary>
        /// 节点ID。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 新的Ip需要为用户可用vpc中的网段。只支持IPV4。
        /// </summary>
        [JsonProperty("new_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string NewIp { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachInternalIpRequestBody {\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  newIp: ").Append(NewIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachInternalIpRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachInternalIpRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.NewIp == input.NewIp ||
                    (this.NewIp != null &&
                    this.NewIp.Equals(input.NewIp))
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
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.NewIp != null)
                    hashCode = hashCode * 59 + this.NewIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
