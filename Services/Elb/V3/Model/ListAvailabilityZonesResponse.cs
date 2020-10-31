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
    /// Response Object
    /// </summary>
    public class ListAvailabilityZonesResponse : SdkResponse
    {

        /// <summary>
        /// 可用区列表。  &gt; 获取可用区集合列表后，在（如创建LB时）设置可用区，选择的多个可用区必须同时在同一个集合中。
        /// </summary>
        [JsonProperty("availability_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<AvailabilityZone>> AvailabilityZones { get; set; }

        /// <summary>
        /// 请求ID。  注：自动生成。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAvailabilityZonesResponse {\n");
            sb.Append("  availabilityZones: ").Append(AvailabilityZones).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAvailabilityZonesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAvailabilityZonesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailabilityZones == input.AvailabilityZones ||
                    this.AvailabilityZones != null &&
                    input.AvailabilityZones != null &&
                    this.AvailabilityZones.SequenceEqual(input.AvailabilityZones)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.AvailabilityZones != null)
                    hashCode = hashCode * 59 + this.AvailabilityZones.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
