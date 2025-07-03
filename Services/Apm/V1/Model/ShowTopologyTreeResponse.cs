using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTopologyTreeResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("topology_tree", NullValueHandling = NullValueHandling.Ignore)]
        public TopologyTree TopologyTree { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTopologyTreeResponse {\n");
            sb.Append("  topologyTree: ").Append(TopologyTree).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTopologyTreeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTopologyTreeResponse input)
        {
            if (input == null) return false;
            if (this.TopologyTree != input.TopologyTree || (this.TopologyTree != null && !this.TopologyTree.Equals(input.TopologyTree))) return false;

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
                if (this.TopologyTree != null) hashCode = hashCode * 59 + this.TopologyTree.GetHashCode();
                return hashCode;
            }
        }
    }
}
