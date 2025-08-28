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
    /// Request Object
    /// </summary>
    public class UpdateCentralNetworkErRouteTableAttachmentRequest 
    {

        /// <summary>
        /// 中心网络的ID。
        /// </summary>
        [SDKProperty("central_network_id", IsPath = true)]
        [JsonProperty("central_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CentralNetworkId { get; set; }

        /// <summary>
        /// 中心网络ER路由表附件ID。
        /// </summary>
        [SDKProperty("er_route_table_attachment_id", IsPath = true)]
        [JsonProperty("er_route_table_attachment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ErRouteTableAttachmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateCentralNetworkErRouteTableAttachmentRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCentralNetworkErRouteTableAttachmentRequest {\n");
            sb.Append("  centralNetworkId: ").Append(CentralNetworkId).Append("\n");
            sb.Append("  erRouteTableAttachmentId: ").Append(ErRouteTableAttachmentId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCentralNetworkErRouteTableAttachmentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCentralNetworkErRouteTableAttachmentRequest input)
        {
            if (input == null) return false;
            if (this.CentralNetworkId != input.CentralNetworkId || (this.CentralNetworkId != null && !this.CentralNetworkId.Equals(input.CentralNetworkId))) return false;
            if (this.ErRouteTableAttachmentId != input.ErRouteTableAttachmentId || (this.ErRouteTableAttachmentId != null && !this.ErRouteTableAttachmentId.Equals(input.ErRouteTableAttachmentId))) return false;
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
                if (this.CentralNetworkId != null) hashCode = hashCode * 59 + this.CentralNetworkId.GetHashCode();
                if (this.ErRouteTableAttachmentId != null) hashCode = hashCode * 59 + this.ErRouteTableAttachmentId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
