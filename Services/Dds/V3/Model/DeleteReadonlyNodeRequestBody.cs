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
    public class DeleteReadonlyNodeRequestBody 
    {

        /// <summary>
        /// 所有需要删除的节点ID。
        /// </summary>
        [JsonProperty("node_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteReadonlyNodeRequestBody {\n");
            sb.Append("  nodeList: ").Append(NodeList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteReadonlyNodeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteReadonlyNodeRequestBody input)
        {
            if (input == null) return false;
            if (this.NodeList != input.NodeList || (this.NodeList != null && input.NodeList != null && !this.NodeList.SequenceEqual(input.NodeList))) return false;

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
                if (this.NodeList != null) hashCode = hashCode * 59 + this.NodeList.GetHashCode();
                return hashCode;
            }
        }
    }
}
