using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteNetworkRequest 
    {

        /// <summary>
        /// **参数解释**：网络资源名称。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("network_name", IsPath = true)]
        [JsonProperty("network_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteNetworkRequest {\n");
            sb.Append("  networkName: ").Append(NetworkName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteNetworkRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteNetworkRequest input)
        {
            if (input == null) return false;
            if (this.NetworkName != input.NetworkName || (this.NetworkName != null && !this.NetworkName.Equals(input.NetworkName))) return false;

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
                if (this.NetworkName != null) hashCode = hashCode * 59 + this.NetworkName.GetHashCode();
                return hashCode;
            }
        }
    }
}
