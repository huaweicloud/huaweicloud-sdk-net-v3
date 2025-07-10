using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowHomeRegionResponse : SdkResponse
    {

        /// <summary>
        /// 区域名称。
        /// </summary>
        [JsonProperty("home_region", NullValueHandling = NullValueHandling.Ignore)]
        public string HomeRegion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHomeRegionResponse {\n");
            sb.Append("  homeRegion: ").Append(HomeRegion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHomeRegionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHomeRegionResponse input)
        {
            if (input == null) return false;
            if (this.HomeRegion != input.HomeRegion || (this.HomeRegion != null && !this.HomeRegion.Equals(input.HomeRegion))) return false;

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
                if (this.HomeRegion != null) hashCode = hashCode * 59 + this.HomeRegion.GetHashCode();
                return hashCode;
            }
        }
    }
}
