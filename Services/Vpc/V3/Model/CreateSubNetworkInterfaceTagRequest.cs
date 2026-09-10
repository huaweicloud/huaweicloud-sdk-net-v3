using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateSubNetworkInterfaceTagRequest 
    {

        /// <summary>
        /// **参数解释**： 辅助弹性网卡唯一标识。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("sub_network_interface_id", IsPath = true)]
        [JsonProperty("sub_network_interface_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubNetworkInterfaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubNetworkInterfaceTagRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubNetworkInterfaceTagRequest {\n");
            sb.Append("  subNetworkInterfaceId: ").Append(SubNetworkInterfaceId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubNetworkInterfaceTagRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubNetworkInterfaceTagRequest input)
        {
            if (input == null) return false;
            if (this.SubNetworkInterfaceId != input.SubNetworkInterfaceId || (this.SubNetworkInterfaceId != null && !this.SubNetworkInterfaceId.Equals(input.SubNetworkInterfaceId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.SubNetworkInterfaceId != null) hashCode = hashCode * 59 + this.SubNetworkInterfaceId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
