using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceSessionsResponse : SdkResponse
    {

        /// <summary>
        /// 节点的会话信息列表。
        /// </summary>
        [JsonProperty("node_sessions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListNodeSessionsResult> NodeSessions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceSessionsResponse {\n");
            sb.Append("  nodeSessions: ").Append(NodeSessions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceSessionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceSessionsResponse input)
        {
            if (input == null) return false;
            if (this.NodeSessions != input.NodeSessions || (this.NodeSessions != null && input.NodeSessions != null && !this.NodeSessions.SequenceEqual(input.NodeSessions))) return false;

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
                if (this.NodeSessions != null) hashCode = hashCode * 59 + this.NodeSessions.GetHashCode();
                return hashCode;
            }
        }
    }
}
