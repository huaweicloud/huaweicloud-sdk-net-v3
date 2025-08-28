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
    /// 分支网络两端接入对象。
    /// </summary>
    public class DirectedEdgePair 
    {

        /// <summary>
        /// 分支网络连接的两个端点定义，长度固定为2的数组。
        /// </summary>
        [JsonProperty("edge_pair", NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectedEdge> EdgePair { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirectedEdgePair {\n");
            sb.Append("  edgePair: ").Append(EdgePair).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DirectedEdgePair);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DirectedEdgePair input)
        {
            if (input == null) return false;
            if (this.EdgePair != input.EdgePair || (this.EdgePair != null && input.EdgePair != null && !this.EdgePair.SequenceEqual(input.EdgePair))) return false;

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
                if (this.EdgePair != null) hashCode = hashCode * 59 + this.EdgePair.GetHashCode();
                return hashCode;
            }
        }
    }
}
