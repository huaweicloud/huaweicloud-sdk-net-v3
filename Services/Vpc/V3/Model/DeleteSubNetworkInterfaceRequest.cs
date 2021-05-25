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
    public class DeleteSubNetworkInterfaceRequest 
    {

        /// <summary>
        /// 弹性辅助网卡唯一标识
        /// </summary>
        [SDKProperty("sub_network_interface_id", IsPath = true)]
        [JsonProperty("sub_network_interface_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubNetworkInterfaceId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSubNetworkInterfaceRequest {\n");
            sb.Append("  subNetworkInterfaceId: ").Append(SubNetworkInterfaceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSubNetworkInterfaceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSubNetworkInterfaceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubNetworkInterfaceId == input.SubNetworkInterfaceId ||
                    (this.SubNetworkInterfaceId != null &&
                    this.SubNetworkInterfaceId.Equals(input.SubNetworkInterfaceId))
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
                if (this.SubNetworkInterfaceId != null)
                    hashCode = hashCode * 59 + this.SubNetworkInterfaceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
