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
    public class UpdateSubNetworkInterfaceRequest 
    {

        /// <summary>
        /// 辅助弹性网卡的唯一标识
        /// </summary>
        [SDKProperty("sub_network_interface_id", IsPath = true)]
        [JsonProperty("sub_network_interface_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubNetworkInterfaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateSubNetworkInterfaceRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSubNetworkInterfaceRequest {\n");
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
            return this.Equals(input as UpdateSubNetworkInterfaceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSubNetworkInterfaceRequest input)
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
