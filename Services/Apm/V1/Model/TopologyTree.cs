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
    /// 
    /// </summary>
    public class TopologyTree 
    {

        /// <summary>
        /// 拓扑树节点。
        /// </summary>
        [JsonProperty("tree", NullValueHandling = NullValueHandling.Ignore)]
        public List<TreeNode> Tree { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopologyTree {\n");
            sb.Append("  tree: ").Append(Tree).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopologyTree);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopologyTree input)
        {
            if (input == null) return false;
            if (this.Tree != input.Tree || (this.Tree != null && input.Tree != null && !this.Tree.SequenceEqual(input.Tree))) return false;

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
                if (this.Tree != null) hashCode = hashCode * 59 + this.Tree.GetHashCode();
                return hashCode;
            }
        }
    }
}
