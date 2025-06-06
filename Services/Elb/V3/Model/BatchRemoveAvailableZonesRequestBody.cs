using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 移除负载均衡器可用区请求body。
    /// </summary>
    public class BatchRemoveAvailableZonesRequestBody 
    {

        /// <summary>
        /// 移除的可用区列表，不能为空。
        /// </summary>
        [JsonProperty("availability_zone_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRemoveAvailableZonesRequestBody {\n");
            sb.Append("  availabilityZoneList: ").Append(AvailabilityZoneList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchRemoveAvailableZonesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchRemoveAvailableZonesRequestBody input)
        {
            if (input == null) return false;
            if (this.AvailabilityZoneList != input.AvailabilityZoneList || (this.AvailabilityZoneList != null && input.AvailabilityZoneList != null && !this.AvailabilityZoneList.SequenceEqual(input.AvailabilityZoneList))) return false;

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
                if (this.AvailabilityZoneList != null) hashCode = hashCode * 59 + this.AvailabilityZoneList.GetHashCode();
                return hashCode;
            }
        }
    }
}
