using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteTrustedIpAddressRequest 
    {

        /// <summary>
        /// **参数解释：** 仓库id，代码仓首页，Repository ID后的数字Id。
        /// </summary>
        [SDKProperty("id", IsPath = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** ip白名单id。
        /// </summary>
        [SDKProperty("ip_id", IsPath = true)]
        [JsonProperty("ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTrustedIpAddressRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ipId: ").Append(IpId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTrustedIpAddressRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTrustedIpAddressRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IpId != input.IpId || (this.IpId != null && !this.IpId.Equals(input.IpId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IpId != null) hashCode = hashCode * 59 + this.IpId.GetHashCode();
                return hashCode;
            }
        }
    }
}
