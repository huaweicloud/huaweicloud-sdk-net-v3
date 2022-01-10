using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowIpInfoResponse : SdkResponse
    {

        /// <summary>
        /// IP归属信息列表。
        /// </summary>
        [JsonProperty("cdn_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<CdnIps> CdnIps { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIpInfoResponse {\n");
            sb.Append("  cdnIps: ").Append(CdnIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIpInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIpInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CdnIps == input.CdnIps ||
                    this.CdnIps != null &&
                    input.CdnIps != null &&
                    this.CdnIps.SequenceEqual(input.CdnIps)
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
                if (this.CdnIps != null)
                    hashCode = hashCode * 59 + this.CdnIps.GetHashCode();
                return hashCode;
            }
        }
    }
}
