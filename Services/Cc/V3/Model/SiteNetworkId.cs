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
    /// 分支网络ID。
    /// </summary>
    public class SiteNetworkId 
    {

        /// <summary>
        /// 分支网络ID。
        /// </summary>
        [JsonProperty("site_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _SiteNetworkId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteNetworkId {\n");
            sb.Append("  _siteNetworkId: ").Append(_SiteNetworkId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SiteNetworkId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SiteNetworkId input)
        {
            if (input == null) return false;
            if (this._SiteNetworkId != input._SiteNetworkId || (this._SiteNetworkId != null && !this._SiteNetworkId.Equals(input._SiteNetworkId))) return false;

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
                if (this._SiteNetworkId != null) hashCode = hashCode * 59 + this._SiteNetworkId.GetHashCode();
                return hashCode;
            }
        }
    }
}
