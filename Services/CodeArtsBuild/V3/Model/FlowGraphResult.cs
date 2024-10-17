using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class FlowGraphResult 
    {

        /// <summary>
        /// edges
        /// </summary>
        [JsonProperty("edges", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowGraphResultEdges> Edges { get; set; }

        /// <summary>
        /// record信息
        /// </summary>
        [JsonProperty("vertices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Vertices> Vertices { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowGraphResult {\n");
            sb.Append("  edges: ").Append(Edges).Append("\n");
            sb.Append("  vertices: ").Append(Vertices).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowGraphResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowGraphResult input)
        {
            if (input == null) return false;
            if (this.Edges != input.Edges || (this.Edges != null && input.Edges != null && !this.Edges.SequenceEqual(input.Edges))) return false;
            if (this.Vertices != input.Vertices || (this.Vertices != null && input.Vertices != null && !this.Vertices.SequenceEqual(input.Vertices))) return false;

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
                if (this.Edges != null) hashCode = hashCode * 59 + this.Edges.GetHashCode();
                if (this.Vertices != null) hashCode = hashCode * 59 + this.Vertices.GetHashCode();
                return hashCode;
            }
        }
    }
}
