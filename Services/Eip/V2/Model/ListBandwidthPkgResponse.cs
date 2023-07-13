using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListBandwidthPkgResponse : SdkResponse
    {

        /// <summary>
        /// bandwidthpkg对象列表
        /// </summary>
        [JsonProperty("bandwidthpkgs", NullValueHandling = NullValueHandling.Ignore)]
        public List<BandwidthPkgResp> Bandwidthpkgs { get; set; }

        /// <summary>
        /// 翻页展示
        /// </summary>
        [JsonProperty("bandwidthpkgs_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<BandwidthPkgPage> BandwidthpkgsLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBandwidthPkgResponse {\n");
            sb.Append("  bandwidthpkgs: ").Append(Bandwidthpkgs).Append("\n");
            sb.Append("  bandwidthpkgsLinks: ").Append(BandwidthpkgsLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBandwidthPkgResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBandwidthPkgResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bandwidthpkgs == input.Bandwidthpkgs ||
                    this.Bandwidthpkgs != null &&
                    input.Bandwidthpkgs != null &&
                    this.Bandwidthpkgs.SequenceEqual(input.Bandwidthpkgs)
                ) && 
                (
                    this.BandwidthpkgsLinks == input.BandwidthpkgsLinks ||
                    this.BandwidthpkgsLinks != null &&
                    input.BandwidthpkgsLinks != null &&
                    this.BandwidthpkgsLinks.SequenceEqual(input.BandwidthpkgsLinks)
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
                if (this.Bandwidthpkgs != null)
                    hashCode = hashCode * 59 + this.Bandwidthpkgs.GetHashCode();
                if (this.BandwidthpkgsLinks != null)
                    hashCode = hashCode * 59 + this.BandwidthpkgsLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
