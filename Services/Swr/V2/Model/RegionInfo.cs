using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RegionInfo 
    {

        /// <summary>
        /// 区域ID
        /// </summary>
        [JsonProperty("regionID", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegionInfo {\n");
            sb.Append("  regionID: ").Append(RegionID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegionInfo input)
        {
            if (input == null) return false;
            if (this.RegionID != input.RegionID || (this.RegionID != null && !this.RegionID.Equals(input.RegionID))) return false;

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
                if (this.RegionID != null) hashCode = hashCode * 59 + this.RegionID.GetHashCode();
                return hashCode;
            }
        }
    }
}
