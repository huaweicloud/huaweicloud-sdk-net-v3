using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DirectionalConnectionList 
    {

        /// <summary>
        /// 有向连接列表。
        /// </summary>
        [JsonProperty("directional_connections", NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectionalConnection> DirectionalConnections { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirectionalConnectionList {\n");
            sb.Append("  directionalConnections: ").Append(DirectionalConnections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DirectionalConnectionList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DirectionalConnectionList input)
        {
            if (input == null) return false;
            if (this.DirectionalConnections != input.DirectionalConnections || (this.DirectionalConnections != null && input.DirectionalConnections != null && !this.DirectionalConnections.SequenceEqual(input.DirectionalConnections))) return false;

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
                if (this.DirectionalConnections != null) hashCode = hashCode * 59 + this.DirectionalConnections.GetHashCode();
                return hashCode;
            }
        }
    }
}
