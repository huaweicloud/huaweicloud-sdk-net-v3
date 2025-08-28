using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 更新中心网络ER附件的请求体。
    /// </summary>
    public class UpdateCentralNetworkErRouteTableAttachmentRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("central_network_er_route_table_attachment", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateCentralNetworkErRouteTableAttachment CentralNetworkErRouteTableAttachment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCentralNetworkErRouteTableAttachmentRequestBody {\n");
            sb.Append("  centralNetworkErRouteTableAttachment: ").Append(CentralNetworkErRouteTableAttachment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCentralNetworkErRouteTableAttachmentRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCentralNetworkErRouteTableAttachmentRequestBody input)
        {
            if (input == null) return false;
            if (this.CentralNetworkErRouteTableAttachment != input.CentralNetworkErRouteTableAttachment || (this.CentralNetworkErRouteTableAttachment != null && !this.CentralNetworkErRouteTableAttachment.Equals(input.CentralNetworkErRouteTableAttachment))) return false;

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
                if (this.CentralNetworkErRouteTableAttachment != null) hashCode = hashCode * 59 + this.CentralNetworkErRouteTableAttachment.GetHashCode();
                return hashCode;
            }
        }
    }
}
