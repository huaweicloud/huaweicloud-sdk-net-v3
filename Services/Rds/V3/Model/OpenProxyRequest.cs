using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OpenProxyRequest 
    {

        /// <summary>
        /// 规格ID。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 节点数量。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenProxyRequest {\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenProxyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenProxyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlavorId == input.FlavorId ||
                    (this.FlavorId != null &&
                    this.FlavorId.Equals(input.FlavorId))
                ) && 
                (
                    this.NodeNum == input.NodeNum ||
                    (this.NodeNum != null &&
                    this.NodeNum.Equals(input.NodeNum))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FlavorId != null)
                    hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.NodeNum != null)
                    hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
