using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListHyperNodesResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hyperNodeList", NullValueHandling = NullValueHandling.Ignore)]
        public List<HyperNode> HyperNodeList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHyperNodesResponse {\n");
            sb.Append("  hyperNodeList: ").Append(HyperNodeList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHyperNodesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHyperNodesResponse input)
        {
            if (input == null) return false;
            if (this.HyperNodeList != input.HyperNodeList || (this.HyperNodeList != null && input.HyperNodeList != null && !this.HyperNodeList.SequenceEqual(input.HyperNodeList))) return false;

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
                if (this.HyperNodeList != null) hashCode = hashCode * 59 + this.HyperNodeList.GetHashCode();
                return hashCode;
            }
        }
    }
}
