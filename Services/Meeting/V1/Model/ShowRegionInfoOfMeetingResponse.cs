using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRegionInfoOfMeetingResponse : SdkResponse
    {

        /// <summary>
        /// 会议所在区域的公网IP地址。
        /// </summary>
        [JsonProperty("regionIP", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionIP { get; set; }

        /// <summary>
        /// 会议所在区域的公网域名。
        /// </summary>
        [JsonProperty("regionUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRegionInfoOfMeetingResponse {\n");
            sb.Append("  regionIP: ").Append(RegionIP).Append("\n");
            sb.Append("  regionUrl: ").Append(RegionUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRegionInfoOfMeetingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRegionInfoOfMeetingResponse input)
        {
            if (input == null) return false;
            if (this.RegionIP != input.RegionIP || (this.RegionIP != null && !this.RegionIP.Equals(input.RegionIP))) return false;
            if (this.RegionUrl != input.RegionUrl || (this.RegionUrl != null && !this.RegionUrl.Equals(input.RegionUrl))) return false;

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
                if (this.RegionIP != null) hashCode = hashCode * 59 + this.RegionIP.GetHashCode();
                if (this.RegionUrl != null) hashCode = hashCode * 59 + this.RegionUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
