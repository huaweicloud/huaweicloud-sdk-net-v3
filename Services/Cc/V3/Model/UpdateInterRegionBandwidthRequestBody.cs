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
    /// 更新域间带宽实例的请求体。
    /// </summary>
    public class UpdateInterRegionBandwidthRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inter_region_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateInterRegionBandwidth InterRegionBandwidth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInterRegionBandwidthRequestBody {\n");
            sb.Append("  interRegionBandwidth: ").Append(InterRegionBandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInterRegionBandwidthRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInterRegionBandwidthRequestBody input)
        {
            if (input == null) return false;
            if (this.InterRegionBandwidth != input.InterRegionBandwidth || (this.InterRegionBandwidth != null && !this.InterRegionBandwidth.Equals(input.InterRegionBandwidth))) return false;

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
                if (this.InterRegionBandwidth != null) hashCode = hashCode * 59 + this.InterRegionBandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
