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
    /// 更改分支连接带宽大小的请求体。
    /// </summary>
    public class UpdateSiteConnectionBandwidthSizeRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("site_connection", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateSiteConnectionBandwidthSize SiteConnection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSiteConnectionBandwidthSizeRequestBody {\n");
            sb.Append("  siteConnection: ").Append(SiteConnection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSiteConnectionBandwidthSizeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSiteConnectionBandwidthSizeRequestBody input)
        {
            if (input == null) return false;
            if (this.SiteConnection != input.SiteConnection || (this.SiteConnection != null && !this.SiteConnection.Equals(input.SiteConnection))) return false;

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
                if (this.SiteConnection != null) hashCode = hashCode * 59 + this.SiteConnection.GetHashCode();
                return hashCode;
            }
        }
    }
}
