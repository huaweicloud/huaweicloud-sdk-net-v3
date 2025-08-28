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
    public class DisassociateSiteNetworkBandwidthRequest 
    {

        /// <summary>
        /// 分支网络的ID。
        /// </summary>
        [SDKProperty("site_network_id", IsPath = true)]
        [JsonProperty("site_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteNetworkId { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("site_connection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteConnectionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateSiteNetworkBandwidthRequest {\n");
            sb.Append("  siteNetworkId: ").Append(SiteNetworkId).Append("\n");
            sb.Append("  siteConnectionId: ").Append(SiteConnectionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateSiteNetworkBandwidthRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateSiteNetworkBandwidthRequest input)
        {
            if (input == null) return false;
            if (this.SiteNetworkId != input.SiteNetworkId || (this.SiteNetworkId != null && !this.SiteNetworkId.Equals(input.SiteNetworkId))) return false;
            if (this.SiteConnectionId != input.SiteConnectionId || (this.SiteConnectionId != null && !this.SiteConnectionId.Equals(input.SiteConnectionId))) return false;

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
                if (this.SiteNetworkId != null) hashCode = hashCode * 59 + this.SiteNetworkId.GetHashCode();
                if (this.SiteConnectionId != null) hashCode = hashCode * 59 + this.SiteConnectionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
