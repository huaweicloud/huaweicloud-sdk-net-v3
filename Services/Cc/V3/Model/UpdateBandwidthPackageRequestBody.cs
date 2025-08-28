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
    /// 更新带宽包实例的请求体。
    /// </summary>
    public class UpdateBandwidthPackageRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth_package", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateBandwidthPackage BandwidthPackage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBandwidthPackageRequestBody {\n");
            sb.Append("  bandwidthPackage: ").Append(BandwidthPackage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateBandwidthPackageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateBandwidthPackageRequestBody input)
        {
            if (input == null) return false;
            if (this.BandwidthPackage != input.BandwidthPackage || (this.BandwidthPackage != null && !this.BandwidthPackage.Equals(input.BandwidthPackage))) return false;

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
                if (this.BandwidthPackage != null) hashCode = hashCode * 59 + this.BandwidthPackage.GetHashCode();
                return hashCode;
            }
        }
    }
}
