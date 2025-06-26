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
    /// 区域纳管情况。
    /// </summary>
    public class RegionManagedList 
    {

        /// <summary>
        /// 区域名字。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 区域的状态，取值为可用或者不可用。
        /// </summary>
        [JsonProperty("region_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegionManagedList {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  regionStatus: ").Append(RegionStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegionManagedList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegionManagedList input)
        {
            if (input == null) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RegionStatus != input.RegionStatus || (this.RegionStatus != null && !this.RegionStatus.Equals(input.RegionStatus))) return false;

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
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RegionStatus != null) hashCode = hashCode * 59 + this.RegionStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
