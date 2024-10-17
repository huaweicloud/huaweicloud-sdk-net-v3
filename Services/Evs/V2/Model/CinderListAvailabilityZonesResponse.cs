using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CinderListAvailabilityZonesResponse : SdkResponse
    {

        /// <summary>
        /// 查询请求返回的可用分区列表，请参见• [availabilityZoneInfo参数说明](https://support.huaweicloud.com/api-evs/evs_04_2081.html#evs_04_2081__li19751007201910)。
        /// </summary>
        [JsonProperty("availabilityZoneInfo", NullValueHandling = NullValueHandling.Ignore)]
        public List<AzInfo> AvailabilityZoneInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CinderListAvailabilityZonesResponse {\n");
            sb.Append("  availabilityZoneInfo: ").Append(AvailabilityZoneInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CinderListAvailabilityZonesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CinderListAvailabilityZonesResponse input)
        {
            if (input == null) return false;
            if (this.AvailabilityZoneInfo != input.AvailabilityZoneInfo || (this.AvailabilityZoneInfo != null && input.AvailabilityZoneInfo != null && !this.AvailabilityZoneInfo.SequenceEqual(input.AvailabilityZoneInfo))) return false;

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
                if (this.AvailabilityZoneInfo != null) hashCode = hashCode * 59 + this.AvailabilityZoneInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
