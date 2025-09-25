using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReduceCnRequestBody 
    {

        /// <summary>
        /// **参数解释**： 缩容节点ID集合。 **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("node_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReduceCnRequestBody {\n");
            sb.Append("  nodeIdList: ").Append(NodeIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReduceCnRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReduceCnRequestBody input)
        {
            if (input == null) return false;
            if (this.NodeIdList != input.NodeIdList || (this.NodeIdList != null && input.NodeIdList != null && !this.NodeIdList.SequenceEqual(input.NodeIdList))) return false;

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
                if (this.NodeIdList != null) hashCode = hashCode * 59 + this.NodeIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
