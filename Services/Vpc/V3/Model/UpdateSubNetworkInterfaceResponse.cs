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
    /// Response Object
    /// </summary>
    public class UpdateSubNetworkInterfaceResponse : SdkResponse
    {

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sub_network_interface", NullValueHandling = NullValueHandling.Ignore)]
        public SubNetworkInterface SubNetworkInterface { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSubNetworkInterfaceResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  subNetworkInterface: ").Append(SubNetworkInterface).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSubNetworkInterfaceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSubNetworkInterfaceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.SubNetworkInterface == input.SubNetworkInterface ||
                    (this.SubNetworkInterface != null &&
                    this.SubNetworkInterface.Equals(input.SubNetworkInterface))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.SubNetworkInterface != null)
                    hashCode = hashCode * 59 + this.SubNetworkInterface.GetHashCode();
                return hashCode;
            }
        }
    }
}
