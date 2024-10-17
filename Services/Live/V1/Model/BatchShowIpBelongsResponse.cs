using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchShowIpBelongsResponse : SdkResponse
    {

        /// <summary>
        /// IP归属信息列表。
        /// </summary>
        [JsonProperty("cdn_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<CdnIp> CdnIps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchShowIpBelongsResponse {\n");
            sb.Append("  cdnIps: ").Append(CdnIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchShowIpBelongsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchShowIpBelongsResponse input)
        {
            if (input == null) return false;
            if (this.CdnIps != input.CdnIps || (this.CdnIps != null && input.CdnIps != null && !this.CdnIps.SequenceEqual(input.CdnIps))) return false;

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
                if (this.CdnIps != null) hashCode = hashCode * 59 + this.CdnIps.GetHashCode();
                return hashCode;
            }
        }
    }
}
