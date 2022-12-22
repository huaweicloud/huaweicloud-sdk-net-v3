using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DisassociateRouterResponse : SdkResponse
    {

        /// <summary>
        /// Router(VPC)的ID。
        /// </summary>
        [JsonProperty("router_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RouterId { get; set; }

        /// <summary>
        /// Router(VPC)所在的region。
        /// </summary>
        [JsonProperty("router_region", NullValueHandling = NullValueHandling.Ignore)]
        public string RouterRegion { get; set; }

        /// <summary>
        /// 资源状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateRouterResponse {\n");
            sb.Append("  routerId: ").Append(RouterId).Append("\n");
            sb.Append("  routerRegion: ").Append(RouterRegion).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateRouterResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateRouterResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RouterId == input.RouterId ||
                    (this.RouterId != null &&
                    this.RouterId.Equals(input.RouterId))
                ) && 
                (
                    this.RouterRegion == input.RouterRegion ||
                    (this.RouterRegion != null &&
                    this.RouterRegion.Equals(input.RouterRegion))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.RouterId != null)
                    hashCode = hashCode * 59 + this.RouterId.GetHashCode();
                if (this.RouterRegion != null)
                    hashCode = hashCode * 59 + this.RouterRegion.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
