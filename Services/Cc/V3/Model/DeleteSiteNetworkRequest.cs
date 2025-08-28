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
    public class DeleteSiteNetworkRequest 
    {

        /// <summary>
        /// 分支网络的ID。
        /// </summary>
        [SDKProperty("site_network_id", IsPath = true)]
        [JsonProperty("site_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteNetworkId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSiteNetworkRequest {\n");
            sb.Append("  siteNetworkId: ").Append(SiteNetworkId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSiteNetworkRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSiteNetworkRequest input)
        {
            if (input == null) return false;
            if (this.SiteNetworkId != input.SiteNetworkId || (this.SiteNetworkId != null && !this.SiteNetworkId.Equals(input.SiteNetworkId))) return false;

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
                return hashCode;
            }
        }
    }
}
