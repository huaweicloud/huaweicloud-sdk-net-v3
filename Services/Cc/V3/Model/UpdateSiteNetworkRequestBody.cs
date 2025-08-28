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
    /// 更新分支网络的请求体。
    /// </summary>
    public class UpdateSiteNetworkRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("site_network", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateSiteNetwork SiteNetwork { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSiteNetworkRequestBody {\n");
            sb.Append("  siteNetwork: ").Append(SiteNetwork).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSiteNetworkRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSiteNetworkRequestBody input)
        {
            if (input == null) return false;
            if (this.SiteNetwork != input.SiteNetwork || (this.SiteNetwork != null && !this.SiteNetwork.Equals(input.SiteNetwork))) return false;

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
                if (this.SiteNetwork != null) hashCode = hashCode * 59 + this.SiteNetwork.GetHashCode();
                return hashCode;
            }
        }
    }
}
