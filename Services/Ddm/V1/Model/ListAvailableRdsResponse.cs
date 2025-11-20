using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAvailableRdsResponse : SdkResponse
    {

        /// <summary>
        /// 可用后端DN信息。
        /// </summary>
        [JsonProperty("data_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<AvailableDnInstance> DataNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAvailableRdsResponse {\n");
            sb.Append("  dataNodes: ").Append(DataNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAvailableRdsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAvailableRdsResponse input)
        {
            if (input == null) return false;
            if (this.DataNodes != input.DataNodes || (this.DataNodes != null && input.DataNodes != null && !this.DataNodes.SequenceEqual(input.DataNodes))) return false;

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
                if (this.DataNodes != null) hashCode = hashCode * 59 + this.DataNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
